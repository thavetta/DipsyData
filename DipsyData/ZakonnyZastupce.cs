using System;

namespace DipsyData
{
    public class ZakonnyZastupce
    {
        public string Prijmeni { get; set; }
        public string Jmeno { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public AdresaZaznam AdresaTrvalehoPobytu { get; set; }
        public string DatovaSchranka { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public bool OverenoVZakladReg { get; set; }
    }
}