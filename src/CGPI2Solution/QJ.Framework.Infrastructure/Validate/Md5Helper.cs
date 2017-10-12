using System.Security.Cryptography;
using System.Text;

namespace QJ.Framework.Infrastructure.Validate
{
    public static class Md5Helper
    {
        public static string ToMd5(this string inputval)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(inputval + "bjqj@2017"));
                StringBuilder sBuilder = new StringBuilder();
                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < result.Length; i++)
                {
                    sBuilder.Append(result[i].ToString("x2"));
                }
                return sBuilder.ToString().Replace("-", "");
            }
        }
    }
}
