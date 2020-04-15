using System;


namespace Szalamandra {
  class Program {
    static void Main(string[] args) {

      int szam = 10;
      String input;

      try {
        Console.WriteLine("Adja meg a versenyzők számát (1-10)!\n");
        input = Console.ReadLine();
        if(String.IsNullOrEmpty(input)) {
          throw new ArgumentOutOfRangeException();
        }
        szam = int.Parse(input);
        if(szam < 1) {
          szam = 10;
          throw new ArgumentOutOfRangeException();
        }
      } catch(ArgumentOutOfRangeException) {
        Console.WriteLine("Rossz számot adott meg, így a versenyzők száma az alapértelmezett értékre (10) lesz beállítva.\n");
      }

      Verseny verseny = new Verseny(szam);

      //A versenyzők sorszámainak és lépésszámainak kiíratása:
      for(int i = 0; i < verseny.VersenyzokSzama(); i++) {
        Console.WriteLine("A {0} versenyző lépésszáma: {1}\n", i, verseny[i]);
      }


      //A nyertes sorszámának és lépésszámának kiíratása:
      int nyertes = verseny.Nyertes();
      Console.WriteLine("A nyertes szalamandra sorszáma: {0}, lépéseinek száma pedig: {1}\n",  nyertes, verseny[nyertes]);

      //Ez csak azért van itt, hogy ne csukja be a konzolt, amíg meg nem nyomsz egy billentyűt...:)
      Console.ReadKey();

    }
  }
}
