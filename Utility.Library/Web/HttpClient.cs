using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Linq;

namespace Common.Library.Web
{
    /// <summary>
    /// http连接基础类，负责底层的http通信
    /// </summary>
    public static class HttpClient
    {
        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            //直接确认，否则打不开    
            return true;
        }

        public static string DoPost(Post post)
        {
            System.GC.Collect();

            string result = "";//返回结果

            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream reqStream = null;

            try
            {
                //设置最大连接数
                ServicePointManager.DefaultConnectionLimit = 200;
                //设置https验证方式
                if (post.Url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.ServerCertificateValidationCallback =
                            new RemoteCertificateValidationCallback(CheckValidationResult);
                }
                /***************************************************************
                * 下面设置HttpWebRequest的相关属性
                * ************************************************************/
                request = (HttpWebRequest)WebRequest.Create(post.Url);
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
                request.Method = "POST";
                request.Timeout = post.Timeout * 1000;

                //设置POST的数据类型和长度
                request.ContentType = post.ContentType;
                byte[] data = System.Text.Encoding.UTF8.GetBytes(post.Param);
                request.ContentLength = data.Length;

                //是否使用证书
                if (post.IsUseCert)
                {
                    string path = HttpContext.Current.Request.PhysicalApplicationPath;
                    X509Certificate2 cert = new X509Certificate2(post.CertPath, post.CertPassword, X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.MachineKeySet);
                    request.ClientCertificates.Add(cert);
                }

                //往服务器写入数据
                reqStream = request.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();

                //获取服务端返回数据
                response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), post.Encoding);
                result = sr.ReadToEnd().Trim();
                sr.Close();
            }
            catch (System.Threading.ThreadAbortException e)
            {
                System.Threading.Thread.ResetAbort();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //关闭连接和流
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            return result;
        }

        public static string DoGet(Post post)
        {
            System.GC.Collect();
            string result = "";

            HttpWebRequest request = null;
            HttpWebResponse response = null;

            //请求url以获取数据
            try
            {
                //设置最大连接数
                ServicePointManager.DefaultConnectionLimit = 200;
                //设置https验证方式
                if (post.Url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.ServerCertificateValidationCallback =
                            new RemoteCertificateValidationCallback(CheckValidationResult);
                }

                /***************************************************************
                * 下面设置HttpWebRequest的相关属性
                * ************************************************************/
                request = (HttpWebRequest)WebRequest.Create(post.ToUrl());
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
                request.Method = "GET";
                request.Timeout = post.Timeout * 1000;
                //获取服务器返回
                response = (HttpWebResponse)request.GetResponse();

                //获取HTTP返回数据
                StreamReader sr = new StreamReader(response.GetResponseStream(), post.Encoding);
                result = sr.ReadToEnd().Trim();
                result = Encoding.UTF8.GetString(Encoding.Convert(post.Encoding, Encoding.UTF8, post.Encoding.GetBytes(result)));
                sr.Close();
            }
            catch (System.Threading.ThreadAbortException e)
            {

                System.Threading.Thread.ResetAbort();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //关闭连接和流
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            return result;
        }

    }
    /// <summary>
    /// 请求参数
    /// </summary>
    public class Post
    {
        public Post()
        {
            IsUseCert = false;
            Timeout = 10;
            Param = string.Empty;
            UrlParams = new Dictionary<string, object>();
            Encoding = Encoding.UTF8;
            ContentType = "application/json";
        }
        public string Url { get; set; }
        private Dictionary<string, object> UrlParams { get; set; }
        public string Param { get; set; }
        public int Timeout { get; set; }
        public bool IsUseCert { get; internal set; }
        public string CertPath { get; internal set; }
        public string CertPassword { get; internal set; }
        public object this[string name]
        {
            set { UrlParams[name] = value; }
        }
        public Encoding Encoding { get; set; }
        public string ToUrl()
        {
            var value = string.Join("&", string.Join("&", UrlParams.Select(s => string.Format("{0}={1}", s.Key, s.Value.ToString()))));
            return string.Format("{0}{1}{2}", Url, string.IsNullOrEmpty(value) ? "" : "?", value);
        }
        public string ContentType { get; set; }

    }
   
}