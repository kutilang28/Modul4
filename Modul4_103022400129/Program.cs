using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022400129
{
    public class KodePaket
    {
        public string getKodePaket(string namaPaket)
        {
            switch (namaPaket)
            {
                case "Basic": return "P201";
                case "Standard": return "P202";
                case "Premium": return "P203";
                case "Unlimited": return "P204";
                case "Gaming": return "P205";
                case "Streaming": return "P206";
                case "Family": return "P207";
                case "Business": return "P208";
                case "Student": return "P209";
                case "Traveler": return "P210";
                default: return "Paket gaada";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KodePaket kp = new KodePaket();
            Console.WriteLine("Paket Streaming:" + kp.getKodePaket("Streaming"));
        }
    }
}
