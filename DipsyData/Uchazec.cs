using System;
using System.Collections.Generic;
using System.Text;

namespace DipsyData
{
    public class Uchazec
    {
        public string Prijmeni { get; set; }

        public string RodnePrijmeni { get; set; }
        public string Jmeno { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public string MistoNarozeni { get; set; }
        public string StatniObcanstvi { get; set; }

        public string RodneCislo { get; set; }
        
        public AdresaZaznam AdresaTrvalehoPobytu { get; set; }

        public string ZakladniSkolaIzo { get; set; }
        public string DatovaSchranka { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public bool OverenoVZakladReg { get; set; }
    }
}
