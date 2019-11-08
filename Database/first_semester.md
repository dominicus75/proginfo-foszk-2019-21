# 2019/20 I. félév szóbeli tételek


## 1. tétel

*(Jegyzet<sup id="1">[[1]](#note1)</sup>: 1., 2., 2.1. fejezet, 5-9. oldal)*

### 1.1 Az adatbázis-kezelés alapfogalmai

**Adat:** tényeket, eseményeket rögzítő elemi, objektív (értelmezhető, nyers)
ismeret, adatbázisban tárolt érték.

**Adatfüggetlenség:**
* *fizikai:* a belső (fizikai) séma megváltoztatásának a képessége anélkül, hogy
meg kellene változtatni a koncepcionális (logikai) sémát. A fizikai adatfüggetlenség
a legtöbb adatbázisban és állománykörnyezetben jelen van; ekkor az adatok pontos
elhelyezkedése a lemezen, a háttértáron való tárolás mikéntje, a rekordok elhelyezése,
tömörítése, szétdarabolása és összeillesztése stb. rejtve vannak a felhasználók
elől.
* *logikai:* a koncepcionális (logikai) séma megváltoztatásának a képessége anélkül,
hogy meg kellene változtatni a külső sémákat vagy az alkalmazói programokat. Egy
adatbázis-kezelő rendszerben, amely támogatja a logikai adatfüggetlenséget, csak
a nézetdefiníciókat és a leképezéseket kell megváltoztatni. Miután a koncepcionális
séma keresztülment a logikai újraszervezésen, az alkalmazói programoknak, amelyek
a külső sémaelemekre hivatkoztak, ugyanúgy kell működniük, mint azelőtt.

**[Adatbázis](https://hu.wikipedia.org/wiki/Adatb%C3%A1zis):** véges számú
egyedelőfordulások, azok egyenként is véges számú tulajdonságértékének és
kapcsolatelőfordulásának az adatmodell szerint szervezett együttese. Másképp:
azonos minőségű (jellemzőjű), többnyire strukturált adatok összessége, amelyet
egy azok tárolására, lekérdezésére és szerkesztésére alkalmas szoftvereszköz kezel.
Célja adatok megbízható, hosszú távon tartós (perzisztens) tárolása, és viszonylag
gyors visszakereshetőségének biztosítása.

**Adatbázis séma:** az adatbázis szerkezete, amit tervezéskor, egyszeri alkalommal
hozunk létre. Különböző adatmodellek segítségével megadja, hogy az adatbázisban
milyen egyedhalmazok vannak, ezek milyen tulajdonsághalmazokkal és kapcsolatokkal
rendelkeznek. Tömören: *az adatbázist felépítő relációk sémáit és a köztük fennálló
kapcsolatokat tartalmazó leírás*.

**Egyed (entitás, entity):** egy a valós világban létező dolog, amit a tulajdonságai
(attribútumai) segítségével lehet leírni, azonosítani. Másképpen: *önálló lényeggel
bíró dolog, amelyről ismereteket közlünk*<sup id="3">[[3]](#note3)</sup>.

**Egyedtípus:** a valós világbeli egyed adatbázis-szintű absztrakciója, leképezése;
az ismeretekkel leírandó jelenségek absztrakt osztálya. Azon (általunk kiválasztott,
az adatbázis céljának megfelelő) tulajdonságtípusok összessége, amelyekkel az adott
dolgot az adatbázisban ábrázolni szeretnénk.
*Pl. Könyv(ISBN, Kiadó, Szerző, Cím)*.

**Egyedpéldány (vagy előfordulás):** egy elvont egyedtípus konkrét előfordulása.
Az egyedpéldány attribútumai egyedi értékeket vesznek fel, ez által válik
megkülönböztethetővé a többi (azonos típusú, de más értékű tulajdonságokkal
rendelkező) egyedpéldánytól.

**Egyedhalmaz:** azonos egyedtípusú egyedpéldányok (azonos táblában tárolt) halmaza.
Pl. a Könyv tábla tartalma.

**Információ:** értelmezett, a befogadó számára jelentéssel bíró adat, szubjektív
ismeret.

> „– Mennyi?<br>
> – Tíz.<br>
> – Mi tíz?<br>
> – Mi mennyi?!”

Az idézett viccben elhangzó párbeszéd szemléletesen világít rá az adat és az
információ közötti különbségre. A »tíz« egészen addig nem válhat tényleges információvá,
ameddig nem tudjuk, hogy konkrétan »mi tíz«. A »tíz« lehet valaminek a mennyisége,
mérete, kora, akármije, de amíg nem mondjuk meg, hogy milyen dolog milyen
tulajdonságát jelöli a kérdéses adat, addig nem hordoz számunkra információt.

Tömören: *„Az adat az, amit tárolunk, az információ pedig, amit kinyerünk. [...]
Az információ olyan adat, amely a feldolgozás révén értelmet nyer.”*<sup id="2">
[[2]](#note2)</sup>

**Kapcsolattípus:** az egyedtípusok közötti viszonyok absztrakt osztályai, melyek
leírják, hogy az egyes egyedtípusok milyen kapcsolatban lehetnek egymással. **Nem
összekeverendő a kapcsolat típusával (2. tétel, 3. pont)!**

**Kapcsolat előfordulás:** egy absztrakt kapcsolattípus konkrét előfordulása, két
egyedpéldány közötti tényleges kapcsolat.

**Rekord:** bejegyzés (sor), az adatbázis alapvető adategysége, a tábla által
ábrázolt entitás (egyedtípus) egy konkrét példányát írja le. Pontosan egy
értéket tartalmaz a tábla minden mezőjéből.

**Reláció (adattábla, tábla):** az adatok kétdimenziós táblázatban történő elrendezése
és tárolása a relációs adatmodellnek megfelelően.

**Relációséma:** a reláció neve és az attribútumok (tulajdonságtípusok) halmaza.
Például a Könyv reláció sémája a következő: *Könyv(ISBN, Kiadó, Szerző, Cím)*. Adott
adatbázishoz tartozó relációsémák összessége (és a köztük fennálló kapcsolatok leírása)
alkotja az adatbázissémát.

**Tulajdonság (attribútum):** a valós világban létező egyednek (entitásnak) az
adatmodellezés szempontjából lényeges jellemzője.

**Tulajdonságtípus:** az egyedeket leíró ismeretek (tulajdonságok) elvont osztálya,
másképpen fogalmazva: az adattábla (reláció) oszlopainak elnevezése, melynek
segítségével az adott oszlopban tárolt adatok értelmet nyernek, információvá válnak.
Adott egyedtípust leíró tulajdonságtípusok felsorolását a relációséma tartalmazza.
A már említett Könyv egyedtípust például az *(ISBN, Kiadó, Szerző, Cím)*
tulajdonságtípusokkal írjuk le.

**Tulajdonság előfordulás (vagy érték):** tulajdonságtípus konkrét előfordulása
egy adott egyedpéldányban (vagyis: az adott egyedpéldány konkrét tulajdonsága).
Maradva a könyv példánál: ha Kiadó felveszi az "Akadémiai Kiadó" értéket, akkor
ez a Kiadó tulajdonságtípus egy konkrét (adott könyvre jellemző) előfordulása.


### 1.2 Adatbázis-kezelő rendszer (DBMS)

Az **[adatbázis-kezelő rendszer (Database Management System, DBMS)](https://hu.wikipedia.org/wiki/Adatb%C3%A1zis-kezel%C5%91_rendszer)**
többfelhasználós, hálózatos környezetben, adatbázisokhoz való hozzáférést,
rendszeres és a felhasználói folyamatok zavartalan működést biztosító szoftveralkalmazás.

A **[relációs adatbázis-kezelő rendszer (RDBMS)](https://hu.wikipedia.org/wiki/Rel%C3%A1ci%C3%B3sadatb%C3%A1zis-kezel%C5%91_rendszer)**
olyan adatbázis-kezelő rendszer, amelynek logikai adatbázisa kizárólag a relációs
adatmodell elve alapján épül fel, illetve kérdezhető le.

### 1.3 Adattípusok

### 1.4 Adatmodellezés

Az **[Adatmodell](https://hu.wikipedia.org/wiki/Adatmodell)** az adatbázis
általános struktúrája, amely véges számú egyedtípusnak, azok egyenként is véges számú
tulajdonság-, és kapcsolattípusának szervezett együttese. A valóság objektumait
(egyedeit), ezek tulajdonságait és a köztük lévő kapcsolatokat, illetve a logikai
adatbázis szerkezeti leírását, nevezetesen azonos jellemzőjű információk logikai
modellezését és a rajtuk végezhető logikai műveletek meghatározását tartalmazza.


### 1.5 Adatmodellek típusai

### 1.6 Az E-K (E-R) modell alapelemei

## 2. tétel

*(Jegyzet: 2.1. fejezet, 10-14. oldal)*

### 2.1 Az Egyed-Kapcsolat (Entity-Relation) modell

### 2.2 Egyedek, kapcsolatok, attribútumok

### 2.3 Kapcsolatok osztályozása (a kapcsolatok típusai)

### 2.4 Speciális kapcsolat típusok

## 3. tétel

*(Jegyzet: 3.1., 3.2., 3.3. fejezet, 15-20. oldal)*

### 3.1 A relációs adatmodell

### 3.2 Reláció fogalma és tulajdonságai

### 3.3 Relációséma

### 3.4 Kulcsok, indexek és tulajdonságaik

## 4. tétel

*(Jegyzet: 3.4. fejezet, 21-27. oldal)*

### 4.1 Relációs adatbázisséma elkészítése E-K diagram alapján

### 4.2 Egyedek, gyenge egyedek, kapcsolatok, specializáló kapcsolatok, összetett és többértékű attribútumok leképezése



## 5. tétel

*(Jegyzet: 4.1., 4.2., 4.4. fejezet, 28-30. és 33. oldal)*

### 5.1 Relációalgebra fogalma

### 5.2 Halmazműveletek

### 5.3 Multihalmazok

## 6. tétel

*(Jegyzet: 4.3. fejezet, 30-33. oldal)*

### 6.1 Relációalgebra fogalma

### 6.2 Kombinációs műveletek

### 6.3 Az összekapcsolás lehetőségei

## 7. tétel

*(Jegyzet: 5.1., 5.2. fejezet, 34-38. oldal)*

### 7.1 Relációs adatbázis normalizálása – elméleti alapok

### 7.2 Redundancia, anomáliák redundáns adattárolás esetén

### 7.3 Funkcionális függőség fogalma

### 7.4 Attribútumhalmaz lezártja függéshalmaz szerint

## 8. tétel

*(Jegyzet: 5.3. fejezet, 38-40. oldal)*

### 8.1 Relációs adatbázis normalizálása – elméleti alapok

### 8.2 Tábla dekompozíciója

### 8.3 Hűséges ill. függőségőrző felbontás

### 8.4 Heath tétele


## 9. tétel

*(Jegyzet: 5.4. fejezet, 41-45. oldal)*

### 9.1 Relációs adatbázis normalizálása – eljárások

### 9.2 Az 1NF, 2NF és 3NF követelményei

### 9.3 Teljes függés fogalma

### 9.4 Harmadik normálformára alakítás

### 9.5 A Boyce-Codd normálforma fogalma


## 10. tétel

*(Jegyzet: 6.1., 6.2., 6.3. fejezet, 48-53. oldal)*

### 10.1 Az SQL nyelv általános jellemzői

### 10.2 Az SQL nyelv szintaxisa, speciális logikai kifejezései

### 10.3 Adatdefiníciós utasítások (DDL)

### 10.4 Relációsémák, indexek

### 10.5 Hivatkozástípusok relációsémák definiálásakor

## 11. tétel

*(Jegyzet: 6.4., 6.7. fejezet, 53-54., 61-62. oldal)*

### 11.1 Az SQL nyelv általános jellemzői

### 11.2 Nézettábla kialakítása és szerepe

### 11.3 Adatmanipulációs utasítások (DML), adattábla aktualizálása


## 12. tétel

*(Jegyzet: 6.5., 6-6. fejezet, 54-60. oldal)*

### 12.1 Az SQL nyelv általános jellemzői

### 12.2 Lekérdezés relációs adattáblákból, a relációalgebrai műveletek megvalósítása

### 12.3 Összesítő függvények alkalmazása

### 12.4 Alkérdések az SQL nyelvben


## 13. tétel

*(Jegyzet: 7.1., 7.2., 7.3., 7.4., 7.5. fejezet, 63-66. oldal)*

### 13.1 Az SQL megszorításai, triggerei

### 13.2 Domain-ek, attribútumokra, rekordokra vonatkozó megszorítások

### 13.3 Önálló megszorítások

### 13.4 Triggerek

## 14. tétel

*(Előadás + összeállított források)*

### Adatbázis-kapcsolati rétegek feladata, típusai (ODBC, OLE DB, DAO)


### Jegyzetek:
* <span id="note1">[[1]](#1)</span> Jegyzet alatt dr. Katona Endre: [Adatbázisok](https://www.inf.u-szeged.hu/sites/default/files/db-ea1.pdf) című
könyve értendő.
* <span id="note2">[[2]](#2)</span> Michael J. Hernandez: Adatbázis-tervezés, 31. o.
* <span id="note3">[[3]](#3)</span> dr. Halassy Béla: [Az adatbázistervezés alapjai és titkai](http://mek.oszk.hu/11100/11123/11123.pdf), 33. o.


### Felhasznált (ajánlott) irodalom:
* Sallai András: [Adatbázis-kezelés](http://szit.hu/doku.php?id=oktatas:adatbazis-kezeles)
* dr. Katona Endre: [Adatbázisok](https://www.inf.u-szeged.hu/sites/default/files/db-ea1.pdf)
* dr. Kovács László: [Adatbáziskezelés - SQL](http://193.6.12.228/uigtk/uipz/hallgatoi/SQL.pdf)
* dr. Halassy Béla: [Az adatbázistervezés alapjai és titkai](http://mek.oszk.hu/11100/11123/11123.pdf)
* Demetrovics Katalin: [Adatbáziskezelés](http://www.zipernowsky.hu/~naszlaci/alapok+hardver/adatbazis/ab_alap_demetrovicsk.pdf)
* Szabó Bálint: [Adatbázis fejlesztés és üzemeltetés II.](http://mek.oszk.hu/14400/14433/pdf/14433.pdf)
* Kósa Márk - Pánovics János: [Fejezetek az adatbázisrendszerek elméletéből](https://gyires.inf.unideb.hu/KMITT/b01/index.html)
* Michael J. Hernandez: [Adatbázis-tervezés](https://www.animakonyv.hu/index.php?BODY=BookInfo&OP=details&ID=54734)
* Wikipédia: [SQL-szócikk](https://hu.wikipedia.org/wiki/SQL)
* Cser Lajos: [SQL alapok](http://cserlajos.hu/files/db2014-n/06-sql-alap.pdf)
* John L. Viescas, Michael J. Hernandez: [SQL-Iekérdezések földi halandóknak](http://dev.logisztika.bme.hu/logdb/irodalom/SQL.lekerdezesek.foldi.halandoknak.2009.eBOOk-digIT.pdf)
* [w3schools SQL Tutorial](https://www.w3schools.com/sql/default.asp)
* Wikipédia: [MySQL-szócikk](https://hu.wikipedia.org/wiki/MySQL)
* Sallai András: [MySQL jegyzet](https://szit.hu/doku.php?id=oktatas:adatb%C3%A1zis-kezel%C3%A9s:mysql:mysql_jegyzet)
* Andó Mihály: [SQL, MySQL oktatóprogram](http://sql.misi.eu/)
* [MySQL 8.0 Kézikönyv](https://dev.mysql.com/doc/refman/8.0/en/)
* Wikipédia: [MariaDB-szócikk](https://hu.wikipedia.org/wiki/MariaDB)
* Sallai András: [MariaDB](http://szit.hu/doku.php?id=oktatas:adatbazis-kezeles:mariadb)
* [MariaDB dokumentáció](https://mariadb.com/kb/en/library/documentation/)
* [Mi a különbség a MariaDB és a MySQL között?](https://linuxadm.hu/cikk/Mi-a-kulonbseg-a-MariaDB-es-a-MySQL-kozott-)
