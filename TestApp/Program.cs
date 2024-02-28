using System.Text.Json;
using DipsyData;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nacitam");

            var file = File.OpenText("Data-test.json");

            var data = JsonSerializer.Deserialize<IList<DipsyZaznam>>(file.ReadToEnd(),
                new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            file.Close();

            Console.WriteLine("Nacteno");

            Console.WriteLine("Pocet zaznamu: " + data.Count);

            foreach (var zaznam in data)
            {
                Console.WriteLine("Zakonny zastupce: " + zaznam.ZakonnyZastupce.Prijmeni);
                Console.WriteLine("Uchazec: " + zaznam.Uchazec.Prijmeni);
                Console.WriteLine("Systemove udaje: " + zaznam.SystemoveUdaje.RegistracniCisloZaka);
                Console.WriteLine("Pocet prihlasek: " + zaznam.Prihlasky.Length);
                Console.WriteLine("Pocet priloh: " + zaznam.Prilohy.Length);
            }

        }
    }
}
