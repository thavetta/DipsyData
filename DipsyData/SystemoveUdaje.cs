using System;

namespace DipsyData
{
    public class SystemoveUdaje
    {
        public int RegistracniCisloZaka { get; set; }
        public string CisloPrihlasky { get; set; }
        public DateTime DatumPodani { get; set; }
        public bool PrihlaskuPodalZakonnyZastupce { get; set; }

        public AdresaZaznam AdresaProDorucovani { get; set; }
        public JpzInfo DelalJPZNaNasiSkole { get; set; }
    }
}