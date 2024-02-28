using System;

namespace DipsyData
{
    public class DipsyZaznam
    {
        public ZakonnyZastupce ZakonnyZastupce { get; set; }
        public Uchazec Uchazec { get; set; }
        public SystemoveUdaje SystemoveUdaje { get; set; }
        public Prihlaska[] Prihlasky { get; set; }
        public Priloha[] Prilohy { get; set; }
    }
}
