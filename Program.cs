using balkezesek_concole.DataSource;

namespace balkezesek_concole
{
    internal class Program
    {
        static List<Balkezes> balkezesek = new List<Balkezes>();
        static void Main(string[] args)
        {

            // 2. feladat

            StreamReader sr = new StreamReader(".\\DataSource\\balkezesek.csv");

            sr.ReadLine();

            while(!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(";");

                Balkezes adatsor = new Balkezes(
                    line[0],
                    DateOnly.ParseExact(line[1], "yyyy-MM-dd"),
                    DateOnly.ParseExact(line[2], "yyyy-MM-dd"),
                    int.Parse(line[3]),
                    int.Parse(line[4])
                    );

                balkezesek.Add(adatsor);
            }

            sr.Close();

            // 3. feladat 

            Console.WriteLine($"3. feladat: {balkezesek.Count()}");

            // 4. feladat

            List<Balkezes> palyaraLepes1999Elott = balkezesek.Where(x => x.UtolsoDatum >= DateOnly.Parse("1999. 10. 01") && x.UtolsoDatum <= DateOnly.Parse("1999. 10. 31.")).ToList();

            Console.WriteLine("4. feladat: ");

            palyaraLepes1999Elott.ForEach(x => Console.WriteLine($"\t{x.JatekosNeve},{Math.Round((x.JatekosMagassaga) * 2.54, 1)} cm"));


            int evszam = 0;

            while(true)
            {
                Console.Write("Kérek egy 1990 és 1999 közötti évszámot!");

                evszam = Convert.ToInt32(Console.ReadLine());
                if(evszam > 1999 || evszam < 1990 )
                {
                    Console.Write("Hibás adat!");
                }
                else
                {
                    break;
                }
            }

            // 6. feladat

            var atlagsulyAzAdottEvben = balkezesek.Where(x => x.ElsoDatum.Year >= evszam && x.UtolsoDatum.Year <= evszam).Average(x => x.JatekosSulya);

            Console.WriteLine($"6. feladat: {Math.Round(atlagsulyAzAdottEvben ,2)} font");

        }
    }
}