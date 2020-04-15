
[Kezdőlap](../README.md)

# Programozási technikák (C#)

## ZH-mintafeladat

**Feladat:** Írjon programot, amely a szalamandrák versenyfutását szimulálja. A
szalamandra egy lépésben véletlenszerűen 1-9 centimétert tesz meg. A versenypálya
100 cm hosszú. Az a szalamandra nyer, amelyik legkevesebb lépésben teszi meg a távot.
A szalamandrák lépéseinek számát tömbben tároljuk.

Először hozzunk létre a Visual Studio-ban egy egy C# konzol alkalmazás típusú új
projektet. A program által felajánlott `ConsoleApplicationN` nevet írjuk át egy
saját névre (legyen mondjuk `Szalamandrak`), így a projektkönyvtár és a névtér neve is
ez lesz majd, nem `ConsoleApplicationN` (nincs nagy jelentősége, csak pofásabb).
A `Program.cs` állomány valami ilyesmi lesz:

```csharp

  using System;


  namespace Szalamandra {

    class Program {

      static void Main(string[] args) {

      }

    }

  }

```

### 1. feladat
*Definiáljon egy `Verseny` nevű osztályt, amelynek privát adattagja a következő:
**lepesek** int típusú tömb tárolására alkalmas referencia, ez tárolja a szalamandrák
lépéseinek számát (a tömb i-edik eleme az i-edik szalamandra lépéseinek száma).*

**Megoldás:** Hozzuk létre a `Verseny` nevű osztályt. Ezt megtehetjük a `Program.cs` állományban
is (a `Main()` metóduson kívül!), de esztétikai és kódkarbantartási okokból célszerűbb,
ha egy külön állományba pakoljuk (`Verseny.cs`). Fontos, hogy a `Verseny.cs` állomány
ugyanabban a könyvtárban legyen, mint a `Program.cs`. Ezt úgy is elérhetjük, hogy a
`Main()` metódusban létrehozunk (8. feladat) egy `Verseny` típusú objektumot (`Verseny verseny =
new Verseny(szam);`), amire a Visual Studió egy hibajelzés keretében (nem létező típusra
hivatkozunk) fel fogja ajánlani az osztály létrehozását (vagy ide vagy egy külön
állományba, válasszuk ez utóbbit). Állítsuk be a kért `lepesek` privát adattagot is
(én belepakoltam egy `versenyzokSzama` tulajdonságot is, ennek a 3. feladatnál lesz
jelentősége). A `lepesek` tulajdonságot állítsuk `null` értékre, ezt majd a konstruktor
segítségével fogjuk feltölteni.

A létrehozott osztály valahogy így fog kinézni:


```csharp
using System;

  namespace Szalamandra {

    private int versenyzokSzama;
    private int[] lepesek = null;

    public class Verseny {

    }

  }


```

### 2. feladat
***paraméteres konstruktor:** átveszi a versenyző szalamandrák számát. Hozza létre
a **lepesek** tömböt az átvett elemszámmal! Majd minden szalamandrára állapítsa meg,
hány lépésben teljesítette a távot. Vagyis minden szalamandrához generáljon egy 12
és 100 közötti véletlen számot vagy kérje be a billentyűzetről ellenőrzötten.*

**Megoldás:** a paraméterül kapott `szalamandrak` értékét (ez a versenyzők száma)
töltsük be a `versenyzokSzama` tulajdonságba. Ennek felhasználásával inicializáljuk a
`null` értékre állított `lepesek` tömbünket (megadjuk, hány eleme legyen). Majd
hozzunk létre egy `Random` objektumot a lépésszámok generálásához és egy for ciklus
segedelmével töltsük fel a tömbünket random lépésszámokkal.


```csharp

    public Verseny(int szalamandrak) {

      this.versenyzokSzama = szalamandrak;
      lepesek = new int[this.versenyzokSzama];

      //Tömb feltöltése, minden versenyzőhöz 12-100 közötti szám hozzárendelése
      //Mivel a sorszámra később szükség van, így az indexelés 1-ről indul
      Random rand = new Random();
      for(int i = 0; i < versenyzokSzama; i++) {
        lepesek[i] = rand.Next(12, 100);
      }

    }


```


### 3. feladat
***VersenyzokSzama():** adja vissza, hány szalamandra vett részt a versenyben.*

