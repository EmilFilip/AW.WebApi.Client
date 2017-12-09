using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW.UI.Helpers
{
    public static class Base64Helper
    {
        public static string Base64Encode(this string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return string.Empty;
            }

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return HttpServerUtility.UrlTokenEncode(plainTextBytes);
        }

        public static string Base64Decode(this string base64EncodedData)
        {
            if (string.IsNullOrEmpty(base64EncodedData))
            {
                return string.Empty;
            }

            try
            {
                byte[] base64EncodedBytes = HttpServerUtility.UrlTokenDecode(base64EncodedData);
                return base64EncodedBytes == null ? string.Empty : System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (FormatException)
            {
                return string.Empty;
            }
        }
    }
}