using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarijableVjezba4
{
    class Program
    {
        static void Main(string[] args)
        {
            string unesenNizZnakova;

            Console.Write("Unesite niz znakova: ");
            unesenNizZnakova = Console.ReadLine();

            char[] znakovi = unesenNizZnakova.ToArray();
            char[] sVelika = new char[znakovi.Length], sMala = new char[znakovi.Length], sPrvaTri = new char[znakovi.Length], sZadnjihPet = new char[znakovi.Length], s8_11 = new char[znakovi.Length];

            for (int i = 0; i < znakovi.Length; i++)
            {
                sVelika[i] = znakovi[i];
                sMala[i] = znakovi[i];
                if (!char.IsNumber(znakovi[i]))
                {
                    #region velika
                    
                    if (char.IsLower(znakovi[i]))
                    {
                        sVelika[i] = char.ToUpper(znakovi[i]);
                    }
                    
                    #endregion

                    #region mala
                    
                    if (char.IsUpper(znakovi[i]))
                    {
                        sMala[i] = char.ToLower(znakovi[i]);
                    }
                    
                    #endregion
                }
                
                #region prva 3
                if (i < 3)
                {
                    sPrvaTri[i] = znakovi[i];
                }
                else sPrvaTri.Where(val => val != znakovi[i]).ToArray();
                #endregion

                #region zadnjih 5
                if (sZadnjihPet.Length - 6 < i)
                {
                    sZadnjihPet[i] = znakovi[i];
                }
                else sZadnjihPet.Where(val => val != znakovi[i]).ToArray();
                #endregion

                #region od 8 do 11
                if (8 < i && i < 12)
                {
                    s8_11[i] = znakovi[i];
                }
                else s8_11.Where(val => val != znakovi[i]).ToArray();
                #endregion
            }

            foreach (char item in sVelika)
            {
                if (default(char) == item) continue;
                Console.Write(item.ToString());
            }
            Console.WriteLine();
            foreach (char item in sMala)
            {
                if (default(char) == item) continue;
                Console.Write(item.ToString());
            }
            Console.WriteLine();
            foreach (char item in sPrvaTri)
            {
                if (default(char) == item) continue;
                Console.Write(item.ToString());
            }
            Console.WriteLine();
            foreach (char item in sZadnjihPet)
            {
                if (default(char) == item) continue;
                Console.Write(item.ToString());
            }
            Console.WriteLine();
            foreach (char item in s8_11)
            {
                if (default(char) == item) continue;
                Console.Write(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
