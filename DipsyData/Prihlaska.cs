namespace DipsyData
{
    public class Prihlaska
    {
        public string Stav { get; set; }
        public int Priorita { get; set; }
        public  string NazevSkolyRedizo { get; set; }
        public AdresaZaznam AdresaSkolyRedizo { get; set; }

        public string NazevSkolyIzo { get; set; }
        public AdresaZaznam AdresaSkolyIzo { get; set; }
        public string Redizo { get; set; }
        public string Izo { get; set; }
        public string KodOboru { get; set; }
        public string NazevOboru { get; set; }
        public string Svp { get; set; }
        public string Lokalita { get; set; }
        public int JazykVyuky { get; set; }
        public int Forma { get; set; }
        public int DelkaStudia { get; set; }
        public bool Zkracene { get; set; }
        public string CisloJednaciKePrihlasce { get; set; }
        public string CisloJednaciProPozvanku { get; set; }
        public string PoznamkyReditele { get; set; }

    }
}