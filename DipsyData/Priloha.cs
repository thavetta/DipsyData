using System;

namespace DipsyData
{
    public class Priloha
    {
        public string Prihlaska { get; set; }
        public string Typ { get; set; }
        public string Hash { get; set; }
        public string NazevSouboru { get; set; }

        public DateTime Prijata { get; set; }
        public bool Povinna { get; set; }
        public bool Akceptovana { get; set; }
    }
}