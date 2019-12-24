[Kezdőlap](README.md)

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

**Értéktartomány [domain]:** az adott jelentésű tulajdonság általánosan felvehető
értékeinek a halmaza.

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
Például a Könyv reláció sémája a következő: *Könyv(ISBN, Kiadó, Szerző, Cím)*.
Adott adatbázishoz tartozó relációsémák összessége (és a köztük fennálló
kapcsolatok leírása) alkotja az adatbázissémát.

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
rendszeres és a felhasználói folyamatok zavartalan működést biztosító szoftveralkalmazás,
amely a különféle felhasználói folyamatok és a fizikai adatbázis – tipikusan egy
fájlrendszer vagy más állománykezelő – között teremt kapcsolatot.

A DBMS főbb feladatai:
* Támogatja új adatbázisok létrehozását, azok struktúrájának, tárolási módjának
  kialakítását
* Megvalósítja az adatbázisban tárolt adatok kezelését, karbantartását
* Lehetővé teszi a tárolt adatok feldolgozását, lekérdezését
* Lehetővé teszi az adatbázisok megosztását több felhasználó között
* Garantálja az adatok biztonságát, konzisztenciáját, a hozzáférések szabályozását,
vagyis hogy a felhasználói műveleteket csak arra jogosult személyek végezhessék,
és ezek a műveletek ne veszélyeztessék az adatok integritását