**Megoldás:** ez meg lehet oldani az [összegzés tételével](http://szit.hu/doku.php?id=oktatas:programozas:programozasi_tetelek:mondatszeru_leiras#oesszegzes)
is, de mivel lusta sertések vagyunk, ezért inkább írunk rá egy gettert:


```csharp

  //Visszaadja a versenyzők számát - egyszerű getter
  public int VersenyzokSzama() {
    return versenyzokSzama;
  }


```


### 4. feladat
***HuszonotlepesAlatt():** visszaadja a távot 25 lépésnél kevesebbel teljesítő
szalamandrák számát.*

**Megoldás:** a [megszámlálás tételét](http://szit.hu/doku.php?id=oktatas:programozas:programozasi_tetelek:mondatszeru_leiras#megszamolas)
fogjuk alkalmazni:


```csharp

  public int HuszonotLepesAlatt() {

    int result = 0;

    //Bejárjuk a lepesek tömböt és megszámoljuk hány eleme kisebb 25-nél
    for(int i = 0; i < versenyzokSzama; i++) {
      if(lepesek[i] < 25) { result++; }
    }

    return result;

  }


```


### 5. feladat
***indexelő:** készítsen egy indexelőt, amely visszaadja a **lepesek** i-edik elemét!*

**Megoldás:** készítünk egy [indexelőt](http://aries.ektf.hu/~hz/wiki7/mprog2ea/indexelo),
ami megvizsgálja, hogy a kért index létezik-e a tömbben, ha igen akkor visszaadja/beállítja
az értékét, ha nem, akkor pedig dob egy kivételt, amit a hívó kódban kell lekezelni.
**Fontos:** az adattagokra nem `verseny.lepesek[i]` alakban kell hivatkozni a hívó
kódban (`Main()`), hanem `verseny[i]` alakban!


```csharp

  //Indexelő
  public int this[int i] {

    get {
      if(i >= 0 || i <= versenyzokSzama) {
        return lepesek[i];
      } else {
        throw new IndexOutOfRangeException("Érvénytelen tömbindex");
      }
    }

    set {
      if(i >= 0 && i <= versenyzokSzama) {
        lepesek[i] = value;
      } else {
        throw new IndexOutOfRangeException("Érvénytelen tömbindex");
      }
    }

  }


```


### 6. feladat
***Nyertes():** adja vissza a nyertes szalamandra sorszámát (legkisebb lépésszámú szalamandra).*

**Megoldás:** a [minimumkiválasztás tételét](http://szit.hu/doku.php?id=oktatas:programozas:programozasi_tetelek:mondatszeru_leiras#minimum_kivalasztas)
fogjuk alkalmazni:

```csharp

  //A nyertes indexének kiválasztása (minimum kiválasztás tétele)
  public int Nyertes() {

    //A legkisebb indexet 1-re állítjuk
    int minimumIndex = 1;

    //Bejárjuk a lepesek tömböt és minden
    for(int i = 0; i < versenyzokSzama; i++) {
      if(lepesek[i] < lepesek[minimumIndex]) { minimumIndex = i; }
    }

    return minimumIndex;

  }


```


### 7. feladat
*A **Main()** metódusban kérje be a szalamandrák számát (egész számot), ellenőrzötten
(try), ha a felhasználó nem ad meg semmit, vagy egynél kisebb számot ad meg, adjon
hibajelzést és legyen a szalamandrák száma 10.*

**Megoldás:** a szalamandrák számának létrehozunk egy int típusú változót, amit
be is állítunk az alapértelmezett 10-es értékre; és egy String típusú változót a
bemenet kezelésére. A `try` blokkban bekérjük a versenyzők számát, ellenőrizzük, hogy
nem üres értéket adott-e meg a user, majd parzoljuk az inputot integer típusra.
Miután egész számmá lényegült (az amúgy String típusú) bemenet, megsasoljuk, hogy
nem-e kisebb 1-nél. Ha kisebb, a `szam` változó értékét 10-re állítjuk és dobunk
egy `ArgumentOutOfRangeException()` kivételt, amit a `catch` ágban fogunk lekezelni
(tájékoztatjuk a user-t, hogy rossz számot adott meg).


```csharp

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

        //...

      }
    }
  }


```


### 8. feladat
*Definiáljon egy **Verseny** típusú objektumot **verseny** néven.*

**Megoldás:** a 7. feladatban kapott érték (`szam` változó) átadásával létrehozzuk
az óhajtott `Verseny` típusú objektumot:


```csharp

  Verseny verseny = new Verseny(szam);


```


### 9. feladat
*Jelenítse meg az indexelő és a **VersenyzokSzama()** metódus segítségével a
szalamandrák sorszámait is lépéseit!*

**Megoldás:** végigiteráljuk a `lepesek` tömböt egy `for` ciklussal. **Fontos:**
a tömb elemeire nem `verseny.lepesek[i]` alakban kell hivatkozni, hanem `verseny[i]`
alakban!

```csharp

  //A versenyzők sorszámainak és lépésszámainak kiíratása:
  for(int i = 0; i < verseny.VersenyzokSzama(); i++) {
    Console.WriteLine("A {0} versenyző lépésszáma: {1}\n", i, verseny[i]);
  }

```


### 10-11. feladat
*Állapítsa meg, hány lépéssel lehetett megnyerni a versenyt!*
*Jelenítse meg a nyertes szalamandra sorszámát!*

**Megoldás:** ezt a két feladatot leginkább együtt van értelme megoldani, mivel
a `Nyertes()` metódus kimenete segítségével lehet megállapítani a nyertes szalamandra
lépésszámait:


```csharp

  //A nyertes sorszámának és lépésszámának kiíratása:
  int nyertes = verseny.Nyertes();
  Console.WriteLine("A nyertes szalamandra sorszáma: {0}, lépéseinek száma pedig: {1}\n",
  nyertes, verseny[nyertes]);

```

A fenti megoldás nem tökéletes (egy programozási feladatra sok megoldás létezhet), vannak
benne lekezeletlen kivételek (pl. az indexelő által eldobható kivételek), de működik és
a feladatnak eleget tesz.

### Forráskódok:

* [Program.cs](../src/Program.cs)
* [Verseny.cs](../src/Verseny.cs)


[Kezdőlap](../README.md)

