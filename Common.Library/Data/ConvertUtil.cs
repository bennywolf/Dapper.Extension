using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library.Data
{
    public static class ConvertUtil
    {
        #region json
        /// <summary>
        /// 将对象转换成JSON字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            IsoDateTimeConverter dateFormat = new IsoDateTimeConverter();
            dateFormat.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj,Newtonsoft.Json.Formatting.Indented, dateFormat);
        }
        /// <summary>
        /// 将JSON字符串转换成指定模型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T ToJsonObject<T>(this string json)
        {
            try
            {
                return (T)Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        #endregion

        #region string
        /// <summary>
        /// 转化成Base64字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToBase64(this string str)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }
        /// <summary>
        /// 解析Base64字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FromBase64(this string str)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }
        /// <summary>
        /// 转化成byte数组
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding">默认是UTF-8</param>
        /// <returns></returns>
        public static byte[] ToBytes(this string str, string encoding = "UTF-8")
        {
            return Encoding.GetEncoding(encoding).GetBytes(str);
        }
        /// <summary>
        /// 将字符编码从一种转换成另一种
        /// </summary>
        /// <param name="str"></param>
        /// <param name="srcEncoding"></param>
        /// <param name="dstEncoding"></param>
        /// <returns></returns>
        public static string EncodingConvert(this string str, string srcEncoding = "UTF-8", string dstEncoding = "GBK")
        {
            return Encoding.GetEncoding(dstEncoding).GetString(Encoding.Convert(Encoding.GetEncoding(srcEncoding), Encoding.GetEncoding(dstEncoding), Encoding.GetEncoding(srcEncoding).GetBytes(str)));
        }
        /// <summary>
        /// 转化成MD5-32bit字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToMd5_32Bit(this string str)
        {
            return SecurityUtil.Md5_32BitEncryp(str);
        }
        /// <summary>
        /// 转化成MD5-16bit字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToMd5_16Bit(this string str)
        {
            return SecurityUtil.Md5_32BitEncryp(str);
        }
        #endregion

        #region Enum
        public static int ToInt(this Enum obj)
        {
            return Convert.ToInt32(obj);
        }
        #endregion

        #region Date
        /// <summary>
        /// 转换成时间戳
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static long ToTimestamp(this DateTime datetime)
        {
            return TimeUtil.ToTimestamp(datetime);
        }
        /// <summary>
        /// 转换成时间
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static DateTime FromTimestamp(this long timestamp)
        {
            return TimeUtil.FromTimestamp(timestamp);
        }
             
        #endregion

    }
}