A **[relációs adatbázis-kezelő rendszer (RDBMS)](https://hu.wikipedia.org/wiki/Rel%C3%A1ci%C3%B3sadatb%C3%A1zis-kezel%C5%91_rendszer)**
olyan adatbázis-kezelő rendszer, amelynek logikai adatbázisa kizárólag a relációs
adatmodell elve alapján épül fel, illetve kérdezhető le.

### 1.3 Adattípusok

Az adattípus meghatározza az adat értékhalmazát (a típus példányai által felvehető
értéktartományt), a vele végezhető műveleteket és a számítógépes ábrázolás módját,
vagyis a tárolására használt memóriaterület bitjeinek darabszámát és azok
értelmezését.

Az adattípusokat értékhalmazuk alapján két csoportba soroljuk.

* Egyszerű (elemi, atomi) adattípusok, melyek szerkezetileg nem bonthatók tovább
  * szám (egész [int] vagy tört[float, double])
  * karakter
  * logikai (bool)
  * dátum (DATE, TIME, DATETIME)

* Összetett adattípusok, melyeket elemi típusokból lehet képezni, itt az értékhalmaz
  mellett a szerkezet is lényeges
  * halmaz: azonos típusú elemek halmaza, minden elem különböző, nincs sorrendiség
  * lista: azonos típusú elemek rendezett sorozata
  * struktúra: különféle típusú elemek rendezett sorozata
  * fentiek kombinációi

* NULL, definiálatlan adat (ami nem azonos a 0 értékkel!)


### 1.4 Adatmodellezés

*„A modellezés a közös, lényeges és tartós jegyek kiemelését, absztrakcióját
jelenti. [...] Az adatmodell véges számú egyedtípusnak illetve azok egyenként is
véges számú tulajdonság- és kapcsolattípusának a szervezett együttese. [...] Az
adatbázis tartalma strukturálisan az adatmodell felépítésének felel meg. Tehát a
modell egyed-, tulajdonság- és kapcsolattípusai szerint rendezzük el az előfordulásokat.
Azonban az adatmodell nem pusztán struktúra, hanem a típusok és az azokra vonatkozó
korlátok szervezett együttese.”*<sup id="4">[[4]](#note4)</sup>

Az **[Adatmodell](https://hu.wikipedia.org/wiki/Adatmodell)** az adatbázis
általános struktúrája. A valóság objektumait (egyedeit), ezek tulajdonságait és
a köztük lévő kapcsolatokat, illetve a logikai adatbázis szerkezeti leírását,
nevezetesen azonos jellemzőjű információk logikai modellezését és a rajtuk
végezhető logikai műveletek meghatározását tartalmazza. Kizárólag az adatbázis
logikai kereteit határozza meg, nem foglalkozik azzal, hogy az adatokat fizikailag
hogyan kell tárolni, módosítani, illetve betölteni a memóriába.


### 1.5 Adatmodellek típusai

**[Hierarchikus adatmodell](http://centroszet.hu/tananyag/adatbazis/21_hierarchikus_modell.html):**
 alapelve az, hogy az egyedeket a köztük lévő kapcsolat alapján fastruktúra-szerű
hierarchiába rendezi, a számítógép könyvtárszerkezetéhez hasonlóan (mely a
hierarchikus modell legismertebb, napjainkban is használt alkalmazása). A feldolgozás
fabejáró és egyéb fastruktúra kezelő algoritmusok segítségével történik.

A hierarchikus modell kizárólag egy-egy (1:1) és egy-sok (1:N) jellegű kapcsolatok
megvalósítására alkalmas. A kapcsolat alapján a két egyedtípus között alá-fölé rendelő
viszony (szülő-gyermek kapcsolat) jön létre, melyben minden gyermek (leszármazott)
egyedtípusnak csak egyetlen őse lehet, viszont minden ős egyedtípushoz rendelhető
több leszármazott. A hierarchikus modell természetéből adódóan nem ábrázolhatók
benne sok-sok (n:m) típusú kapcsolatok. További hátránya, hogy az adatok elérése
csak egyféle útvonalon lehetséges, a tárolt hierarchiának megfelelő sorrendben.

A hierarchikus modell az 1960-s évek végén alakult ki és az 1970-es évek végéig
használták, mára teljesen kiszorította a relációs modell, napjainkban már csak
történeti jelentősége van.

**[Hálós adatmodell](https://hu.wikipedia.org/wiki/H%C3%A1l%C3%B3s_adatmodell):**
tekinthető a hierarchikus modell kiterjesztésének. A különbség az, hogy míg a
hierarchikus modell gráfja csak fa lehet, a hálósnál tetszőleges gráf előfordulhat.
Ez azt jelenti, hogy egy egyedtípusnak több őse is lehet. A hálós adatmodellben
a sok-sok (N:M) kapcsolatok is kezelhetők, úgy hogy azokat két egy-sok (1:N)
kapcsolatra bontják fel.

A rekordok pointerekkel (mutatókkal) kapcsolódnak egymáshoz, ezek ciklikusan
körbefutnak egy összetartozó rekordcsoporton, amelyet setnek neveznek. A hierarchikus
modellhez hasonlóan az adatbázisba fixen beépített kapcsolatok következtében
csak a tárolt kapcsolatok segítségével bejárható adat-visszakeresések oldhatók
meg hatékonyan, viszont szerkezetük merev, módosításuk nehézkes.

A hálós adatmodellt 1971-ben az adatrendszer nyelvek konferenciáján (CODASYL)
definiálták, mára teljesen kiszorította a relációs modell, napjainkban már csak
történeti jelentősége van.

**[Relációs adatmodell](https://hu.wikipedia.org/wiki/Rel%C3%A1ci%C3%B3s_adatmodell):**
az egyik legáttekinthetőbb és a 80-as évektől kezdve a legelterjedtebb adatmodell.
Kidolgozása [Edgar F. Codd](https://hu.wikipedia.org/wiki/Edgar_F._Codd), az IBM
kutatója nevéhez fűződik. Alapjait 1970-ben megjelent *[„A Relational Model Data Large
Shared Data Banks”](https://www.seas.upenn.edu/~zives/03f/cis550/codd.pdf)* című
munkájában fektette le. Codd adatmodellje a nevét a relációs algebráról kapta,
amely az adatmodell elvi alapjául szolgált, így legfontosabb eleme a matematikai [reláció](https://hu.wikipedia.org/wiki/Rel%C3%A1ci%C3%B3) fogalma. A relációs
adatbázis-kezelő rendszerek legfontosabb tulajdonságait, adottságait és
szükségszerűségeit [Codd 12 szabálya - ami valójában 13...](https://hu.wikipedia.org/wiki/Rel%C3%A1ci%C3%B3sadatb%C3%A1zis-kezel%C5%91_rendszer#Codd_szab%C3%A1lyai) foglalja össze.

A relációs modellben az adatokat táblázatok soraiban képezzük le. A legfontosabb
eltérés az előzőekben bemutatott két modellhez képest az, hogy itt nincsenek előre
definiált kapcsolatok az egyes adategységek között, hanem a kapcsolatok
létrehozásához szükséges adatokat tároljuk többszörösen.

Előnyei:
* A relációs adatszerkezet egyszerűen értelmezhető a felhasználók és az alkalmazás
  készítők számára is
* A logikai adatmodell relációi egy relációs adatbázis-kezelő rendszerbe módosítások
  nélkül átvihetők.
* A relációs modellben az adatbázis tervezés a normál formák bevezetésével egzakt
  módon elvégezhető

**Objektumorientált modell:** az objektumorientált programozási nyelvek
eszközrendszerével definiálja az adatbázis struktúráját, összetett, komplex
adattípusok megvalósítását is igényli. Leíró nyelve az Object Definition Language
(ODL), lekérdező nyelve az OQL. Az objektumorientált modellre épülő adatbázis-kezelő
rendszereket OODBMS-nek nevezzük (Object Oriented DBMS). Hatékonyságukban jelenleg
még alulmaradnak a relációs adatbázisokkal szemben.

**Objektum-relációs modell:** a relációs modell bővítése objektumorientált
lehetőségekkel (ISO 9075:2008). A relációs és az objektum orientált megközelítést
egyesítő megoldások az objektum relációs adatbázis-kezelő rendszerek (ORDBMS).

### 1.6 Az E-K (E-R) modell alapelemei

A valós világ jelenségeit egyedekkel, tulajdonságokkal és kapcsolatokkal leíró
modellt egyed-kapcsolat modellnek, az ezt ábrázoló diagramot egyed-kapcsolat
diagramnak nevezik. Rövidítve az E-K modell és E-K diagram, illetve az angol
entity-relationship model elnevezés alapján az E-R modell és az E-R diagram
elnevezések használatosak.

![Imgur](https://i.imgur.com/Dlbp7CI.jpg)

**Egyed (entitás, entity):** egy a valós világban létező dolog, amit a tulajdonságai
(attribútumai) segítségével lehet leírni, azonosítani. Másképpen: *önálló lényeggel
bíró dolog, amelyről ismereteket közlünk*<sup id="3">[[3]](#note3)</sup>. Az E-K
diagramban téglalappal jelöljük, amelybe beírjuk a nevét.

**Gyenge egyed:** olyan egyed, amelynek attribútumhalmazából nem tudunk kijelölni
kulcsot ezért kapcsolatai és nem a tulajdonságai határozzák meg. Dupla-vonalas
téglalappal jelöljük.

**Kapcsolat:** két vagy több egyed között határoz meg relációt. Rekurzív kapcsolat
esetén az egyed önmagával van relációban. Egy egyedtípus teljesen részt vesz egy
kapcsolatban, ha minden egyedpéldány kapcsolatban áll valamely másik egyeddel.
Az E-K diagramban rombusszal jelöljük amelybe beleírjuk a kapcsolat nevét.

**Kulcs:** azt a legszűkebb attribútumhalmazt, amely egyértelműen azonosítja az
egyedet kulcsnak nevezzük. A kulcsban szereplő attribútumok nevét aláhúzással
jelöljük. Egy kulcs lehet:
* egyszerű (egyetlen attribútumból álló)
* összetett (több attribútumból álló).

**Külső (vagy idegen) kulcs:** olyan kulcs, ami egy másik séma elsődleges kulcsára
hivatkozik, ezzel összeköti a két sémát.

**Meghatározó kapcsolat:** gyenge egyedet meghatározó kapcsolat. A meghatározó
kapcsolat jele a dupla-vonalas rombusz.

**Specializáló kapcsolat:** olyan kapcsolat, amely hierarchiát jelöl az egyedek
között. A specializáló kapcsolatot háromszöggel jelöljük, amelynek felső csúcsa
a főtípus felé mutat. Mivel a specializáló kapcsolat leszármaztatást jelöl, ezért
a származtatott egyedek öröklik, a főegyed (vagy főtípus) tulajdonságait.

![Imgur](https://i.imgur.com/Jv8zwTB.jpg)

**Többértékű attribútum:** olyan attribútum, amely egyidejűleg több értékkel
rendelkezik. Dupla-vonalas ellipszissel jelöljük.

**Tulajdonság (attribútum):** a valós világban létező egyednek (entitásnak) az
adatmodellezés szempontjából lényeges jellemzője. Az attribútumokat úgy célszerű
megválasztani, hogy azok egyértelműen meghatározzák az egyedet. Minden egyed kell,
hogy rendelkezzen legalább egy attribútummal. Kapcsolatok is rendelkezhetnek
attribútummal. Az E-K diagramban ellipszissel jelöljük, amelybe  beleírjuk a nevét.

## 2. tétel

*(Jegyzet: 2.1. fejezet, 10-14. oldal)*

### 2.1 Az Egyed-Kapcsolat (Entity-Relation) modell

A valós világ jelenségeit egyedekkel, tulajdonságokkal és kapcsolatokkal leíró
modellt egyed-kapcsolat modellnek, az ezt ábrázoló diagramot egyed-kapcsolat
diagramnak nevezik. Rövidítve az E-K modell és E-K diagram, illetve az angol
entity-relationship model elnevezés alapján az E-R modell és az E-R diagram
elnevezések használatosak.

Az adatbázis logikai modelljének elkészítéséhez az alábbi szempontokat kell
figyelembe venni:

* Miről szeretnénk eltárolni adatokat?
* Milyen adatokat szeretnénk tárolni?
* Hogyan viszonyulnak egymáshoz a tárolandó az adatok?

A fenti kérdésekre adjuk meg a választ az egyed-kapcsolat diagram jelölésrendszere
segítségével. Ez egy grafikus leíró eszköz, diagram segítségével szemléletesen
adja meg az adatbázis struktúráját. Az adatbázis implementálásához a diagramot
transzformálni kell valamilyen adatmodellre, ill. annak megfelelő nyelvi
leírásra (pl. SQL).

![Imgur](https://i.imgur.com/Dlbp7CI.jpg)

E-K Diagram készítéséhez egy szabad szoftver: [Dia](http://dia-installer.de/), ha
a [Libreoffice Draw](https://hu.libreoffice.org/termekbemutato/draw/) nem elég. A
Linux disztribúciók tárolóiban megtalálható, Windowshoz a linkről letölthető
(mindkettő tud magyarul is).

### 2.2 Egyedek, kapcsolatok, attribútumok

**Egyed (entitás, entity):** egy a valós világban létező dolog, amit a tulajdonságai
(attribútumai) segítségével lehet leírni, azonosítani. Másképpen: *önálló lényeggel
bíró dolog, amelyről ismereteket közlünk*<sup id="3">[[3]](#note3)</sup>. Az E-K
diagramban téglalappal jelöljük, amelybe beírjuk a nevét.

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

**Értéktartomány [domain]:** az adott jelentésű tulajdonság általánosan felvehető
értékeinek a halmaza.

**Gyenge egyed:** olyan egyed, amelynek attribútumhalmazából nem tudunk kijelölni
kulcsot ezért kapcsolatai és nem a tulajdonságai határozzák meg. Dupla-vonalas
téglalappal jelöljük.

**Kapcsolat:** két vagy több egyed között határoz meg relációt. Rekurzív kapcsolat
esetén az egyed önmagával van relációban. Az E-K diagramban rombusszal jelöljük
amelybe beleírjuk a kapcsolat nevét.

**Kapcsolattípus:** az egyedtípusok közötti viszonyok absztrakt osztályai, melyek
leírják, hogy az egyes egyedtípusok milyen kapcsolatban lehetnek egymással. **Nem
összekeverendő a kapcsolat típusával (2. tétel, 3. pont)!**

**Kapcsolat előfordulás:** egy absztrakt kapcsolattípus konkrét előfordulása, két
egyedpéldány közötti tényleges kapcsolat.

**Kulcs:** azt a legszűkebb attribútumhalmazt, amely egyértelműen azonosítja az
egyedet kulcsnak nevezzük. A kulcsban szereplő attribútumok nevét aláhúzással
jelöljük. Egy kulcs lehet:
* egyszerű (egyetlen attribútumból álló)
* összetett (több attribútumból álló).

**Külső (vagy idegen) kulcs:** olyan kulcs, ami egy másik séma elsődleges kulcsára
hivatkozik, ezzel összeköti a két sémát.

**Meghatározó kapcsolat:** gyenge egyedet meghatározó kapcsolat. A meghatározó
kapcsolat jele a dupla-vonalas rombusz.

**Specializáló kapcsolat:** olyan kapcsolat, amely hierarchiát jelöl az egyedek
között. A specializáló kapcsolatot háromszöggel jelöljük, amelynek felső csúcsa
a főtípus felé mutat. Mivel a specializáló kapcsolat leszármaztatást jelöl, ezért
a származtatott egyedek öröklik, a főegyed (vagy főtípus) tulajdonságait.

![Imgur](https://i.imgur.com/Jv8zwTB.jpg)

**Többértékű attribútum:** olyan attribútum, amely egyidejűleg több értékkel
rendelkezik. Dupla-vonalas ellipszissel jelöljük.

**Tulajdonság (attribútum):** a valós világban létező egyednek (entitásnak) az
adatmodellezés szempontjából lényeges jellemzője. Az attribútumokat úgy célszerű
megválasztani, hogy azok egyértelműen meghatározzák az egyedet. Minden egyed kell,
hogy rendelkezzen legalább egy attribútummal. Kapcsolatok is rendelkezhetnek
attribútummal. Az E-K diagramban ellipszissel jelöljük, amelybe  beleírjuk a nevét.

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

### 2.3 Kapcsolatok osztályozása (a kapcsolatok típusai)

A kapcsolattípusok általában rendelkeznek bizonyos megszorításokkal, amelyek
korlátozzák azokat a lehetséges egyedkombinációkat, amelyek részt vehetnek egy
kapcsolathalmazban. A kapcsolatokra vonatkozó megszorításoknak két fő típusát
különböztetjük meg: számosság és részvétel. Ezeket együtt a kapcsolattípusok
strukturális megszorításainak is szokás nevezni.

Egy **kapcsolattípus foka** a kapcsolatban részt vevő egyedtípusok száma. Egy kapcsolat
így lehet **két egyedtípus közötti (bináris vagy másodfokú) vagy sokágú (kettőnél több
egyedtípus közötti, vagy n-ed fokú)** kapcsolat. Utóbbi elég ritkán fordul elő és
szükség esetén visszavezethető több bináris kapcsolatra, vagy helyettesíthető
gyenge entitással.

**A bináris kapcsolatok számossága**

A bináris (másodfokú) kapcsolatok számossága meghatározza azon kapcsolat-előfordulások
maximális számát, amelyekben egy egyed részt vehet. A bináris kapcsolattípusok
lehetséges számosságai:

* 1:1 (egy az egyhez) kapcsolat esetén minden egyes egyedhez pontosan egy másik
egyed tartozik. Ennek jelölésmódja az, hogy a kapcsolatot úgy kötjük az egyedekhez,
hogy minden egyed felé mutat nyíl.

* 1:N (egy a sokhoz) kapcsolat esetén az egyik egyedhez több másik egyedet tudunk
társítani, de a másik csoport minden egyes példányához pontosan egyet társítunk.
A diagramban a nyilat úgy rajzoljuk, hogy az „1-es reláció felé” mutasson.

* N:M (sok a sokhoz) kapcsolat esetén mindkét típusú egyedhez tetszőleges számú
másik típusú egyed tartozhat. N:M típusú és sokágú kapcsolat mindig helyettesíthető
gyenge entitással és több bináris kapcsolattal.

A kapcsolat típusa lényeges az E-K modell szempontjából, ezért azt az E-K diagramon
is jelölni szokták (nyilakkal).

![Imgur](https://i.imgur.com/xiw6XLQ.jpg)

**Részvételi megszorítások**

Egy egyedtípus teljesen részt vesz egy kapcsolatban, ha minden egyedpéldány
kapcsolatban áll valamely másik egyeddel. Ezt egy olyan dupla vonallal jelöljük,
amely a részt vevő egyedtípust köti össze a kapcsolattal. A teljes részvétel
azonban általában nem teljesül.

A részvételi megszorítás meghatározza azon kapcsolat-előfordulások minimális és
maximális számát, amelyekben az egyes egyedek részt vehetnek, ezért számossági
megszorításnak, vagy **kardinalitás**nak nevezzük, amely azt mutatja meg,
hogy az adott egyedtípusból hány példány vehet és hány példány vesz kötelezően részt
a kapcsolatban.

**Minimum kardinalitás:** minimális példányszám az egyedből, amelynek részt kell
vennie a kapcsolatban.

**Maximum kardinalitás:** az egyedpéldányok maximális száma, ami egy adott egyedhez
kapcsolódhat a kapcsolatban.

Az **ordinalitás** azt jelzi, hogy egy egyedek közti kapcsolat kötelező vagy
opcionális.

Az E-K diagramban a kapcsolatot jelképező vonal közepe felé a minimális,
széle felé a maximális részvételt jelöljük mindkét oldalon. A kör nulla kardinálist
jelöl, a függőleges vonal 1-et, a varjúláb pedig sokat.

![Imgur](https://i.imgur.com/VqJoSEe.jpg)

### 2.4 Speciális kapcsolat típusok

Ha valamely általános egyednek bizonyos altípusait külön szeretnénk modellezni,
akkor a főtípus és az altípusok viszonyát specializáló kapcsolattal írhatjuk le.
Mivel a specializáló kapcsolat leszármaztatást jelöl, ezért a származtatott egyedek
öröklik, a főegyed (vagy főtípus) tulajdonságait (objektumorientált stílusú
reprezentálás), de emellett saját attribútumokkal is rendelkezhetnek.

![Imgur](https://i.imgur.com/Jv8zwTB.jpg)

A specializáló kapcsolat az egyedek többszörös előfordulását eredményezi. Ha ugyanis
egyedhalmazokat képzelünk a főtípus és altípusok helyére, akkor egy egyedpéldány több
egyedhalmazban is szerepel. A specializáló kapcsolat lényegében 1:1 kapcsolatot jelent egy
főtípus és egy altípus között, de sajátos módon nem különböző egyedeket, hanem ugyanazon
egyed két előfordulását kapcsolja össze.

## 3. tétel

*(Jegyzet: 3.1., 3.2., 3.3. fejezet, 15-20. oldal)*

### 3.1 A relációs adatmodell

Az egyik legáttekinthetőbb és a 80-as évektől kezdve a legelterjedtebb adatmodell.
Kidolgozása [Edgar F. Codd](https://hu.wikipedia.org/wiki/Edgar_F._Codd), az IBM
kutatója nevéhez fűződik. Alapjait 1970-ben megjelent *[„A Relational Model Data Large
Shared Data Banks”](https://www.seas.upenn.edu/~zives/03f/cis550/codd.pdf)* című
munkájában fektette le. Codd adatmodellje a nevét a relációs algebráról kapta,
amely az adatmodell elvi alapjául szolgált, így legfontosabb eleme a matematikai [reláció](https://hu.wikipedia.org/wiki/Rel%C3%A1ci%C3%B3) fogalma. A relációs
adatbázis-kezelő rendszerek legfontosabb tulajdonságait, adottságait és
szükségszerűségeit [Codd 12 szabálya](https://hu.wikipedia.org/wiki/Rel%C3%A1ci%C3%B3sadatb%C3%A1zis-kezel%C5%91_rendszer#Codd_szab%C3%A1lyai) foglalja össze.

A relációs modellben az adatokat táblázatok soraiban képezzük le. A legfontosabb
eltérés az előzőekben bemutatott két modellhez képest az, hogy itt nincsenek előre
definiált kapcsolatok az egyes adategységek között, hanem a kapcsolatok
létrehozásához szükséges adatokat tároljuk többszörösen.

Előnyei:
* A relációs adatszerkezet egyszerűen értelmezhető a felhasználók és az alkalmazás
  készítők számára is
* A logikai adatmodell relációi egy relációs adatbázis-kezelő rendszerbe módosítások
  nélkül átvihetők.
* A relációs modellben az adatbázis tervezés a normál formák bevezetésével egzakt
  módon elvégezhető

A relációs adatmodell lényege, hogy a különböző relációsémák azonos attribútumokat
tartalmazhatnak, ezáltal kerülnek kapcsolatba egymással, és így a különálló adattáblák
együttese egy szervesen összefüggő adatbázist alkot.

### 3.2 Reláció fogalma és tulajdonságai

A matematikában **halmazok Descartes-szorzatának részhalmazát** általában relációnak
nevezik. Mivel az adattáblát relációként definiáltuk, innen kapta nevét a relációs
adatmodell. Ahogy az E-K modellnél megkülönböztettünk egyedtípust és egyedpéldányt,
a relációs modellnél is beszélhetünk **relációtípus**ról, amely a relációsémának felel
meg, és **relációpéldány**ról, amely az adattáblának felel meg. Több adattábla
együttesen alkotja a relációs adatbázist, amely egy teljes jelenségkör leírására
alkalmas.

Mivel a definíció szerint a reláció egy halmaz, így **a relációs modellben a tábla
minden sora különböző**, és a sorokra semmilyen rendezettséget nem tételez fel.
Logikai szinten a relációk **táblában (adattábla)** jelennek meg. Az adattábla sorokból és
oszlopokból áll. Egy sorát **rekord**nak nevezzük, amely annyi mezőből áll, ahány
oszlopa van a táblának. Az attribútumok számát (az oszlopok számát) az R **reláció
fokának**, a sorok számát pedig a **reláció számosságának** nevezzük.

### 3.3 Relációséma

**Relációséma:** a reláció neve és az attribútumok (tulajdonságtípusok) halmaza.
A relációsémát R(A<sub>1</sub>,...,A<sub>n</sub> ) módon szokás jelölni, ahol
A<sub>1</sub>,...,A<sub>n</sub> attribútumok, R pedig a séma neve. Például a Könyv
reláció sémája a következő: *Könyv(ISBN, Kiadó, Szerző, Cím)*. Adott adatbázishoz
tartozó relációsémák összessége (és a köztük fennálló kapcsolatok leírása) alkotja
az adatbázissémát.

### 3.4 Kulcsok, indexek és tulajdonságaik

**Szuperkulcs:** olyan attribútumhalmaz, amely egyértelműen azonosítja a tábla
sorait (rekordjait), kikötve, hogy ha egyetlen attribútumot is elhagyunk belőle,
akkor ez már nem teljesül. A teljes attribútumhalmaz mindig szuperkulcs, hiszen
definíció szerint a tábla minden sora különböző.

**Kulcs:** az a **minimális szuperkulcs**, amelynek egyetlen valódi részhalmaza sem
szuperkulcs. Ha egyetlen attribútumból áll, akkor **egyszerű**, egyébként **összetett**
kulcsról beszélünk. A kulcs nem a tábla tulajdonsága, hanem annak megkövetelése,
hogy a sémához tartozó táblában (annak bármely időpontbeli állapotában) *nem lehet
két azonos kulcsú sor*.

**Kulcsjelölt:** olyan attribútum vagy attribútumhalmaz, amely eleget tesz a minimális
kulcs definíciójának.

**Másodlagos attribútum:** minden olyan attribútum, ami nem kulcs, vagy nem része
valamely kulcsnak.

**Elsődleges kulcs (Primary Key):** ha egy relációsémának több kulcsa is van, egyet
kiválasztunk közülük, ez lesz az elsődleges kulcs (ha csak egy van, akkor szükségképpen
az lesz az elsődleges kulcs). Egy relációsémában mindig csak egy elsődleges kulcs
lehet, amelynek nem lehet NULL az értéke.

**Idegen** vagy **külső kulcs (Foreign Key):** egy másik séma elsődleges kulcsára
hivatkozik. A külső kulcs értéke a hivatkozott táblában előforduló kulcsérték vagy
NULL lehet. Két reláció csak akkor áll kapcsolatban egymással, ha az egyik **külső
kulcsként** tartalmazza a másik **elsődleges kulcsát**. Az idegen kulcsot tartalmazó
relációt **hivatkozó relációnak**, a másikat, melyben ez a kulcs elsődleges,
**hivatkozott relációnak** nevezzük.

**Index:** nem része a relációs modellnek, hanem kiegészítő adatstruktúra, amelyet
egy táblához lehet generálni. Egy táblához egyszerre több index is létrehozható.
Az index a táblához kapcsolódó, gyors keresést lehetővé tevő táblázat. Az index
tartalmazza, hogy a tábla rekordjai egy vagy több oszlop alapján (pl. vezetéknév
és keresztnév) sorba rendezve hogyan következnek egymás után. Fontos, hogy ez nem
jelenti a teljes tábla megismétlését többféle rendezettséggel: az index csak egy
mutató, amely hivatkozik a táblára. Az indexek létrehozása jelentősen növeli az
adatbázis hatékonyságát, de a méretét is. Egy általános adatbázisban az indexek
helyfoglalása körülbelül akkora, mint az adatoké.


## 4. tétel

*(Jegyzet: 3.4. fejezet, 21-27. oldal)*

### 4.1 Relációs adatbázisséma elkészítése E-K diagram alapján

A konverzió alapelve az, hogy egy reláció egy egyedtípusnak felel meg. A relációs
adatmodell egy relációja tehát egy egyedtípus előfordulásait fogja tartalmazni. A
reláció neve megegyezik az egyedtípus azonosító nevével. A reláció szerkezet is
az E-K modellből jön. A reláció több mezőből épül fel, ahogy az egyedtípus is a
tulajdonságokból áll össze.

Tehát az első szabály a konverziónál az az irányelv, hogy az egyedből készítsünk
relációt, amelynek neve az egyed neve, attribútumai az egyed attribútumai, elsődleges
kulcsa az egyed kulcs-attribútuma(i). Az így kapott séma feletti adattábla minden
egyes sora egy egyedpéldánynak felel meg. Az EK-modellben megismert kapcsolatok
a relációs modellben külső kulcsok formájában jelennek meg.

### 4.2 Egyedek, gyenge egyedek, kapcsolatok, specializáló kapcsolatok, összetett és többértékű attribútumok leképezése

**A leképezési eljárás lépései**

1. **Erős egyedtípusok leképezése:** az E-K modell minden erős egyedtípusához
rendeljünk hozzá egy relációsémát, amely tartalmazza annak összes egyszerű attribútumát.
Az összetett attribútumoknak csak az egyszerű komponenseit adjuk hozzá. Válasszuk
az E-K modell kulcs attribútumainak egyikét az relációséma elsődleges kulcsául.
2. **Gyenge egyedtípusok leképezése:** az E-K modell minden gyenge egyedtípusához
rendeljünk hozzá egy relációsémát, melynek attribútumai legyenek az entitás összes
egyszerű attribútuma és összetett attribútumainak egyszerű komponensei. A gyenge
entitás relációsémáját bővíteni kell a meghatározó kapcsolat(ok)ban szereplő egyed(ek)
kulcsával (külső kulcsok).
3. **Bináris kapcsolattípusok leképezése:**
  * **1:1 kapcsolat** esetén kiválasztjuk a kapcsolatban résztvevő két entitás egyikét
  (bármelyiket), és annak sémájába új attribútumként felvesszük a másik entitás kulcs
  attribútumait, valamint a kapcsolat attribútumait.
  * **1:N kapcsolat** esetén az „N” oldali entitás sémájába új attribútumként felvesszük
  a másik entitás kulcs attribútumait, valamint a kapcsolat attribútumait.
  * **N:M kapcsolat** esetén új sémát veszünk fel, amelynek attribútumai a kapcsolódó
  entitások kulcs attribútumai, és a kapcsolat saját attribútumai.
4. **Többértékű attribútumok leképezése:** minden többértékű attribútum esetén hozzunk
létre egy új relációsémát. Ez tartalmazzon egy, az eredetinek megfelelő attribútumot,
valamint annak a relációsémának az elsődleges kulcsát — külső kulcsként —, amelyet
az eredeti attribútumot tartalmazó egyedtípusból vagy kapcsolattípusból képeztünk.
Ha a többértékű attribútum összetett, akkor az egyszerű komponenseit vegyük fel
az új séma attribútumaiként.
5. **n-edfokú (n > 2) kapcsolatok leképezése:** vegyünk fel a kapcsolathoz egy új sémát,
amelynek neve a kapcsolat neve, attribútumai pedig a kapcsolódó entitások kulcs
attribútumai és a kapcsolat saját attribútumai. Vegyük fel külső kulcsként a
kapcsolatban részt vevő egyedtípusokból képzett relációsémák elsődleges kulcsait.
6. **Specializáló kapcsolatok leképezése:**
  * minden altípushoz külön séma felvétele, egy egyed csak egy sémában szerepel.
  Az altípusok öröklik a főtípus attribútumait.
  * minden altípushoz külön séma felvétele, egy egyed több sémában is szerepelhet.
  A főtípus sémájában minden egyed szerepel, és annyi altípuséban ahánynak megfelel.
  Az altípusok a főtípustól csak a kulcs-attribútumokat öröklik.
  * egy közös séma felvétele, az attribútumok uniójával. Az aktuálisan értékkel
  nem rendelkező attribútumok NULL értékűek.


## 5. tétel

*(Jegyzet: 4.1., 4.2., 4.4. fejezet, 28-30. és 33. oldal)*

### 5.1 Relációalgebra fogalma

A relációs algebra adattáblákon végzett műveletek rendszere, amely az adatbázis
lekérdezés matematikai alapját képezi. A lekérdezések eredménye egy új reláció,
amelyet egy vagy több relációból kapunk. Az eredményül kapott új relációk tovább
manipulálhatók ugyanezen algebra műveleteivel. A relációalgebrai műveletek egy
sorozata relációalgebrai kifejezést alkot, amelynek az eredménye szintén egy reláció,
ami egy adatbázis-lekérdezés eredményét reprezentálja.

A relációalgebra műveletei két csoportra oszthatók. Az egyik csoport a matematikai
halmazelmélet halmazműveleteiből áll; ezek azért alkalmazhatók, mert **a formális
relációs modellben a relációt rekordok halmazaként definiáljuk**. A halmazműveletek
közé tartozik az **unió, a metszet, a (halmaz)különbség és a Descartes-szorzat**.
A másik csoport olyan műveletekből áll, amelyeket speciálisan a relációs modellhez
fejlesztettek ki — ilyen többek között a **szelekció, a projekció és az összekapcsolás**.

### 5.2 Halmazműveletek

Két táblát kompatibilisnek nevezünk, ha sémáik megegyeznek, vagy csak az attribútumok
elnevezésében különböznek (mind az attribútumok száma, mind értéktartománya – a
tárolt adat típusa – azonos). A halmazműveleteket csak kompatibilis táblákon
értelmezzük. Minden értelmezett halmazművelethez legalább két operandus szükséges.
A halmazműveletekre is igazak a [de Morgan azonosságok](https://hu.wikipedia.org/wiki/De_Morgan-azonoss%C3%A1gok). A relációkra
általában a komplemens képzés nem értelmezhető.

A halmazokon értelmezett hagyományos matematikai műveletek bináris műveletek, azaz
mindegyiket két halmazra (relációra) alkalmazzuk. Ide tartozik az **unió, a metszet,
a (halmaz)különbség és a Descartes-szorzat**.

**Unió**

Az unió művelete azonos szerkezetű két vagy több reláció között végezhető el. Az
eredmény reláció tartalmazza azokat a sorokat, melyek a műveletbe bevont relációk
közül legalább egyben szerepelnek. Ha ugyanaz a sor az egyesítendő relációk közül
többen is szerepelne, akkor is csak egyszer szerepel az eredmény relációban.

*Halmazelméleti unió SQL-ben:*

```sql
  (SELECT * FROM table1) UNION (SELECT * FROM table2);
```

**Metszet (Intersection)**

A metszet művelete azonos szerkezetű két vagy több reláció között végezhető el. Az
eredmény reláció csak azokat a sorokat tartalmazza, melyek a műveletbe bevont
relációk közül mindegyikben szerepelnek.

*Halmazelméleti metszet SQL-ben:*

```sql
  (SELECT * FROM table1) INTERSECT (SELECT * FROM table2);
```

**Különbség (Difference)**

A különbség művelete azonos szerkezetű két reláció között végezhető el. Az eredmény
reláció csak azokat a sorokat tartalmazza, melyek a első relációban megtalálhatóak,
de a másodikban nem.

*Halmazelméleti különbség SQL-ben:*

```sql
  (SELECT * FROM table1) EXCEPT (SELECT * FROM table2);

  (SELECT * FROM table1) MINUS (SELECT *FROM table2);
```

*Tulajdonságok:* az unió és metszet összetevői felcserélhetők, a különbségé nem.

Megállapodás szerint **az unió, a metszet, és a különbség műveletek eredmény relációnak
ugyanazok lesznek az attribútumnevei, mint amik az első relációnak** voltak. Az átnevezés
művelet segítségével később át lehet nevezni az eredménybeli attribútumokat.

**Descartes-szorzat (cross join)**

A Descartes-szorzat művelet olyan halmazművelet, amelynek segítségével két reláció
rekordjait tudjuk párosítani az összes lehetséges kombináció előállításával. A
eredményreláció elemei rendezett párok, amely azt jelenti, hogy az elemek közül
az első az első relációból, a második a második relációból való. Ez is egy bináris
(két operandusú) halmazművelet, azonban azoknak a relációknak, amelyekre alkalmazzuk,
nem kell kompatibiliseknek lenniük. A Descartes-szorzatot általában nem alkalmazzák
a gyakorlatban, mert az adathalmaz redundanciáját növeli.

*Descartes-szorzat SQL-ben:*

```sql
SELECT * FROM table1, table2;
```

### 5.3 Multihalmazok

A relációs algebra műveletei multihalmazokra is értelmezhetők. **Multihalmazon olyan
halmazt értünk, amely ismétlődő elemeket is tartalmazhat**. Ha a relációt multihalmaznak
tekintjük, akkor ezzel az adattáblában azonos sorokat is megengedünk.

**Az adatbázis-kezelő rendszerek általában multihalmazokkal dolgoznak**, és csak külön
kérésre végzik el az azonos sorok kiszűrését. Ennek okai a következők:
* Az adattábla fizikai tárolása természetes módon megengedi az azonos sorokat.
* Egyes relációs műveletek (például unió, projekció) lényegesen gyorsabbak, ha nem
kell kiszűrni az azonos sorokat.
* Egyes esetekben a multihalmaz szolgáltat korrekt eredményt (a szelekció feltételeiben
megadott attribútumok egyezősége esetén sem kerülnek összeolvasztásra az azonos
tulajdonságú, de más-más egyedpéldányokat reprezentáló sorok).

A multihalmaz nem megengedett a formális relációs modellben, de elfogadható a
gyakorlatban. Ezért minden adatbázis-műveletnél el kell dönteni, hogy a relációs
modell szerint halmazokkal, vagy (az adatbázis-kezelő számára természetesebb)
multihalmazokkal kívánunk dolgozni, és ennek megfelelően kell a műveleteket
végrehajtani.


## 6. tétel

*(Jegyzet: 4.3. fejezet, 30-33. oldal)*

### 6.1 Relációalgebra fogalma

A relációs algebra adattáblákon végzett műveletek rendszere, amely az adatbázis
lekérdezés matematikai alapját képezi. A lekérdezések eredménye egy új reláció,
amelyet egy vagy több relációból kapunk. Az eredményül kapott új relációk tovább
manipulálhatók ugyanezen algebra műveleteivel. A relációalgebrai műveletek egy
sorozata relációalgebrai kifejezést alkot, amelynek az eredménye szintén egy reláció,
ami egy adatbázis-lekérdezés eredményét reprezentálja.

A relációalgebra műveletei két csoportra oszthatók. Az egyik csoport a matematikai
halmazelmélet halmazműveleteiből áll; ezek azért alkalmazhatók, mert **a formális
relációs modellben a relációt rekordok halmazaként definiáljuk**. A halmazműveletek
közé tartozik az **unió, a metszet, a (halmaz)különbség és a Descartes-szorzat**.
A másik csoport olyan műveletekből áll, amelyeket speciálisan a relációs modellhez
fejlesztettek ki — ilyen többek között a **szelekció, a projekció és az összekapcsolás**.

### 6.2 Kombinációs műveletek

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` - logikai
vagy operátor) jelöli.*

**Descartes-szorzat (cross join)**

A Descartes-szorzat művelet olyan halmazművelet, amelynek segítségével két reláció
rekordjait tudjuk párosítani az összes lehetséges kombináció előállításával. A
eredményreláció elemei rendezett párok, amely azt jelenti, hogy az elemek közül
az első az első relációból, a második a második relációból való. Ez is egy bináris
(két operandusú) halmazművelet, azonban azoknak a relációknak, amelyekre alkalmazzuk,
nem kell kompatibiliseknek lenniük. A Descartes-szorzatot általában nem alkalmazzák
a gyakorlatban, mert az adathalmaz redundanciáját növeli.

*Descartes-szorzat SQL-ben:*

```sql
SELECT * FROM table1, table2;
```

**Összekapcsolás (illesztés, join)**

Jól megtervezett (normalizált) adatbázisokban az összetartozó információk sokszor
több táblába vannak szétosztva. Ezzel elkerülhető a redundancia, továbbá az adatok
módosításnál vagy törlésénél így egyszerűbb elkerülni bizonyos hibákat (inkonzisztens
adatok, információvesztés). Amikor lekérdezünk az adatbázisból, össze kell szednünk
az összetartozó adat-töredékeket. Erre szolgál a táblák összekapcsolása.

A relációs modell lényegéhez tartozik, hogy két tábla között a megegyező attribútumok
létesítenek kapcsolatot. Az összekapcsolás művelete két vagy több relációt kapcsol
össze egy-egy attribútum érték összehasonlításával. Az összekapcsolás eredmény
relációjában az első reláció csak azon sorai szerepelnek, melyekre található a
feltételt kielégítő sor a második relációban.

Relációk összekapcsolásakor meg kell adni az összekapcsolás módját (természetes,
belső vagy külső) és a sorok összekapcsolásának feltételét. Az `ON` kulcsszót
használhatjuk az összekapcsolás tetszőleges feltételének vagy oszlopainak megadására,
segítségével különböző nevű oszlopok is összekapcsolhatóak. Az összekapcsolási
feltétel független a többi keresési feltételtől.

A JOIN nyelvi elemek egy része kifejezhető a

```sql
SELECT <attribútumok> FROM <táblák> WHERE <feltételek>;
```

kifejezés segítségével is.

![Imgur](https://i.imgur.com/JE58fcX.png)

*Az összekapcsolás módja szerint lehet:*

* **Természetes-összekapcsolás (Natural join):** két reláció Descartes-szorzatából
  az azonos nevű attribútumokon megegyező értékű elemek kiválasztásával, illetve az
  azonos nevű attribútumok közül az ismétlődések elhagyásával nyert relációt eredményezi.
  Ha az azonos nevű oszlopok adattípusa eltérő, akkor hibával tér vissza.
  ```sql
    SELECT *
    FROM table1
    NATURAL JOIN table2;
  ```
  Az `ON` kikötés nem használható, ezért irányíthatatlan a kapcsolat, minden azonos
  nevű mező kapcsolódik.
* **Külső-összekapcsolás (Outer join):** az összekapcsolt két tábla egyikénél vagy
  mindkettőnél valamennyi rekord megőrzését garantálja. Az SQL szabvány szerint
  a `LEFT`, `RIGHT` vagy `FULL OUTER JOIN` kulcsszavakkal adható meg. A *baloldali
  oldali külső összekapcsolás* (`LEFT JOIN`) azt jelenti, hogy az eredménytáblában
  a baloldali tábla azon sorai is szerepelnek, melyek a jobboldali tábla egyetlen
  sorával sem párosíthatók. A *jobboldali oldali külső összekapcsolás* (`RIGHT JOIN`)
  ugyan ez, csak fordítva. A * teljes külső összekapcsolás* (`FULL OUTER JOIN` vagy
  egyszerűen: `FULL JOIN`) mindkét tábla nem párosított rekordjait megőrzi az
  eredménytáblában.

  ```sql
    SELECT column_name
    FROM table1
    LEFT JOIN table2
    ON table1.column_name = table2.column_name;

    SELECT column_name
    FROM table1
    RIGHT JOIN table2
    ON table1.column_name = table2.column_name;

    SELECT column_name
    FROM table1
    FULL [OUTER] JOIN table2
    ON table1.column_name = table2.column_name
    WHERE condition;
  ```
* **Belső-összekapcsolás (Inner join):** a két tábla közös soraival tér vissza.

  ```sql
    SELECT column_name(s)
    FROM table1
    INNER JOIN table2
    ON table1.column_name = table2.column_name;
  ```

* **Théta-összekapcsolás (Theta-join):** nem egyenlőségen alapuló összekapcsolás,
  itt a táblák Descartes-szorzatából tetszőleges feltétel szerint választunk ki
  sorokat. A théta szó erre a tetszőleges feltételre utal, amit θ jellel szokás
  jelölni.


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

A SQL (Structured Query Language – strukturált lekérdezőnyelv) relációsadatbázis-kezelők
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

Az SQL rendszerek *„háromértékű logikát”* használnak, vagyis a **TRUE** és **FALSE**
mellett a **NULL (definiálatlan)** érték is felléphet. *Ha egy kifejezés valamelyik
eleme NULL, akkor a kifejezés értéke is NULL lesz*.

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

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli.*

### 10.2 Az SQL nyelv szintaxisa, speciális logikai kifejezései

Az SQL nyelv alapvetően case-insensitive, tehát nem kis-és nagybetű érzékeny. A
szöveges literálokat, tehát amit aposztrófok közé írunk, azt szó szerint (literally)
kell érteni, tehát nyilván lényeges a nagybetűk–kisbetűk különbsége. **A nyelv kulcsszavait
(parancsait) általában nagybetűvel szokás írni (pl. SELECT), a kód jobb olvashatósága
és áttekinthetősége érdekében**. Az **oszlopneveknél a kisbetűs írásmód javasolt**,
különösen ha a kulcsszavak nagybetűsek, ekkor ugyanis jól elkülönül egymástól a
kettő.

Változó nincs, csak tábla- és oszlopnevekre lehet hivatkozni. Az SQL utasítások
kulcsszavakból (SQL names, keywords), azonosítókból, műveleti jelekből, literálokból
(számszerű, dátum jellegű, szöveges konstansok) állnak. Az utasítások sorfolytonosan
írhatók (és egymásba is ágyazhatók), minden utasítást pontosvesszővel kell lezárni.

### 10.3 Adatdefiníciós utasítások (DDL)



### 10.4 Relációsémák, indexek

### 10.5 Hivatkozástípusok relációsémák definiálásakor


## 11. tétel

*(Jegyzet: 6.4., 6.7. fejezet, 53-54., 61-62. oldal)*

### 11.1 Az SQL nyelv általános jellemzői

A SQL (Structured Query Language – strukturált lekérdezőnyelv) relációsadatbázis-kezelők
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

Az SQL rendszerek *„háromértékű logikát”* használnak, vagyis a **TRUE** és **FALSE**
mellett a **NULL (definiálatlan)** érték is felléphet. *Ha egy kifejezés valamelyik
eleme NULL, akkor a kifejezés értéke is NULL lesz*.

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

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli.*

### 11.2 Nézettábla (VIEW) kialakítása és szerepe

### 11.3 Adatmanipulációs utasítások (DML), adattábla aktualizálása




## 12. tétel

*(Jegyzet: 6.5., 6-6. fejezet, 54-60. oldal)*

### 12.1 Az SQL nyelv általános jellemzői

A SQL (Structured Query Language – strukturált lekérdezőnyelv) relációsadatbázis-kezelők
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

Az SQL rendszerek *„háromértékű logikát”* használnak, vagyis a **TRUE** és **FALSE**
mellett a **NULL (definiálatlan)** érték is felléphet. *Ha egy kifejezés valamelyik
eleme NULL, akkor a kifejezés értéke is NULL lesz*.

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

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli.*

### 12.2 Lekérdezés relációs adattáblákból, a relációalgebrai műveletek megvalósítása



### 12.3 Összesítő függvények alkalmazása

### 12.4 Alkérdések az SQL nyelvben

Az SQL támogatja azt a lehetőséget, hogy a `WHERE` vagy `HAVING` szelekciós feltételben
nemcsak létező, letárolt adatelemekre hivatkozzunk, hanem számított kifejezéseket
is alkalmazhassunk. A számítást egy másik SELECT utasítással tudjuk megadni, tehát
az egyik lekérdezés szelekciós feltételében hivatkozunk egy másik lekérdezés eredményére.
Ezt alkérdésnek vagy belső SELECT-nek is nevezzük, formailag megegyezik a normál
SELECT utasítással. Az alkérdésnek mindig zárójelben kell megadni, hogy elemei
elkülönüljenek.


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
* <span id="note4">[[4]](#4)</span> dr. Halassy Béla:
[Adatmodellezés](http://mek.oszk.hu/11100/11144/11144.pdf), 29-30. o.


[Kezdőlap](README.md)
