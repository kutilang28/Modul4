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

    public class MesinKopi
    {
        public enum State { OFF, STANBY, BREWING, MAINTENANCE};
        public State currentState;

        public MesinKopi()
        {
            currentState = State.OFF;
        }

        public void Lanjut(string action)
        {
            State nextState = currentState;
            string m = "";
            
            switch (currentState)
            {
                case State.OFF:
                    if (action == "POWER_ON")
                    {
                        nextState = State.STANBY;
                        m = "Mesin Off berubah menjadi stanby";
                    }
                    break;
                case State.STANBY:
                    if (action == "START_BREW")
                    {
                        nextState = State.BREWING;
                        m = "Mesin Standby berubah menjadi Brewing";
                    }
                    else if (action == "START_MAINTENANCE")
                    {
                        nextState = State.MAINTENANCE;
                        m = "Mesin Standby berubah menjadi Maintenance";
                    }
                    else if (action == "POWER_OFF")
                    {
                        nextState = State.OFF;
                        m = "Mesin Standby berubah menjadi Off";
                    }
                    break;
                case State.BREWING:
                    if (action == "FINISH_BREW")
                    {
                        nextState = State.STANBY;
                        m = "Mesin Brewing berubah menjadi Standby";
                    }
                    break;
                case State.MAINTENANCE:
                    if (action == "FINISH_MAINTENANCE")
                    {
                        nextState = State.STANBY;
                        m = "Mesin Maintenance berubah menjadi Standby";
                    }
                    break;
            }
            if (nextState != currentState)
            {
                currentState = nextState;
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KodePaket kp = new KodePaket();
            Console.WriteLine("Paket Streaming:" + kp.getKodePaket("Streaming"));

            Console.WriteLine("========================");
            MesinKopi kopi = new MesinKopi();

            kopi.Lanjut("POWER_ON");
            kopi.Lanjut("START_BREW");
            kopi.Lanjut("FINISH_BREW");
            kopi.Lanjut("START_MAINTENANCE");
            kopi.Lanjut("FINISH_MAINTENANCE");
            kopi.Lanjut("POWER_OFF");

            Console.WriteLine("=Contoh tidak valid, dari brew langsung start maintentance=");
            kopi.Lanjut("START_MAINTENANCE");

        }
    }
}
