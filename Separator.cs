// ========================================================
// Letter separators
// ========================================================

// new Separator("minum susu sapi")
// Expected output: m-i-n-u-m-s-u-s-u-s-a-p-i
//
// new Separator("minum susu sapi", '*')
// Expected output: m*i*n*u*m*s*u*s*u*s*a*p*i

using System;
using System.Text;

namespace ChallengeApp
{
    public class Separator
    {
        public static string Run()
        {
            string str = "minum susu sapi";
            string separator = "-";
            string delete = str.Replace(" ", String.Empty);
            var separasi = string.Join(separator, delete.ToCharArray());
            foreach (var p in separasi)
            {
                Console.Write(p);
            }
                Console.WriteLine("");
            return separasi;
        }
    }
}
