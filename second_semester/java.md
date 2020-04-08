[Kezdőlap](../README.md)

# Java alkalmazások – elméleti ZH kérdéssor

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható (opcionális) részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli, a [BNF](https://hu.wikipedia.org/wiki/Backus%E2%80%93Naur-forma)
metaszintaxishoz hasonló módon. A {kapcsos zárójelbe zárt szöveg} logikai egységet
alkotó nyelvi elemeket jelöl a szintaxis leírásában.*

## I. Java bevezető, változók, operátorok


### 1. Mi a különbség a gépi kód és a Java bájtkód között?

A gépi kód a processzor által közvetlenül feldolgozható utasítások (műveletek és adatok
bináris vagy hexadecimális számokkal ábrázolt), további fordítást nem igénylő sorozata.
Ezek az utasítások általában csak egy processzortípusra vonatkoznak, és azon belül
is generációnként változhatnak.

A gépi kódot (Linuxon a kiterjesztése .bin, Windowson .exe) – fordított programnyelvek
esetén – fordítóprogramok (compiler) állítják elő a forráskódból. Értelmezett vagy
interpreteres nyelvek esetén a forráskódból egy értelmező (interpreter) futásidőben
állítja elő. A legtöbb programozási nyelv esetén tehát fordítást vagy értelmezést
kell végrehajtani, mielőtt a program futna a gépen. A Java esetén a kettő keverékét
használják.

A forrásprogramot (programom.java) a fordító egy köztes nyelvre fordítva Java
bájtkódot (programom.class) állít elő, és ezt a platformfüggetlen kódot értelmezi
és futtatja a JVM (Java Virtuális Gép, mint interpreter). A fordítás egy alkalommal
történik (bájtkódra), az értelmezés pedig minden alkalommal, ahányszor a program
végrehajtódik.

A natív (vagy gépi) kód tehát olyan kódot jelent, amelyik a hardveren közvetlenül
futtatható, míg a java bájtkódot a JVM értelmezi és a futtató gép saját utasításkészletének
megfelelő utasítások sorozatává alakítja át, majd ezeket futtatja.

### 2. Soroljon fel a Java magas szintű nyelvre vonatkozó jellemzőket!

* egyszerű
* objektumorientált
* előfordított
* értelmezett (implementált)
* robusztus
* biztonságos
* semleges architektúrájú
* hordozható
* nagy teljesítményű
* többszálú
* dinamikus

### 3. Mik a Java platform fő komponensei?

A platform hardver vagy szoftverkörnyezet, ahol a programok futnak. A legtöbb platform
a hardvert és az operációs rendszert jelenti. A Java platform nem egy konkrét hardvert
vagy operációs rendszert jelöl, hanem egy virtuális gépnek nevezett futtató programot
és szabványos osztálykönyvtárak gyűjteményét, amik egységes működést biztosítanak.

A Java platform két komponensből áll:
* **Java VM (virtuális gép)**
* **Java API (alkalmazásprogramozási felület)**: több ezer használatra kész szoftverkomponenst
tartalmaz, csomagokba szervezett osztályokat és interfészeket


### 4. Mit jelent a JVM?

Java Virtual Machine – Java Virtuális Gép. A JVM alapvető feladata a platformfüggetlen
Java bájtkód futtatása (értelmezése). Minden operációs rendszerre létezik egy a
rendszertől függő Java virtuális gép.

Amikor egy Java alkalmazás elindul, egyetlen futásidejű virtuális gép jön létre,
vagyis minden Java alkalmazás saját külön JVM-ben fut.

Főbb elemei:

* **[Osztálybetöltő (classloader)](https://hu.wikipedia.org/wiki/Java_Classloader):**
dinamikusan tölti be a Java osztályokat a Java virtuális gépbe. A Java futtatható
környezetnek nem kell ismernie a fájlok elhelyezkedését vagy fájl rendszert, mivel
ezek felderítését a classloader végzi.
* **Method area**: a JVM többek közt itt tárolja a metódusok kódjait
* **[Heap (kupac)](https://hu.wikipedia.org/wiki/Kupac_(adatszerkezet))**: az a
memóriaterület, ahol a referenciatípusokat tárolja a virtuális gép. A program futása
során minden objektumpéldány erre a területre kerül, vagyis egy tulajdonképpeni
referencia ezen a területen mutat valahová. A szemétgyűjtő (garbage collector) ezt
a területet is kezeli. Mivel a tömbök is Java objektumok, ezek is itt tárolódnak.
* **[Stack (verem)](https://hu.wikipedia.org/wiki/Verem_(adatszerkezet))**: a stack-en
a primitív típusok kerülnek tárolásra. Miden programszálban minden Java metódushívás
állapota egy-egy verembe kerül. Az állapot tartalmazza a lokális változókat, a
metódus paramétereit, esetleges visszatérési értékét és a belső számítások átmeneti
adatait.
* **Program counter regiszterek**: minden szálnak egy külön PC (*utasításszámláló,
Program Counter*) regisztere van, ami megmutatja, hogy a bájtkódban épp melyik
utasítást kell következőként végrehajtani. Külön regiszter mutatja a verem aktuális
tetejét is.
* **Native method stack**: a natív (vagyis nem Java bájtkód, hanem többnyire C-ben
vagy C++–ban megírt) metódushívások adatai itt tárolódnak.
* **Végrehajtó motor (execution engine):** a tulajdonképpeni végrehajtást végzi. A
következő elemeket tartalmazza:
  * *Virtuális processzor*
  * *Interpreter*: értelmezi, és végrehajtja a byte code-ból kiolvasott instrukciókat
  * *JIT compiler (Just-In-Time fordító):* a byte code-ból gépi kódot generál.
  * *Java Native Interface*
* **[Szemétgyűjtő (garbage collector)](https://hu.wikipedia.org/wiki/Szem%C3%A9tgy%C5%B1jt%C3%A9s):**
működés közben a nem használt objektumokat eltávolítja a memóriából, ezzel helyet
szabadít fel.

### 5. Mi a JVM lényege?

A JVM alapvető feladata a platformfüggetlen Java bájtkód futtatása (értelmezése).
A JVM biztosítja a java programok platformfüggetlenségét azzal, hogy köztes rétegként
ékelődik az adott platform (operációs rendszer) és a java program közé.

### 6. Mit jelent az, hogy egy változó deklarációja, illetve változó definíciója?

A definíció és deklaráció szinte teljesen azonos fogalmak. Változók esetében
**a deklaráció általában a név és a típus rögzítéséből áll**. Ha változó definiálását
emlegetjük változó deklarálása helyett, akkor azzal azt hangsúlyozzuk ki, hogy
a név és a típus rögzítése mellett a szükséges tárhely is lefoglalásra kerül a
változó számára (hogy mekkora hely, azt a típus határozza meg). **Inicializálás**nak
nevezzük, amikor egy változó definiálásával egyidejűleg kezdőértéket is adunk a
változónak.

### 7. Soroljon fel a Java primitív típusait!

A primitív adattípusok egy egyszerű értéket képesek tárolni: számot, karaktert
vagy logikai értéket. A változó neve így közvetlenül egy értéket jelent.

| Típus | Tárolt érték típusa | Alapértelmezett érték | Méret (bit) | Értéktartomány |
|-------|---------------------|-----------------------|-------------|----------------|
| byte  | előjeles egész | 0  | 8  | -128 – 127   |
| short  | előjeles egész  | 0  | 16  | -32768 – 32767   |
| int  | előjeles egész  | 0  | 32  | -2147483648 – 2147483647   |
| long  | előjeles egész  | 0  | 64  | -9223372036854775808 – 9223372036854775807  |
| float  | [IEEE 754 lebegő pontos](https://hu.wikipedia.org/wiki/IEEE_lebeg%C5%91pontos_sz%C3%A1mform%C3%A1tum)  | 0.0  |  32 | 7 tizedesjegy pontosság  |
| double  | [IEEE 754 lebegő pontos](https://hu.wikipedia.org/wiki/IEEE_lebeg%C5%91pontos_sz%C3%A1mform%C3%A1tum)  | 0.0  |   64  | 15 tizedesjegy pontosság  |
| char  | [Unicode karakter](https://hu.wikipedia.org/wiki/Unicode)  | \u0000  | 16  | \u0000 - \uFFFF  |
| boolean  | logikai érték  | false  | 1  | true, false  |

A Java nyelvben minden típus előjeles (signed), azaz nincs előjel nélküli
(unsigned) típus!

### 8. Soroljon fel példákat referencia típusokra!

Míg az egyszerű adattípusok csakis 1 db elemet tárolnak (például egy számot: int
a = 23), addig az összetett adattípusok képesek több elemet is, még pedig rendszerezetten
és könnyen visszakereshető módon.

Referenciatípusok esetén a létrehozott példány (objektum) által lefoglalt
memóriaterület nem a létrehozás helyén fog elhelyezkedni, hanem egy külön
tárterületet fog elfoglalni a memória egy másik területén (a heap-ben). A befogadó
területen csak egy hivatkozás, más szóval referencia lesz eltárolva.

Referenciatípusok a javában a **string**, a **tömb** és az **objektum**.

### 9. Mit jelent a final kulcsszó egy változó esetén?

Primitív adattípusú változó esetén az érték **megváltoztathatatlan (immutable)** lesz,
míg a referenciatípusok esetén a referencia lesz az (maga az objektum nem). A **final**
kulcsszó tulajdonképpen a más nyelvekben előforduló **állandók (konstansok)** javás
megfelelője, ezért a változó neve csupa nagybetűvel írandó.

```
final int VALTOZO = 200;
```

### 10. Mi a különbség a Java értékadó utasítása és a matematikai egyenlőség között?

Az értékadó utasítás bal oldalán egy változó neve szerepel, jobb oldalán egy
kifejezés, amely értékét a számítógép kiszámolja, majd a kapott értéket elhelyezi
a változó által lefoglalt memóriaterületen. Értékadáskor tehát a jobb oldalon
található értéket hozzárendeljük a bal oldali azonosítóhoz. A matematikai egyenlőség
ellenben azt jelenti, hogy az egyenlőségjel két oldalán található kifejezések értéke
azonos.

### 11. Milyen értékeket vehet fel a logikai kifejezés?

True (igaz) vagy False (hamis).

### 12. Ismertesse az operátorok precedencia szintjeit!

A különböző precedencia szintű operátorok esetén mindig a magasabb precedenciájú
hajtódik végre először. Az azonos precedencia szintű operátorok közül a leírás
sorrendisége dönt. A legtöbb precedencia szint esetén a leírás sorrendjében, azaz
balról-jobbra hajtódnak végre. Egyes precedencia szinteknél előfordul, hogy jobbról-balra.
A precedencia nagyrészt megegyezik a matematikai műveletek sorrendjével, valamint
itt is igaz az, hogy zárójelezéssel felül lehet bírálni azt.

| Prioritás | Operátor | Elnevezés | Végrehajtási irány (azonos precedencia esetén) | Példa |
|----------:|----------|-----------|:----------------------------------------------:|-------|
| 1 | `++ --` | Egyoperandusú postfix | balról jobbra | `valtozo++;` |
| 2 | `++ -- ~ !` | Egyoperandusú prefix | jobbról balra | `++valtozo;` |
| 3 | `new (<típus>)<kifejezés>` | Példányosítás, típuskényszerítés | balról jobbra | `(int)valtozo;` |
| 4 | `* / %` | Multiplikatív operátorok | balról jobbra | `a*b;` |
| 5 | `+ -` | Additív operátorok | balról jobbra | `a+b` |
| 6 | `<< >> >>>` | Bitenkénti léptető operátorok | balról jobbra | `int b = a >>> 1;` |
| 7 | `< <= > >= instanceof` | Hasonlító operátorok | balról jobbra | `if (e instanceof ArithmeticException) { //... }` |
| 8 | `== !=` | Egyenlőségvizsgáló operátorok | balról jobbra | `valtozo1 != valtozo2` |
| 9 | `&` | Bitenkénti és (AND) | balról jobbra | `(a & b)` |
| 10 | `^` | Bitenkénti kizáró vagy (XOR) | balról jobbra | `(a ^ b)` |
| 11 | `\|` | Bitenkénti vagy (OR) | balról jobbra | `(a \| b)` |
| 12 | `&&` | Logikai és (AND) | balról jobbra | `(a && b)` |
| 13 | `\|\|` | Logikai vagy (OR) | balról jobbra | `(a \|\| b)` |
| 14 | `?:` | Feltételes értékadás | balról jobbra | `b = (a == 1) ? 20 : 30;` |
| 15 | `= += -= *= /= %= &= ^= \|= <<= >>= >>>=` | Értékadó operátorok | jobbról balra | `valtozo1 += valtozo2` |

Értékadásnál először mindig a jobb oldalon álló kifejezés értéke kerül kiszámításra,
majd a kiszámított érték bekerül a bal oldalon álló változóba.

### 13. Mit jelent a függvény deklaráció és függvény definíció?

Függvények esetén a deklaráció általában a függvény nevének, argumentumainak és
visszatérési értékének (vagyis: szignatúrájának) leírásából áll. Ez általában interfészekben
és absztrakt osztályokban fordul elő. Az interfészt implementáló osztályban történik
a függvénydefiniálás, vagyis a szignatúrához függvénytörzset készítünk. Azokban az
esetekben, amikor egy függvénynévhez több törzs is tartozik, fontos ismerni az argumentumok
pontos típusát, mert a törzs kiválasztása gyakran az aktuális paraméterek típusától
függ.

### 14. Mit jelent a függvény aláírása?

Egy metódus/függvény szignatúrája a nevéből, visszatérési értékéből, valamint paramétereinek
számából és típusából áll.



## II. Kifejezések, utasítások, blokkok, ciklusok, vezérlési szerkezetek, kivételkezelés, burkoló osztályok


### 1. Mit jelent a programblokk?

A **blokk nulla vagy több utasítás kapcsos zárójelek között**, amely használható bárhol,
ahol az önálló utasítások megengedettek. A blokkon belül bárhová írható
deklaráció és végrehajtható utasítás is. A blokkon belüli deklarációra annyi megkötés van,
hogy **minden változót az előtt kell deklarálni, hogy értéket adnánk neki**, illetve a
**blokkon belül deklarált változó hatóköre a blokk végéig tart**. Ez azt jelenti, hogy
a blokkot lezáró kapcsos zárójel után a blokkon belül deklarált változók számára
lefoglalt memóriaterület felszabadul, és a változó innentől fogva már nem
használható.

Habár nem szükséges, az áttekinthetőség és egyértelműség miatt a kapcsos zárójelek
alkalmazása akkor is ajánlott, ha a blokk csak egy utasítást tartalmaz.

### 2. Ismertesse a kifejezés definícióját! Írjon rá példát.

A kifejezés változók, literálok, operátorok és metódushívások olyan sorozata, amely
figyelembe veszi a nyelv szintaxisát és egy értéket ad vissza.

```
int c = (a + b) * 5;
```

### 3. Ismertesse az utasítás definícióját!

Az utasítások nagyjából a beszélt nyelv mondatainak felelnek meg. Az utasítás egy
konkrét futási egységet hoz létre, amelyet pontosvesszővel (`;`) kell lezárni. Az
utasítások fajtái:
1. **kifejezés utasítások**
    * értékadó kifejezések
    * ++ és -- használata
    * metódushívások
    * objektumot létrehozó kifejezések.
2. **deklarációs utasítások:** változókat hoznak létre
3. **végrehajtás-vezérlő utasítások:** azt szabályozzák, hogy az utasítások milyen
sorrendben hajtódnak végre. A `for` ciklus és az `if` utasítás jó példák a
végrehajtás-vezérlő szerkezetre.

### 4. Hogyan kell egy programblokkot leírni Java-ban?

Kapcsos zárójelek között. Habár nem szükséges, az áttekinthetőség és egyértelműség
miatt a kapcsos zárójelek alkalmazása akkor is ajánlott, ha a blokk csak egy utasítást
tartalmaz.

```
if (<logikai kifejezés>) {
  <első programblokk>
} else {
  <második programblokk>
}
```

### 5. Java-ban milyen ciklusok érhetők el?

Az iteráció olyan alapstruktúra, amelynek során egy vagy több lépést többször megismételve
hajtunk végre. Az ismétlések száma függhet egy feltételtől, de lehet előírt lépésszámú
is. Az iterációt a programozási nyelvekben ciklusszervező utasításokkal valósítjuk meg.

A javában használható ciklusok:
* **előltesztelő:** először megvizsgálja a feltételt (logikai kifejezés), majd annak
  függvényében hajtja végre a ciklusmagot (0 vagy több alkalommal).
  ```
    [<számláló inicializálása>;]
    while(<feltétel>){
      <ciklusmag>;
      [<számláló léptetése>;]
    }
  ```
* **hátultesztelő:** először végrehajtja a ciklusmagot, majd megvizsgálja a feltételt,
  s annak függvényében fut vagy nem fut le ismét. Legalább egyszer biztosan lefut
  (jellemző használata: ellenőrzött adatbekérés).
  ```
    do {
      <ciklusmag>
    } while(<feltétel>)
  ```
* **számlálós:** a ciklusmag végrehajtásának száma előre ismert
  ```
    for(<számláló inicializálása>; <feltétel>; <számláló léptetése>){
      <ciklusmag>
    }
  ```
* **iteráló ciklus:** a Java 5.0 változata egy újfajta **for** utasítást vezetett
  be, kifejezetten gyűjteményekhez (osztályok, amik a Collection interfészt
  implementálják) és tömbökhöz.
  ```
    for (<típus> <elem_neve> : <tömb_neve>) {
      <ciklusmag> // pl: System.out.println(<elem_neve>);
    }
  ```


### 6. Mit jelent, hogy egy while ciklus elöltesztelős ciklus?

Az elöltesztelő ciklus először megvizsgálja, hogy a feltétel igaz-e. Ha igen, akkor
lefuttatja a ciklusmagot, és újból kezdődik; ha nem, akkor a program a ciklus utáni
ponton folytatódik, azaz a ciklusmag kimarad. Lehetséges tehát, hogy az elöltesztelő
ciklus egyszer sem fog lefutni (ha a feltétel nem igaz).

### 7. Írjon példát egymásba ágyazott ciklusra!

Rendezési algoritmus megvalósítása java nyelven:

```
  int csere;

  for(int i = 0; i < tomb.length-1; i++) {
    for(int j = i+1; j < tomb.length; j++) {
      if(tomb[i] > tomb[j]) {
        csere = tomb[i];
        tomb[i] = tomb[j];
        tomb[j] = csere;
      }
    }
  }
```

### 8. Ismertesse a „foreach” ciklust! Írjon rá egy példát!

A Java 5.0 változata egy újfajta **for** utasítást vezetett be, kifejezetten
gyűjteményekhez (osztályok, amik a Collection interfészt implementálják) és tömbökhöz,
amely működésében nagyban hasonlít a más programnyelvekben használt foreach ciklushoz.
Lényege, hogy nem kell sem kezdőértéket, sem feltételt megadni, ahogy a számlálót
léptetni sem. A ciklus három paramétert vár: az adatelem típusát, egy tetszőlegesen
választott nevet az egyes adatelemekhez (ezen a néven lehet hivatkozni rájuk a
ciklusmagban) és a bejárandó adatszerkezet nevét.

```
  public class MyClass {

    public static void main(String[] args) {

      String[] autok = {"Volvo", "BMW", "Ford", "Mazda"};

      for (String tipus : autok) { System.out.println(tipus); }

    }

  }
```

### 9. Ismertesse a Java vezérlési szerkezeteit! Sorolja fel őket!

A java vezérlési szerkezeteit három fő csoportba sorolhatjuk:
1. **szekvencia:** egyes utasítások (vagy blokkok) egymás után történő végrehajtása.
A Neumann-elvű számítógépek processzorai ugyanis úgy működnek, hogy a memóriában
található utasításokat a memóriabeli sorrendjüknek megfelelő sorrendben (szekvenciálisan)
hajtják végre.
2. **szelekció:** olyan struktúra, amelynek során egy feltételtől függően két
vagy több végrehajtható lépés közül választunk ki és hajtunk végre egyet. A
programozási nyelvek ezeket a vezérlési szerkezeteket **feltételes elágazás**nak
nevezik. Ide tartoznak az **if-else** és a **switch-case** szerkezetek.
3. **iteráció:** olyan alapstruktúra, amelynek során **egy vagy több lépést többször
megismételve hajtunk végre**. Az ismétlések száma függhet egy feltételtől, de lehet
előírt lépésszámú is. Az iterációt a programozási nyelvekben ciklusszervező
utasításokkal valósítjuk meg. Ilyenek az elől-, és hátultesztelő (**while**, **do-while**)
és számláló ciklusok (**for**) valamint a **forech**.

Az 1966-ban Corrado Böhm és Giuseppe Jacopini olasz matematikusok által megalkotott
tétel szerint minden algoritmus megvalósítható a fenti 3 programozási alapszerkezet
segítségével.

### 10. Milyen feltétel nélküli vezérlésátadás létezik a Java programozási nyelvben?

A legelső magas szintű programozási nyelvekben (FORTRAN, COBOL) már létezett a `GOTO`
utasítás a feltétel nélküli vezérlésátadásra. A `GOTO` utasítás használata széles
körben vitatott a mai napig. Az általános nézet mára az, hogy a használata egyáltalán
nem javasolt, mivel előnye szinte nincs, hátránya viszont rengeteg.

A `goto` ugyan kulcsszava a Java nyelvnek, viszont az utasítást nem implementálták.
Ez azt jelenti, hogy létezik `goto` kulcsszó a Javában, de nem csinál semmit. A
feltétel nélküli vezérlésátadásnak ugyanakkor létezik három utasítása a Java nyelvben:
ezek:
* `break` (azonnal megszakítja a ciklus futását, a program a ciklus utáni utasítás
végrehajtásával folytatódik)
* `continue` (átugorja a ciklusmag hátralevő részét és újraindítja a ciklust)
* `return` (az aktuális metódusból/függvényből való kilépésre használják, lehet
visszatérési értéke is, amit a függvényt hívó kódnak ad át).

A break és a continue utasításokat használhatjuk címkével vagy anélkül. A címke egy
azonosító, ami az utasítás előtt helyezkedik el. A címkét egy kettőspont (:) követi.


### 11. Mire szolgál a try-catch szerkezet? Mire használható a finally ág? Írjon egy példát.

A Java programokban a kivételektől védendő részt a `try` kulcsszóval bevezetett
blokkban kell elhatárolni. Ezt követően kell elhelyezni a kivételeket kezelő
(tetszőleges számú) `catch` blokkot. Amikor a védett részben kivétel keletkezik,
azt a védett rész eldobja, és valamelyik catch-szerkezet kapja el. **Minden `catch`
blokk egy kivételkezelő, és azt a típusú kivételt kezeli, amilyet a paraméter
tartalmaz**. A paraméter típusa (ExceptionType) deklarálja a kivétel típusát, amit
a kezelő lekezel. Ha több catch-ágat használunk egy blokkban, akkor mindig a speciálisabb
típust kell korábban feltüntetni, mert a `catch` ágak kiértékelése fentről lefelé
halad.

A `finally` blokkban mondjuk meg, hogy mi az az utasítás, amelyet
mindenképpen végre kell hajtani a `try` blokk után, függetlenül attól, hogy az dobott-e
kivételt vagy sem. Jellemzően ilyenek lehetnek az erőforrások lezárása. Egy `try`
után kötelező legalább egy `catch` vagy egy `finally` ágat tenni. A `catch`
ágakból több is lehet, de egy `try` blokk végén csak egy `finally` lehet.

```
  try {
    <utasítás(ok)>
  } catch (<kivételtípus>) {
    <utasítás(ok)>
  } catch (<kivételtípus>) {
    <utasítás(ok)>
  } finally {
    <utasítás(ok)>
  }
```

### 12. Hogyan tudunk saját kivételt létrehozni? Lehetséges-e ez a Java-ban egyáltalán?

A Java kivételkezelésének célja a programfutás során keletkezett hibák kiszűrése
és megfelelő kezelése. Az ilyen hibákat a Java platformon **Exception**-nek (kivételnek)
nevezik. Két fő csoportjuk van: a **futásidejű** (pl. aritmetikai [0-val osztás:
`ArithmeticException`], indexeléssel kapcsolatos [nem létező indexre hivatkozás]) és
a **nem futásidejű** (I/O műveletek során keletkező hibák [pl. a fájl nem található])
**kivételek**.

A Java kivételkezelése nyitott, bárki létrehozhat saját névvel és funkcionalitással
ellátott kivételosztályokat, amelyeket az Exception osztályból (vagy valamely leszármazottjából)
kell származtatni. A saját kivételosztálynak – hacsak nem akarjuk felüldefiniálni
az őszosztály valamely metódusát – célszerű üresnek lennie. Az üres kivételosztály
ugyanis örökli az ős metódusait (funkcionalitását), a létrehozás tulajdonképpeni
célja és értelme az osztály neve (új kivételtípus, amit a catch ágban el lehet kapni).

### 13. Kivétel osztályoknál melyik osztály az osztályhierarchiájában csúcsán (nem az Object)?

A Throwable (minden további specializált kivétel-osztály ebből származik, kezdve az
Exception-nel).

### 14. Milyen kulcsszóval lehetséges a kivételek továbbadása?

`throw` (`throw new Exception`).

### 15. Sorolja fel a Java burkoló osztályait!

A primitív típusok rendelkeznek egy nekik megfelelő (azonos, de nagybetűvel kezdődő
nevű) csomagoló (vagy burkoló) osztállyal. A szám csomagoló osztályok több hasznos
publikus és statikus konstanst tartalmaznak. Ezekre úgy tudunk hivatkozni kifejezésekben,
hogy az osztály nevét és a konstanst egy ponttal választjuk el, pl. Integer.MIN_VALUE.
Ezek biztosítják az általános információt az adattípusról. Tartalmaznak ezen felül
hasznos metódusokat, amelyek pl. értéket konvertálnak más típussá (például String-gé,
vagy egy másik szám típussá), vagy különböző műveleteket hajtanak végre az adott
adattípuson.

| Elemi típus | Burkoló osztály | Csomag |
|-------------|-----------------|:------:|
| boolean | Boolean | java.lang |
| byte | Byte | java.lang |
| char | Character | java.lang |
| short | Short | java.lang |
| int | Integer | java.lang |
| int | BigInteger | java.math |
| long | Long | java.lang |
| float | Float | java.lang |
| float | BigDecimal | java.math |
| double | Double | java.lang |

A `BigInteger` és `BigDecimal` kiterjeszti a hagyományos adattípusokat, és tetszőleges
pontosság alkalmazását engedi meg.

### 16. Soroljon fel néhány burkoló osztály metódust és adattagot!

A Number osztály összes leszármazott osztálya által tartalmazott metódusok:
| Metódus | Működés |
|---------|---------|
| `<tipus> <tipus>Value()` | Konvertálja a szám objektum értékét egy egyszerű adattípussá (short, long, float, doube) |
| `<típus> compareTo(<Integer\|Object>)` | Összehasonlítja a szám objektumot a paraméterrel. |
| `<típus> equals(Object)` | Meghatározza, hogy a szám objektum egyenlő-e a paraméterrel. Különböző típusú szám objektumok – a matematikai értéküktől függetlenül – sosem egyenlőek. |

A Float és a Double osztály néhány konstansa:
| Konstans | Jelentés |
|----------|----------|
| `<osztály>.NaN` | Nem szám |
| `<osztály>.NEGATIVE_INFINITY` | Negatív végtelen |
| `<osztály>.POSITIVE_INFINITY` | Pozitív végtelen |
| `<osztály>.SIZE` | Az adat bitben kifejezett mérete |


## III. Adattípusok, String műveletek


### 1. Sorolja fel az egész számokat reprezentáló primitív típusokat!

`byte`, `short`, `int`, `long`.


### 2. Sorolja fel a valós számokat reprezentáló primitív típusokat!

`float`, `double`.


### 3. Mit valósít meg a String pool?

A létrehozott `String` típusú objektum egy különálló, csakis a `String` osztály által
használható memóriaterületre kerül a **heap**-be (ez a **String pool**). Amikor
egy új példány jön létre, a JVM ellenőrzi a String pool-ban, hogy létezik-e ugyanolyan
string érték az ott tárolt objektumokban. Ha igen, létrehoz rá egy újabb referenciát
(az újonnan létrehozott objektum is a már létező, azonos tartalmúra fog mutatni),
ha nem, akkor létrehoz egyet.

Tehát a következő két `String` objektum valójában egy objektum két alias-a (ugyanarra
a String pool-béli memóriacímre mutat):

```
  String st1 = "Java";

  String st2 = "Java";
```

### 4. Melyik függvénnyel segítségével kerülnek bele manuálisan a String-ek a String pool-ba?

Konstruktor.


### 5. Index alapján melyik függvénnyel tudunk kiolvasni egy karaktert (String-ből)?

Habár a sztring karaktereit tömb segítségével tárolja a Java, a karakterek mégsem
érhetők el a tömböknél megszokott módon. E helyett a `charAt(<pozíció>)` metódus
használható, amely visszaadja a megadott pozíción található karaktert. A sztring
első karakterének pozíciója – a tömbindexekhez hasonlóan – a 0.

```
  String hónap = "május";
  char betű = hónap.charAt(2); // a betű változó értéke ’j’ lesz
```

### 6. Két String értékét mivel hasonlítjuk össze?

**Egyenlőségvizsgálat**

A nyelv a könnyebb kezelés érdekében lehetővé teszi, hogy két sztring egyenlőségét
megvizsgáljuk az `==` operátorral. Két sztringliterál csak akkor egyenlő, ha kis-
és nagybetűk szerint tartalmazzák ugyanazokat a karaktereket, ugyanabban a sorrendben.
A **sztringek összehasonlításakor a Java a sztringeket tároló karaktertömbök azonos
indexű pozícióin álló karaktereit hasonlítja össze**. Mivel az azonos betűk kis-
és nagybetűs változatának kódja különbözik (pl. A – 65, a – 97), a csak kis- és
nagybetűkben eltérő sztringek sem lesznek egyenlők. De ez csak akkor igaz, ha az
összehasonlítást az `==` operátorral végezzük.

A String osztály használatával van módunk arra, hogy két sztring egyezőségét megvizsgáljuk
a kis- és nagybetűk figyelmen kívül hagyása mellett. Az `equals(szöveg)` metódus
összehasonlítja a hívó sztringet a paraméterként átadott sztringgel. A visszaadott
érték true, ha a sztringek megegyeznek, false, ha különböznek. Ez a metódus
különbséget tesz a kis- és nagybetűk között. Az `equalsIgnoreCase(szöveg)` metórus
nem tesz különbséget a kis- és nagybetűk között.

Nem csak teljes karakterláncok összehasonlításra van lehetőség. Az `endsWith(<String>)`
és a `startsWith(<String>)` metódusok segítségével megvizsgálható, hogy a paraméterként
átadott szöveg szerepel-e a vizsgált karakterlánc elején vagy végén, illetve a
`startsWith(<String>, <int>)`-ben az int paraméterben az eltolási értéket adhatjuk
meg, hogy az eredeti String-ben hanyadik indextől kezdődjön a keresés.

**Összehasonlítás**

A `compareTo({<String|Object>})` metódus két String-et hasonlít össze ABC szerint, és
egy egész számmal tér vissza, jelezve, hogy ez a String nagyobb (eredmény>0), egyenlő
(eredmény=0), illetve kisebb (eredmény<0), mint a paraméter. A `CompareToIgnoreCase()`
ugyan ezt teszi, de nem tesz különbséget a kis-és nagybetűk között.

```
  String szoveg = "alma";

  System.out.println(szoveg.equals("almaa")); // true, ha egyezik, amúgy false
  System.out.println(szoveg.compareTo("alma")); // 0-át kapunk, ha egyezik

```

### 7. Mely függvény teszi lehetővé, hogy egy String részletét megkapjuk index-ek alapján?

A `substring(<eleje>[, <vége>])` metódus rész-karakterláncot hoz létre az `<eleje>`
indexű karaktertől az (elhagyható) `<vége>`–1 pozíción álló karakterig. Ha a `<vége>`
paraméter hiányzik, akkor az `<eleje>` indextől az eredeti szöveg végéig.

### 8. Whitespace karaktereket hogyan törlünk a String elejéről és végéről?

A `trim()` metódussal. A metódus visszatérési értéke tartalmazza a megtisztított
sztringet, az eredeti nem változik.

### 9. String felbontása (egy általunk megadott elválasztó szöveg mentén) melyik függvénnyel valósítható meg?

A `split()` függvény a megadott elválasztó mentén feldarabolja a paraméterként átadott
szöveget és az eredményt egy string típusú tömbben adja vissza.

```
  //Szöveg darabolása
  String sor ="alma:körte:barack:szilva";
  String[] tomb = sor.split(":");
  System.out.println(tomb[1]);  // Kimenet: körte
```

### 10. switch-case szerkezetnél a feltétel a switch-ben megadott változó lehet String típusú?

A Java 7-es változatának megjelenése óta igen, azelőtt csak egész szám lehetett.

### 11. Mire jó a StringBuilder és a StringBuffer?

A `StringBuilder` és `Stringbuffer` osztály hivatott kiküszöbölni a `String` osztály
egyik kevésbé előnyös tulajdonságát: egy létrehozott String objektum megváltoztathatatlan,
ha pedig ezt megkíséreljük, akkor róla másolatok fognak keletkezni, amelyek processzoridőt
és további memóriát foglalnak le. Ezek az osztályok tehát nagy és gyakran változó
karakterfüzérek gyors elérését és manipulációját teszik lehetővé. A két osztály
szintén karaktertömbben (char tomb[]) tárolja az információt, ám ezen tömb mérete
már változtatható. A karakterek tömbindexe szintén 0-nál kezdődik.

A két osztály lényegében azonos funkcionalitású, azzal a nem elhanyagolható különbséggel,
hogy míg a `StringBuffer` képes együtt dolgozni több programszálon futó, szinkronizált
metódusokkal, addig a `StringBuilder` osztály nem.

### 12. Mi a különbség a StringBuilder, a StringBuffer és a String között?

1. `String` osztály: immutable (megváltoztathatatlan) típusú, ezért olyan stringeket
tárolunk benne, melyek értéke nem fog változni. Ha a tárolt értéken módosítást végzünk,
az eredeti nem módosul, új példány fog létrejönni.
2. `StringBuffer` osztály: akkor használjuk, ha a szövegen szeretnénk változtatni,
elsősorban dinamikus karakterlánc készítésekor (pl. fájlból olvasás); használata
biztonságos több szálas környezetben is.
3. `StringBuilder` osztály: gyorsabb, mint a `StringBuffer`, de csak egy szálon
használható biztonságosan.



## IV. Objektumorientáltság, osztályok, interface-ek


### 1. Mi az objektum, mi az osztály és milyen viszonyban vannak egymással?


### 2. Mi az objektumorientált programozás főbb alapelvei?


### 3. Mit jelent a konstruktor? Milyen láthatósága lehet?


### 4. Mire használjuk a new kulcsszót?


### 5. Sorolja fel a Java-ban elérhető hozzáférhetőségi szinteket!


### 6. Mit jelent az automatikus szemétgyűjtés?


### 7. Egy osztálynak hány konstruktora lehet?


### 8. Írjon példát saját osztály és objektum létrehozására!


### 9. Írjon példát beágyazott osztályra!


### 10. Mit jelent a statikus változó/metódus? Mikor alkalmazható?


### 11. Mit jelent a this, super kulcsszó? Mikor használjuk?


### 12. Mit jelent az öröklődés? Egy osztálynak hány szülőosztálya lehet?


### 13. Osztályhierarchia csúcsán milyen osztály van?


### 14. Object osztálytól milyen metódusokat kapunk?


### 15. Mit jelent az interface? Mire használhatjuk?


### 16. Az interface metódusait mikor kötelező megvalósítani?


### 17. Interface-ek között lehetséges az öröklődés?


### 18. Hogyan néz ki egy interface és az azt tartalmazó törzs? Írjon rá példát! (Interface típusként való használata)


### 19. Írjon példát öröklődésre. Készítsen egy ősosztályt, amely konstruktora legalább egy paramétert átvesz, valamint két leszármazott osztályt. A leszármazottak legalább egy adattaggal és egy függvénnyel többet tartalmazzanak, mint az ős.


### 20. Írjon példát interface megvalósításra. Hozzon létre két interface-t legalább egy-egy függvénnyel, továbbá készítsen egy osztályt, amely mindkét interface-től örököl és megvalósítja azok függvényeit.



## V. Tömbök, gyűjtemények, algoritmusok, generikus típusok


### 1. Jellemezze a Java tömböket?


### 2. Java-ban milyen típusok a tömbök?


### 3. Írjon példát tömb használatára!


### 4. Tömbök másolására milyen megoldásokat ismer?


### 5. Mi a gyűjtemény?


### 6. Mit támogat a gyűjtemény keretrendszer a Java-ban?


### 7. Sorolja fel a Collection interface metódusait!


### 8. Melyik gyűjtemény interfész engedélyezi a duplikált tárolást?


### 9. Kulcs-érték párok tárolására melyik gyűjteményt interface-t használná?


### 10. Soroljon fel gyűjtemény implementációkat (osztályokat, amelyek megvalósítják a gyűjtemény interface-eket)!


### 11. Hogyan járhatók be a gyűjtemények? Írjon minden lehetőségre 1-1 példát.


### 12. Milyen implementált algoritmusok vannak a Java programozási nyelvben?


### 13. Mire jó a Comperator interface?


### 14. Írjon példát Comparable<T> interface megvalósítására (saját osztályt is)!



## VI. Fájlműveletek, adatfolyamok


### 1. Melyik osztály fér hozzá direkt módon (nem adatfolyamként) a fájlokhoz és fájlrendszerhez?


### 2. Mire jó a File osztály?


### 3. Soroljon fel a File osztály metódusait!


### 4. Hogyan lehet könyvtárakat létrehozni Java-ban?


### 5. Mit jelent az adatfolyam Java-ban?


### 6. Adatfolyamoknál mely két interface a legfontosabb?


### 7. Soroljon fel Stream osztályokat!


### 8. Soroljon fel a byte adatfolyamot megvalósító osztályokat!


### 9. Soroljon fel a karakter adatfolyamot megvalósító osztályokat!


### 10. Mely két fontos szűrő osztály létezik Java-ban?


### 11. Mire való a Console osztály?



## VII. Lambda kifejezések, Stream API, dátumkezelés


### 1. Mi a felsorolási típus? Milyen kulcsszóval tudjuk létrehozni?


### 2. Mikortól jelent meg Java-ban a lamda kifejezések?


### 3. Mire használhatóak a lambda kifejezések?


### 4. Hogyan működnek a lambda kifejezések? Írjon egy példát!


### 5. Mire való a default kulcsszó?


### 6. Mire használhatjuk a Stream API-t?


### 7. Sorolja fel a Stream API fontosabb függvényeit! Jellemezze ezeket!


### 8. Milyen „végső műveleteket” ismer?


### 9. Mire jó az Optional osztály?


### 10. Jellemezze a Java 8 új „Date and Time API”-ját!



## VIII. Adatbáziskezelés JDBC-vel


### 1. Java-ban milyen API-n keresztül tudjuk kezelni a relációs adatbázisokat?


### 2. Sorolja fel a JDBC driverek típusait!


### 3. Melyek a JDBC driver típusok előnyei és hátrányai?


### 4. Adatbázis kapcsolat mely osztállyal tudjuk kezelni? Melyik osztály mely függvényével tudunk példány létrehozni belőle?


### 5. Adatbázissal kapcsolat metaadatok mely interface segítségével tudunk lekérdezni?


### 6. Mire való a Statement?


### 7. Hogyan tudunk létrehozni egy Statement objektumot?


### 8. Sorolja fel a Statement SQL parancs végrehajtó függvényeit!


### 9. Írjon példát executeQuery() függvény használatára!


### 10. Írjon példát executeUpdate() függvény használatára!


### 11. Lekérdezés eredményét milyen típusban tároljuk?


### 12. Mire használjuk a PreparedStatement-et? Milyen előnye van a Statement-tel szemben?


### 13. Írjon példát PreparedStatement használatára!


### 14. Soroljon fel néhány JDBC adattípust!


### 15. Milyen ResultSet tulajdonságok léteznek?


### 16. Milyen metódusok léteznek az adatok módosítására ResultSet-ben?


### 17. JDBC-ben hogyan valósíthatjuk meg a tranzakció kezelést?


### 18. JDBC-ben hogyan kérdezhetőek le a hibák és a figyelmeztetések?


### Felhasznált (ajánlott) irodalom:

* Nagy Gusztáv: [Java programozás](https://nagygusztav.hu/sites/default/files/csatol/java_programozas_1.3.pdf)
* Tömösközi Péter: [Programozás javában](https://mek.oszk.hu/14200/14282/pdf/14282.pdf)
* Sallai András: [Java](https://szit.hu/doku.php?id=oktatas:programozas:java)
* Wikipedia: [Java-szócikk](https://hu.wikipedia.org/wiki/Java_(programoz%C3%A1si_nyelv))
* Pénzes László: [Tanuld meg a Java javát!](http://www.informatika-programozas.hu/informatika_java_programozas_bevezetes.html)
* W3Schools: [Java tutorial](https://www.w3schools.com/java/)

[Kezdőlap](../README.md)
