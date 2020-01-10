// ========================================================
// Covert all vowel letters into uppercase
// ========================================================
// Input: rasanya otakku semakin keram
// Expected result
// rAsAnyA OtAkkU sEmAkIn kErAm
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeApp
{
    public class VowelToUppercase
    {
        public static string Run()
        {
            string nama = "rasanya otakku semakin keram";
            if (string.IsNullOrEmpty(nama))
                return string.Empty;

            var sb = new StringBuilder();
            var lookup = new HashSet<Char>() {'a', 'e', 'i', 'o', 'u'};
            foreach (var x in nama)
                sb.Append(lookup.Contains(x) ?
                    Char.ToUpper(x) : x);

            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}
