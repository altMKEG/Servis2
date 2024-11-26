using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ogrenciListe = new List<string>();
           

            int ogrencisayi = 0;

            Console.WriteLine(" geziye gelenler");
            while (true)
            {

                int karar = 0;
                karar = Convert.ToInt32(Console.ReadLine());

                if (karar == 1)
                {
                    ogrenciListe.Add(Console.ReadLine());
                    ogrencisayi++;
                }
                else if (karar == 2)
                {
                    Console.WriteLine(" top eklenen" + ogrencisayi);
                    break;
                }
                else
                {
                    Console.WriteLine("geçersiz");

                }

                Console.WriteLine("araç kaç kişşi");
                int kapasite = Convert.ToInt32(Console.ReadLine());
                if (ogrencisayi <= kapasite)
                {
                }
            }
        }
    }
}
