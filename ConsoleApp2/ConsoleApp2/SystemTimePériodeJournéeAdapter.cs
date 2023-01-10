using System;
namespace OHCE.ConsoleApp
{
    public class SystemTimePériodeJournéeAdapter
    {
        public static PériodeJournée PériodeActuelle
        {
            get { return new PériodeJournée(DateTime.Now); }
        }
    }
}
