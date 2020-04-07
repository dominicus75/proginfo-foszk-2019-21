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

A kifejezések változókból, literálokból, operandusokból és operátorokból (műveleti
jelekből) állnak, értéküket a program futás közben számolja ki.

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


### 8. Ismertesse a „foreach” ciklust! Írjon rá egy példát!


```
  public class MyClass {

    public static void main(String[] args) {

      String[] autok = {"Volvo", "BMW", "Ford", "Mazda"};

      for (String tipus : autok) { System.out.println(tipus); }

    }

  }
```

### 9. Ismertesse a Java vezérlési szerkezeteit! Sorolja fel őket!


### 10. Milyen feltétel nélküli vezérlésátadás létezik a Java programozási nyelvben?


### 11. Mire szolgál a try-catch szerkezet? Mire használható a finally ág? Írjon egy példát.


### 12. Hogyan tudunk saját kivételt létrehozni? Lehetséges-e ez a Java-ban egyáltalán?


### 13. Kivétel osztályoknál melyik osztály az osztályhierarchiájában csúcsán (nem az Object)?


### 14. Milyen kulcsszóval lehetséges a kivételek továbbadása?


### 15. Sorolja fel a Java burkoló osztályait!


### 16. Soroljon fel néhány burkoló osztály metódust és adattagot!



## III. Adattípusok, String műveletek


### 1. Sorolja fel az egész számokat reprezentáló primitív típusokat!


### 2. Sorolja fel a valós számokat reprezentáló primitív típusokat!


### 3. Mit valósít meg a String pool?


### 4. Melyik függvénnyel segítségével kerülnek bele manuálisan a String-ek a String pool-ba?


### 5. Index alapján melyik függvénnyel tudunk kiolvasni egy karaktert (String-ből)?


### 6. Két String értékét mivel hasonlítjuk össze?


### 7. Mely függvény teszi lehetővé, hogy egy String részletét megkapjuk index-ek alapján?


### 8. Whitespace karaktereket hogyan törlünk a String elejéről és végéről?


### 9. String felbontása (egy általunk megadott elválasztó szöveg mentén) melyik függvénnyel valósítható meg?


### 10. switch-case szerkezetnél a feltétel a switch-ben megadott változó lehet String típusú?


### 11. Mire jó a StringBuilder és a StringBuffer?


### 12. Mi a különbség a StringBuilder, a StringBuffer és a String között?



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
* W3Scholls: [Java tutorial](https://www.w3schools.com/java/)

[Kezdőlap](../README.md)
