using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Library.Data
{
    public class RandUtil
    {
        /// <summary>
        /// 64位长度的全局GUID
        /// </summary>
        /// <param name="format">“N”、“D”、“B”、“P”或“X”</param>
        /// <returns></returns>
        public static string GetGuid(string format = "N")
        {
            return Guid.NewGuid().ToString(format);
        }
        /// <summary>
        /// 获取表唯一的Tuid
        /// </summary>
        /// <returns></returns>
        public static string GetTuid()
        {
            var s1 = Guid.NewGuid().ToString("N").ToList().FindAll(f => char.IsLower(f)).Take(2);
            var s2 = DateTime.Now.ToString("yyMMddHHmmssff");
            return string.Format("{0}-{1}", string.Join("", s1).ToUpper(), s2);
        }
        /// <summary>
        /// 创建用户帐号
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetAcc(int count)
        {
            var guids = new List<char>();
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                var guid = Guid.NewGuid().ToString().ToList().FindAll(f=>char.IsNumber(f)).ToList();
                guids.Add(guid[rand.Next(1,9999) % guid.Count]);
            }
            return string.Join("",guids);
        }
        public static string GetMchid(string prefix = "")
        {
            var s2 = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            return string.Format("{0}{1}{2}", prefix, string.IsNullOrEmpty(prefix) ? "" : "-", s2);
        }
        /// <summary>
        /// 生成指定范围的随机数字
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值,不可取</param>
        /// <returns></returns>
        public static int GetNum(int min,int max)
        {
            return new Random().Next(min, max);
        }
    }
}
