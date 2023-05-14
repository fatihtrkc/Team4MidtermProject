using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UI_Layer.Utilities
{
    public static class Helper
    {
        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


        public static bool SifreKontrol(string sifre)
        {

            if (sifre.Length < 8)
            {
                return false;
            }
            else
            {
                int buyukHarfSayisi = 0;
                int kucukHarfSayisi = 0;
                int ozelKarakterSayisi = 0;


                foreach (char c in sifre)
                {
                    if (Char.IsUpper(c))
                    {
                        buyukHarfSayisi++;
                    }
                    else if (Char.IsLower(c))
                    {
                        kucukHarfSayisi++;
                    }
                    else if (c == '!' || c == ':' || c == '@' || c == '*')
                    {
                        ozelKarakterSayisi++;
                    }

                }

                if (buyukHarfSayisi < 2 || kucukHarfSayisi < 2 || ozelKarakterSayisi < 1)
                {
                    return false;
                }


                return true;
            }
        }

        public static bool MailKontrol(string email)
        {
            
            if (email.Count(c => c == '@') != 1)
                return false;

            
            if (!email.EndsWith(".com"))
                return false;

            return true;
        }

    }
}


