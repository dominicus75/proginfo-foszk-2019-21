[Kezdőlap](../README.md)

## 1. tétel
 Az adatbázis-kezelés alapfogalmai. DBMS, adattípusok. Adatmodellezés. Az EK-diagram alapelemei.
Egyedek, kapcsolatok, attribútumok. Kapcsolatok osztályozása. Speciális kapcsolat-típusok.

## 2. tétel
 A relációs adatmodell. Relációséma, reláció. Relációk tulajdonságai, az attribútumok
értéktartománya. Kulcsok, indexek.

## 3. Relációs adatbázisséma elkészítése EK-diagramból. Egyedek, gyenge egyedek, kapcsolatok,
specializáló kapcsolatok, összetett és többértékű attribútumok leképezése.

## 4. tétel
 Relációs adatbázis normalizálása – elméleti alapok. Redundancia, anomáliák redundáns adattárolás
esetén. Funkcionális függőség fogalma. Tábla hűséges felbontása. Heath tétele.

## 5. tétel
 Relációs adatbázis normalizálása – eljárások. Az 1NF, 2NF és 3NF követelményei. Teljes függés és
közvetett függés fogalma. Második és harmadik normálformára alakítás módszere.

## 6. tétel

### 6.1 Az SQL nyelv általános jellemzői

Az **SQL (Structured Query Language – strukturált lekérdezőnyelv)** relációsadatbázis-kezelők
szabványos lekérdezési nyelve. Jellegét tekintve szakterület-specifikus nyelv. Az
SQL nem algoritmikus nyelv, nem tartalmaz algoritmus szerkezeteket (például elágazás,
ciklus), de algoritmikus nyelvekbe beépíthető (beágyazott SQL). Halmazorientált
nyelv, amely a relációkon dolgozik. Az SQL-t jellemzően kliens-szerver hierarchiában
használják, ahol az adatbázis a szerveren kerül tárolásra. A kliens oldaláról érkező
kéréseket a szerver szolgálja ki, és az adatokat visszaadja a kliensnek.

Az SQL nyelv **önálló felhasználás**a esetén csak a nyelv saját utasításai állnak
rendelkezésre. Ennek alkalmazására főként akkor kerülhet sor, ha nincs megfelelő
alkalmazás az adott feladat elvégzésére. A **beágyazott SQL** esetén egy algoritmikus
nyelvbe (C, Pascal, FORTRAN, PHP, stb.) ágyazva alkalmazzuk az SQL nyelv elemeit.
Ebben az esetben az algoritmikus feladatokat a befogadó (host) nyelvre, az adatbázissal
kapcsolatos műveleteket pedig az SQL-re bízhatjuk.

*Az SQL nyelvi elemeket 4 részre lehet bontani:*
* **adatdefiníciós (Data Definition Language, DDL):** adatstruktúra definiáló
utasítások – adatbázisok, táblák létrehozása, módosítása és törlése;
* **adatkezelési (Data Manipulation Language, DML):** adatokon műveletet végző
utasítások – adatok rögzítése, módosítása, törlése;
* **lekérdező (Data Query Language, DQL):** adat lekérdező utasítás (`SELECT`);
* **adatvezérlő (Data Control Language, DCL):** adatvezérlő, felügyelő utasítások
 – tranzakciók kezelése, jogosultságok menedzselése.

**SQL-szabványok**

