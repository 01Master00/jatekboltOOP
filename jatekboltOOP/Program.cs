namespace jatekboltOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bolt bolt = new Bolt();

            Jatek jatek1 = new Jatek("The Witcher 3", "RPG", 12000);
            bolt.JatekHozzaadas(jatek1);
            Jatek jatek2 = new Jatek("FIFA 23", "SPORT" ,18000);
            bolt.JatekHozzaadas(jatek2);
            Jatek jatek3 = new Jatek("Cyberpunk 2077", "RPG", 15000);
            bolt.JatekHozzaadas(jatek3);
            Jatek jatek4 = new Jatek("Undertale", "RPG", 4000);
            bolt.JatekHozzaadas(jatek4);


            felhasznalo adam = new felhasznalo("Ádám", 20000);
            bolt.FelhHozzaadas(adam);
            Jatek witcher = bolt.JatekKeres("The Witcher 3");
            adam.JatekVasarlas(witcher);


            adam.PenzFeltoltes(10000);
            Console.WriteLine(adam.Egyenleg);
            Jatek cyberpunk = bolt.JatekKeres("Cyberpunk 2077");
            adam.JatekVasarlas(cyberpunk);
            
            Jatek undertale = bolt.JatekKeres("FIFA 23");
            adam.JatekVasarlas(undertale);

            adam.PenzFeltoltes(20000);
            Console.WriteLine(adam.Egyenleg);
            adam.JatekVasarlas(cyberpunk);

        }
    }
}
