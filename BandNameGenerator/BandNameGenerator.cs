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
            
            if (IsFirstLetterSameAsLast(strAry))
            {
                return NormalName(strAry);
            }

            return RepeatName(strAry);
        }

        private static bool IsFirstLetterSameAsLast(string[] strAry)
        {
            return strAry[0] != strAry[^1];
        }
        
        private static string NormalName(string[] strAry)
        {
            var capitalizedWord = GetCapitalizedWord(strAry);
            
            return $"{_firstWord} {capitalizedWord}";
        }

        private static string RepeatName(string[] strAry)
        {
            var input = string.Join("", strAry);
            var capitalizedWord = GetCapitalizedWord(strAry);
            
            return $"{capitalizedWord}{input.Substring(1, input.Length - 1)}";
        }
        
        private static string GetCapitalizedWord(string[] strAry)
        {
            strAry[0] = strAry[0].ToUpper();
            return string.Join("", strAry);
        }

    }
}