A relációsadatbázis-kezelő rendszerek szabványos adathozzáférési és adatdefiníciós
nyelve az SQL. Az SQL-t leíró első szabványt az
[ANSI](https://hu.wikipedia.org/wiki/ANSI) 1986-ban
jegyezte be, erre **SQL86** néven szoktak hivatkozni. Az SQL leírását az
[ISO](https://hu.wikipedia.org/wiki/Nemzetk%C3%B6zi_Szabv%C3%A1ny%C3%BCgyi_Szervezet)
9075 számú szabványának aktuális változata rögzíti.

Az ISO/IEC 9075 1992-ig kiadott első változatai:
* [ISO 9075:1987](https://www.iso.org/standard/16661.html) (SQL-86).
* [ISO/IEC 9075:1989](https://www.iso.org/standard/16662.html) (SQL-89).
* [ISO/IEC 9075:1992](https://www.iso.org/standard/16663.html) (SQL-92/SQL2).

Az **ISO/IEC 9075:1999** változatától (SQL3) a szabvány már több részre bomlik,
ezek külön-külön tartalmazzák az egyes témaköröket és kiterjesztéseket leíró
szabályokat. Az ISO/IEC 9075:1999 például 5 részt tartalmaz, míg a 2003-as kiadás
már kilencet (a többdimenziós tömbökkel foglalkozó részt 2019-ben csapták hozzá
tizedikként). A leírásokban az 1999 utáni SQL-szabványokra vagy az ISO/IEC-számmal
(SZABVÁNYSZÁM[-RÉSZ]:ÉVSZÁM, pl. 9075-1:1999 vagy csak 9075:1999), vagy a kiadás
évével (SQL:ÉVSZÁM, pl. SQL:1999) hivatkoznak.

Az ISO/IEC 9075 szabvány 1999 után kiadott változatai:
* 9075:2003 (SQL:2003)
* 9075:2006 (SQL:2006)
* 9075:2008 (SQL:2008)
* 9075:2011 (SQL:2011)

A szabvány legújabb változata a **2016**-os kiadás, ennek részei a következők:
* [9075-1:2016](https://www.iso.org/standard/63555.html): A nyelv alapjai (a
szabvány egyes részeit írja le, és olyan információkat tartalmaz, amelyek minden
részre vonatkoznak).
* [9075-2:2016](https://www.iso.org/standard/63556.html): Adatstruktúrák és alapvető
műveletek (az SQL nyelv adatmeghatározó és adatkezelő részeinek nyelvtanát és
jelentéstanát írja le).
* [9075-3:2016](https://www.iso.org/standard/63475.html): Hívásszintű interfész (SQL/CLI,
megfelel a [Microsoft ODBC](https://tudasbazis.sulinet.hu/hu/szakkepzes/informatika/adatbazis-kezeles/kliens-szerver-hierarchia/az-odbc-lenyege) szabványának).
* [9075-4:2016](https://www.iso.org/standard/63557.html): Tárolt eljárások (SQL/PSM,
azokat az eljárásközpontú SQL-utasításokat határozza meg, amelyek felhasználói
függvényekben és eljárásokban használhatók).
* [9075-9:2016](https://www.iso.org/standard/63476.html): Külső adatok kezelése (SQL/MED,
az 1. részt olyan nyelvi elemekkel és meghatározásokkal egészíti ki, amelyek
lehetővé teszik az SQL-nek, hogy nem SQL adatforrásokat (fájlokat) is elérjen).
* [9075-10:2016](https://www.iso.org/standard/63477.html): Beágyazott JSQL (SQL/OLB,
az SQL-nek a Java programozási nyelvbe történő beágyazását írja le nyelvtani és
jelentéstani szempontból. Megfelel az ANSI
[SQLJ Part O](https://en.wikipedia.org/wiki/SQLJ#SQLJ_part_0) szabványának).
* [9075-11:2016](https://www.iso.org/standard/63565.html): Információs és meghatározási
sémák (SQL/sémák)
* [9075-13:2016](https://www.iso.org/standard/63478.html): Java programnyelvet
használó részprogramok és típusok (SQL/JRT, leírja, hogy miként használhatunk Java
kódot egy SQL adatbázison belül).
* [9075-14:2016](https://www.iso.org/standard/63566.html): XML-hez kapcsolódó
előírások (SQL/XML, azt határozzák meg, hogy miként használhatunk XML-t
egy SQL adatbázison belül. A W3C [XQuery](https://gyires.inf.unideb.hu/GyBITT/12/ch06.html)
szabványához igazodik).
* [9075-15:2019](https://www.iso.org/standard/67382.html): Többdimenziós tömbök
(SQL/MDA).

Az SQL nyelv alapvetően case-insensitive, tehát nem kis-és nagybetű érzékeny. A
táblák és oszlopok nevének leírásához ajánlatos **csak ASCII (ékezet nélküli) karaktereket
használni**. A szöveges literálokat, tehát amit egyszeres, vagy dupla aposztrófok
közé írunk, szó szerint (literally) kell érteni, itt tehát lényeges a nagybetűk–kisbetűk
különbsége (ezek tartalmazhatnak UTF8 karaktereket is).

**A nyelv kulcsszavait (parancsait) általában nagybetűvel szokás írni (pl. SELECT),
a kód jobb olvashatósága és áttekinthetősége érdekében**. A **tábla-, és oszlopneveknél
a kisbetűs írásmód javasolt**, különösen ha a kulcsszavak nagybetűsek, ekkor ugyanis
jól elkülönül egymástól a kettő. A táblák és oszlopok neveit a biztonság érdekében
rakjuk backtick-ek (tompa ékezet) közé (pl. `username`), mert ha véletlenül egy
fenntartott szót használunk oszlop-, vagy táblanévnek, akkor ezek nélkül hibás
lesz a kód (` = backtick = **AltGr+7**).

Változó nincs, csak tábla- és oszlopnevekre lehet hivatkozni. Az SQL utasítások
kulcsszavakból (SQL names, keywords), azonosítókból, műveleti jelekből, literálokból
(számszerű, dátum jellegű, szöveges konstansok, aposztrófok közé írva) állnak. Az
utasítások sorfolytonosan írhatók (és egymásba is ágyazhatók), vagy tetszőlegesen
tagolhatók (szóköz, tabulátor) akár több sorba is írhatók, de minden utasítást
pontosvesszővel kell lezárni.

Az egysoros kommenteket dupla kötőjel (`--`) jelöli, a többsorosakat pedig
`/*` és `*/`. A megjegyzésbe tett tartalmakat a SQL nem veszi figyelembe.


```sql

  -- Ez itt egy egysoros komment

  /* Ez pedig egy
  több soros megjegyzés */

```

A zárójelek a műveletek végrehajtási sorrendjét módosítják (először a zárójeles
kifejezés kerül kiértékelésre). Segítségükkel a műveletek egymásba ágyazhatók.


### 6.2 Speciális logikai kifejezések az SQL-ben

Az SQL rendszerek *„háromértékű logikát”* használnak, vagyis a **TRUE** és **FALSE**
mellett a **NULL (definiálatlan)** érték is felléphet. *Ha egy kifejezés valamelyik
eleme NULL, akkor a kifejezés értéke is NULL lesz*.

|  Operátor  |  Leírás  |
|------------|----------|
| **ALL** | IGAZ, ha az összes alkérdés eredménye megfelel a feltételnek |
| **AND** | IGAZ, ha mindkét feltétel teljesül (logikai **ÉS**) |
| **ANY** vagy **SOME** | IGAZ, ha alkérdés bármely eredménye megfelel a feltételnek |
| **BETWEEN** | IGAZ, ha az operandus a megadott értéktartományon belül van ` SELECT * FROM Termékek WHERE Ár BETWEEN 500 AND 600; ` (minden terméket listáz, aminek az ára 500 és 600 közé esik) |
| **EXISTS**  | IGAZ, ha beágyazott lekérdezés talál a feltételt kielégítő sort. Előtte a NOT kulcsszó is állhat, így jelezve, hogy az alkérdésnek egy sort sem szabad visszaadnia. Használható a **SELECT**, **UPDATE**, **INSERT** vagy **DELETE** utasításokban, közvetlenül a **WHERE** kulcsszó után (az alkérdés előtt). |
| **IN**  | IGAZ, ha az operandus a felsorolt értékek között található, segítségével több **OR** (**VAGY**) operátor helyettesíthető  |
| **LIKE**  | IGAZ, ha az operandus illeszkedik a megadott mintára. A mintában, a `%` jel tetszőleges hosszúságú karakter sorozatot helyettesít, az `_` aláhúzás karakter pedig egy tetszőleges karaktert. Szögletes zárójelek `[]` között egy karakterre vonatkozó értéktartományt adhatunk meg, pl. `[a-d]` **a** és **d** között bármi lehet. Az értéktartományt a `^` karakterrel negálhatjuk, ekkor arra a mintára illeszkedik, ami **nem tartalmazza** a felsoroltakat, pl. `[^a-d]` minden betű, ami nem az **a** és **d** közé esik. |
| **NOT** | IGAZ, ha a kifejezésben az adott feltétel nem teljesül (tagadás, negáció). Használható a többi logikai operátor negálására is (pl. **NOT BETWEEN**, **NOT EXISTS**, **NOT LIKE**, stb.). |
| **OR**  | IGAZ, ha bármelyik feltétel teljesül (logikai **VAGY**) |
| **IS NULL** | IGAZ, ha a kifejezés értéke **NULL**  |
| **IS NOT NULL** | IGAZ, ha a kifejezés értéke **NEM NULL** |

Mivel a **NULL** nem tesztelhető a szokványos összehasonlító operátorokkal (az ilyen
összehasonlítás eredménye mindig ismeretlen) és a **NULL**-t tartalmazó kifejezés
eredménye is mindig **NULL**, ezért azt, hogy egy kifejezés értéke **NULL**-e, az
**IS NULL** operátorral tesztelhetjük, illetve ennek ellenkezőjét az **IS NOT NULL**
operátorral.

### 6.3 Tábla szerkezetének létrehozása, módosítása, [adatdefiníciós utasítások (DDL)](https://mariadb.com/kb/en/data-definition/)

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható (opcionális) részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli, a [BNF](https://hu.wikipedia.org/wiki/Backus%E2%80%93Naur-forma)
metaszintaxishoz hasonló módon. A {kapcsos zárójelbe zárt szöveg} logikai egységet
alkotó nyelvi elemeket jelöl a szintaxis leírásában.*

Az adatdefiníciós nyelv segítségével hozhatjuk létre illetve szüntethetjük meg magát
az adatbázist, illetve a relációkat (táblákat), az indexeket, a nézet táblákat,
[és még sok egyebet](https://mariadb.com/kb/en/create/).

A következő SQL parancsok tartoznak ide:
* **CREATE** (létrehozás)
* **DROP** (eldobás)
* **ALTER** (módosítás)

#### [CREATE DATABASE](https://mariadb.com/kb/en/create-database/)

Létrehoz egy üres adatbázist a megadott néven.

Szintaxis:
```sql

  CREATE [OR REPLACE] {DATABASE | SCHEMA} [IF NOT EXISTS] `<adatbázis_név>`
    [<létrehozási_feltételek>];

  <létrehozási_feltételek> ::=
    [DEFAULT] CHARACTER SET [=] <karakterkészlet>
  | [DEFAULT] COLLATE [=] <szövegösszevetési_mód>

        <karakterkészlet> ::= pl. utf8, alapértelmezett: latin1
  <szövegösszevetési_mód> ::= A kis-, és nagybetű érzékenységet és az adott nyelv
                            abc-je szerinti sorba rendezésre vonatkozó beállításokat
                            tartalmazzák. Az utf8_hungarian_ci például nem kis-,
                            és nagybetű érzékeny (ci - case insensitive) és a magyar
                            abc szerit rendezi sorba a szöveges adatokat, figyelembe
                            véve az ékezetes betűket is.

```

A karakterkészlet és a szövegösszevetési_mód az egyes táblák létrehozásánál is
megadhatók (akkor az adott táblára fognak csak vonatkozni).

Példa:
```sql

  CREATE DATABASE IF NOT EXISTS `Adatbazis`
  CHARACTER SET = utf8
  COLLATE = utf8_hungarian_ci;

```

#### [CREATE TABLE](https://mariadb.com/kb/en/create-table/)

Relációséma létrehozására a CREATE TABLE utasítás szolgál, amely egyben egy üres
táblát is létrehoz a sémához, a megadott névvel. Az utasítás után a tábla neve, majd
a tábla szerkezetét (mezők, indexek, megszorítások) meghatározó, kerek zárójelek
közé zárt tábladefiníció következik. Az attribútumok definiálása (név és adattípus
beállítása) mellett a kulcsok (elsődleges és külső), indexek valamint tábla-, és
oszlopszintű megszorítások megadására is lehetőséget nyújt.

A kerek zárójelek közé kerülő meződefiníciók egymástól vesszővel elválasztott
meghatározások. Minden meződefinícióban kötelezően szerepel a mező neve és adattípusa,
de tartalmazhat további mezőtulajdonságokat is.

Szintaxis:
```sql

  CREATE TABLE [IF NOT EXISTS] `<Táblanév>` (
    `<oszlopnév>` <adattípus>(<méret>) [<oszlop_megszorítások>],
    [<tábla_megszorítások>]
  )[ENGINE [=] <adatbázismotor> | CHARACTER SET [=] <karakterkészlet>
   | COLLATE [=] <szövegösszevetési_mód>];

  <Táblanév>, <oszlopnév> ::= max. 64 karakter hosszú, szóköz nélküli ASCII szöveg
              <adattípus> ::= a relációs adatmodell előírja, hogy egy mező minden
                              értékének azonos értéktartományba (domain) kell
                              tartoznia. Ezt az adattípus határozza meg, melyhez
                              DEFAULT '<érték>' kifejezéssel alapértelmezett
                              érték is definiálható
                  <méret> ::= a tárolt adat maximális mérete
   <oszlop_megszorítások> ::= az oszlopra vonatkozó megszorítások (pl. PRIMARY
                              KEY = elsődleges kulcs, azonosító; NULL vagy NOT
                              NULL; REFERENCES = külső kulcs hivatkozás,
                              UNSIGNED = előjel nélküli).
    <tábla_megszorítások> ::= az egész táblára vonatkozó megszorítások (a NULL
                              és a NOT NULL kivételével azonosak az oszlop
                              megszorításokkal, pl. PRIMARY KEY, REFERENCES)
         <adatbázismotor> ::= a MySQL saját, eredeti adatbázismotorja a MyISAM
                              nem támogatja a tranzakció kezelést, és a hivatkozási
                              integritás megőrzését sem. Ezért általában az InnoDB
                              motort állítják be alapértelmezettként.

```

A **NOT NULL** opció használata esetén a mező kitöltése kötelező, az ilyen mezők nem
maradhatnak üresen. A kötelező mezőkben bármilyen értéket tárolhatunk, amit a választott
típus megenged. **A NOT NULL opciónak fontos szerepe van a táblák közötti kapcsolatban,
a minimális részvétel, azaz a kötelezőség beállításában**.

A tábla módosításakor a definiált kulcsfeltételek automatikusan ellenőrzésre
kerülnek. **PRIMARY KEY** és **UNIQUE** esetén ez azt jelenti, hogy a rendszer nem
enged olyan módosítást illetve új sor felvételét, amely egy már meglévő kulccsal
ütközne.

**REFERENCES** (külső kulcs hivatkozás) esetén **ON**-feltételek megadásával
szabályozhatjuk a rendszer viselkedését:
* **Alapértelmezés (ha nincs ON-feltétel):** a hivatkozó táblában nem megengedett
olyan beszúrás és módosítás, amely a hivatkozott táblában nem létező kulcs értékre
hivatkozna, továbbá a hivatkozott táblában nem megengedett olyan kulcs módosítása
vagy sor törlése, amelyre a hivatkozó tábla hivatkozik.
* **ON UPDATE CASCADE:** ha a hivatkozott tábla egy sorában változik a kulcs értéke,
akkor a rá való hivatkozások is megfelelően módosulnak (módosítás továbbgyűrűzése).
* **ON DELETE CASCADE:** Ha a hivatkozott táblában törlünk egy sort, akkor törlődnek
a rá hivatkozó sorok (törlés továbbgyűrűzése).
* **ON UPDATE SET NULL:** ha a hivatkozott tábla egy sorában változik a kulcs értéke,
akkor a rá való külső kulcs hivatkozások értéke NULL lesz.
* **ON DELETE SET NULL:** ha a hivatkozott táblából törlünk egy sort, akkor a rá
való külső kulcs hivatkozások értéke NULL lesz.

A MySQL-ben több módszer is létezik a lemezfájlok belső struktúrájának kialakítására
és kezelésére. Ezeket a DBMS különálló, akár egyenként is telepíthető moduljai,
az **adatbázismotorok** biztosítják. Az egyes motorok eltérő kiegészítő lehetőségeket
biztosítanak a relációk kezelésének alapvető funkcióin túl. Egy tábla definiálásakor
megadhatjuk, hogy melyik adatbázismotort szeretnénk használni, a MySQL pedig mindig
a kiválasztott módon fogja kezelni a relációt.

A telepített motorok a **SHOW ENGINES;** paranccsal tekinthetők meg.

A MySQL adatbázisokban az **InnoDB** motorral kezelt táblákban használhatunk
tranzakciókezelést, **csak az InnoDB relációkban őrizhetjük meg az idegen kulcsok
helyességét** (mert az InnoDB támogatja az idegen kulcsra vonatkozó megszorítások
használatát). A MySQL-szerverek konfigurációjában (*a rendszergazdáknak*) megadható
az alapértelmezett táblamotor, karakterkódolás, és a többi táblatulajdonság is.

**[SQL adattípusok](https://webfejlesztes.gtportal.eu/?f0=7_tabla_06)**

* **CHAR(n):** n hosszúságú karaktersorozat
* **VARCHAR(n):** legfeljebb n hosszúságú karaktersorozat
* **INTEGER** vagy **INT:** egész szám
* **REAL:** valós (lebegőpontos) szám, másnéven FLOAT
* **DECIMAL(n[,d]):** n jegyű decimális szám, ebből d tizedesjegy
* **DATE:** az [ISO 8601](https://hu.wikipedia.org/wiki/ISO_8601) szabványnak megfelelő
dátum (ÉÉÉÉ-HH-NN).
* **TIME:** az [ISO 8601](https://hu.wikipedia.org/wiki/ISO_8601) szabványnak megfelelő
idő (óó:pp:mm).

Példa:
```sql

  CREATE TABLE `Dolgozok` (
    `azonosito` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
    `csaladnev` varchar(30),
    `keresztnev` varchar(20),
    `szul_datum` date,
    `lakcim` varchar(40) DEFAULT 'hajléktalan',
    `osztaly_id` int(10),
    PRIMARY KEY (azonosito)
  )ENGINE = InnoDB;

```

#### [ALTER](https://mariadb.com/kb/en/alter/) utasítás

**[ALTER DATABASE](https://mariadb.com/kb/en/alter-database/)**

Lehetővé teszi az adatbázis általános tulajdonságainak megváltoztatását. Ezeket
a jellemzőket a `db.opt` fájl tárolja az adatbázis könyvtárban.

Szintaxis
```sql

  ALTER {DATABASE | SCHEMA} [<adatbázisnév>]
      <változtatások_meghatározása>;

  <változtatások_meghatározása> ::=
      [DEFAULT] CHARACTER SET [=] <karakterkészlet>
    | [DEFAULT] COLLATE [=] <szövegösszevetési_mód>

```

Példa
```sql

  ALTER DATABASE `adatbazisom`
  CHARACTER SET = 'utf8'
  COLLATE = 'utf8_hungarian_ci';

```

**[ALTER TABLE](https://mariadb.com/kb/en/alter-table/)**

Lehetővé teszi egy **létező tábla struktúrájának megváltoztatását**. Képes oszlopokat
vagy indexeket, elsődleges kulcsokat és megszorításokat hozzáadni és törölni, létező
oszlopok típusát megváltoztatni, vagy oszlopokat és magát a táblát is átnevezni.
De meg lehet vele változtatni a táblához használt adatbázismotort, karakterkészletet
és szövegösszevetési módot is. Az ALTER TABLE utasítás szintaxisa és szemantikája
rendszerenként eltérő, oszlopok törlését nem minden rendszer engedi meg.

Szintaxis
```sql

  ALTER TABLE <táblanév>
    <változtatások_meghatározása>;

  <változtatások_meghatározása> ::=
    {ADD | MODIFY} [COLUMN] <oszlopnév> <oszlop_meghatározása>
    | ADD {INDEX|KEY} [IF NOT EXISTS] [<index_neve>]
    | ADD [CONSTRAINT] <index_neve> { UNIQUE [INDEX|KEY] }
        (<index_oszlop_neve>,...)
    | ADD PRIMARY KEY (<index_oszlop_neve>)
    | ADD [CONSTRAINT <megszorítás_elnevezése>]
        FOREIGN KEY [IF NOT EXISTS] (<hivatkozó_mező_neve>,...)
        REFERENCES <hivatkozott_tábla_neve>(<hivatkozott_mező_neve>,...)
    | DROP {COLUMN | PRIMARY KEY | INDEX | KEY | FOREIGN KEY | CONSTRAINT}
        [IF EXISTS] <törlendő_objektum_neve>
    | ALTER [COLUMN] <oszlopnév> SET DEFAULT (<kifejezés>)
    | ALTER [COLUMN] <oszlopnév> DROP DEFAULT

               <táblanév> ::= a módosítandó tábla neve
              <oszlopnév> ::= a módosítandó oszlop neve
   <oszlop_meghatározása> ::= <adattípus>(<méret>) [<oszlop_megszorítások>]
              <adattípus> ::= a relációs adatmodell előírja, hogy egy mező minden
                              értékének azonos értéktartományba (domain) kell
                              tartoznia. Ezt az adattípus határozza meg, melyhez
                              DEFAULT '<érték>' kifejezéssel alapértelmezett
                              érték is definiálható
                  <méret> ::= a tárolt adat maximális mérete
   <oszlop_megszorítások> ::= az oszlopra vonatkozó megszorítások (pl. PRIMARY
                              KEY = elsődleges kulcs, azonosító; NULL vagy NOT
                              NULL; REFERENCES = külső kulcs hivatkozás,
                              UNSIGNED = előjel nélküli).
      <index_oszlop_neve> ::= egy már létező oszlop neve, amit indexként vagy
                              elsődleges kulcsként akarunk használni
             <index_neve>,
 <megszorítás_elnevezése> ::= ezen a néven lehet rá később hivatkozni
              <kifejezés> ::= lehet konstans, függvényhívás, vagy alkérdés

```

Péda
```sql

  ALTER TABLE `Dolgozok` ADD COLUMN `fizetes` int(8) UNSIGNED NOT NULL;

  ALTER TABLE `Dolgozok` DROP PRIMARY KEY;

  ALTER TABLE `Dolgozok` ADD PRIMARY KEY (`azonosito`);

  ALTER TABLE `Dolgozok` ALTER `fizetes` SET DEFAULT 300000;

  ALTER TABLE `Dolgozok`
  ADD FOREIGN KEY (osztaly_id) REFERENCES osztalyok(osztaly_id) ON UPDATE CASCADE;

  ALTER TABLE Orders
  ADD CONSTRAINT `FK_megszoritas_neve`
  FOREIGN KEY (osztaly_id) REFERENCES osztalyok(osztaly_id) ON UPDATE CASCADE;

```

#### [DROP](https://mariadb.com/kb/en/drop/) utasítás

Törli a kijelölt objektumot.

**[DROP DATABASE](https://mariadb.com/kb/en/drop-database/)**

Törli az összes táblát és az adatbázis szerkezetét is. Az adatbázis törlésével a
hozzátartozó felhasználói jogosultságok nem törlődnek automatikusan.

Szintaxis
```sql

  DROP {DATABASE | SCHEMA} [IF EXISTS] <adatbázisnév>;

```

Péda
```sql

  DROP DATABASE `Adatbazisom`;

```

**[DROP TABLE](https://mariadb.com/kb/en/drop-table/)**

Törli a tábla összes sorát és magát a tábla szerkezetét is. Az tábla törlésével a
hozzátartozó felhasználói jogosultságok nem törlődnek automatikusan.

Szintaxis
```sql

  DROP TABLE [IF EXISTS] <táblanév>;

```

Példa
```sql

  DROP TABLE `Dolgozok`;

```

### 6.4 Idegenkulcs-hivatkozások relációsémák definiálásakor

A **külső (vagy idegen) kulcs** olyan kulcs, ami egy másik séma elsődleges kulcsára
hivatkozik, ezzel összeköti a két sémát. A külső kulcs értéke a hivatkozott táblában
előforduló kulcsérték vagy NULL lehet. Két reláció csak akkor áll kapcsolatban egymással,
ha az egyik **külső kulcsként** tartalmazza a másik **elsődleges kulcsát**. Az idegen
kulcsot tartalmazó relációt **hivatkozó relációnak**, a másikat, melyben ez a kulcs elsődleges,
**hivatkozott relációnak** nevezzük.

Idegenkulcs-hivatkozások a CREATE TABLE utasításban valamely attribútum deklarációja
után adhatók meg a

```sql

    FOREIGN KEY [IF NOT EXISTS] (<hivatkozó_mező_neve>,...)
    REFERENCES <hivatkozott_tábla_neve>(<hivatkozott_mező_neve>,...)

```

szintaxis használatával. Ez azt jelenti, hogy az adott oszlop idegen kulcs-hivatkozást
tartalmaz a kapcsolótábla kapcsoló oszlopára, mely csak elsődleges, vagy egyedi kulcs lehet.
Az ilyen megszorítással rendelkező oszlopok csak NULL (itt: *nincs kapcsolat*), vagy olyan
értékeket vehetnek fel, amilyen a kapcsolt tábla kapcsolt oszlopában is megtalálható,
kivétel, ha az oszlop **NOT NULL** megszorítással rendelkezik.


## 7. tétel

### 7.1 Nézettábla (VIEW) kialakítása és szerepe

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható (opcionális) részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli, a [BNF](https://hu.wikipedia.org/wiki/Backus%E2%80%93Naur-forma)
metaszintaxishoz hasonló módon. A {kapcsos zárójelbe zárt szöveg} logikai egységet
alkotó nyelvi elemeket jelöl a szintaxis leírásában.*

**A nézet vagy nézettábla olyan virtuális tábla, amely az adatbázis egy vagy több
táblájának mezőiből épül fel**. A nézettáblát alkotó táblákat alaptábláknak hívjuk.
A relációs modell azért tekinti virtuálisnak (látszólagosnak) a nézettáblákat, mert
azok adatai más táblákból származnak. Maguk a nézettáblák nem tárolnak adatokat;
az adatbázisban valójában a szerkezetük az egyetlen információ, ami tárolódik róluk.

Sok RDBMS program a nézettáblákat mentett lekérdezésként valósítja meg, és ezen
a néven vagy egyszerűen lekérdezésként hivatkozik rájuk. A lekérdezések a legtöbb
esetben rendelkeznek a nézettáblák minden jellemzőjével, vagyis csupán a nevük az
egyetlen különbség köztük.

Az SQL-szabvány szerit a `<tábla_neve>` nézettáblát is takarhat, de kiköti, hogy a
nézettáblának lehetővé kell tennie a módosítást és a beszúrást. Számos adatbázisrendszer
lehetővé teszi, hogy nézettáblákba szúrjunk be adatokat, de mindegyiknek saját
szabályai vannak, amelyek alapján meghatározzák, hogy egy nézettábla módosítható-e,
illetve beszúrható-e bele új adat. Az esetek többségében egy nézettáblába nem
szúrhatunk be adatokat, ha az oszlopok valamelyike kifejezés vagy összesítő függvény
eredményét tartalmazza.<sup id="6">[[6]](#note6)</sup>

Ha a nézettábla tartalmát módosítjuk, akkor a módosítás a megfelelő tárolt táblákon
hajtódik végre és természetesen megjelenik a nézettáblában is. Ha egy módosítható
nézettáblába új rekordot veszünk fel, akkor az alaptáblának a nézettáblában nem
szereplő oszlopaiba szükségképpen NULL kerül.

Nézettáblák alkalmazási lehetőségei:
* Származtatott adattáblák létrehozása, amelyek a törzsadatok módosításakor
automatikusan módosulnak (pl. összegzőtáblák).
* Bizonyos adatok elrejtése egyes felhasználók elől (adatbiztonság vagy egyszerűsítés
céljából).

**[CREATE VIEW](https://mariadb.com/kb/en/create-view/)**

Létrehoz egy új nézettáblát, vagy – amennyiben az `OR REPLACE` kikötés szerepel a
kifejezésben – lecseréli a már létezőt. A CREATE VIEW végrehajtásakor a rendszer
csak letárolja a nézettábla definícióját, és majd csak a rá való hivatkozáskor
generálja a szükséges adatokat.

Szintaxis
```sql

  CREATE [OR REPLACE] VIEW [IF NOT EXISTS]
    <nézettábla_neve> [(<oszloplista>)]
    AS <select_utasítás>;

  <nézettábla_neve> ::= erre a névre lehet hivatkozni ott, ahol egy SQL parancsban
                        táblanév adható meg, ott rendszerint nézettábla neve is
                        szerepelhet.
      <oszloplista> ::= megadásával a nézettábla oszlopainak új nevet adhatunk,
                        ennek hiányában a forrástáblák oszlopnevei kerülnek bele.
  <select_utasítás> ::= ennek a beágyazott (vagy al-) lekérdezésnek az
                        eredménytáblája alkotja a nézettáblát.

```

Példa
```sql

  CREATE VIEW `Melosok` (`Családnév`, `keresztnév`, `Állandó lakcím`)
    AS SELECT `csaladnev`, `keresztnev`, `lakcim`
    FROM `Dolgozok`
    WHERE `osztaly_id` = 1234;

```

### 7.2 Adattábla aktualizálása, [adatmanipulációs utasítások (DML)](https://mariadb.com/kb/en/data-manipulation/), adattábla aktualizálása

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható (opcionális) részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli, a [BNF](https://hu.wikipedia.org/wiki/Backus%E2%80%93Naur-forma)
metaszintaxishoz hasonló módon. A {kapcsos zárójelbe zárt szöveg} logikai egységet
alkotó nyelvi elemeket jelöl a szintaxis leírásában.*

A **DML (Data Manipulation Language, adatmanipulációs nyelv)** az SQL adatmanipulációs
résznyelve. A DML-utasításokkal rekordokat illeszthetünk a létrehozott adatbázis
tábláiba, módosíthatjuk a tárolt adatokat, vagy törölhetjük a fölöslegessé vált
rekordokat.

Az adatmanipulációs nyelv három fő utasítása:
* **INSERT** – adatok beszúrása
* **UPDATE** – adatok módosítása
* **DELETE** – adatok törlése

Az **[INSERT](https://mariadb.com/kb/en/insert/)** utasítás

Szintaxis
```sql

  INSERT [INTO] <táblanév> [<mezőlista>]
    VALUES <értéklista>;

     <mezőlista> ::= (<oszlopnév1>, <oszlopnév2>,...<oszlopnévN>,)
    <értéklista> ::= (<érték1>, <érték2>,...<értékN>)

```

A mezőlistában szereplő mezők számának és az értéklistában szereplő értékek
számának meg kell egyeznie. A mezőlistát elhagyhatjuk, ha az pontosan megegyezik
a tábla oszlopaink sorrendjével. Ha el szeretnénk térni az oszlopok eredeti sorrendjétől,
vagy ki akarunk hagyni az értékadásból oszlopokat, akkor mindenképpen szükséges
a mezőlista. A mezőlistából kihagyott oszlopok az oszlopra definiált **DEFAULT**
megszorításbeli értékkel, ennek hiányában **NULL** értékkel szerepelnek majd az
új sorban. Ha olyan oszlopot hagyunk ki az értékadásból, melyre nincs **DEFAULT**
megszorítás, és **NOT NULL** záradék van az oszlopon, akkor az új sor beszúrása
nem történik meg, hibaüzenetet kapunk.

Az értéklistában szerepelhet **NULL** érték, ha az oszlopra NULL engedélyünk van. Ha
az oszlopra **NOT NULL** megszorítás van érvényben (és az elsődleges kulcs oszlop
mindig ilyen), akkor hibaüzenetet kapunk, és a sor beszúrása nem történik meg.
A táblába adatokat tölthetünk át másik táblából is, ha a `VALUES (<értéklista>)`
helyére egy alkérdést írunk.

A legtöbb SQL implementációban van mód arra, hogy az elsődleges kulcsként definiált
oszlopban egy automatikusan növekvő számot írjunk be új sor esetén, ne nekünk
kelljen gondoskodni a megadásáról. De innentől kezdve az elsődleges kulcs oszlopokba
expliciten nem adhatunk meg értéket (MySQL és MariaDB esetén: AUTO_INCREMENT).

Példa
```sql

  INSERT INTO `Dolgozok`
    (`csaladnev`, `keresztnev`, `szul_datum`, `lakcim`, `osztaly_id`)
  VALUES
    ('Gipsz', 'Jakab', '1966-12-13', '8491 Karakószörcsök, Fő út 12', 1234);

```
A példában nem szerepel az `azonosito` mező (elsődleges kulcs), mivel a **10.3**
tételben szereplő példában ez az attribútum AUTO_INCREMENT-re van állítva.

Az **[UPDATE](https://mariadb.com/kb/en/update/)** utasítás

A megadott tábla **WHERE** záradékban megadott feltételek által kijelölt sorait módosítja.
Az értékadás minden olyan soron végrehajtódik, amely eleget tesz a WHERE feltételnek.
Ha a WHERE záradékot elhagyjuk, akkor a tábla összes során megtörténik a módosítás.
Az esetek többségében egyetlen sor módosítására használjuk, a sort pedig az elsődleges
kulcsán keresztül érjük el.

A kiválasztott sorokon belül módunk van egyszerre több oszlop értékét is módosítani,
azokat, amelyeket a **SET** után felsoroltunk. A kifejezés lehet egy konstans érték,
de hivatkozhatunk benne az adott tábla bármelyik oszlopára is, illetve használhatunk
az adott adatbázis-kezelő által implementált rendszerfüggvényeket (pl. Substring, Len,
stb.), valamint alkérdéseket is. Ha a kifejezés helyett a `DEFAULT` kulcsszó áll,
akkor a mező értékét az alapértelmezettre állítja (ha van ilyen).

Szintaxis
```sql

  UPDATE <táblanév>
    SET <oszlopnév1>={<kifejezés1>|DEFAULT} [,
    <oszlopnév2>={<kifejezés2>|DEFAULT},
    ....,
    <oszlopnévN>={<kifejezésN>|DEFAULT}]
    [WHERE <feltétel>];

    <táblanév> ::= a módosítandó tábla neve
   <oszlopnév> ::= a módosítandó oszlop neve
   <kifejezés> ::= lehet konstans, függvényhívás, vagy alkérdés
    <feltétel> ::= az értékadás minden olyan soron végrehajtódik, amely eleget
                   tesz a feltételnek

```

Példa
```sql

  UPDATE `Dolgozok` SET
    `fizetes` = `fizetes`*1.25,
    `lakcim`  = 'Kőbánya-alsó'
  WHERE `azonosito` = 123;

```
A példában megemeljük az 123 azonosítójú dolgozó fizetését 25%-al és jól elköltöztetjük
Kőbánya-alsóra.

A **[DELETE](https://mariadb.com/kb/en/delete/)** utasítás

Sor(ok) törlésére szolgál. Ha feltétel nélkül használjuk az utasítást, a tábla
összes sora törlődik, ezért óvatosan bánjunk vele. A feltétel teljesüléstől függően
egyszerre több sor is törölhető. Több sor törlése esetén, ha bármelyik sor törlése
hibára fut (pl. más tábla idegenkulcsként hivatkozik rá), a törlés egy sorra sem
történik meg.

Szintaxis
```sql

  DELETE FROM <táblanév>
    [WHERE <feltétel>]

    <táblanév> ::= a módosítandó tábla neve
    <feltétel> ::= minden olyan sort töröl, amely eleget tesz a feltételnek

```

Példa
```sql

  DELETE FROM `Dolgozok`  WHERE `azonosito` = 123;

```

## 8. tétel

### 8.1 [Lekérdezés relációs adattáblákból (DQL)](https://mariadb.com/kb/en/selecting-data/)

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható (opcionális) részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli, a [BNF](https://hu.wikipedia.org/wiki/Backus%E2%80%93Naur-forma)
metaszintaxishoz hasonló módon. A {kapcsos zárójelbe zárt szöveg} logikai egységet
alkotó nyelvi elemeket jelöl a szintaxis leírásában.*

A **DQL (Data Query Language, adatlekérdező nyelv)** az SQL névadó résznyelve.
Használatával az adatbázisok tábláiban tárolt adatok különböző szempontok és összefüggések
alapján kérdezhetők le. A DQL-ben pontosan megfogalmazhatjuk a megjelenítendő rekordok
és mezők forrásául szolgáló táblákat, vagy táblakapcsolatokat, és feltételekkel
szűrhetjük a rekordokat. A kiválasztott adatokkal statisztikai műveleteket végezhetünk,
vagy egyszerűen megjeleníthetjük őket. Egyes osztályozások DQL-t a DML részének
tekintik, így számos irodalomban nem is találkozunk külön ezzel a résznyelvvel.

**[SELECT](https://mariadb.com/kb/en/select/) utasítás**

A **SELECT** az adatlekérdező nyelv egyetlen parancsa, mellyel megvalósítható a
kiválasztás, vetítés (*az oszlopok felsorolásával végezzük el a projekció műveletét,
a **WHERE** kulcsszó utáni feltétel kiértékelése alapján pedig szelekció történik*),
összekapcsolás és a Descartes-szorzat (bővebben lásd: **12.3 tétel**).

Szintaxis
```sql

  SELECT [DISTINCT]
    <select_kifejezés> [, <select_kifejezés> ...]
    [FROM <tábla_hivatkozások>
      [WHERE <where_feltétel>]
      [GROUP BY <oszlopnév> [, <oszlopnév>,...]]
      [HAVING <having_feltétel>]
      [ORDER BY <oszlopnév> [ASC|DESC] [, <oszlopnév> [ASC|DESC],...]]
    ];

    <select_kifejezés> ::= oszlopneveket, tetszőleges kifejezéseket tartalmazhat,
                           vagy egy csillag * karaktert (jelentése: mindegyik).
  <tábla_hivatkozások> ::= egy vagy több tábla neve, ezek Descartes-szorzatából
                           szelektáljuk a <where_feltétel>-nek eleget tévő sorokat,
                           vagy ennek hiányában ezekből választjuk ki projekcióval
                           az eredménytábla oszlopait.
      <where_feltétel>,
     <having_feltétel> ::= logikai kifejezés, műveleteket és operátorokat tartalmazhat

```

### 8.2 A SELECT parancs záradékainak szerepe

A SELECT egyszerűsége abban áll, hogy a parancsot követő számos nyelvi elem jó
része opcionális, elhagyható. Szinte az összes opciót mellőzhetjük, egyedül a
SELECT-et követő `<select_kifejezés>` kötelező. Ez nem csak oszlopneveket,
hanem tetszőleges kifejezéseket (pl. aggregáló függvényeket) is tartalmazhat, és
itt adhatók meg az eredménytábla oszlopainak átnevezésére szolgáló alias nevek is.
A **DISTINCT** opciót akkor kell a **SELECT** után írni, ha az eredménytáblában
az azonos sorokból csak egyet kívánunk megtartani.

**A WHERE záradék**

A kiválasztást végrehajtó parancs a WHERE <feltétel> záradékot is tartalmazza.
Az eredménytáblába csak azok a sorok adatai kerülnek, melyekre teljesül a feltétel.
A feltétel műveleteket és operátorokat tartalmazhat. A műveletekre érvényesek a
szokásos precedencia szabályok, amelyeket zárójelezéssel felülbírálhatunk. Ügyelnünk
kell arra, hogy végeredményben a kifejezés mindig logikai értéket kapjon, mivel
az eredménytáblába azok az előfordulások (sorok) kerülnek be, amelyekre a megadott
kifejezés igaz (TRUE) értéket kap.

*Az SQL összehasonlító operátorai*

Ezek segítségével összehasonlításokat végezhetünk. Számoknál és szöveges adatoknál
egyaránt használhatók.

|  Operátor  |  Leírás  |
|------------|----------|
| = | egyenlő |
| > | nagyobb, mint |
| < | kisebb, mint  |
| >=  | nagyobb vagy egyenlő  |
| <=  | kisebb vagy egyenlő |
| <> vagy !=  | nem egyenlő |

*Az SQL logikai operátorai*

Az SQL rendszerek *„háromértékű logikát”* használnak, vagyis a **TRUE** és **FALSE**
mellett a **NULL (definiálatlan)** érték is felléphet. *Ha egy kifejezés valamelyik
eleme NULL, akkor a kifejezés értéke is NULL lesz*.

|  Operátor  |  Leírás  |
|------------|----------|
| **ALL** | IGAZ, ha az összes alkérdés eredménye megfelel a feltételnek |
| **AND** | IGAZ, ha mindkét feltétel teljesül (logikai **ÉS**) |
| **ANY** vagy **SOME** | IGAZ, ha alkérdés bármely eredménye megfelel a feltételnek |
| **BETWEEN** | IGAZ, ha az operandus a megadott értéktartományon belül van ` SELECT * FROM Termékek WHERE Ár BETWEEN 500 AND 600; ` (minden terméket listáz, aminek az ára 500 és 600 közé esik) |
| **EXISTS**  | IGAZ, ha beágyazott lekérdezés talál a feltételt kielégítő sort. Előtte a NOT kulcsszó is állhat, így jelezve, hogy az alkérdésnek egy sort sem szabad visszaadnia. Használható a **SELECT**, **UPDATE**, **INSERT** vagy **DELETE** utasításokban, közvetlenül a **WHERE** kulcsszó után (az alkérdés előtt). |
| **IN**  | IGAZ, ha az operandus a felsorolt értékek között található, segítségével több **OR** (**VAGY**) operátor helyettesíthető  |
| **LIKE**  | IGAZ, ha az operandus illeszkedik a megadott mintára. A mintában, a `%` jel tetszőleges hosszúságú karakter sorozatot helyettesít, az `_` aláhúzás karakter pedig egy tetszőleges karaktert. Szögletes zárójelek `[]` között egy karakterre vonatkozó értéktartományt adhatunk meg, pl. `[a-d]` **a** és **d** között bármi lehet. Az értéktartományt a `^` karakterrel negálhatjuk, ekkor arra a mintára illeszkedik, ami **nem tartalmazza** a felsoroltakat, pl. `[^a-d]` minden betű, ami nem az **a** és **d** közé esik. |
| **NOT** | IGAZ, ha a kifejezésben az adott feltétel nem teljesül (tagadás, negáció). Használható a többi logikai operátor negálására is (pl. **NOT BETWEEN**, **NOT EXISTS**, **NOT LIKE**, stb.). |
| **OR**  | IGAZ, ha bármelyik feltétel teljesül (logikai **VAGY**) |
| **IS NULL** | IGAZ, ha a kifejezés értéke **NULL**  |
| **IS NOT NULL** | IGAZ, ha a kifejezés értéke **NEM NULL** |

Mivel a **NULL** nem tesztelhető a szokványos összehasonlító operátorokkal (az ilyen
összehasonlítás eredménye mindig ismeretlen) és a **NULL**-t tartalmazó kifejezés
eredménye is mindig **NULL**, ezért azt, hogy egy kifejezés értéke **NULL**-e, az
**IS NULL** operátorral tesztelhetjük, illetve ennek ellenkezőjét az **IS NOT NULL**
operátorral.

**A [GROUP BY](https://mariadb.com/kb/en/group-by/) és a HAVING záradék**

A **GROUP BY** utasítással csoportosítjuk az adatokat a megadott oszloplista szerint.
A csoportosítás azt jelenti, hogy a rekordokat egy adott mező értékei szerint
csoportokra bontjuk. Egy csoportba az adott mezőben azonos értékeket felvevő
rekordok kerülnek. A csoportokhoz tartozó rekordokra különböző műveleteket hajthatunk
végre, például alkalmazhatjuk az aggregáló függvényeket, vagy a csoportokra
vonatkozóan kiválasztó műveletet (**HAVING**) alkalmazhatunk.

Az SQL nyelv lehetőséget biztosít arra is, hogy a csoportosított adatokra vonatkozóan
feltételeket adhassunk meg. Ebben az esetben a feltételt nem a **WHERE**, hanem
a **HAVING** záradékban kell megadni. Ez a már csoportosított adatokon hajt végre
egy újabb szelekciót, belőlük választ ki a `<having_feltétel>` alapján újabb sorokat.

Fontos megjegyezni, hogy ha a lekérdezés **GROUP BY** utasítást tartalmaz, akkor a
**SELECT** utáni oszloplistában (`<select_kifejezés>`) csak ezen oszloplista eleme,
valamint összesítő függvény szerepelhet.

**Az [ORDER BY](https://mariadb.com/kb/en/order-by/) záradék**

Az SQL lehetőséget biztosít arra, hogy lekérdezéseink eredményét rendezetten jelenítsük
meg. Az **ORDER BY** kulcsszó után felsorolt oszloplista alapján rendezzük az eredménytábla
sorait. Ha több oszlopot soroltunk fel, akkor a rendezés először az első, majd a
második (és így tovább) oszlopok értékei alapján történik. A rendezési szempontként
megadott oszlopnak szerepelni kell a SELECT parancs után is (`<select_kifejezés>`).

Alapértelmezés szerint a rendezés a növekvő sorrend szerint történik (**ASC**). De
ha a **DESC** kulcsszót használjuk, akkor a megadott oszlopban a rendezés csökkenő
lesz.

## 9. tétel

### 9.1 Összesítő (aggregáló) függvények

A lekérdezés eredményeként előálló táblák egyes oszlopaiban lévő értékeken
végrehajthatunk összesítő műveleteket, amelyek egyetlen értéket adnak vissza.

Ha összesítő függvény segítségével számítunk összeget, átlagot, darabszámot vagy
más mennyiséget, de a számításnál a **NULL** értékeket tartalmazó rekordok nem számítanak
bele az eredménybe. Ha például a **COUNT** függvénnyel számoljuk meg a tábla sorainak
számát, ez a nem NULL értékű rekordok számát adja vissza. Ha a NULL értéket tartalmazókat
is be szeretnénk venni az eredménybe, a **COUNT** függvényt csillag (*) helyettesítő
karakterrel kell meghívni.

```sql

  SELECT COUNT(*) FROM <táblanév>;

```
Ha aritmetikai operátor ( +, -, *, /) is szerepel a **COUNT** kifejezésben és a
kifejezés mezőinek egyike **NULL** értéket tartalmaz, az egész kifejezés eredménye
**NULL** lesz.

Szintaxis
```sql

  <függvénynév> ( [DISTINCT] <oszlopnév> )

```
Ha **DISTINCT** szerepel, akkor az oszlopban szereplő azonos értékeket csak egyszer
kell figyelembe venni.

Az SQL szabvány az alábbi 5 aggregáló függvényt írja elő:
* **COUNT (számláló függvény)** – megadja a tábla sorainak számát.
* **SUM (összegző függvény)** – megadja a paraméterében szereplő oszlop adatainak
az összegét az összes sorra. Csak numerikus attribútumra alkalmazható.
* **AVG (átlagoló függvény)** – megadja a paraméterében szereplő oszlop adatainak
az átlagát az összes sorra. Csak numerikus attribútumra alkalmazható.
* **MIN (minimum-kiválasztó függvény)** – megadja a paraméterében szereplő oszlop
adatainak a minimumát az összes sorra.
* **MAX (maximum-kiválasztó függvény)** – megadja a paraméterében szereplő oszlop
adatainak a maximumát az összes sorra.

A MIN és MAX függvények argumentuma numerikus, dátum vagy karakteres is lehet
(olyan típusú, amire van rendezés).


### 9.2 [Alkérdések](https://mariadb.com/kb/en/subqueries-and-joins/) az SQL nyelvben

Az SQL támogatja azt a lehetőséget, hogy a `WHERE` vagy `HAVING` szelekciós feltételben
nemcsak létező, letárolt adatelemekre hivatkozzunk, hanem számított kifejezéseket
is alkalmazhassunk. A számítást egy másik SELECT utasítással tudjuk megadni, tehát
az egyik lekérdezés szelekciós feltételében hivatkozunk egy másik lekérdezés eredményére.
Ezt alkérdésnek vagy belső vagy beágyazott SELECT-nek is nevezzük, formailag megegyezik
a normál SELECT utasítással.

Az alkérdéseket mindig zárójelben kell megadni, hogy elemeik elkülönüljenek. A
zárójelek e mellett a műveletek végrehajtási sorrendjét is módosítják. Az egymásba
ágyazott lekérdezéseket az alaprendszer belülről kifelé haladva dolgozza fel, tehát
először a legbelső zárójelben lévő kifejezés értékelődik ki.

Az egyenlőség vizsgálat esetén a belső lekérdezés csak egy értéket adhat vissza.

## 10. tétel

### 10.1 Az SQL megszorításai

**Az aktív elem olyan programrész, amely bizonyos szituációban automatikusan végrehajtódik**.
Ez a szituáció lehet egy esemény bekövetkezése, mint például egy adott relációba
való beszúrás, vagy lehet az adatbázisnak olyan megváltozása, amikor egy logikai
értékű feltétel igazzá válik. Az aktív elemek speciális esete a megszorítás. **A
megszorítások olyan előírások, korlátozások, amelyekkel megadhatjuk az adatbázis
tartalmára vonatkozó kívánságainkat**. Ha ezeket az adatbázisrendszerrel egyszer,
egy helyen közöljük, az mindig gondoskodni fog betartásukról.

A megszorításokat az adatbázisrendszer minden olyan akció során ellenőrzi, amely
eredményeként az adatbázis tartalma úgy változhat, hogy az a megszorítást már nem
elégítené ki. A megszorítások megadásuktól kezdve érvényesülnek (nincs visszamenőleges
hatásuk).

A megszorítások a relációs adatbázisokban lehetnek
* **Kulcs megszorítások**
* **Integritási megszorítások**
* **Attribútumértékekre vonatkozó megszorítások**

A megszorítások szintaktikai elhelyezésük szerint lehetnek **oszlop vagy tábla szintűek**.
Az egy oszlopot érintő megszorításokat megadhatjuk közvetlenül az oszlop definíciója
után (vesszőt nem kell tenni közéjük), míg a több oszlopot érintő megszorításokat
(pl. összetett kulcsok) csak tábla szintű megszorításként írhatjuk elő (vesszőt
kell tenni közéjük), az oszlopok felsorolása után (pl. **CREATE TABLE** utasítás
esetén).

A megszorítások mindegyike a **CONSTRAINT** kulcsszóval kezdődik, amit egy adatbázis
szintjén egyedi, úgynevezett szimbolikus név követ. Szükség esetén ezzel a névvel
azonosítható a megszorítás. Ha a felhasználó nem ad meg nevet, a rendszer generál
egy azonosítót **SYS_Cn** formátumban. Ez hibajelzésekben jelenik meg, valamint
használhatjuk az ALTER TABLE utasításban is.

A **CONSTRAINT** kulcsszó és a név elhagyható, ha **CREATE TABLE** vagy **ALTER
TABLE** utasítás keretében kötünk ki oszlop-, vagy táblaszintű megszorításokat és
nem szeretnénk nevet adni nekik.

### 10.2 Domain-ek, attribútumokra, rekordokra vonatkozó megszorítások

**Domain-megszorítások**

A tartományok segítségével **a mezők általános megszorításait egy karbantartási helyre
lehet összegyűjteni**. Például több táblázat tartalmazhat e-mail cím oszlopokat,
amelyek mindegyikére ugyanazt a CHECK megszorítást igényli a cím szintaxisának
ellenőrzése. Az egyes táblák külön-külön történő beállítása helyett célszerű
ezt a megszorítást egy helyen megadni, majd azokban a táblákban, ahol szükséges,
adattípusként hivatkozni rá. Az önálló értéktartomány (domain) tulajdonképpen egy
**felhasználó által létrehozott adattípus (User-Defined Data Type, UDT)**, opcionális
megszorításokkal (az engedélyezett értékkészlet korlátozásaival), ami az egész
adatbázisra érvényes.

Az SQL szabvány régebbi változatai nem támogatták az oszlopok fentiek szerint
elkülönített definícióit, ezeket csak a táblák keretében lehetett létrehozni,
egyenként. **Több SQL-implementáció a mai napig sem támogatja (pl. MySQL, MariaDB)**.

Értéktartományt a **[CREATE DOMAIN](https://www.postgresql.org/docs/9.1/sql-createdomain.html)**
utasítás segítségével lehet létrehozni (**PostgreSQL**-ben). Az oszlopok tárolási
módját vissza kell vezetni bármely, már létező SQL adattípusra (CHAR(n), DATE stb.).
Az új oszloptípus örökli az alapadattípus jellemzőit, ezeket lehet egyéni megszorításokkal
bővíteni. A **DEFAULT** záradékkal megadhatunk egy alapértelmezett értéket is,
ami azon mezőkbe kerül majd, amelyek nem tartalmaznak saját értéket.

A létrehozott típusra az SQL alapvető adattípusaihoz hasonlóan hivatkozhatunk. Az
érintett adattáblák szerkezetének definiálásakor, illetve módosításakor az
oszlopdefiníciók egységessége így már biztosított.

Szintaxis
```sql

  CREATE DOMAIN <oszloptípus_neve> AS <sql_adattípus>
  [DEFAULT <alapértelmezett_érték>]
  CHECK (<kifejezés>);

     <oszloptípus_neve> ::= az új oszloptípus neve, amire az oszlopdefiníciókban
                            majd hivatkozni lehet
        <sql_adattípus> ::= létező SQL adattípus, amelyből az új típus származik
<alapértelmezett_érték> ::= az új oszloptípus alapértelmezett értéke
            <kifejezés> ::= az új adattípusra vonatkozó megszorítások

```
A tesztelt értékre a **VALUE** kulcsszóval lehet hivatkozni.

Példa
```sql

  /* Saját adattípus létrehozása */

  CREATE DOMAIN `fizu` AS UNSIGNED INT
  DEFAULT 200000
  CHECK (VALUE BETWEEN 200000 AND 500000);

  /* Saját adattípus alkalmazása */

  ALTER TABLE `Dolgozok` ALTER COLUMN `fizetes` fizu(6);

```
Értéktartomány módosítása **ALTER DOMAIN**, törlése **DROP DOMAIN** utasítással
lehetséges.

**Attribútumokra vonatkozó (oszlopszintű) megszorítások**

A CREATE TABLE utasításban valamely attribútum deklarációja után adhatók meg, az
adott attribútumra (oszlopra) vonatkoznak.

* **NOT NULL:** az oszlop mezőinek kitöltése **kötelező**, nem tartalmazhatnak NULL
értéket.

* **NULL:** az oszlop mezőinek kitöltése **nem kötelező**, tartalmazhatnak NULL
értéket.

* **DEFAULT:** alapértelmezett érték, mely akkor kerül az új sor adott oszlopába,
ha nem adunk meg a beszúrás során semmilyen értéket.

* **PRIMARY KEY:** a tábla elsődleges kulcsa lesz, megköveteli a kijelölt oszlopban
az értékek egyediségét. Oszlop-megszorításokban csak akkor tudunk elsődleges kulcsot
definiálni, ha az elsődleges kulcs csak egy oszlopból áll. Ilyen oszlop csak egy
lehet a táblában. Hatására mindig létrejön egy index állomány.

* **UNIQUE:** az adott oszlopban minden érték egyedi. Hatására index állomány jön létre

* **REFERENCES:** az adott oszlop idegen kulcs-hivatkozást tartalmaz a kapcsolótábla
kapcsoló oszlopára, mely csak elsődleges, vagy egyedi kulcs lehet. Az ilyen megszorítással
rendelkező oszlopok csak NULL (itt: *nincs kapcsolat*), vagy olyan értékeket vehetnek
fel, amilyen a kapcsolt tábla kapcsolt oszlopában is megtalálható, kivétel, ha az
oszlop **NOT NULL** megszorítással rendelkezik.

* **CHECK:** az oszlopra vonatkozó logikai kifejezést adhatunk meg, a feltételben
csak az oszlop szerepelhet. A beszúrás, módosítás csak akkor történik meg, ha a
kifejezés értéke igaz lesz.

**Táblaszintű megszorítások**

Az oszlopszintű megszorítások közül többet meg lehet adni táblaszinten is. Ezek
**mindig az egész táblára vonatkoznak, szerepelhet bennük a tábla egy vagy több
oszlopa**.

* **PRIMARY KEY (oszlop1, oszlop2,...oszlopN):** a több oszlopból álló elsődleges
kulcsokat tábla szintű megszorításban kell megadni.

* **UNIQUE (oszlop1, oszlop2,...oszlopN):** az adott oszlopokban lévő értékek
egyediek lesznek. Hatására index állomány(ok) jön(nek) létre.

* **FOREIGN KEY (oszlop1, oszlop2,...oszlopN):** az adott oszlopok idegen kulcs-hivatkozást
tartalmaznak a kapcsolótábla kapcsoló oszlopaira, melyekre elsődleges, vagy egyedi
kulcsot kell definiálni. Az oszlopok sorrendje számít.

**Rekordokra vonatkozó (soralapú) megszorítások**

A **CHECK** megszorításban nemcsak attribútum értékekre vonatkozó kikötéseket
adhatunk meg, hanem **sorokra vonatkozó megszorítást** is. Ilyenkor a **CHECK**
feltételt nem egy oszlop definíciójához fűzzük, hanem a táblát definiáló utasítás
végén adjuk meg.

A **CHECK** kulcsszó után tetszőleges feltételt (logikai kifejezést) adhatunk meg,
melyben csak az adott tábla oszlopai szerepelhetnek. Az erre vonatkozó szabályok
megegyeznek a **SELECT** parancsban használt **WHERE záradék** lehetséges feltételével.
**A feltétel ellenőrzése sor beszúrásakor, vagy az attribútum módosításakor történik**.
Egy rekord beszúrása, módosítása csak akkor történik meg, ha a kifejezés értéke
igaz. Ha az eredmény hamis lesz, akkor a feltételt megsértő sorra vonatkozó
beszúrás-, vagy módosításutasítást a rendszer visszautasítja.

A soralapú megszorítás gyakrabban kerül ellenőrzésre, mint az attribútumalapú.
Ugyanis a soralapú megszorítás esetén a feltétel a sor bármely megfelelő
attribútumértékének a megváltozásakor ellenőrzésre kerül, míg az attribútumalapúnál
csak az adott attribútum értékének megváltozásakor történik vizsgálat.

Egy tábla módosításakor a definiált kulcsfeltételek automatikusan ellenőrzésre
kerülnek. **PRIMARY KEY** és **UNIQUE** esetén ez azt jelenti, hogy a rendszer nem
enged olyan módosítást illetve olyan új sor felvételét, amely egy már meglévő kulccsal
ütközne.

**REFERENCES** (külső kulcs hivatkozás) esetén a következő idegenkulcs-megszorítások
megadásával szabályozhatjuk a rendszer viselkedését:
* **Alapértelmezés (ha nincs megadva külön megszorítás):** a hivatkozó táblában
nem megengedett olyan beszúrás és módosítás, amely a hivatkozott táblában nem létező
kulcs értékre hivatkozna, továbbá a hivatkozott táblában nem megengedett olyan
kulcs módosítása vagy sor törlése, amelyre a más tábla hivatkozik.
* **ON UPDATE CASCADE:** ha a hivatkozott tábla egy sorában változik a kulcs értéke,
akkor a rá való hivatkozások is megfelelően módosulnak (módosítás továbbgyűrűzése).
* **ON DELETE CASCADE:** Ha a hivatkozott táblában törlünk egy sort, akkor törlődnek
a rá hivatkozó sorok (törlés továbbgyűrűzése).
* **ON UPDATE SET NULL:** ha a hivatkozott tábla egy sorában változik a kulcs értéke,
akkor a rá való külső kulcs hivatkozások értéke NULL lesz.
* **ON DELETE SET NULL:** ha a hivatkozott táblából törlünk egy sort, akkor a rá
való külső kulcs hivatkozások értéke NULL lesz.


### 10.3 Általános vagy önálló megszorítások (assertions)

Az oszlop vagy tábla szintű megszorításokat a rendszer csak akkor ellenőrzi, ha
az oszlop vagy tábla, melyre a feltétel vonatkozik, beszúrás vagy módosítás hatására
változik meg. Ezért, **hogy a több táblát érintő feltétel minden esetben kiértékelődjön,
önálló megszorításként kell megadni**. Ezek az önálló feltételek elkülönülnek a
táblák definíciótól, és egy vagy több tábla összefüggéseit szabályozzák; az
adatbázissémához tartoznak a relációsémákhoz és nézetekhez hasonlóan. E feltételeket
a rendszer mindannyiszor megvizsgálja, valahányszor beszúrás/módosítás/törlés
történik az érintett táblák bármelyikében.

Szintaxis
```sql

  CREATE ASSERTION <megszorítás_elnevezése> CHECK (<feltétel>);

  <megszorítás_elnevezése> ::= ezzel a névvel azonosítható a megszorítás. Ennek
                               hiányában a rendszer generál egy azonosítót SYS_Cn
                               formátumban
                <feltétel> ::= tetszőleges feltétel megadható, az erre vonatkozó
                               szabályok megegyeznek a SELECT parancsban használt
                               WHERE záradék lehetséges feltétéivel

```

Az önálló megszorítás törlése
```sql

  DROP ASSERTION <megszorítás_elnevezése>;

```

### 10.4 Triggerek

Az aktív elemek másik speciális esete a trigger. **A trigger olyan eljárást definiál
mely automatikusan lefut, ha egy tábla módosul** (ideiglenes táblákhoz és nézetekhez
nem társítható trigger). A triggereket az **INSERT, UPDATE, DELETE parancsok végrehajtása
előtt, után vagy helyett (utóbbit nem minden SQL megvalósítás támogatja) hívja meg
a rendszer**. A trigger vagy engedélyezheti vagy elvetheti az adott táblán történt
módosításokat, naplózási feladatokat végezhet, járulékos módosításokat hajthat
végre az adatbázisban.

Egy táblához parancsonként csak egy trigger rendelhető hozzá, vagyis, **egy táblához
legfeljebb három trigger készíthető (INSERT, UPDATE, DELETE)**. Lehetőség van arra
is, hogy egy trigger ne csak egy parancsnál legyen aktiválva. Előfordulhat, hogy
például az INSERT és UPDATE parancsoknál történő ellenőrzések (szinte) megegyeznek:
ilyenkor nem szükséges két triggert írni, hiszen az ellenőrzést eggyel is meg lehet
oldani.

Szintaxis
```sql

  CREATE TRIGGER
    <trigger_neve> <trigger_idő> <trigger_esemény>
    ON <táblanév> [FOR EACH ROW]
    <trigger_törzse>;

     <trigger_neve> ::= a trigger elnevezése, amire majd lehet hivatkozni
      <trigger_idő> ::= { BEFORE | AFTER  | INSTEAD OF } - a művelet indításának
                        ideje (esemény előtt, után vagy helyett)
  <trigger_esemény> ::= { INSERT | UPDATE | DELETE } - a triggert kiváltó esemény
                        vesszővel elválasztva több esemény is megadható
         <táblanév> ::= ezen tábla aktualizálásakor lép működésbe a trigger
     [FOR EACH ROW] ::= opcionális, ha megadjuk, akkor a trigger a tábla minden
                        egyes sorára lefut, amelyet a triggert kiváltó esemény érint
                        (sor szintű trigger); egyébként egy esemény esetén csak
                        egyszer fut le a (utasítás szintű trigger)
   <trigger_törzse> ::= ide kerül az a kód, ami az esemény hatására, a beállított
                        időben le fog futni; egy vagy több SQL utasításból álló,
                        vagy valamely programozási nyelven írt blokk

```

A **SHOW TRIGGERS** utasítással listázhatók az adatbázisban beállított triggerek.
A **FROM <adatbázis_név>** záradék elhagyásával az összes adatbázis össze triggere
listázásra kerül.
```sql

  SHOW TRIGGERS
  [FROM <adatbázis_név>];

```

Triggerek törlése a **DROP TRIGGER** utasítással lehetséges.
```sql

  DROP TRIGGER [IF EXISTS] [<adatbázis_név>.]<trigger_neve>;

```


### Felhasznált (ajánlott) irodalom:

* Sallai András: [Adatbázis-kezelés](http://szit.hu/doku.php?id=oktatas:adatbazis-kezeles)
* dr. Katona Endre: [Adatbázisok](https://www.inf.u-szeged.hu/sites/default/files/db-ea1.pdf)
* dr. Kovács László: [Adatbáziskezelés - SQL](http://193.6.12.228/uigtk/uipz/hallgatoi/SQL.pdf)
* dr. Halassy Béla: [Az adatbázistervezés alapjai és titkai](http://mek.oszk.hu/11100/11123/11123.pdf)
* dr. Halassy Béla: [Adatmodellezés](http://mek.oszk.hu/11100/11144/11144.pdf)
* Demetrovics Katalin: [Adatbáziskezelés](http://www.zipernowsky.hu/~naszlaci/alapok+hardver/adatbazis/ab_alap_demetrovicsk.pdf)
* dr. Holovács József: [Adatbázis-kezelés](http://aries.ektf.hu/~holovacs/AB/)
* Szabó Bálint: [Adatbázis fejlesztés és üzemeltetés I.](https://mek.oszk.hu/14400/14432/pdf/14432.pdf)
* Szabó Bálint: [Adatbázis fejlesztés és üzemeltetés II.](http://mek.oszk.hu/14400/14433/pdf/14433.pdf)
* Kósa Márk - Pánovics János: [Fejezetek az adatbázisrendszerek elméletéből](https://gyires.inf.unideb.hu/KMITT/b01/index.html)
* Michael J. Hernandez: [Adatbázis-tervezés](https://www.animakonyv.hu/index.php?BODY=BookInfo&OP=details&ID=54734)
* Wikipédia: [SQL-szócikk](https://hu.wikipedia.org/wiki/SQL)
* Cser Lajos: [SQL alapok](http://cserlajos.hu/files/db2014-n/06-sql-alap.pdf)
* John L. Viescas, Michael J. Hernandez: [SQL-Iekérdezések földi halandóknak](http://dev.logisztika.bme.hu/logdb/irodalom/SQL.lekerdezesek.foldi.halandoknak.2009.eBOOk-digIT.pdf)
* [w3schools SQL Tutorial](https://www.w3schools.com/sql/default.asp)
* ELTE-Prognyelvek portál: [Az SQL lekérdezési nyelv](http://nyelvek.inf.elte.hu/leirasok/SQL/index.php)
* Wikipédia: [MySQL-szócikk](https://hu.wikipedia.org/wiki/MySQL)
* Sallai András: [MySQL jegyzet](https://szit.hu/doku.php?id=oktatas:adatb%C3%A1zis-kezel%C3%A9s:mysql:mysql_jegyzet)
* Andó Mihály: [SQL, MySQL oktatóprogram](http://sql.misi.eu/)
* [MySQL 8.0 Kézikönyv](https://dev.mysql.com/doc/refman/8.0/en/sql-statements.html)
* Wikipédia: [MariaDB-szócikk](https://hu.wikipedia.org/wiki/MariaDB)
* Sallai András: [MariaDB](http://szit.hu/doku.php?id=oktatas:adatbazis-kezeles:mariadb)
* [MariaDB dokumentáció](https://mariadb.com/kb/en/library/documentation/)
* [Mi a különbség a MariaDB és a MySQL között?](https://linuxadm.hu/cikk/Mi-a-kulonbseg-a-MariaDB-es-a-MySQL-kozott-)

[Kezdőlap](../README.md)
