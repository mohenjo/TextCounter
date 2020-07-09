using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HNP.Text
{
    public class TextUtils
    {
        /// <summary>
        /// 인자로 입력한 문자열에서 whitespace를 제거한 문자열을 반환합니다.
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string RemoveWhitespaces(string inputStr)
        {
            string resultStr = new string((from c in inputStr
                                           where !char.IsWhiteSpace(c)
                                           select c).ToArray());
            return resultStr;
        }

        /// <summary>
        /// 인자로 입력된 문자열의 글자 수를 반환합니다.
        /// </summary>
        /// <param name="inputString">글자 수를 셀 문자열</param>
        /// <param name="ignoreWhitespaces">Whitespace 무시 여부 (기본값: 아니오)</param>
        /// <returns></returns>
        public static int GetStringLength(string inputString, bool ignoreWhitespaces = false)
        {
            string resultStr = inputString;
            if (ignoreWhitespaces) { resultStr = RemoveWhitespaces(resultStr); }

            // 윈도우 시스템에서는 개행 문자가 2 문자열로 취급됨 Cr + Lf
            // 따라서, 개행 문자의 개수 만큼 제외함
            int newlineCount = resultStr.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length - 1;

            return resultStr.Length - newlineCount;
        }

        /// <summary>
        /// 인자로 입력된 문자열의 바이트 수를 반환합니다.
        /// </summary>
        /// <param name="inputString">바이트 수를 셀 문자열</param>
        /// <param name="ignoreWhitespaces">Whitespace 무시 여부 (기본값: 아니오)</param>
        /// <returns></returns>
        public static int GetStringByteLength(string inputString, bool ignoreWhitespaces = false)
        {
            string resultStr = inputString;
            if (ignoreWhitespaces) { resultStr = RemoveWhitespaces(resultStr); }

            // 윈도우 시스템에서는 개행 문자가 2 bytes로 취급됨 Cr + Lf
            // 따라서, 개행 문자의 개수 만큼 제외함
            int newlineCount = resultStr.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Length - 1;

            return Encoding.Default.GetByteCount(resultStr) - newlineCount;
        }

    }
}
