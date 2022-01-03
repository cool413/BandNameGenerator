using System.Linq;

namespace BandNameGenerator
{
    public class BandNameGenerator
    {
        private static readonly string _firstWord = "The";

        public string GetName(string input)
        {
            if (string.IsNullOrEmpty(input)) { return ""; }

            var strAry = input.Trim().Select(x => x.ToString()).ToArray();
            if (strAry.Length == 0) { return ""; }
            
            if (strAry[0] != strAry[^1])
            {
                return GetNormalName(strAry);
            }

            return GetRepeatName(strAry);
        }

        private static string GetRepeatName(string[] strAry)
        {
            var input = string.Join("", strAry);
            strAry[0] = strAry[0].ToUpper();

            return $"{string.Join("", strAry)}{input.Substring(1, input.Length - 1)}";
        }

        private static string GetNormalName(string[] strAry)
        {
            strAry[0] = strAry[0].ToUpper();

            return $"{_firstWord} {string.Join("", strAry)}";
        }
    }
}