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
Azonban az adatmodell nem pusztán struktúra, hanem a típusok és az
azokra vonatkozó korlátok szervezett együttese.”*<sup id="4">[[4]](#note4)</sup>

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

![Imgur](https://i.imgur.com/Wpes4XX.jpg)

A valós világ jelenségeit egyedekkel, tulajdonságokkal és kapcsolatokkal leíró
modellt egyed-kapcsolat modellnek, az ezt ábrázoló diagramot egyed-kapcsolat
diagramnak nevezik. Rövidítve az E-K modell és E-K diagram, illetve az angol
entity-relationship model elnevezés alapján az E-R modell és az E-R diagram
elnevezések használatosak.

**Egyed (entitás, entity):** egy a valós világban létező dolog, amit a tulajdonságai
(attribútumai) segítségével lehet leírni, azonosítani. Másképpen: *önálló lényeggel
bíró dolog, amelyről ismereteket közlünk*<sup id="3">[[3]](#note3)</sup>. Az E-K
diagramban téglalappal jelöljük, amelybe beírjuk a nevét.

**Gyenge egyed:** olyan egyed, amelynek attribútumhalmazából nem tudunk kijelölni
kulcsot ezért kapcsolatai és nem a tulajdonságai határozzák meg. Dupla-vonalas
téglalappal jelöljük.

**Kapcsolat:** két vagy több egyed között határoz meg relációt. Rekurzív kapcsolat
esetén az egyed önmagával van relációban. Az E-K diagramban rombusszal jelöljük
amelybe beleírjuk a kapcsolat nevét.

**Kulcs:** azt a legszűkebb attribútumhalmazt, amely egyértelműen azonosítja az
egyedet kulcsnak nevezzük. A kulcsban szereplő attribútumok nevét aláhúzással
jelöljük. Egy kulcs lehet:
* egyszerű (egyetlen attribútumból álló)
* összetett (több attribútumból álló).

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

![Imgur](https://i.imgur.com/Wpes4XX.jpg)

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

Egy kapcsolat lehet **két egyed közötti (bináris) vagy sokágú (kettőnél több egyed
közötti)** kapcsolat. Utóbbi elég ritkán fordul elő és szükség esetén visszavezethető
több bináris kapcsolatra, vagy helyettesíthető gyenge entitással.

A bináris kapcsolatoknak három típusa van:

* 1:1 (egy az egyhez) kapcsolat esetén minden egyes egyedhez pontosan egy másik
egyed tartozik. Ennek jelölésmódja az, hogy a kapcsolatot úgy kötjük az egyedekhez,
hogy minden egyed felé mutat nyíl.

* 1:N (egy a sokhoz) kapcsolat esetén az egyik egyedhez több másik egyedet tudunk
társítani, de a másik csoport minden egyes példányához pontosan egyet társítunk.
A nyilat úgy rajzoljuk, hogy az „1-es reláció felé” mutasson.

* N:M (sok a sokhoz) kapcsolat esetén mindkét típusú egyedhez tetszőleges számú
másik típusú egyed tartozhat. N:M típusú és sokágú kapcsolat mindig helyettesíthető
gyenge entitással és több bináris kapcsolattal.

![Imgur](https://i.imgur.com/xiw6XLQ.jpg)

A kapcsolat típusa lényeges az E-K modell szempontjából, ezért azt az E-K diagramon
is jelölni szokták (nyilakkal, vagy „varjúlábakkal”).

### 2.4 Speciális kapcsolat típusok

![Imgur](https://i.imgur.com/Jv8zwTB.jpg)


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

### 10.3 Adatdefiníciós utasítások (DDL)

### 10.4 Relációsémák, indexek

### 10.5 Hivatkozástípusok relációsémák definiálásakor

## 11. tétel

*(Jegyzet: 6.4., 6.7. fejezet, 53-54., 61-62. oldal)*

### 11.1 Az SQL nyelv általános jellemzői

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

### 11.3 Adatmanipulációs utasítások (DML), adattábla aktualizálása


## 12. tétel

*(Jegyzet: 6.5., 6-6. fejezet, 54-60. oldal)*

### 12.1 Az SQL nyelv általános jellemzői

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
* <span id="note4">[[4]](#4)</span> dr. Halassy Béla:
[Adatmodellezés](http://mek.oszk.hu/11100/11144/11144.pdf), 29-30. o.

