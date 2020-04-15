
[Kezdőlap](../README.md)

# Programozási technikák (C#)

## 2018/2019. II. félév, ZH-feladat

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

**Megoldás:**


```csharp



```


### 3. feladat
***VersenyzokSzama():** adja vissza, hány szalamandra vett részt a versenyben.*

**Megoldás:**


```csharp



```


### 4. feladat
***HuszonotlepesAlatt():** visszaadja a távot 25 lépésnél kevesebbel teljesítő
szalamandrák számát.*

**Megoldás:**


```csharp



```


### 5. feladat
***indexelő:** készítsen egy indexelőt, amely visszaadja a **lepesek** i-edik elemét!*

**Megoldás:**


```csharp



```


### 6. feladat
***Nyertes():** adja vissza a nyertes szalamandra sorszámát (legkisebb lépésszámú szalamandra).*

**Megoldás:**


```csharp



```


### 7. feladat
*A **Main()** metódusban kérje be a szalamandrák számát (egész számot), ellenőrzötten
(try), ha a felhasználó nem ad meg semmit, vagy egynél kisebb számot ad meg, adjon
hibajelzést és legyen a szalamandrák száma 10.*

**Megoldás:**


```csharp



```


### 8. feladat
*Definiáljon egy **Verseny** típusú objektumot **verseny** néven.*

**Megoldás:**


```csharp



```


### 9. feladat
*Jelenítse meg az indexelő és a **VersenyzokSzama()** metódus segítségével a
szalamandrák sorszámait is lépéseit!*

**Megoldás:**


```csharp



```


### 10. feladat
*Állapítsa meg, hány lépéssel lehetett megnyerni a versenyt!*

**Megoldás:**


```csharp



```


### 11. feladat
*Jelenítse meg a nyertes szalamandra sorszámát!*

**Megoldás:**


```csharp



```







```csharp



```

### Forráskódok:

* [Program.cs](../src/Program.cs)
* [Verseny.cs](../src/Verseny.cs)


[Kezdőlap](../README.md)

