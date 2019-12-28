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
  ugyan ez, csak fordítva. A *teljes külső összekapcsolás* (`FULL OUTER JOIN` vagy
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

Az adatmodellezés egyik fő célja az optimalizálás, vagyis az adatmodellt alkotó
egyedtípusok lehető legjobb belső és külső szerkezetének a megkeresése. Adatbázis
tervezés során olyan adatstruktúrákat kell kialakítani amelyek segítik a hatékony
adatkezelést. Fontos hogy az egyes táblákba csak a logikailag valóban összetartozó
adatok kerüljenek, és hogy minél kevesebb ismétlődés legyen az adatok között.

Az optimális adatmodell kialakítására – egyéb technikák mellett – a normalizálás
szolgál. A normalizálás az adatbázis belső szerkezetének ellenőrzése, lépésenkénti
átalakítása oly módon, hogy az adatbázis minden egyes lépésben egy-egy újabb kritériumnak,
egymásra épülő normálformának (n-ik normálformában lenni annyit jelent, hogy már
az n-1. normálformában benne van) feleljen meg. A műveletsorozat célja a redundancia-
és anomáliamentes adatbázisok kialakítása.

Egy reláció normálformája a legmagasabb olyan normálforma, amely feltételének a
reláció megfelel, és így jelzi a reláció normalizáltságának a fokát.

### 7.2 Redundancia, anomáliák redundáns adattárolás esetén

Redundanciának ill. redundáns adattárolásnak nevezzük azt, amikor a minimálisan
szükségesnél több adatot tárolunk egy adott információs állapot ábrázolása során.
Egy ábrázolás általában attól lesz redundáns, hogy magában foglalja az adathalmaz
más részeiből számítható információkat is.

A redundáns adattárolás a következő anomáliákhoz vezethet:

* **Beszúrási anomália:** amikor egy adatrekord beszúrása egy másik, hozzá logikailag
nem kapcsolódó adatcsoport beszúrását kívánja meg.
* **Módosítási anomália:** ha egy relációban egy adat módosítása több helyen
történő módosítást igényel.
* **Törlési anomália:** amennyiben egy adat törlésével másik, hozzá logikailag
nem kapcsolódó adatcsoportot is elveszítünk.

A karbantartási anomáliák abból származnak, hogy nem az igazán összetartozó adatokat
vesszük be egy relációba. Hogy mely mezők tartoznak igazán egy relációba, azt a
mezők közötti összetartozási viszony, a mezők közötti függőségek határozzák meg.
A legfontosabb függőségi típus a funkcionális függőség.

### 7.3 Funkcionális függőség (FD – Functional Dependency) fogalma

A funkcionális függés egy olyan megszorítás, amely az adatbázis két attribútumhalmaza
között áll fenn. Egy funkcionális függés az attribútumok szemantikájának vagy
jelentésének egy jellemzője. A függőség nem az aktuális tábla, hanem a séma
tulajdonsága.

Funkcionális függésről akkor beszélünk, ha egy tábla valamelyik mezőjében lévő
érték meghatározza egy másik mező értékét. A funkcionális függőség bal oldalát a
függőség meghatározójának nevezzük. A funkcionális függőség bal oldalán több
attribútum is megjelenhet, melyek együttesen határozzák meg a jobb oldalon szereplő
attribútum értékét. A funkcionális függőség jobb oldalán több attribútum is állhat.

A funkcionális függőségekkel magyarázható a redundancia is. Ha ugyanis egy ismétlődő
értékű mező meghatároz egy másik mezőt, akkor a függés definíciója alapján annak
is ismétlődnie kell. Tehát a redundancia oka a nem megfelelő, felesleges funkcionális
függőség a relációsémán belül. A funkcionális függőségek felderítését, és az adatbázis
funkcionális függőségek-mentessé alakítását (dekompozícióját) nevezzük normalizálásnak.

A funkcionális függés kiterjesztése a **teljes funkcionális függés**. Három feltétele
van:
* egy tábla minden nem kulcs mezője függjön a kulcstól,
* minden, nem kulcs mező csak a kulcstól függjön,
* összetett kulcs esetén, minden nem kulcs mező függjön a kulcs minden elemétől.

Az **A → B függést triviálisnak** nevezzük, ha B részhalmaza A-nak, ellenkező esetben
**nem triviális**. Az **A → B függést teljesen nemtriviálisnak** nevezzük, ha a két
attribútumhalmaznak nincs közös eleme. A gyakorlatban általában teljesen nemtriviális
függőségek fordulnak elő.

### 7.4 Attribútumhalmaz lezártja függéshalmaz szerint

Egy funkcionális függéshalmaz (jelölése: **F**) elemeiből az Armstrong-axiómák
segítségével képezhető, immár az összes függőséget magában foglaló halmazt az
eredeti **függőségi halmaz lezártjának** nevezzük. Jelölése: **F<sup>+</sup>**.
Egy függőségi halmaz lezártja tehát tartalmazza a kiinduló funkcionális függéshalmaz
elemei mellett azokat a függéseket is, amelyek az Armstrong-axiómák segítségével
levezethetők a kiinduló halmaz elemeiből. Az Armstrong-axiómák segítségével ugyanis
egy adott függőségi halmazból következő bármely függőség formálisan levezethető.

**Armstrong-axiómák:**

1. *Tranzitivitás (átvihetőség):* az elempárok azon tulajdonsága, hogy egymással
  relációban állnak, „láncszerűen” tovább adódik. Tehát, ha R(A, B, C) relációsémában
  B argumentum függ A-tól, C pedig B-től, akkor C tranzitíven függ A-tól.
2. *Reflexivitás (triviális függés):* egy attribútumhalmaz mindig meghatározza
  önmagát, vagy saját maga bármelyik részhalmazát.
3. *Augmentivitás (bővíthetőség):* egy funkcionális függés mindkét oldalának ugyanazzal
  az attribútumhalmazzal való bővítése újabb érvényes funkcionális függést eredményez.

**Az Armstrong-axiómákból levezethető szabályok**
* **Additivitás – Egyesítési szabály:** az azonos bal oldalú függőségek jobb oldalán
szereplő attribútum-halmazokat egyesíthetjük (ha teljesül egy **A → B** és egy
**A → C** függőség, akkor teljesül az **A → {B, C}** függőség is).
* **Dekompozíció – Szétvághatósági szabály:** az additivitás ellentéte. A funkcionális
függőség jobb oldalán szereplő attribútum-halmaz minden részhalmaza is függ a
baloldaltól (vagyis: ha **A → {B, C}** függőség teljesül, akkor **A → B** és A → C**
is fennáll).

A lezárt képzésénél kiindulunk az adott attribútumhalmazból, és többször ismételten
növeljük ezt a halmazt azoknak a funkcionális függőségeknek a jobb oldali attribútumaival,
amely függőségek bal oldalát már tartalmazza a leendő lezárt. Nyilvánvalóan
eljutunk egy pontig, amikor a halmaz már nem bővíthető tovább. Ez az eredményhalmaz
lesz a lezárt.


## 8. tétel

*(Jegyzet: 5.3. fejezet, 38-40. oldal)*

### 8.1 Relációs adatbázis normalizálása – elméleti alapok

Az adatmodellezés egyik fő célja az optimalizálás, vagyis az adatmodellt alkotó
egyedtípusok lehető legjobb belső és külső szerkezetének a megkeresése. Adatbázis
tervezés során olyan adatstruktúrákat kell kialakítani amelyek segítik a hatékony
adatkezelést. Fontos hogy az egyes táblákba csak a logikailag valóban összetartozó
adatok kerüljenek, és hogy minél kevesebb ismétlődés legyen az adatok között.

Az optimális adatmodell kialakítására – egyéb technikák mellett – a normalizálás
szolgál. A normalizálás az adatbázis belső szerkezetének ellenőrzése, lépésenkénti
átalakítása oly módon, hogy az adatbázis minden egyes lépésben egy-egy újabb kritériumnak,
egymásra épülő normálformának (n-ik normálformában lenni annyit jelent, hogy már
az n-1. normálformában benne van) feleljen meg. A műveletsorozat célja a redundancia-
és anomáliamentes adatbázisok kialakítása.

A normalizálás néhány rögzített irányelven alapszik (ezek a normálformák), amelyek
iránymutatást adnak a tervezéshez, helyes mederbe terelve a modellezés menetét.

### 8.2 Tábla dekompozíciója (felbontása)

A dekompozíció során az induló séma felbontásával emeljük ki a nem kívánt funkcionális
függőségeket külön relációkba. Azaz a felesleges funkcionális függőséget tartalmazó
sémát dekompozícióval hozzuk normalizált alakra. A dekompozíciós módszerben felállított
tervezési irányelveket több, egymásra épülő követelmény alakjában adják meg. Az
egyes követelményeket szokás normálformáknak is nevezni. A gyakorlatban azt kell
mérlegelni, hogy a redundancia és az anomáliák mennyire jelentenek súlyos veszélyt,
indokolt-e azok megszüntetésével a táblák számát növelni (dekompozíció).

A dekompozíciónak mindig veszteségmentesnek kell lennie.

### 8.3 Hűséges ill. függőségőrző felbontás

A dekompozíció megfordítható – reverzibilis – művelet. Ez azt jelenti, hogy az
eredmény-relációkból mindig visszaállíthatók az eredetiek. Egy felbontást hűségesnek
nevezünk, ha a felbontás után adódó relációk összekapcsolásával az eredeti relációt
kapjuk vissza.

### 8.4 Heath tétele

**Azt mondja ki, hogy akkor tekinthető egy felbontás biztosan veszteségmentesnek vagy
hűségesnek, ha a kapott relációk összekapcsolásával az eredeti relációt kapjuk vissza**.

R(B, C, D), ahol B, C és D attribútumhalmazoknak nincs közös eleme. Ha D funkcionálisan
függ C-től, akkor az R1(B, C), R2(C, D) felbontás hűséges, mivel R1 és R2 relációkból
összekapcsolással az eredeti R relációt kapjuk vissza (C attribútum R1 relációban
idegenkulcs, R2-ben pedig elsődleges kulcs, tehát C biztosítja a kapcsolatot a két
reláció között).


## 9. tétel

*(Jegyzet: 5.4. fejezet, 41-45. oldal)*

### 9.1 Relációs adatbázis normalizálása – eljárások

A normalizációs folyamat Codd első javaslata szerint (Codd, 1972) végigvisz egy
relációsémát tesztek egy sorozatán annak ellenőrzésére, hogy kielégít-e egy bizonyos
normálformát. Ezt a folyamatot, **analízis alapú relációs tervezésnek** tekinthetjük.
Codd kezdetben három normálformát javasolt, Boyce és Codd később egy, a 3NF-nél
erősebb normálformát definiált, amelyet **Boyce–Codd-normálformának (BCNF)** nevezünk.
**Mindegyik normálforma egyetlen analitikai eszközön alapul: a reláció attribútumai
között fennálló funkcionális függéseken**.

Az adatok normalizálása egy olyan folyamatnak tekinthető, amely elemzi az adott
relációsémákat a funkcionális függéseik és elsődleges kulcsaik alapján, hogy minimalizálja
a redundanciát és a beszúrási, törlési és módosítási anomáliákat.

A nem megfelelő relációsémákat felbontjuk kisebb relációsémákra, amelyek rendelkeznek
az elvárt tulajdonságokkal. A normalizációs eljárás tehát az adatbázis-tervezők
számára a következőket biztosítja:
* formális keretrendszert a relációsémák elemzéséhez, amely a relációsémák kulcsain
és az attribútumaik között fennálló funkcionális függéseken alapszik,
* normálformatesztek egy sorozatát, amelyek egy-egy relációsémán hajthatók végre,
hogy az adatbázis tetszőleges mértékig normalizálható legyen.

Bár számos magasabb normálformát definiáltak (mint például a 4NF és az 5NF), ezek
gyakorlati hasznossága kérdésessé válik akkor, amikor azok az adatbázis-tervezők
és felhasználók, akiknek ez a feladatuk, nehezen tudják megérteni, illetve felismerni
azokat a megszorításokat, amelyeken ezek a normálformák alapulnak. Az iparban manapság
alkalmazott adatbázis-tervezés során ezért **csak a 3NF-ig, BCNF-ig végrehajtott
normalizálásra fordítanak figyelmet**.

### 9.2 Az 1NF, 2NF és 3NF követelményei

Az alábbi normálformák az elsődleges kulcson alapulnak. Ezen normálformák léteznek
általánosabb definíciói is, amelyek a reláció összes kulcsjelöltjét figyelembe veszik,
nem csak az elsődleges kulcsot.

Az **első normálforma (1NF)** az alap relációs modellben ismertetett reláció fogalom
formális definíciójának a részeként is felfogható. Egy relációséma 1NF-ben van, ha
**az attribútumok értéktartománya csak egyszerű (atomi) adatokból áll** (azaz nem
nem többértékű és nem összetett attribútum; nem tartalmaz például listát vagy struktúrát).

A **második normálforma (2NF)** a teljes funkcionális függés fogalmán alapul. Egy
relációséma 2NF-ben van, ha **minden másodlagos attribútum funkcionálisan függ az
elsődleges kulcstól**. Azok a relációk, melyek elsődleges kulcsa csak egy attribútumból
áll, mindig második normálformában vannak, ekkor ugyanis nem lehetséges, hogy csak az
elsődleges kulcs egy részétől függjön egy nem elsődleges attribútum.

A **harmadik normálforma (3NF)** a tranzitív függés fogalmán alapul. Egy egyed leíró
(nem kulcs) tulajdonsága akkor és csak akkor függ tranzitíven az egyed kulcsától,
ha azt meghatározza a kulcstól függő másik leíró tulajdonság is. Egy relációséma
3NF-ben van, ha **minden másodlagos attribútuma közvetlenül függ az elsődleges kulcstól,
és csak attól függ** (nincs tranzitív függés, tehát egy leíró attribútum sem függ egy
másiktól, csak a kulcstól).

### 9.3 Teljes függés fogalma

A funkcionális függés kiterjesztése a **teljes funkcionális függés**. Három feltétele
van:
* egy tábla minden nem kulcs (leíró) mezője függjön a kulcstól,
* minden, nem kulcs mező csak a kulcstól függjön,
* összetett kulcs esetén, minden nem kulcs mező függjön a kulcs minden elemétől.

**Részleges funkcionális függés** a teljes funkcionális függés egyik akadálya. Akkor
fordulhat elő egy táblában, ha abban van összetett kulcs és nem teljesül a teljes
funkcionális függés azon feltétele, miszerint *„minden nem kulcs mező függjön a
kulcs minden elemétől”*, vagyis ha **az összetett kulcs egyik részét eltávolítva a
függés továbbra is fennáll**. Ebből következik, hogy **részleges funkcionális függés
csak akkor fordulhat elő egy táblában, ha abban összetett kulcs van**. A normalizálás
során a részleges funkcionális függést meg kell szüntetni.

### 9.4 Harmadik normálformára alakítás

Az egyed akkor van harmadik normálformában, ha
* az attribútumok értéktartománya csak egyszerű (atomi) adatokból áll,
* minden leíró tulajdonsága funkcionálisan függ a kulcsától (1NF),
* minden leíró tulajdonsága csak a teljes kulcsától függ (2NF),
* leíró tulajdonságai semmilyen más tulajdonságától, csak a kulcsától függnek (3NF).

**A normalizálás lépései:**

1. A normalizálás feltétele az egyértelműség. Ezért legelőször fel kell
számolni a [szinonim](https://hu.wikipedia.org/wiki/Szinon%C3%ADmia) és [homonim](https://hu.wikipedia.org/wiki/Homon%C3%ADmia) oszlopneveket, azaz meg kell
teremteni a korrekt normalizálási alapot. Minden attribútumnévnek világosnak és
egyértelműnek kell lennie, ami pontosan tükrözi az oszlop tartalmát.
2. **Többértékű és összetett attribútumok felbontása**.
    * az összetett attribútumokat a részattribútumaikkal helyettesítjük,
    * a többértékű attribútumokat új relációsémába visszük át, az új séma elsődleges
    kulcsát idegenkulcsként beillesztve a kiinduló sémába.
3. **Elsődleges kulcs kiválasztása** a kulcsjelöltek közül. Ha nincs alkalmas kulcsjelölt,
akkor létre kell hozni egy olyat (azonosító, ID, auto increment megkötéssel), amelytől
a reláció minden leíró attribútuma függ.
4. **Részleges funkcionális függés megszüntetése:** a sémát felbontjuk Heath tétele
szerint, a részleges függőség mentén úgy, hogy a kulcsa egy elemű legyen. Kiemeljük
a kulcsból azokat az tulajdonságokat, amelyek önállóan is meghatározzák a másodlagos
attribútumokat. Az így kapott elsődleges (kulcs) attribútumokból és a tőlük függő
másodlagos tulajdonságokból új relációt hozunk létre. Ebben az új relációban elsődleges
kulcsként kell szerepelni azoknak az attribútumoknak, amelyektől az átvitt leíró
attribútumok függnek. Erre az eredeti relációban idegenkulcsként kell hivatkozni.
Ha a kulcs eleve egy attribútumból áll, illetve a sémában nincs másodlagos attribútum,
akkor 2NF-ben van (nem kell felbontani).
5. **Tranzitív függés megszüntetése:** ekkor ugyanis a kulcs egy köztes attribútumon
keresztül, tranzitíven határozza meg a másik leíró attribútum értékét. A sémát
felbontjuk Heath tétele szerint, a tranzitív függőség mentén. Az eredeti relációból
eltávolítjuk a tranzitíven függő leíró attribútumokat egy másik relációba. Ebben
az új relációban elsődleges kulcsként kell szerepelni azoknak az attribútumoknak,
amelyektől az átvitt leíró attribútumok függnek. Erre az eredeti relációban idegenkulcsként
kell hivatkozni. Ha a sémában nincs másodlagos attribútum, akkor 3NF-ben van.

### 9.5 A Boyce-Codd normálforma fogalma

A **Boyce–Codd-féle normálforma (BCNF)** látszólag a 3NF egy egyszerűbb alakja, de
valójában erősebb, mint a 3NF. Azaz **minden BCNF-ben lévő reláció egyúttal 3NF-ben
is van**, ám egy 3NF-ben lévő reláció nem szükségképpen van BCNF-ben. A BCNF formális
definíciója alig különbözik a 3NF definíciójától, a gyakorlatban a legtöbb relációséma,
amely 3NF-ben van, egyúttal BCNF-ben is van.

Egy relációséma BCNF-ben van, ha bármely olyan **A→B** függés esetén, ahol **B**
nem részhalmaza **A**-nak (nemtriviális függés), **A szuperkulcs**. A séma nincs
BCNF-ben, ha van benne olyan nemtriviális függés, amelynek meghatározó (bal) oldala
nem szuperkulcs.

**BCNF-re hozás:** a sémát felbontjuk Heath tétele szerint, a normálformát sértő
függőség mentén.


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

### 10.2 Az SQL nyelv szintaxisa, speciális logikai kifejezései

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

**Az SQL aritmetikai operátorai**

|  Operátor  |  Leírás  |
|:----------:|----------|
| + | összeadás |
| - | kivonás |
| * | szorzás |
| / | osztás  |
| % | maradékos osztás |

**Az SQL összehasonlító operátorai**

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

**Az SQL [bitenkénti](https://hu.wikipedia.org/wiki/Bitm%C5%B1velet#Bitm%C5%B1veletek) logikai operátorai**

A bitművelet olyan művelet, amely egy vagy több bitsorozatot vagy bináris számot
az egyes bitek szintjén manipulál. A két operandust bitsorozatokként ábrázolják
amelyek egy párt alkotnak. Az operátor a párok felhasználásával bitenként
állítja össze az eredményt. Gyors, primitív tevékenység, amit a CPU közvetlenül
támogat.

|  Operátor  |  Leírás  |
|:----------:|----------|
| & | Bitenénti ÉS (AND) |
| &vert; | Bitenkénti VAGY (OR) |
| ^ | Bitenkénti KIZÁRÓ VAGY (XOR)  |

**Az SQL logikai operátorai**

Az SQL rendszerek *„háromértékű logikát”* használnak, vagyis a **TRUE** és **FALSE**
mellett a **NULL (definiálatlan)** érték is felléphet. *Ha egy kifejezés valamelyik
eleme NULL, akkor a kifejezés értéke is NULL lesz*.

|  Operátor  |  Leírás  |
|------------|----------|
| **ALL** | IGAZ, ha az összes alkérdés eredménye megfelel a feltételnek |
| **AND** | IGAZ, ha mindkét feltétel teljesül (logikai **ÉS**) |
| **ANY** vagy **SOME** | IGAZ, ha alkérdés bármely eredménye megfelel a feltételnek |
| **BETWEEN** | IGAZ, ha az operandus a megadott értéktartományon belül van ` SELECT * FROM Termékek WHERE Ár BETWEEN 500 AND 600; ` (minden terméket listáz, aminek az ára 500 és 600 közé esik) |
| **EXISTS**  | IGAZ, ha beágyazott lekérdezés talál a feltételt kielégítő sort. Előtte a NOT kulcsszó is állhat, így jelezve, hogy a alkérdésnek egy sort sem szabad visszaadnia. |
| **IN**  | IGAZ, ha az operandus a felsorolt értékek között található, segítségével több **OR** (**VAGY**) operátor helyettesíthető  |
| **LIKE**  | IGAZ, ha az operandus illeszkedik a megadott mintára. Két speciális karakter adható meg a mintában, a `%` jel tetszőleges hosszúságú karakter sorozatot helyettesít, az `_` aláhúzás karakter pedig egy tetszőleges karaktert. ` SELECT * FROM Ügyfelek WHERE Város LIKE 'b%'; ` (minden ügyfelet listáz, akinek a városa b-vel kezdődik) |
| **NOT** | IGAZ, ha a kifejezésben az adott feltétel nem teljesül (tagadás, negáció) |
| **OR**  | IGAZ, ha bármelyik feltétel teljesül (logikai **VAGY**) |

**Az operátorok precedenciája (végrehajtási sorrendje) csökkenő sorrendben:**
1. Összehasonlító operátorok
2. NOT
3. AND
4. OR

A végrehajtási sorrend megváltoztatható kerek zárójelek használatával.

### 10.3 [Adatdefiníciós utasítások (DDL)](https://mariadb.com/kb/en/data-definition/)

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
    `lakcim` varchar(40) DEFAULT 'hajléktalan'
    `osztaly_id` int(10)
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

### 10.4 Relációsémák, indexek

A **relációséma** a reláció nevét és az attribútumok (tulajdonságtípusok) halmazát
tartalmazza és Relációnév(Tulajdonság<sub>1</sub>,...,tulajdonság<sub>n</sub> ) módon
szokás jelölni. Ez a séma nem más, mint a táblázat alapszerkezetének, az oszlopfejlécek
sorrendjének leírása. Az adatbázis megvalósításakor ezt a sémát kell táblaként
leképezni, az SQL nyelv által biztosított eszközökkel.

Az SQL három típusú relációt ismer:
1. **Táblák (TABLE)**, tárolt relációk. Általában ilyen relációkkal foglalkozunk.
Benne vannak az adatbázisban, soraik változtatásával megváltoztathatók és
soraik is lekérdezhetők.
2. A **Nézetek (VIEW)** vagy virtuális táblák más relációkra vonatkozó lekérdezésekkel
jönnek létre. Nem valódi táblák az adatbázisban, csak származtatott adatokat
tartalmaznak. A virtuális tábla nem tárol adatokat.
3. **Ideiglenes (TEMPORARY) táblák**, amelyeket az SQL nyelvi feldolgozója készít,
amikor valamilyen lekérdezéseket és adatmódosításokat végez el. Ezeket a relációkat
eldobja és nem tárolja sehol az SQL feldolgozója.

#### Indexek<sup id="5">[[5]](#note5)</sup>

A lemezműveletek mindig kritikus pontot jelentenek a sebesség tekintetében. Amikor
egy tábla valamelyik mezőjének értékétől függően akarjuk a rekordok egy részét
kiválogatni, ez a probléma hatványozottan jelentkezik. A DBMS ugyanis úgy állítja
össze a rekordok szükséges részhalmazát, hogy minden rekordot beolvas, és a kérdéses
mező rekordonkénti vizsgálata alapján eldönteni, hogy mely rekordok kerüljenek az
eredményhalmazba. Előfordulhat, csak a legutolsó rekord, vagy egyetlen egyed sem
elégíti ki a feltételt, de ennek eldöntéséhez mindig minden rekordot meg kell vizsgálni.

Az indexelés jelentősen redukálja az ilyen műveletek lebonyolításához szükséges időt.

A technika lényege, hogy a bázistábla (a rekordok adatait tároló reláció) létrehozásakor
bármelyik mezőt indexelhetjük. Az indexelés azt jelenti, hogy a DBMS úgynevezett
indextáblát (röviden indexet) hoz létre a mező számára. A bázistábla feltöltésekor
az indexelt mező összes előforduló értékét bemásolja az indextáblába, és az index
rekordjait sorba rendezi az értékek szerint. Az indextáblában a minden mezőérték
mellett följegyzi azt is, hogy a bázistábla adott értéket tároló rekordja hol
található a lemezen.

Az indextábla minden sora az indexelt mező egye-egy értékét és a hozzá tartozó
rekordmutatót tárolja. A sorok az indexelt értékek szerint rendezettek.

Ha a bázistáblában egy indexelt mező alapján akarunk rekordokat keresni, vagy kiválogatni,
akkor a DBMS automatikusan beolvassa a memóriába a teljes indextáblát, kiválogatja
a megfelelő mezőértékeket (ez a művelet a rendezettség miatt gyors lesz), és
bázistáblának csak a kiválasztott, az ezeket az értékeket tartalmazó rekordjait
olvassa be a lemezről.

Egy táblában bármennyi mező indexelhető. Ha több mezőt is indexelünk, akkor
természetesen mindegyik számára különálló indextábla készül.

Szintaxis
```sql

  CREATE [OR REPLACE] [UNIQUE] INDEX [IF NOT EXISTS] <index_neve>
    ON <táblanév> (<index_oszlop_neve>,...);

         <index_neve> ::= ezen a néven lehet rá később hivatkozni
  <index_oszlop_neve> ::= már létező oszlop neve, amit indexként akarunk használni

```
Az **UNIQUE** kulcsszó jelzi, hogy egyedi indexet szeretnénk készíteni. Az **INDEX|KEY**
kulcsszavak kompatibilitási okokból maradtak a nyelvben, egymás szinonimái, de el
is hagyhatók.

Minden indextábla helyet foglal a lemezen, és ezzel növeli az adatbázis méretét.
Ráadásul az indexek csak akkor működnek helyesen, ha a DBMS a bázistábla rekordjainak
változásakor (új rekord, rekordtörlés, mezőérték változtatás) automatikusan frissíti
az indextáblát is.

Ha helyesen akarunk eljárni, akkor csak azokat a mezőket indexeljük,
* amelyek alapján gyakran válogatunk ki rekordokat egy nagy méretű bázistáblából,
* biztosítani akarjuk, hogy a mező rekordonként egyedi értéket tartalmazzon,
* a mezőt idegen kulcsként akarjuk használni.

### 10.5 Hivatkozástípusok relációsémák definiálásakor

Az Objektum-relációs modell (SQL3) a relációs világba átemel objektum-orientált
elemeket. A reláció továbbra is alapfogalom, amelyet absztrakt adattípusok definiálásával
bővíthetünk. Az objektum-relációs elv alapján belül minden relációsan működik, egy
ráépülő rétegként alakítják ki az objektum-orientált felületet.

Az SQL3 támogatja az **absztrakt adattípus (ADT = Abstract Data Type)** alkalmazását
(ez bizonyos értelemben az osztály fogalomnak felel meg). Az ADT-k a strukturális
elemek mellett metódusokat is tartalmazhatnak, közöttük öröklési kapcsolat
létesíthető. Ezek más néven a felhasználó által létrehozott típusok (User Defined Type,
UDT), melyekben új típusokat (pl. objektumot attribútumokkal, metódusokkal) és
műveleteket lehet definiálni, majd használni azokat az SQL utasításokban a beépített
típusokhoz és operátorokhoz hasonlóan. **A MySQL és a MariaDB nem támogatja felhasználói
adattípusok használatát**, az Oracle, az MS SQL és a PostgreSQL viszont igen.

Egy tábla mezőtípusa lehet objektum, másik tábla, pointer más objektumra (hivatkozás),
itt a mező csak egy pointert tartalmaz a hivatkozott objektumra. A hivatkozott
objektum nem része a hivatkozó objektumnak. A fogalom hasonló a [C++-beli mutatóhoz](http://www.mogi.bme.hu/TAMOP/c++programozas/ch01.html#ch-I.6.1). A hivatkozás
típusú attribútum tehát egy másik objektumtábla adott sorára (objektumazonosítójára)
hivatkozik.

A hivatkozás kapcsolatok kezelésére alkalmas:
* Hasonló a külső kulcshoz, de nem egyenértékű vele.
* Ha hivatkozott sort töröljük, majd azonos tartalommal újra felvesszük, akkor
új objektumazonosítót kap.


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

### 11.2 Nézettábla (VIEW) kialakítása és szerepe

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható (opcionális) részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli, a [BNF](https://hu.wikipedia.org/wiki/Backus%E2%80%93Naur-forma)
metaszintaxishoz hasonló módon. A {kapcsos zárójelbe zárt szöveg} logikai egységet
alkotó nyelvi elemeket jelöl a szintaxis leírásában.*

A nézet vagy nézettábla olyan virtuális tábla, amely az adatbázis egy vagy több
táblájának mezőiből épül fel. A nézettáblát alkotó táblákat alaptábláknak hívjuk.
A relációs modell azért tekinti virtuálisnak (látszólagosnak) a nézettáblákat, mert
azok adatai más táblákból származnak. Maguk a nézettáblák nem tárolnak adatokat;
az adatbázisban valójában a szerkezetük az egyetlen információ, ami tárolódik róluk.

Sok RDBMS program a nézettáblákat mentett lekérdezésként valósítja meg, és ezen
a néven vagy egyszerűen lekérdezésként hivatkozik rájuk. A lekérdezések a legtöbb
esetben rendelkeznek a nézettáblák minden jellemzőjével, vagyis csupán a nevük az
egyetlen különbség köztük.

Az SQL-szabvány szerit a tábla_neve nézettáblát is takarhat, de kiköti, hogy a
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

### 11.3 [Adatmanipulációs utasítások (DML)](https://mariadb.com/kb/en/data-manipulation/), adattábla aktualizálása

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

### 12.2 [Lekérdezés relációs adattáblákból (DQL)](https://mariadb.com/kb/en/selecting-data/)

*Megjegyzés: az utasítások szintaxisának leírásánál az elhagyható (opcionális) részleteket
szögletes zárójel, a több lehetőség közüli választást függőleges vonal (`|` logikai
vagy operátor) jelöli, a [BNF](https://hu.wikipedia.org/wiki/Backus%E2%80%93Naur-forma)
metaszintaxishoz hasonló módon. A {kapcsos zárójelbe zárt szöveg} logikai egységet
alkotó nyelvi elemeket jelöl a szintaxis leírásában.*

A DQL (Data Query Language, adatlekérdező nyelv) az SQL névadó résznyelve.
Használatával az adatbázisok tábláiban tárolt adatok különböző szempontok és összefüggések
alapján kérdezhetők le. A DQL-ben pontosan megfogalmazhatjuk a megjelenítendő rekordok
és mezők forrásául szolgáló táblákat, vagy táblakapcsolatokat, és feltételekkel
szűrhetjük a rekordokat. A kiválasztott adatokkal statisztikai műveleteket végezhetünk,
vagy egyszerűen megjeleníthetjük őket. Egyes osztályozások DQL-t a DML részének
tekintik, így számos irodalomban nem is találkozunk külön ezzel a résznyelvvel.




Az SQL nyelvben a **SELECT** utasítással valósítható meg a kiválasztás, vetítés,
összekapcsolás és a Descartes-szorzat (bővebben lásd: **12.3 tétel**).



### 12.3 Relációalgebrai műveletek megvalósítása

A relációalgebra műveletei két csoportra oszthatók. Az egyik csoport a matematikai
halmazelmélet halmazműveleteiből áll; ezek azért alkalmazhatók, mert **a formális
relációs modellben a relációt rekordok halmazaként definiáljuk**. A halmazműveletek
közé tartozik az **unió, a metszet, a (halmaz)különbség és a Descartes-szorzat**.
A másik csoport olyan műveletekből áll, amelyeket speciálisan a relációs modellhez
fejlesztettek ki — ilyen többek között a **szelekció, a projekció és az összekapcsolás**.

**A matematikai halmazelmélet műveletei**

Két táblát kompatibilisnek nevezünk, mind az attribútumok száma, mind értéktartománya
– a tárolt adat típusa – azonos. A halmazműveleteket csak kompatibilis táblákon
értelmezzük. Minden értelmezett halmazművelethez legalább két operandus szükséges.
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

A metszet művelete azonos szerkezetű két vagy több reláció között végezhető el.
Az eredmény reláció csak azokat a sorokat tartalmazza, melyek a műveletbe bevont
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
rekordjait tudjuk párosítani az összes lehetséges kombináció előállításával. Ez
is egy bináris (két operandusú) halmazművelet, azonban azoknak a relációknak,
amelyekre alkalmazzuk, nem kell kompatibiliseknek lenniük. A Descartes-szorzatot
általában nem alkalmazzák a gyakorlatban, mert az adathalmaz redundanciáját növeli.

*Descartes-szorzat SQL-ben:*

```sql

  SELECT * FROM table1, table2;

```

**A relációs modellhez kifejlesztett relációalgebrai műveletek**

Az SQL nyelvben a **SELECT** utasítással valósítható meg a kiválasztás, vetítés,
összekapcsolás és a Descartes-szorzat.

**Szelekció (kiválasztás) és projekció (vetítés)**

A kiválasztás (szelekció) és a vetítés (projekció) két teljesen máshogy viselkedő
művelet. A kiválasztás feladata elsősorban az, hogy a reláció mint halmaz elemei
közül emelje ki azokat, amelyek egy megadott logikai feltételt teljesítenek, míg
a vetítés oszlopok (attribútumok) szerint válogat. A SELECT kiértékelését úgy is
felfoghatjuk, mintha előszór vennénk a FROM utáni relációk direkt szorzatát és
aztán azon végeznénk el a kiválasztást vagy a vetítést.

*A kiválasztás általános szintaxisa*
```sql

  SELECT [DISTINCT] *
    FROM <táblanév>
    WHERE <feltétel>;

  <feltétel> ::= logikai kifejezés, amely ha igaz értéked ad vissza, az adott
                 rekord bekerül az eredmény relációba (kiválasztásra kerül)

```
A kiválasztás új relációt hoz létre, a FROM záradékban megadott egy vagy több
relációnak a WHERE záradékban lévő logikai kifejezésnek eleget tévő rekordjaiból.

*A vetítés általános szintaxisa*
```sql

  SELECT [DISTINCT] <oszloplista>
    FROM <táblanév>;

```
A vetítés új relációt hoz létre, a FROM záradékban megadott egy vagy több
reláció meghatározott oszlopaiból.

**Összekapcsolás (illesztés, join)**

A relációs modell lényegéhez tartozik, hogy két tábla között a megegyező attribútumok
létesítenek kapcsolatot. Az összekapcsolás művelete két vagy több relációt kapcsol
össze egy-egy attribútum érték összehasonlításával.

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
  ugyan ez, csak fordítva. A *teljes külső összekapcsolás* (`FULL OUTER JOIN` vagy
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

**Descartes-szorzat**

A Descartes-szorzat művelet olyan halmazművelet, amelynek segítségével két reláció
rekordjait tudjuk párosítani az összes lehetséges kombináció előállításával. Ez
is egy bináris (két operandusú) halmazművelet, azonban azoknak a relációknak,
amelyekre alkalmazzuk, nem kell kompatibiliseknek lenniük. A Descartes-szorzatot
általában nem alkalmazzák a gyakorlatban, mert az adathalmaz redundanciáját növeli.

*Descartes-szorzat SQL-ben:*

```sql

  SELECT * FROM table1, table2;

```

### 12.4 Összesítő (aggregáló) függvények

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


### 12.5 Alkérdések az SQL nyelvben

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


## 13. tétel

*(Jegyzet: 7.1., 7.2., 7.3., 7.4., 7.5. fejezet, 63-66. oldal)*

### 13.1 Az SQL megszorításai

Az aktív elem olyan programrész, amely bizonyos szituációban automatikusan végrehajtódik.
Ez a szituáció lehet egy esemény bekövetkezése, mint például egy adott relációba
való beszúrás, vagy lehet az adatbázisnak olyan megváltozása, amikor egy logikai
értékű feltétel igazzá válik. Az aktív elemek speciális esete a megszorítás. A
megszorítások olyan előírások, korlátozások, amelyekkel megadhatjuk az adatbázis
tartalmára vonatkozó kívánságainkat. Ha ezeket az adatbázisrendszerrel egyszer,
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

### 13.2 Domain-ek, attribútumokra, rekordokra vonatkozó megszorítások

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
elkülönített definícióit, ezeket csak a táblák keretében lehetett létrehozni.
**Több SQL-implementáció a mai napig sem támogatja (pl. MySQL, MariaDB)**.

Értéktartományt a **[CREATE DOMAIN](https://www.postgresql.org/docs/9.1/sql-createdomain.html)**
utasítás segítségével lehet létrehozni (**PostgreSQL**-ben...). Az oszlopok tárolási
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
Értéktartomány módosítása **ALTER DOMAIN**, törlése **DROP DOMAIN** utasítással
lehetséges.

Példa
```sql

  /* Saját adattípus létrehozása */

  CREATE DOMAIN `fizu` AS INT
  DEFAULT 200000
  CHECK (VALUE BETWEEN 200000 AND 500000);

  /* Saját adattípus alkalmazása */

  ALTER TABLE `Dolgozok` ALTER COLUMN `fizetes` fizu(6);

```

**Attribútumokra vonatkozó megszorítások**

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

A felsorolt megkötésekből többnek is létezik táblaszintű változata is. A táblaszintű
megszorítások **mindig az egész táblára vonatkoznak, szerepelhet bennük a tábla egy
vagy több oszlopa**.

* **PRIMARY KEY (oszlop1, oszlop2, ….):** a több oszlopból álló elsődleges kulcsokat
tábla szintű megszorításban kell megadni. Hatására mindig létrejön egy index állomány.

* **UNIQUE (oszlop1, oszlop2, …):** az adott oszlopokban lévő értékek egyediek
lesznek. Hatására index állomány(ok) jön(nek) létre.

* **FOREIGN KEY (oszlop1, oszlop2, …):** az adott oszlopok idegen kulcs-hivatkozást
tartalmaznak a kapcsolótábla kapcsoló oszlopaira, melyekre elsődleges, vagy egyedi
kulcsot kell definiálni. Az oszlopok sorrendje számít.

**Rekordokra vonatkozó (soralapú) megszorítások**

A **CHECK** kulcsszó után tetszőleges feltételt (logikai kifejezést) adhatunk meg,
melyben csak az adott tábla oszlopai szerepelhetnek. Az erre vonatkozó szabályok
megegyeznek a SELECT parancsban használt WHERE záradék lehetséges feltételével.
A feltétel ellenőrzése sor beszúrásakor, vagy az attribútum módosításakor történik.
Egy rekord beszúrása, módosítása csak akkor történik meg, ha a kifejezés értéke
igaz. Ha az eredmény hamis lesz, akkor a feltételt megsértő sorra vonatkozó
beszúrás-, vagy módosításutasítást a rendszer visszautasítja.

A soralapú megszorítás gyakrabban kerül ellenőrzésre, mint az attribútumalapú.
Ugyanis a soralapú megszorítás esetén a feltétel a sor bármely megfelelő
attribútumértékének a megváltozásakor ellenőrzésre kerül, míg az attribútumalapúnál
csak az adott attribútum értékének megváltozásakor történik vizsgálat.

Egy tábla módosításakor a definiált kulcsfeltételek automatikusan ellenőrzésre
kerülnek. **PRIMARY KEY** és **UNIQUE** esetén ez azt jelenti, hogy a rendszer nem
enged olyan módosítást illetve új sor felvételét, amely egy már meglévő kulccsal
ütközne.

**REFERENCES** (külső kulcs hivatkozás) esetén a következő idegenkulcs-megszorítások
megadásával szabályozhatjuk a rendszer viselkedését:
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


### 13.3 Általános vagy önálló megszorítások (assertions)

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

### 13.4 Triggerek

Az aktív elemek másik speciális esete a trigger. A trigger olyan eljárást definiál
mely automatikusan lefut, ha egy tábla módosul (ideiglenes táblákhoz és nézetekhez
nem társítható trigger). A triggereket az **INSERT, UPDATE, DELETE parancsok végrehajtása
előtt, után vagy helyett (utóbbit nem minden SQL megvalósítás támogatja) hívja meg
a rendszer**. A trigger vagy engedélyezheti vagy elvetheti az adott táblán történt
módosításokat, naplózási feladatokat végezhet, járulékos módosításokat hajthat
végre az adatbázisban.

Egy táblához parancsonként csak egy trigger rendelhető hozzá, vagyis, **egy táblához
legfeljebb három trigger készíthető el (INSERT, UPDATE, DELETE)**. Lehetőség van arra
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


## 14. tétel

*(Előadás + összeállított források)*

### Adatbázis-kapcsolati rétegek feladata, típusai (ODBC, OLE DB, DAO, PDO)

Az SQL alapú adatbázis kezelést megvalósító alkalmazások egyik lehetséges csoportját
a hívásszintű interfész – Call-Level Interface, SQL/CLI, amelyet az [ISO/IEC 9075-3:2016](https://www.iso.org/standard/63475.html) szabvány ír le – alapú
alkalmazások alkotják, melynek fő jellemzője, hogy a gazdanyelvi programba a gazdanyelv
szabályait teljesítő formalizmussal adatbázis-kezelő függvényhívásokat illeszthetünk
be. Itt nem szabvány SQL utasítások formájában hajtódik végre az adatkezelés, hanem
a gazdanyelv függvényhívásian keresztül. Természetesen az adatbázis-kezelő rendszer
felé kiadott relációs algebrán alapuló utasítások továbbra is SQL utasítások lesznek,
csak más formalizmusban, más előkészítési lépéseken keresztül hajtódnak végre.

A CLI lényegében egy olyan alkalmazásprogramozási felület vagy alkalmazásprogramozási
interfész (Application Programming Interface, API), amely egy adatbázis-független
adathozzáférési absztrakciós réteget alkot, mely az alkalmazások számára egységes
elérést biztosít és elrejti előlük a különböző adatbázis-rendszerekhez való
hozzáférés sajátosságait.

A CLI a gazdanyelv szintaktikájához idomul, az eljárások, függvények hívása a gazdanyelvi
környezetben történik, ahol a tulajdonképpeni SQL utasítás, mint paraméter kerül
átadásra. Az SQL-kapcsolat definiálása is függvénnyel történik.

**ODBC (Open Database Connectivity)**

Az ODBC (Open DataBase Connectivity, Nyílt adatbázis kapcsolat) a Microsoft korai,
programozási nyelvtől független megoldása az adatbázis független adatelérésnek.
A magja szabványos, vagyis lényegében megfelel a hívásszintű interfészt (Call-Level
Interface) leíró [ISO/IEC 9075-3:2016](https://www.iso.org/standard/63475.html)
specifikációnak (röviden SQL/CLI).

Az ODBC egy C nyelven alapuló interfészt ad, mely egységes felületet biztosít az
adatbázisokhoz a következő területeken:
* Csatlakozás és bejelentkezés,
* Adattípus és adatábrázolás,
* Hibakódok,
* SQL parancsok.

Minden adatbázishoz szükséges saját ODBC-meghajtó

**PDO (PHP Data Objects)**

A PHP Adat Objektum kiterjesztése egy pehelysúlyú, következetes programozási felületet
kínál a különféle adatbázisokhoz való hozzáféréshez a PHP kódból. Minden adatbázis-meghajtó,
amely implementálja a PDO interfészt, képes adatbázis-specifikus funkciók szabályos
függvényként való végrehajtására. Megjegyzendő, hogy **önmagában a PDO használatával nem
lehet bármilyen adatbázis-funkciót végrehajtani; az adatbázis szerverhez való hozzáféréshez
a megfelelő adatbázis-specifikus PDO-meghajtó használata is szükséges**.

A PDO egy adatbázis-független adathozzáférési absztrakciós réteget biztosít, ami
azt jelenti, hogy ugyanazokat a függvényeket lehet alkalmazni, függetlenül attól,
hogy milyen adatbázisból kérünk le adatokat. A PDO nem egy új adatbázis-absztrakciót
kínál, nem írja újra az SQL-t vagy emulálja az esetleg hiányzó funkcióit. (Forrás:
[PHP Kézikönyv](https://www.php.net/manual/en/intro.pdo.php))

A PDO számos driverrel rendelkezik, melyek közül a legismertebbek a PostgreSQL,
Oracle, MS SQL, SQLite és a MySQL. Az ezzel készített PHP-s alkalmazások mögött
könnyedén – a kód jelentős módosítása nélkül – cserélhető az adatbázis rendszer.


### Jegyzetek:
* <span id="note1">[[1]](#1)</span> Jegyzet alatt dr. Katona Endre: [Adatbázisok](https://www.inf.u-szeged.hu/sites/default/files/db-ea1.pdf) című
könyve értendő.
* <span id="note2">[[2]](#2)</span> Michael J. Hernandez: Adatbázis-tervezés, 31. o.
* <span id="note3">[[3]](#3)</span> dr. Halassy Béla: [Az adatbázistervezés alapjai és titkai](http://mek.oszk.hu/11100/11123/11123.pdf), 33. o.
* <span id="note4">[[4]](#4)</span> dr. Halassy Béla:
[Adatmodellezés](http://mek.oszk.hu/11100/11144/11144.pdf), 29-30. o.
* <span id="note5">[[5]](#5)</span> Szabó Bálint: [Adatbázis fejlesztés és üzemeltetés I.](https://mek.oszk.hu/14400/14432/pdf/14432.pdf), 138-140. o.
* <span id="note6">[[6]](#6)</span> John L. Viescas, Michael J. Hernandez: [SQL-Iekérdezések földi halandóknak](http://dev.logisztika.bme.hu/logdb/irodalom/SQL.lekerdezesek.foldi.halandoknak.2009.eBOOk-digIT.pdf), 9., 485. o.

[Kezdőlap](README.md)
