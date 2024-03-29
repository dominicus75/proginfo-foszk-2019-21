[Kezdőlap](../README.md)

# Szoftvertechnológia tételsor

## 1. Ismertesse a tevékenység hálót és sávdiagramot (ábra szükséges mindkettőhöz). Mi a Kritikus út, és mi a jelentősége?

### Történeti áttekintés

Bár a ma ismert projekttervezési és irányítási technikák csak a XX. században születtek
meg, a problémák, amelyekre választ kerestek, szinte egyidősek a civilizációval. A
történelem nagy vállalkozásai (piramisok, a kínai nagy fal, a középkori katedrálisok,
stb.) nem születhettek volna meg a munka valamilyen ütemezése nélkül. Ugyanez igaz
az emberiség kezdetektől legkedveltebb időtöltésére, a háborúra is. [Szun-ce](https://hu.wikipedia.org/wiki/Szun-ce)
(kínai hadvezér, Kr. e 544-470) mondja: „*irányítsuk a sereget alapos számítások és
jó tervek szerint, de ugyanakkor tetteinket senki át ne tekinthesse”* (A hadviselés
törvényei, 11. fejezet).

A XX. századig a projektek tervezése és irányítása nem számított önálló szakterületnek
és több köze volt egy-egy vezető (mérnök vagy hadvezér) szervezőképességéhez, tehetségéhez,
tapasztalatához, mint bármiféle tudományosan megalapozott módszertanhoz. A tervezési
eszközök az 1900 évek elején kezdtek formalizált alakot ölteni. Ekkortól kezdték
összegyűjteni és tudományos módszerekkel rendszerezni azokat az évezredek óta alkalmazott
informális eljárásokat és újabb technikákat, melyek ma a projektmenedzsment alapjainak
tekinthetők.

A szakterület egyik úttörőjének tekintett [Frederick Winslow Taylor](https://hu.wikipedia.org/wiki/Frederick_Winslow_Taylor)
(amerikai mérnök, 1856–1915) például egy pennsylvaniai acélműben rájött, hogy a
munkások által végzett feladatok részekre bontásával és mérésével növelhető a hatékonyság.
Az ő munkatársa volt [Henry Laurence Gantt](https://en.wikipedia.org/wiki/Henry_Gantt)
(gépészmérnök és vezetési tanácsadó, 1861–1919), a hadihajók építésének
folyamatát feladatokra bontotta, az egyes feladatok végrehajtását pedig mérte és
grafikonokkal dokumentálta. Még 1896-ban [Karol Adamiecki](https://en.wikipedia.org/wiki/Karol_Adamiecki)
lengyel mérnök, közgazdász kifejlesztette az általa harmonogram-nak nevezett diagramot,
ami manapság Gantt-diagram néven ismert. Adamiecki nem publikálta diagramját csak 1931-ben,
akkor is kizárólag lengyelül. Ezért viseli Henry Gantt nevét, aki 1910-1915 között
fejlesztette ki a saját harmonogram-verzióját, amit nyugaton el is terjesztett. A
koncepció később alkalmazást nyert a számítástechnikában is. A Gantt-diagram egy
olyan grafikus ütemterv, mely a tevékenységek tervezett lefolyását időskála mentén
mutatja be. Ennek segítségével nyomon lehet követni a munka előrehaladását (terv
szerint, késésben), ma is fontos eszköze a projektmenedzsmentnek, a mai hálós
technikák előfutárának tekinthető.

A projektek tervezését a XX. század fordulójától kezdve szinte kizárólag az ún.
*tradicionális technikák* uralták (*Gantt-diagram*, *mérföldkődiagram*, *ciklogram*,
*Line of Balance eljárás [LOB]*), melyek egyszerű, jól áttekinthető információt
szolgáltattak a tervezett megvalósulásról, viszont módosításuk nehézkes volt. Ezért
a 30-as évektől kezdve a projekt belső összefüggéseit megjelenítő, könnyebben és
egyszerűbben módosítható technikák után kezdtek kutatni. A kutatást később a hidegháború
is nagyban ösztönözte. Az amerikai rakétaprogram ugyanis az 1950-es években jelentős
lemaradásban volt a szovjetekkel szemben, így nemzetbiztonsági kérdéssé vált, hogy
az USA minél előbb képessé váljon tengeralattjáróról indítható ballisztikus rakétát
előállítani (1955 szeptemberében az oroszok már indítottak ballisztikus rakétát egy
felszínen tartózkodó tengeralattjáróról, 1959-es rendszerbe állításakor ez volt a
világ első ilyen jellegű fegyverrendszere).

A Polaris projekt (melyen ezernél is több alvállalkozó és beszállító dolgozott) során
fejlesztette ki 1958-ban a Booz Allan Hamilton Inc. tanácsadó cég a projektek
tervezésére és ütemezésére használt első tudományos modellt, az ún. PERT-modellt
(Program Evaluation and Review Technique – program kiértékelési és felülvizsgálati
technika). Ezzel a módszerrel a projekt 5 éves határidejét 3 és fél évre sikerült
lefaragni. 1957. május 7-én a Du Pont vállalat és a Remington Rand Kutatóintézet létrehozta a
CPM-projektet, Morgan R. Walker (Du Pont) és James Elliot Kelly (matematikus, Remington
Rand) vezetésével. *„Innen datálódik a projektmenedzsment mint önálló tudományterület
és önálló eszköztárral rendelkező szakma elismerése is.”* (dr. Hajdú Miklós)

1969-ben megalakult a Project Management Institute (PMI). Az intézet alapötlete az
a felismerés volt, hogy *a projektmenedzsment-eszközök és technikák közösek még az
olyan egymástól távol álló területek között is, mint a szoftverfejlesztés vagy az
építőipar*.

### A Gantt-diagramm

A Gantt-diagramm lényegében egy sávdiagram, ahol a vízszintes (X) tengelyen az időt,
míg a függőleges (Y) tengelyen az egyes tevékenységeket tüntetjük fel. A projekt
egyes tevékenységeit egy-egy vízszintesen elhelyezkedő oszloppal vagy sávval jeleníti
meg az időtervben. A diagram kialakításától függően az oszlopok, egy időskála alatt
vagy fölött helyezkednek el és azok hossza arányos a tevékenységek tervezett teljesítési
idejével. A diagram baloldalán található a tevékenységek fölsorolása.

Adott folyamat modellezésének főbb lépései a következők:
* a feladat építőelemeinek, azaz az egyes tevékenységek felsorolása azok számbavétele,
* a tevékenységek közötti logikai-függőségi kapcsolatok megállapítása,
* az egyes tevékenységekhez tartozó idő- és erőforrás - hozzárendelés elvégzése,
* a Gantt-diagram megrajzolása.

A diagram a tevékenységek közötti logikai-függőségi kapcsolatokat a következőkben jelöli:
* Ha **a tevékenységi oszlopok egymás mellett vannak**, akkor ez azt jelenti, hogy
az időben előbb (sorban följebb) lévő tevékenységet be kell fejezni ahhoz, hogy
a követő tevékenység megkezdhető legyen.
* Ha **a tevékenységi oszlopok egymás alatt vagy fölött találhatóak**, akkor ez azt
jelzi, hogy az adott tevékenységek párhuzamosan végezhetők.
* Ha **két tevékenységi oszlop átfedésben van**, akkor ez azt fejezi ki, hogy az
időben előbb kezdődő tevékenységet nem kell teljesen befejezni ahhoz, hogy az azt
követő tevékenység teljesítése megkezdhető legyen. Ez az úgynevezett pozitív átfedés.
* **Két tevékenységi oszlop közötti távolság** (oszlop nélküli rész) utal a várakozás
mértékére, a késleltetésre vagy az úgynevezett negatív átfedésre.

![gantt](https://upload.wikimedia.org/wikipedia/commons/9/9e/Gantt_chart_example.png)

A megszerkesztett diagram információ-tartalma a következőkről tájékoztat:
* a végrehajtáshoz szükséges tevékenységekről,
* az egyes tevékenységek kezdési és befejezési időpontjairól,
* a tevékenységekhez tartozó idő- és erőforrás értékekről,
* a projektfeladat átfutási idejéről (arra az esetre, ha valamennyi kritikus műveletet
sikerül a becsült időtartam alatt megvalósítani).

A Gantt-diagramm  népszerűségét szemléletességének köszönheti. Kisméretű projekt
esetén ideális az ütemezés szemléltetésére. Több száz tevékenységből álló bonyolult
projekteknél azonban elveszti egyszerűségét és követhetetlenné, átláthatatlanná válik.

### A tevékenységi háló fogalma

A hálódiagram egy olyan folyamatábra, amely egy komplex folyamat (projekt) véges
számú elemi részekre bontott munkatervét jeleníti meg grafikusan. Másképpen kifejezve,
egy speciális gráf, amely:
* véges elemből áll (egy kezdő és egy végponttal)
* irányított
* hurokmentes (nincsenek benne ciklusok)
* a tevékenységek csomópontban is összefuthatnak, illetve csomópontból is indulhatnak
* összefüggő.

A hálódiagramokat többféleképpen lehet csoportosítani, attól függően, hogy egy adott
háló milyen szempontokat helyez előtérbe, mit akarunk vele hangsúlyozni. A **logikai
háló** az egyes tevékenységek közötti logikai-függőségi kapcsolatokat jeleníti meg,
míg egy **technikai háló** számszerű adatokat is tartalmaz (idő és erőforrás igény).
Az alkalmazott gráf típusa szerint léteznek **eseményorientált/tevékenységélű hálók**
(CPM, PERT), ahol a gráfok csúcsai/csomópontjai eseményeket jelképeznek, az élek pedig
tevékenységeket; illetve **tevékenységorientált hálók** (MPM), itt a gráf csúcsaiban
találjuk a tevékenységeket, míg az élek az eseményeket jelenítik meg. Meghatározottság
szerint megkülönböztetünk **determinisztikus** (CPM, MPM – a megvalósulás ideje
meghatározott), és **sztochasztikus** (PERT – a véletlen hatását is számításba veszi,
a megvalósulási időt egy adott valószínűségi eloszlásfüggvény írja le) hálókat.

### A hálótervezés folyamata

#### 1. 1. Logikai tervezés

**Minden összetett feladat lebontható elemi lépésekre, feladatokra (tevékenységekre),
amelyek aztán logikai hálóba rendezhetők**. A logikai hálóterv kidolgozásának alapja
a tevékenységek folyamatszintű és teljes körű ismerete.

Az egyes tevékenységek a következő tulajdonságokkal jellemezhetők:
* időigény
* erőforrásigény (anyag és munkaerő)
* megelőző tevékenység (vagy ennek hiánya: kezdet)
* vele párhuzamosan végezhető tevékenység
* következő tevékenység (vagy ennek hiánya: vég).

A tevékenységeket célszerű tevékenységjegyzékbe foglalni, amely a felsorolt tulajdonságokat
(különös tekintettel az időadatokra, a megelőző és következő tevékenységekre) is
tartalmazza. A tevékenységek közötti logikai-függőségi kapcsolatok meghatározása
érdekében ki kell deríteni, hogy 
1. milyen megelőző tevékenységeket kell befejezni, adott tevékenység megkezdése előtt;
2. milyen tevékenységeket lehet vele párhuzamosan végezni;
3. milyen következő tevékenységeket lehet elkezdeni adott tevékenység befejezése után.

A tevékenységek azonosíthatósága érdekében minden tevékenységet egyedi azonosítóval
(pl. egy számpárral, szám-betű kombinációval) kell ellátni, különben a párhuzamosan
teljesíthető tevékenységek megkülönbözhetetlenné válnak a diagramban. A tevékenységjegyzék
alapján elkészíthető a logikai háló.

#### 2. Időtervezés

Az időtervezés a következő lépésekből áll:
* a projekt kezdési és befejezési időpontjának meghatározása,
* a tevékenységek időbecslése, (legkorábbi és legkésőbbi) kezdési és befejezési időpontjának megállapítása,
* a projekt átfutási idejének meghatározása,
* a kritikus tevékenységek azonosítása, a kritikus út kijelölése,
* az időtartalékok meghatározása.

**Kritikus tevékenység az a tevékenység, melynek csúszása nem megengedhető, a kritikus
út pedig ezen tevékenységek láncolata**. A kritikus úton található tevékenységek ismerete
azért fontos, mert a projekt átfutási idejét ezen tevékenységek összes időigénye
határozza meg.

#### 3. Kapacitás tervezés

Időhöz tartozó kapacitások leírása és összegzése.

#### 4. Költségtervezés

Költségigények felmérése és összegzése.

### Kritikus út módszer (Critical Path Method, CPM)

A különféle sávos diagramokon az egyes részfeladatok (tevékenységek) kezdő-, és
befejező időpontja, valamint az esetlegesen rendelkezésre álló időtartalék jól
nyomon követhető (erre találták ki), viszont az egyes munkafolyamtok közötti függőségi
viszony (főleg szerteágazóbb projekteknél, ahol egymással párhuzamosan is végezhetők
egyes tevékenységek) ábrázolása már nem annyira szemléletes és magától értetődő.
A CPM (Kritikus út metódus) technika 1957-es megjelenése többek között ezt a problémát
igyekezett kiküszöbölni.

A CPM módszer eseményorientált (a gráf csúcsai eseményeket jelölnek, míg élei tevékenységeket),
determinisztikus, tehát akkor alkalmazható, ha a tevékenységek időszükséglete ismert.
Segítségével a projekt teljes átfutási ideje az egyes tevékenységek időszükséglete
és a tevékenységek közötti kapcsolat alapján számítható ki, meghatározva, mely tevékenységek
kritikusak, és melyeknek van tartalékidejük.

Alkalmas bonyolult, nehezen áttekinthető folyamatok szervezésére és irányítására,
melyekről könnyen átlátható képet ad, a feladatok végrehajtásának ütemezését, időbeni
kezelhetőbbé teszi. A kritikus folyamatok kijelölésével (kritikus út – innen a neve)
lehetővé teszi a rendelkezésre álló erőforrások átcsoportosítását oda, ahol az
esetleges elmaradás az egész projekt csúszását okozhatja. A CPM tehát nemcsak a
legrövidebb időtartam meghatározásában és betartásában segít, hanem abban is,
hogy miként lehet a rendelkezésre álló kapacitást optimálisan kihasználni. Mindezeken
felül jól programozható (a Du Pont éppen azért bízta meg anno Morgan Walker mérnököt
azzal, hogy kiderítse, a cég UNIVAC-típusú számítógépe alkalmas-e projekttervezési
feladatokra, ez a kutatás vezetett aztán a CPM-technika kidolgozásához).

A CPM hálóknak három fő építőeleme van: az események, a tevékenységek és a látszattevékenységek.

Az **esemény** a terv meghatározott, pillanatnyi állapotaként értelmezhető, készültségi
foknak is nevezhető (vagy *csomópont*nak, esetleg *mérföldkő*nek). **Valamennyi tevékenységet
egy kezdő- és egy végesemény határol**. Az esemény *mindig egy konkrét időpontot jelöl,
így idő-, és erőforrás igénye nincs*. Az eseményorientált hálók (CPM, PERT) az eseményeket
helyezik a gráf csúcsaiba és általában körrel vagy más síkidommal jelölik. Az eseményeket
számozzuk, a tevékenységet jelölő nyíl mindig a kisebbtől a nagyobb felé mutat, ehhez
balról jobbra, majd fentről lefelé haladva kell elvégezni a számozást, az első esemény
sorszáma 0.

![Imgur](https://imgur.com/J2sUBTS.png)

A **tevékenység** egy munkafolyamatot jelent, ami a terv jól körülhatárolható részfolyamata,
meghatározott kezdő, illetve végállapottal. **A tevékenység mindig időtartamot jelent,
így idő-, és erőforrásigénye is van**. Az eseményorientált hálók (CPM, PERT) a gráf
éleiként, nyílban végződő folyamatos vonallal ábrázolják, ami az egyik eseménytől
a másik eseményig tart.

A **látszattevékenység** két esemény egymásutániságát, logikai kapcsolatát fejezi ki,
**önmaga nem jelent konkrét munkavégzést, ezért időtartam és erőforrás igénye nincs**.
Akkor kell alkalmazni, ha egy esemény bekövetkezésével 2 tevékenység indulhat el,
de mindkettő befejeződése szükséges ahhoz, hogy egy harmadik tevékenység elkezdődhessen.
A látszattevékenység az eseményorientált hálók (CPM, PERT) kiegészítő eleme, nyílban
végződő szaggatott vonallal jelölik.

![Imgur](https://imgur.com/aKjRLMU.png)

A CPM-háló megkötései:
* minden hálótervnek csak egyetlen kezdő-, és végpontja lehet
* csak véges számú eseményt tartalmazhat
* hurokmentesség és irányfolyamatosság
* a tevékenységek (a gráf élei) nem keresztezhetik egymást (ha lehet...)
* a tevékenységeket (a gráf éleit) a határoló események számaival (0-1, 2-3, 4-6,
stb.) vagy külön jellel (A, B, C4, stb.) jelöljük
* él (tevékenység) csak eseményből (csúcs, csomópont) indulhat és csak oda érkezhet
* két egymást követő eseményt két tevékenység nem kapcsolhat össze (ilyenkor
látszattevékenységet kell közbeiktatni)
* minden tevékenységet úgy kell ábrázolni, ahogy az a projekt végrehajtása során
logikai/időrendi sorrendben egymás után vagy egymással párhuzamosan végrehajtandó.

### A hálótervezés bemutatása gyakorlati példán

Az elvégzendő feladat (projekt) a fél órás ebédidő kihasználása úgy, hogy dohányzásra
is maradjon idő. Első lépés a tevékenységjegyzék összeállítása, különös tekintettel
az egyes tevékenységek időszükségletére és függőségeire (megelőző tevékenységek,
amelyek befejezése előfeltétele az adott tevékenység megkezdésének). A függőségekből
megállapítható az is, mely tevékenységek végezhetők egyidejűleg, párhuzamosan.

| Tevékenység jele | Megnevezés | Időszükséglet (perc) | Függőségek |
|------------------|------------|----------------------|------------|
| A | Kávéfőzés | 6 perc | –  |
| B | Főétel melegítése | 4 perc | – | 
| C | Főétel elfogyasztása | 10 perc | B | 
| D | Gyümölcs elfogyasztása | 3 perc | – | 
| E | Kávé elfogyasztása |  1 perc | A | 
| F | Mosogatás | 5 perc | C, D, E | 
| G | Elcsomagolás | 3 perc | F |
| H | Heveny dohányzás |  5 perc | G |

A fenti tevékenységlistából az derül ki, hogy **A**, **B**, és **D** tevékenységeknek
nincsenek függőségeik, ellenben más tevékenységek tőlük függnek. Ezért elvégzésük
lehet akár párhuzamos is, de be kell fejeződniük a tőlük függő tevékenységek elkezdése
előtt. Ezt szem előtt tartva a tevékenységi háló a következőképpen fog kinézni:

![Imgur](https://imgur.com/aYDHJcS.png)

A projekt tehát **A**, **B** és **D** tevékenységek párhuzamosításával éppen 30
perc (a rendelkezésre álló idő) alatt kivitelezhető. A kritikus út: 1, 4, 5, 6, 7,
8, 9. 1 és 4 esemény között **A** tevékenységnek nincs tartalékideje, viszont **B**
és **D** tevékenységnek van.

## 2. Ismertesse és hasonlítsa össze a vízesés és a V modelleket.

[Ian Sommerville](https://hu.wikipedia.org/wiki/Ian_Sommerville) meghatározása szerint *„a szoftverfolyamat tevékenységek és kapcsolódó
eredmények sora, amelyek egy szoftvertermék előállításához vezetnek”*<sup id="1">[[1]](#note1)</sup>.
Számos különböző szoftverfolyamat létezik, vannak azonban olyan általános feladatok,
alapvető tevékenységek, amelyek minden szoftverfolyamatban közösek. Sommerville
négy ilyen tevékenységet sorol fel:<sup id="2">[[2]](#note2)</sup>
* **Szoftverspecifikáció**: Itt kell meghatároznunk, hogy milyen szolgáltatásokat
követelünk meg a rendszertől, és hogy a rendszer fejlesztésének és működtetéseinek
milyen megszorításait alkalmazzuk. Ezt a tevékenységet gyakran *követelménytervezésnek*
is hívják, amely a követelménydokumentum előállítását eredményezi.
* **Szoftvertervezés és implementáció**: Az implementáció nem más, mint a rendszerspecifikáció
futtatható rendszerré történő konvertálása. Ez magában foglalja a szoftver tervezését
és a programozást. A tervezési folyamat általános modellje:
	* *Architekturális tervezés*: a rendszert felépítő alrendszereket és a köztük
	lévő kapcsolatokat 	azonosítja és dokumentálja.
	* *Absztrakt specifikáció*: az alrendszerek szolgáltatásainak absztrakt specifikációjának
	megadása és azok a megszorítások, amelyek mellett a szolgáltatások működnek.
	* *Interfész tervezése*: az alrendszerek interfészeinek megtervezése és dokumentálása
	* *Komponens tervezése*: A szolgáltatásokat el kell helyezi a különböző komponensekben
	és meg kell tervezni az interfészeket.
	* *Adatszerkezet tervezése*: Meg kell határozni és részletesen meg kell tervezni
	a rendszer implementációjában használat adatszerkezeteket.
	* *Algoritmus tervezése*: Meg kell tervezni és pontosan meg kell határozni a
	szolgáltatásokhoz 	szükséges algoritmusokat.
* **Szoftvervalidáció**: célja: hogy megmutassa, a rendszer egyezik saját specifikációjával,
és hogy a rendszer megfelel a rendszert megvásárló ügyfél elvárásainak. A validációnál
két fő technikát használnak: a szoftverátvizsgálásokat és a tesztelést. 
* **Szovftverevolúció**: A nagy és összetett rendszerek hosszú élettartamúak. Ezalatt
egyrészt korrigálni kell az eredeti rendszer követelményeinek hibáit, másrészt a
felmerülő új követelményeket is bele kell építeni. A szoftvert úgy kell alakítani,
hogy a megrendelő által kért változtatásoknak minél könnyebben eleget tudjunk tenni.

**A szoftverfolyamat modellje a szoftverfolyamat absztrakt reprezentációja**. Minden
egyes modell különböző speciális nézőpontból reprezentál egy folyamatot, de ily
módon csak részleges információval szolgálhat arról. Ezek az általános modellek
nem a szoftverfolyamat pontos, végleges leírásai, hanem valójában inkább hasznos
absztrakciók, amelyet a szoftverfejlesztés különböző megközelítési módjainak
megértéséhez használhatunk. A modellek feladata, hogy meghatározzák, hogy a
szoftver életciklus egyes lépései milyen sorrendben követik egymást, milyen dokumentumokat,
szoftver termékeket kell előállítani és hogyan.

A szoftverfejlesztési gyakorlatban leginkább három általános modell terjedt el széles
körben:
* **Vízesésmodell**, mely a folyamat alapvető tevékenységeit a folyamat különálló
fázisainak tekinti.
* **Evolúciós vagy iteratív fejlesztés**, amely összefésüli a specifikáció, a fejlesztés
és a validáció tevékenységeit. A kezdeti, nem teljes specifikációból gyorsan kifejleszthető
egy kezdeti szoftververzió. A továbbiakban ezt a kezdeti verziót kell a megrendelő
újabb követelményeinek megfelelően, több egymást követő fordulóban úgy finomítani,
hogy az kielégítse az ügyfél kívánságait.
* **Komponens alapú fejlesztés** az újrafelhasználható komponensek felhasználásán
alapul. A szoftverfolyamat ezeknek a komponenseknek rendszerré történő integrációjára
összpontosít ahelyett, hogy kifejlesszék ki azokat.

Egy fejlesztési projekt során nem kizárólagos a használatuk, gyakran váltják egymást
az alkalmazott modellek. Egy komplex és összetett rendszer alrendszereit
különböző folyamatmodellek alapján is kifejleszthetik.

### A vízesés modell

A szoftverfejlesztés történetének első publikált modellje, amely más tervezői modellekből
származik. A vízesés modelljének első hivatalos leírását gyakran [Winston W. Royce](https://en.wikipedia.org/wiki/Winston_W._Royce)
1970-es [cikkeként](http://www-scf.usc.edu/~csci201/lectures/Lecture11/royce1970.pdf) idézik,
bár Royce konkrétan nem alkalmazta a *vízesés* kifejezést a publikációjában. A *„vízesés”*
kifejezés legkorábbi használata Bell és Thayer 1976. évi tanulmányában található. 1985-ben az
Egyesült Államok Védelmi Minisztériuma fogalmazta meg ezt a megközelítést a *DOD-STD-2167A*
szabványban, amely a szoftverfejlesztési vállalkozókkal való együttműködésre vonatkozott,
és kimondta, hogy *„a vállalkozónak olyan szoftverfejlesztési ciklust kell implementálnia,
amely a következő hat fázist tartalmazza: szoftverkövetelmény-elemzés, előzetes
tervezés, részletes tervezés, kódolás és egységtesztelés, integráció és tesztelés”*.

A vízesésmodell egy szekvenciális fejlesztési modell, amely jól elkülönülő lépésekre
osztja a rendszertervezés egymás utáni lépcsőit (innen származik az elnevezés, bár az
eredeti publikációban még nem így nevezték). Ez a megközelítés alapvetően arra az
alapgondolatra támaszkodott, hogy a projektek egyértelműen körülhatárolhatóak és
kiszámíthatóak, hiszen egymásra épülő, lineáris lépéssorozatok alkotják őket. Ezeknek
köszönhetően részletekbe menően, egyszerűen tervezhetőek, és a megvalósítás során
nem igényelnek nagymértékű változtatást. 

A modell fontos szabálya, hogy a következő fázis addig nem indulhat el, amíg az előző
be nem fejeződött. A gyakorlatban persze ezek a szakaszok kissé átfedhetik egymást.
Maga a szoftverfolyamat nem egyszerű lineáris modell, hanem a fejlesztési tevékenységek
iterációjának sorozata. Ez a vízesésmodellnél a visszacsatolásokban jelenik meg (
az ábrán világoskék nyílakkal jelölve). A vízesésmodell a szoftverfejlesztési folyamat
alapvető tevékenységeit a következő egymást követő fejlesztési fázisokkal reprezentálja:

![Imgur](https://imgur.com/tEHA3JK.png)

1. **Követelményelemzés és meghatározás**: a fejlesztendő rendszer céljai, funkciói
és megszorításai a rendszer megrendelőivel és felhasználóival történő konzultációk
alapján kerülnek feltárásra. Ezeket részletesen kifejtve határozzák meg a részletes
rendszer specifikációt.
2. **Rendszer és szoftvertervezés**: a rendszer tervezési folyamatában válnak szét
a hardver és a szoftver követelmények. Ebben a fázisban kell kialakítani a rendszer
átfogó architektúráját a funkcionális követelményeknek megfelelően. A szoftver
tervezése az alapvető szoftverkomponensek, illetve a közöttük levő kapcsolatok
azonosítását és leírását foglalja magában.
3. **Implementáció és egységteszt**: ebben a szakaszban a szoftver komponensek
implementációja és egységtesztelése történik. Az egységteszt azt ellenőrzi, hogy
minden egyes komponens megfelel-e a specifikációjának.
4. **Integráció és rendszerteszt**: ebben a fázisban kerül sor a szoftver komponensek
integrálására és teljes rendszer tesztelésére abból a célból, hogy a rendszer megfelel-e
követelményeknek. A tesztelés után a szoftverrendszer átadható az ügyfélnek.
5. **Működtetés és karbantartás**: általában (bár nem szükségszerűen) ez a szoftver
életciklusának leghosszabb fázisa. Megtörtént a rendszertelepítés és megtörtént a
rendszer gyakorlati használatbavétele. A karbantartásba beletartozik az olyan hibák
kijavítása, amelyekre nem derült fény az életciklus korábbi szakaszaiban, a rendszeregységek
implementációjának továbbfejlesztése, valamint a rendszer szolgáltatásainak továbbfejlesztése
a felmerülő új követelményeknek megfelelően.

A vízesésmodell egy strukturált megközelítést biztosít, illetve a modell maga lineárisan
halad előre egy könnyen érthető és magyarázható szakaszon keresztül; ezenkívül könnyen
azonosítható mérföldköveket biztosít a fejlesztési folyamatban. A vízesésmodell olyan
projekteknél lehet alkalmas, ahol a követelmények és az alkalmazási kör rögzítve van,
maga a termék biztosan megvalósítható, és a technológia is érthető. További érv a
vízesésmodell mellett, hogy hangsúlyt fektet a dokumentációra (mint a követelmény-
és tervezési dokumentációk) is, a forráskód megírása mellett.

*A vízesés modell problémái:*

* Lineáris, így nehéz a visszalépés a felmerülő problémák megoldására, és ez jelentősen
megnöveli a javítás költség- és időigényét.
* Az integráció a teljes folyamat végén, egyben, robbanásszeren történik. A korábban
fel nem fedezett hibák ilyenkor hirtelen, együttesen jelennek meg, így felderítésük
és javításuk egyaránt nehezebb feladat.
* A megrendelő csak a folyamat végén láthatja a rendszert, menet közben nincs lehetősége
véleményezni azt.
* A minőség szintén csak a folyamat utolsó fázisában mérhető.
* Minden egyes fázis az előző fázis teljes befejezésére épít, ezzel jelentősen megnő a kockázat.
* A fejlesztés során a követelmények nem módosíthatók, hiszen már az életciklus elején befagyasztjuk őket.
* Már a fejlesztés kezdetén ismernünk kell valamennyi követelményt, azok későbbi
módosítására vagy bővítésére nincs lehetőség.
* Elképzelhető, hogy bár a végtermék megfelel valamennyi specifikációnak, mégsem
működik (pl. mert az elvárásokban vannak ellentmondások).
* Dokumentumvezérelt, és túlzott dokumentálási követelményeket állít fel.
* Az egész szoftvertermék egy időben készül, nincs lehetőség kisebb részekre osztására.

A vízesésmodell legfőbb problémáját a projekt szakaszainak különálló részekké történő
nem flexibilis partícionálása okozza. Egy komplex, bonyolult probléma megoldása nem
végezhető el hatékonyan ezzel a megközelítéssel. A vízesésmodell csak akkor használható
jól, ha már előre jól ismerjük a követelményeket, melyeket részletes és pontos specifikáció
követ.

Az elméleti vízesésmodellel észlelt problémákra válaszul számos módosított vízesésmodellt
vezettek be. A különböző módosított vízesésmodellek (ideértve Royce végső modelljét)
azonban ennek a folyamatnak csekély vagy akár jelentős változásait is tartalmazhatják. 

### A V-modell

A V-modell egy módosított vízesés modellnek tekinthető, ami a nevét onnan kapta,
hogy két szára van és így egy V betűhöz hasonlít. Az egyik szára megegyezik a vízesés
modellel, ez a fejlesztési szár. A másik szára a létrejövő termékek tesztjeit tartalmazza,
ez a tesztelési szár. Míg a tervezési folyamat fentről lefelé halad a diagram bal
oldali ágában, a jobb oldali ágban a tesztelési folyamat lentről felfelé. Az egy
szinten lévő fejlesztési és tesztelési lépések összetartoznak, azaz a tesztelési
lépés a fejlesztési lépés során létrejött dokumentumokat használja, vagy a létrejött
terméket teszteli.  

Ábrázolásánál a szoftverfejlesztési folyamat tervezési és tesztelési tevékenységeit
helyezik előtérbe. Elsődlegesen azt szemlélteti, hogy az ilyen modellt megtestesítő
fejlesztési folyamat során a tesztelési tevékenység végigköveti a teljes fejlesztési
folyamatot. Hasonlóan a vízesés modellhez a fő tevékenységek ebben az esetben is
szekvenciálisan követik egymást, azonban a V-modell lehetővé teszi az egy szinten
elhelyezkedő tevékenységek részben párhuzamos végrehajtását is. A V-modell a vízesés
modell kiegészítése teszteléssel. Ez azt jelenti, hogy először végre kell hajtani
a fejlesztés lépéseit, ezután jönnek a tesztelés lépései. Ha valamelyik teszt hibát
talál, akkor vissza kell menni a megfelelő fejlesztési lépésre. 

A modell két ágában ábrázolt fejlesztési tevékenységek a tesztelési folyamat tevékenységeihez
illeszkednek.

![Imgur](https://imgur.com/IoGancF.png)


<table>
  <tr>
    <th align="left" width="50%"><h3>Fejlesztési ág</h3></th>
    <th align="right" width="50%"><h3>Tesztelési ág</h3></th>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Követelmények meghatározása</dt>
        <dd>
          A követelményelemzési fázisban a rendszer követelményeit a felhasználó(k)
          igényeinek elemzésével gyűjtik össze. Ez a szakasz annak meghatározására
          irányul, hogy miként kell működnie az ideális rendszernek.
		  A követelmény specifikációban jól meghatározott átvételi kritériumokat
		  fogalmaznak meg, amik lehetnek funkcionális és nemfunkcionális igények
		  is. Ez lesz majd az alapja a felhasználói átvételi tesztnek (User Acceptance
		  Test, UAT). Különböző módszereket alkalmaznak a felhasználói követelmények
		  összegyűjtésére. Ilyenek például a felhasználókkal készített interjúk,
		  kérdőívek, dokumentumelemzések, megfigyelések, prototípusok készítése,
		  használati esetek (use case), statikus és dinamikus nézetek használata.
        </dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Felhasználói átvételi tesztelés</dt>
        <dd>A felhasználói elfogadási tesztterveket a követelményelemzés fázisában
        dolgozzák ki. A tesztet a követelmény specifikáció alapján, olyan felhasználói
        környezetben hajtják végre, amely hasonlít a valós termelési környezetre,
        ahol már valósághű adatokat használnak fel. Ez a teszt ellenőrzi, hogy az
        elkészített és leszállított rendszer megfelel-e a felhasználó igényeinek,
        illetve a rendszer már készen áll-e a használatra a mindennapokban.</dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Rendszertervezés</dt>
        <dd>A rendszertervezés az a szakasz, amelyben a rendszermérnökök a felhasználói
        követelményekről szóló dokumentum tanulmányozásával elemzik és megértik a
        javasolt rendszer üzleti tevékenységét. Megtalálják azokat a lehetőségeket
        és technikákat, amelyekkel a felhasználói igények megvalósíthatók. Elkészül
        a szoftver specifikációs dokumentuma, amely konkrét tervként szolgál a
        fejlesztési szakasz számára, tartalmazza az általános rendszer felépítést,
        menüszerkezeteket, adatszerkezeteket stb. Ebben a szakaszban más műszaki
        dokumentáció is készül, például egyed-kapcsolat diagramok, adatszótár. A
        rendszer tesztelésére szolgáló dokumentumok is ekkor készülnek.</dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Rendszerteszt</dt>
        <dd>A rendszertesztelési terveket a rendszer tervezési szakaszában dolgozzák ki.
        A terveket az ügyfél üzleti csapata állítja össze. A rendszerteszt biztosítja,
        hogy a kifejlesztett alkalmazás elvárásai teljesüljenek. A teljes
        alkalmazás funkcionalitását, kölcsönös függőségét és más alkalmazásokkal
        való kommunikációját tesztelik. A rendszer tesztelése azt vizsgálja, hogy
        a funkcionális és nem funkcionális követelmények teljesültek-e. A terheléses
        tesztelés, a teljesítmény teszt, a stressz tesztelés, a regressziós tesztelés
        mind a rendszer tesztelésének a része.</dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Architektúrális tervezés</dt>
        <dd>Az architektúra kiválasztásának alapja az, hogy megvalósítsa mindazt,
        amely jellemzően a modulok listájából, az egyes modulok rövid funkcionalitásából,
        az interfészkapcsolatokból, függőségekből, adatbázis-táblázatokból, architekturális
        diagramokból, technológiai részletekből stb. áll. A architektúrális terv
        a rendszert felépítő alrendszereket és a köztük	lévő kapcsolatokat azonosítja
        és dokumentáljaleírja, leírja, hogy a komponensek hogyan működnek együtt.</dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Integrációs teszt</dt>
        <dd>Az integrációs tesztterveket az architekturális tervezési szakaszban dolgozzák
        ki. Ezek a tesztek azt vizsgálják, hogy az önállóan létrehozott és tesztelt
        egységek nem ütköznek-e és kommunikálni is tudnak egymással. Ezeket a teszteredményeket
        már megosztják az ügyfél csapatával.</dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Komponens tervezés</dt>
        <dd>A tervezett rendszert kisebb egységekre vagy modulokra bontják, és mindegyiket
        részletesen kifejtik, hogy a programozók közvetlenül neki tudjanak kezdeni
        a kód megírásának. Az alacsony szintű tervezési dokumentum vagy programspecifikációk
        tartalmazni fogják a modul részletes funkcionális logikáját, pszeudokódban kifejtve:
        <ul>
			<li>adatbázis-táblázatokat az összes elemmel, beleértve azok típusát és a méretét</li>
			<li>összes interfészt részletes és teljes API-referenciákkal</li>
			<li>összes függőségi kérdést</li>
			<li>hibaüzenetek felsorolását</li>
			<li>teljes bemeneti és kimeneti modulokat.</li>
		</ul>
		Ebben a szakaszban tervezik meg az egységtesztek tesztelésének folyamatát is.</dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Egységteszt</dt>
        <dd>Az egységtesztelési terveket a modul tervezési szakaszában fejlesztik ki.
        Ezeket az egységteszteket még a kódolási vagy egységi (unit) szinten lefuttatják,
        hogy ki tudják küszöbölni a felmerülő hibákat. Az egység a legkisebb entitás,
        amely függetlenül létezhet, ilyen például egy programmodul. Az egységtesztelés
        a forráskód egységeit a kapcsolódó vezérlő adatokkal, a felhasználási-és a
        működtető eljárásokkal együtt teszteli annak meghatározására, hogy azok
        elérik-e kitűzött céljukat. Ellenőrzi, hogy a legkisebb entitás megfelelően
        tud-e működni, ha elkülönül más egységektől. Az egységtesztek általában
        automatizált tesztek, amelyeket a szoftverfejlesztők írnak és futtatnak.</dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td colspan="2" align="center">
      <dl>
        <dt>Implementáció</dt>
        <dd>A rendszerspecifikáció futtatható rendszerré történő konvertálása</dd>
      </dl>
    </td>
  </tr>
</table>


### A két életciklusmodell összehasonlítása

A V-modell a vízesés szoftverfejlesztési modell kiterjesztésének tekinthető. Ugyanazokat
a kapcsolatokat használja a vízesés modellben meghatározott fázisok között. De a
lineáris lejtés helyett a V-modell lépcsőzetesen lefelé halad, majd visszafelé
(kódolási fázis után).

A V-modell hasonlóan a vízesés modellhez nagyon merev, de alkalmazói kevésbé ragaszkodnak
ehhez a merevséghez, mint a vízesés modellnél. Ennek megfelelően jobban elterjedt.
Fő jellemzője a teszt központi szerepe. A vízesés és a V-modell közötti egyik lényeges
különbség az, hogy a vízesés modellben a szoftveres tesztelés a fejlesztési szakasz
befejezése után történik, míg a V-modellben a fejlesztési ciklus minden szakaszának
van egy közvetlenül társított tesztelési fázisa. A V-modell útmutatást nyújt ahhoz,
hogy a tesztelést a lehető legkorábban el kell kezdeni az életciklusban, ezeket a
tevékenységeket a fejlesztéssel párhuzamosan kell elvégezni, és a tesztelőknek együtt
kell működniük a fejlesztőkkel, üzleti-elemzőkkel.

## 3. Ismertesse részletesen a használati eset diagramot és annak elemeit (egy konkrét példa is szükséges).

A követelményspecifikáció, mint dokumentáció egy igazolt tervezést tesz lehetővé.
Azaz, ha egy terv megfelel a dokumentációban megfogalmazott korlátoknak és tulajdonságoknak,
akkor ez a terv a fejlesztési probléma egy elfogadható megoldását adja. A rendszerkövetelmények
felhasználói szintűek, és arról szólnak, hogy milyen feladatokat, és hogyan végez
el a felhasználó a rendszerrel. A rendszerfejlesztés használati eset centrikus; a
használati esetek a teljes fejlesztés során központi szerepet játszanak.

A **használati eset-modell** (*use case model*)<sup id="3">[[3]](#note3)</sup> a rendszer modellezése a felhasználó,
megrendelő szemszögéből. Ez a modell a fejlesztés kezdeti fázisaiban lényegében kialakul,
és végigkíséri a teljes fejlesztést. Tartalmazza a rendszerrel szemben támasztott
felhasználói követelményeket, melyek a következő csoportokba sorolhatók:
* **Felhasználók információs igényei**: kik és mire akarják használni a rendszert
* **Funkcionális rendszerkövetelmények**: a rendszertől várt funkciókat és/vagy
szolgáltatásokat írják le. A szoftverrendszer működésére, a tényleges funkcionalitásra
vonatkozó leírások. A funkcionális követelmények leírása teljes és konzisztens kell,
hogy legyen. A teljesség azt jelenti, hogy a felhasználók által igényelt összes
szolgáltatást tartalmazza. A konzisztencia azt jelenti, hogy egy követelmény sem
lehet ellentmondásban bármely másik követelménnyel.
* **Nem funkcionális követelmények**: a rendszer működését befolyásoló követelmények
és annak funkcióival és szolgáltatásaival kapcsolatos megszorítások. Például időbeli
korlátozások, szabványok, hardver és szoftverkörnyezeti előírások, teljesítménykövetelmények, stb.

A használati eset modell a rendszer felhasználói nézetét szemlélteti. A modell elemei:
* egy vagy több használati eset diagram,
* a diagramokon megjelenő modell elemek megnevezése, rövid, összefoglaló leírása,
amely a fejlesztés korai fázisában kialakul,
* az egyes modell elemek részletes specifikációja, amely a fejlesztés későbbi fázisaiban
bővíti, pontosítja a modellt.

A használati eset modell a feltárt követelmények elemzése alapján készülhet el.

A **használati eset diagram** az üzleti elemzésben használt diagram, amely a modellezni
kívánt jelenség viselkedését felhasználói oldalról megközelítve modellezi, a rendszer
belső szerkezetével nem foglalkozik. Fontos, hogy az üzleti esetek leírása során az
üzleti nyelvet és ne az informatika nyelvét használjuk. Ez a diagram a kommunikációs
elem az ügyfelek és a fejlesztők között. Általában a fejlesztési ciklus elején készítjük.
Használati eset diagram készülhet egy már meglévő rendszerről (hogy a működését jobban
megértsük), vagy egy tervezett rendszerről (hogy összegyűjthessük a rendszerkövetelményeket,
hogy megmutathassuk a megrendelőknek, felhasználóknak illetve, hogy a kész rendszer
teszteléséhez is használhassuk majd).

### A használati eset diagram elemei:
<dl>
	<dt>Aktor</dt>
	<dd>Egy szerepkört reprezentál (személy, csoport, szervezeti egység vagy fizikai
	eszköz, aki vagy ami kapcsolatba lép a rendszerrel). Az aktor a rendszeren kívül
	áll. Használati eseteket indítványozhat, illetve fogadhat, de passzív is lehet.
	Az aktor tehát a felhasználó egy lehetséges szerepkörét jelenti, amelyet betöltve
	lép kapcsolatba a rendszerrel, hogy annak információt szolgáltasson, vagy egy
	szolgáltatását igénybe vegye. Jogosultságot is kifejezhet. Aktor nem csak személy
	lehet, hanem valamilyen külső rendszer, eszköz is. A felhasználó és az aktor
	fogalmak között több-több kapcsolat van:
	<ul>
	<li>Több felhasználó - egy aktor*: sok tényleges felhasználó léphet kapcsolatba
	a rendszerrel ugyanolyan szerepkörben</li>
	<li>Egy felhasználó - több aktor*: ugyanaz a személy több szerepkörben is használhatja
	a rendszert.</li>
	</ul>
	Az aktorok egy meghatározott feladatkört (szerepet, jogosultságot) betöltve lépnek
	kapcsolatba a rendszerrel, csak a konkrét szerepkör birtokában használhatják a
	szoftverrendszert és azok szolgáltatásait. A feladatok végrehajtását kezdeményező
	szereplőket kezdeményező szereplőnek, a funkció, használati eset megvalósításában
	részt vevőket résztvevő szereplőnek hívjuk. Egy használati esetet mindig csak
	egy aktor kezdeményezhet, egy használati eset megvalósításában viszont több aktor
	is részt vehet.	Az aktor szimbóluma egy pálcikaember. A szimbólum alá kell írni
	a szerepkör megnevezését.</dd>
	<dt>Használati eset (use case)</dt>
	<dd>Egy jól meghatározott funkció, elvárt viselkedési minta, melynek végrehajtása
	a rendszer és egy aktor közötti üzenetváltást kíván. A használati eset a rendszer,
	az alrendszer vagy egy osztály által végrehajtott művelet-együttes. Mindig a
	felhasználó/aktor által elvárt feladatmegoldást jelöli, a konkrét felhasználói
	cél elérését rögzíti. A használati eset jele egy ellipszis. Az ellipszisbe, vagy
	az alá kell írni a megnevezését.</dd>
	<dt>Reláció</dt>
	<dd>
		  <dl>
			<dt>Asszociáció (társítási, vagy kommunikációs kapcsolat)</dt>
			<dd>Csak aktor és használati eset között jöhet létre. Azt jelenti, hogy
			az aktor használja a használati esetet (vagy információt kap tőle).
			Jele egy vonal a két elem között. Egyes UML szerkesztők nyilat használnak,
			ami lehetővé teszi, hogy hangsúlyozzuk, hogy az aktor kezdeményező (ekkor
			a nyíl a használati eset felé mutat) vagy információt fogadó (a nyíl az
			aktor felé mutat) viszonyban van a használati esettel.
			
![Imgur](https://imgur.com/SNIAg6Q.png)</dd>
			<dt>Generalizáció (általánosítás, öröklés)</dt>
			<dd>Használati esetek között jelölhető az objektum orientált programozásból
			már ismert általánosítás – pontosítás kapcsolat. Ha A használati eset
			leszármazottja B, akkor azt jelenti, hogy B egy speciális esete A-nak
			(azaz tudja mindazt, amit A, de van néhány speciális, csak rá jellemző
			tulajdonsága). Az aktorok között csak az általánosítás – pontosítás
			kapcsolat lehetséges. Minden más kapcsolat – ha a valóságban létezik is – a
			rendszeren kívüli, ezért a rendszer szempontjából közömbös. A generalizáló
			kapcsolat jele a speciális felől az általános (szülő) felé mutató, háromszögben
			végződő folyamatos vonal.
			
![Imgur](https://imgur.com/8UFwogb.png)</dd>
			<dt>Tartalmazás (include)</dt>
			<dd>A és B használati eset között tartalmazás (include) kapcsolat áll fenn,
			ha az A használati eset végrehajtásakor a B mindig, feltétel nélkül
			végrehajtódik. Az A használati esetnek részét képezi B, esetleg B ismétlődésével
			hajtható végre. A tartalmazott használati eset lehet közvetett kapcsolatban
			egy aktorral, a tartalmazó funkción keresztül, de közvetlen kapcsolatban is
			állhat vele. A tartalmazás kapcsolat jele a tartalmazótól a tartalmazott
			felé mutató, szaggatott vonallal rajzolt nyíl, amelyet az «Include»
			sztereotípiával minősítünk.
			
![Imgur](https://imgur.com/dCirtqj.png)</dd>
			<dt>Kiterjesztés (extend)</dt>
			<dd>A bővítés kapcsolat az jelenti, hogy egy használati eset bizonyos
			esetekben (valamilyen feltétel fennállása esetén) egy másik funkció
			végrehajtását igényli. A bővítő használati eset kiegészíti az alap
			funkciót, vagy valamilyen kivételes esetet kezel. Az ilyen használati
			eset önmagában – önállóan – nem fordulhat elő, és aktorral közvetlenül
			nem lehet kapcsolatban.	A kiterjesztő kapcsolat jele a kiegészítő használati
			eset felől az alap funkció felé mutató szaggatott vonallal rajzolt nyíl,
			amelyet az «Extend» sztereotípiával minősítünk.</dd>
		  </dl>
	</dd>
	<dt>Rendszerhatár (Boundary)</dt>
	<dd>A megvalósítandó rendszer és a szereplők közötti határ. Rajzjele téglalap,
	amelyen kivül az aktorok, belül a használati eseteket jelképező elipszisek
	foglalnak helyet.</dd>
</dl>

### Használati eset diagram elemeinek azonosítása

A használati eset modell a rendszer funkcionális követelményleírásának elemzése
segítségével készíthető el. Első lépésként célszerű az aktorokat azonosítani, mert
az általában könnyebb, és még bonyolult rendszerek esetén sem kell túl sok aktorral
számolnunk. Az aktorok köre már a fejlesztés elején is pontosan meghatározható.
Az aktorokra a feladat leírásában, a funkciólistákban többnyire valamilyen főnévvel
hivatkozunk. Fontos azonban, hogy az aktor
* a rendszeren kívül létező entitás
* a rendszerrel valamilyen funkcionális kapcsolatba kerül.

Az aktorok azonosításának elsődleges célja, hogy megtudjuk, hogy ki vagy mi fog
kapcsolatba kerülni a fejlesztendő rendszerrel. Azonosításukra több lehetőség nyílik.
A felhasználóval folytatott beszélgetések, a felhasználói célokat összefoglaló
dokumentumok alapján körvonalazódik, hogy mik, vagy kik az érdekeltek a rendszer
határán kívül, amik/akik közvetlenül kapcsolatba kerülnek, kommunikálnak a
szoftverrendszerrel. A munkafolyamat végén az egyes aktorokról egy rövid leírást
kell készíteni, hogy mit vár a rendszertől, és egyben mi a felelőssége.

Következő lépés a használati esetek azonosítása. Egy bonyolult rendszer esetén
nagyon sok használati esettel kell foglalkozni, ezért ebben is az inkrementális
megközelítés javasolt. Használati esetekre valamilyen igei szerkezet utalhat a
feladat leírásában, azonban nem olyan közvetlenül, mint az aktorok esetén. A tapasztalatok
szerint egy áttekinthető használati eset diagram legfeljebb tíz-húsz használati esetet
tartalmazhat. A használati eset modellt tehát számos használati eset diagramból kell
felépíteni. Ezt úgy tudjuk elérni, hogy
* a rendszert részrendszerekre bontjuk, és azokat külön-külön modellezzük,
* előbb nagyobb funkcionális egységeket modellezünk egy használati esetként, majd
ezeket részletezve jutunk el a finomabb felbontásig.

A diagram rajzolása során mind az aktoroknak, mind a használati eseteknek nevet kell
adni. Az elnevezések nem csak azonosító szerepet töltenek be, hanem segítenek a diagram
tartalmának megértésében is. Minden további modell típusra is általánosan érvényes
az, hogy az elnevezési kényszer egyben annak ellenőrzése, hogy az adott funkciót,
fogalmat, kapcsolatot – általánosságban minden modell elem jelentését pontosan
megértettük-e. A tapasztalatok alapján elmondható, hogy ha egy modell elemre nem
tudunk rövid, frappáns, kifejező elnevezést találni, annak mindig az az oka, hogy
nem tisztáztuk pontosan az adott elem jelentését és a modellen belül játszott szerepét.

### Egy konkrét példa<sup id="4">[[4]](#note4)</sup>

A HelóVilág c. tévéműsor-folyamban a nézők kukkolhatnak. Ez egyes esetekben spontán
agyeltávolításban végződik. A regisztrált nézők a kukkolás mellett kiszavazásban
is részt vehetnek. Mind a kiszavazás, mind a kukkolás során a rendszer végrehajtja
az agyzsugorítást. A rendszert a készítők is használják: egyfelől besorsolhatnak
idiótákat, másfelől feladatokat adhatnak meg, harmadrészt pedig aktív résztvevői
az agyzsugorításnak. Ha a feladat túl rücskösre sikerül, akkor büntetéssel jár,
ennek mértékét az [NMHH](https://nmhh.hu/) határozza meg.

![Imgur](https://imgur.com/pgaqstz.png)

## 4. Ismertesse az állapotautomatát/állapotgép diagramot (state machine, egy konkrét példa is szükséges).

Minden objektumnak van egy életciklusa. Az objektum létrejön, más objektummal működik
együtt különböző feladatok megoldásában, majd megsemmisül. Az objektum aktív állapotaiban
különböző objektumokkal kerül kapcsolatba, és ennek eredményeként különböző állapotokba
kerül. Az objektum orientált szemlélet szerint egy objektum állapotát az attribútumai
pillanatnyi értékhalmaza határozza meg (konkrét állapot), ez az objektum attribútumai
által felvehető értékek részhalmaza.

Az állapot általában esemény, eseménysorozat hatására jön létre. Ezeket az eseményeket
megelőző eseményeknek (pre-events) nevezzük. Egy speciális, rendszeren kívüli állapot
a kezdeti állapot.

Az állapot időben mindaddig fennmarad, amíg az objektumok attribútumainak értékei
kielégítik az állapothoz rendelt invariánst<sup id="5">[[5]](#note5)</sup>. Az állapot
fennállása során belső átmenetek fordulhatnak elő. Ezek nem változtatják meg az
objektum állapotát, azaz érvényes marad továbbra is az állapotinvariáns. Az állapot
megszűnése egy esemény hatására következik be, melyhez egy eseménysorozat kötődhet
(rákövetkező események, post-events). Azaz az objektum egy külső állapotátmenet
hatására egy másik állapotba kerül.

Az objektum megszűnése ugyancsak egy állapotátmenet hatására következik be. Ekkor
az objektum egy rendszeren kívüli, úgynevezett befejező állapotba kerül.

A **dinamikus modell** három fő részből tevődik össze: az *állapotdiagramokból*, az *állapotok
leírásából* és az *események leírásából*. Az események leírására szolgál a *szekvencia-,
együttműködési és aktivációs diagram*. A szekvencia- és az együttműködési diagram az
objektumok interakcióját határozza meg.

Az osztály objektumainak dinamikus viselkedését a probléma megoldása során az
állapotdiagram írja le. **A diagram egy osztály objektumainak az életciklusuk alatt
felvehető lehetséges állapotait és az állapotok közötti lehetséges átmeneteket ábrázolja**.
Ez a diagramfajta nem az UML találmánya, eredetileg David Harell dolgozta ki, amelyet
az UML beillesztett a saját rendszerébe, az ehhez szükséges módosításokkal és
kiegészítésekkel.

### Az állapotok ábrázolása

Az állapotok egymástól megkülönböztethetők, például van nevük. Az állapotokat gyakran
nehéz megfelelően kifejező névvel ellátni. Ezért gyakran azonosítóként használjuk
a belső tevékenységek, belső műveletek nevét. 

A diagramon két speciális állapot jelenhet meg:
* **kezdőállapot**: ebbe kerül az objektum, amikor létrejön. Ebbe az állapotba nem
vezethet átmenet. Kitöltött körrel jelezzük.
* **végállapot**: az objektum megszűnését jelzi. Ebből az állapotból nem indulhat
ki átmenet. Egy körbe rajzolt ponttal jelöljük.

Az állapot jelölése egy kerekített sarkú téglalap, amelynek felső részében az állapot
megnevezése található (ez kötelező) majd a vonal alatt a további elemei, melyek
opcionálisak. Az opcionális elemek:
* **entry/**: Annak a tevékenységnek a leírása, ami az állapotba való belépés esetén
elvégzendő. Ez a tevékenység mindig végrehajtódik, attól függetlenül, hogy milyen
átmenet miatt lépett be az objektum az állapotba.
* **do/**: Annak a tevékenységnek a leírása, amely az adott állapothoz tartozik. Ha
több ilyen is van, azokat a végrehajtásuk sorrendjében soroljuk fel. Ezt a tevékenységet
egy esemény félbeszakíthatja. Az esemény lehet:
	* *esemény/*: Belső esemény bekövetkezéséhez kapcsolt tevékenység leírása.
	* *exit/*: Annak a tevékenységnek a leírása, amelyet bármely átmenet bekövetkezése
	esetén még az állapotból való kilépés előtt végre kell hajtani.

Előfordulhat, hogy egy állapotot azzal tudunk legjobban jellemezni, hogy milyen
tevékenységet folytat abban az állapotban az objektum. Ilyenkor nem adunk külön
nevet az állapotnak, hanem a **do/** fázist használjuk megnevezésként.

Bonyolultabb viselkedésű objektum esetén az állapotok és a köztük lehetséges átmenetek
száma olyan nagy lehet, hogy a diagram áttekinthetetlenné válna. Az áttekinthetőség
érdekében ilyenkor az összetartozó állapotokat **szuperállapotokba** foglalhatjuk.
A szuperállapotok tartalmazhatnak **alállapotokat** és azok közötti átmeneteket.
A szuperállapotokat külön ábrába is foglalhatjuk.

Ha egy összetett állapotból kilépünk és szeretnénk majd ugyanott folytatni a tevékenységet,
ahol abbahagytuk, akkor van szükségünk az **emlékező** vagy **történeti állapotra**
(history state). Létezik egyszerű történeti állapot, amely csak az állapotkonfiguráció
legfelső szintjét őrzi meg (az alállapotoknak is lehetnek további alállapotai, ezek
több szintűen is egymásba ágyazhatók), és létezik a mély történeti állapot, amely
teljes mélységében megőrzi az állapotkonfigurációt. Az egyszerű történeti állapotot
egy bekarikázott ```H``` betű jelzi, a mélyet pedig egy bekarikázott ```H*```.

### Az esemény és az akció

Az esemény egy olyan tevékenység, történés, ami valamely objektum állapotát megváltoztatja.
Ha az esemény végrehajtása időben elhúzódik, megkülönböztethetjük tőle a pillanatszerű
akciót.

Az állapotok közötti átmenet, a tranzakció valójában egy relációt fejez ki két
állapot között. Az első állapotban az objektum kezdeményezi a kilépés akcióját,
amely elindítja azt az eseményt, eseménysorozatot, amely a második állapotba történő
belépést eredményezi. Ha az első állapotból történő kilépés és a másodikba történő
belépés ugyanaz az időpillanat, akkor akcióról beszélünk, ellenkező esetben eseményről.
Események esetén célszerű az eseményhez állapotot rendelni.

Az eseményeknek általában három fázisuk van, amelyek közül kettő akció:
* **entry** fázis, a belépés akciója, amely elindítja azt az eseményt, eseménysorozatot,
amelynek hatására létrejön egy eseményhez rendelt állapot.
* **event** fázis, amely az adott állapothoz kötődik, azaz belső események sorozata,
amely az adott állapothoz kötődő belső állapotokat jelenti.
* **exit** fázis, a kilépési akció, amely az esemény befejezését, a hozzá rendelt
állapotból való kilépést eredményezi.

*Az állapotátmeneteket szimbolizáló nyilakra ráírhatjuk az állapotváltást okozó
esemény vagy akció nevét, illetve a feltételt*.

### Az állapot átmenet és jelölése

Az állapotok közötti átmenetet valamilyen esemény bekövetkezése okozza. Az átmenetek
atomi egységek, nem szakíthatók félbe, azaz időponthoz kötöttek. Lehetséges olyan
esemény, amelynek hatására ugyanabba az állapotba tér vissza az objektum. **Az átmenetet
nyitott hegyű nyíllal jelezzük**. Az átmenet adatai lehetnek:
* kiváltó ok (trigger) az esemény megnevezése
* feltétel (guard) szögletes zárójelpárral határolt, az átmenet bekövetkezésének
feltételét adja meg,
* hatás (effekt) az októl ```/``` jellel elválasztva adható meg, és az átmenet miatt
végrehajtandó tevékenységet specifikálhatja.

A fentiek mindegyike opcionális. Ha nincs megadva kiváltó ok, akkor a kiváltó esemény
az előző állapot befejeződése. Minden állapothoz legalább egy átmenet vezet (kivéve:
kezdőállapot), és onnan legalább egy átmenet vezet egy másik állapotba (kivéve: végállapot).
Az állapotdiagramban a rombusz az esetválasztó csúcs. Azokra az átmenetekre, amelyek
az esetválasztó csúcsból indulnak, szögletes zárójelbe helyezett feltételt kell írni.
Ha az esetválasztó csúcsból kiinduló átmenetek feltételei kölcsönösen kizárják egymást
és együttesen lefednek minden lehetséges esetet, akkor a feltételt írhatjuk az esetválasztó
csúcshoz is.

### Egy konkrét példa<sup id="6">[[6]](#note6)</sup>

Példaként, rajzoljuk meg egy ATM állapotgép diagramját (a valóságban ennél biztosan
több állapota van, és nem biztos, hogy minden állapot átmenet az ábrának megfelelő,
de a diagram jelöléseinek szemléltetésére ez is elegendő). Figyeljük meg, hogy
ezen az ábrán nincs kezdő és végállapot feltüntetve, azaz az ATM objektumot „örökéletűként”
modelleztük. A kezdő állapot a telepítést, a végállapot a leszerelést jelentené ebben
az esetben, de ez a működés modellezése szempontjából nem lényeges.

![Imgur](https://imgur.com/XdUAzkN.png)
 
## 5. Ismertesse a sorrend (szekvencia) diagramot (egy konkrét példa is szükséges).

A használati esetek az UML jelölésrendszer részei. Ezeket a diagramokat szekvenciadiagrammal
szokás kiegészíteni, szemléltetendő, hogy a működés során milyen dinamikus kölcsönhatás
lép fel az objektumok között. Ez ábrázolható az UML szekvencia diagram segítségével,
ami egy adott forgatókönyv szerint, egy időtengely mentén mutatja be a modellelemek
közötti összes kölcsönhatást.

### A diagram elemei:

<dl>
  <dt>Objektum</dt>
  <dd>
	Egy rendszer valamilyen működésre képes részét, vagy akár az egész rendszert
	jelenheti. Speciális „objektumként” jelenhetnek meg a rendszer aktorai (pálcikaemberrel
	jelölve), hiszen egy üzenetváltás gyakran az aktor és a rendszer (vagy annak valamely
	objektuma) 	közötti interakcióval kezdődik, vagy az üzenet egy aktornak szól. Ha
	implementációs szintű („igazi”) objektumról van szó, akkor a szokásos objektum
	jelölést (téglalap) használjuk. A téglalapban példány_neve:osztály_neve
	alakban jelöljük, hogy mit is ábrázol.
  </dd>
  <dt>Életvonal</dt>
  <dd>
	Az objektumból egy szaggatott vonallal jelzett életvonal indul, amely felülről
	lefelé az idő múlását jelképezi és meghatározza az objektumok és aktorok létezésének
	időtartamát. Az életvonalon jelölhetők az objektum aktivitási szakaszai. Az aktivitási
	szakaszt a szaggatott vonal helyett elnyújtott téglalap jelzi. Ha egy üzenet hatására
	az objektum megszűnik, az életvonal végét egy X zárja le.
  </dd>
  <dt>Üzenet</dt>
  <dd>
	Két objektum közötti üzenetet egy vízszintes nyíl ábrázolja, a két életvonal
	között húzódva. A nyilakon fel van tüntetve az üzenet neve. Ezt ki lehet egészíteni
	az üzenet argumentumaival és vezérlési információkkal is. Az objektumok életvonala
	egy felülről lefelé mutató időtengelyt is képvisel. Az időbeliség azonban alapesetben
	csak sorrendiséget jelent: amelyik üzenet nyila lejjebb található, az követi
	a felé rajzolt üzenetet. A lefelé lejtő (nem vízszintes) nyíllal jelölt üzenet
	továbbítása „valamennyi időt” vesz igénybe. A szekvencia során üzenet segítségével:
	<ul>
	  <li>létrehozhatunk új objektumokat (a konstruktorral), ekkor elindul az életvonaluk,</li>
	  <li>megsemmisíthetünk objektumokat (a destruktorral), ekkor vége az életvonaluknak,</li>
	  <li>kommunikálhatunk az objektumokkal.</li>
	</ul>
	Az üzenetek fajtái:

![Imgur](https://imgur.com/gQ2bV06.png)
	<dl>
	  <dt>létrehozó üzenet</dt>
	  <dd>
		Az üzenet hatására létrejön egy új objektum. A létrehozandó objektum fejére
		mutató, nyitott hegyű nyílban végződő szaggatott vonallal jelüljük.
	  </dd>
	  <dt>szinkron üzenet</dt>
	  <dd>
		A feldolgozását a hívó megvárja, addig nem végez további műveleteket, a
		fogadó aktiválódik (ha nem volt az). Zárthegyű nyílban végződő folyamatos
		vonallal jelüljük, ami a hívótól a hívott felé mutat.
	  </dd>
	  <dt>aszinkron üzenet</dt>
	  <dd>
		A feldolgozását a hívó nem várja meg, hanem tovább tevékenykedik. Nyitott
		hegyű nyílban végződő folyamatos vonallal jelüljük, ami a hívótól a hívott
		felé mutat.
	  </dd>
	  <dt>visszatérési üzenet</dt>
	  <dd>
		Egy korábbi üzenet feldolgozásának eredménye. A választ küldő deaktiválódik,
		a fogadó pedig aktiválódik. Nyitott hegyű nyílban végződő szaggatott vonallal
		jelüljük, ami a választ küldőtől a hívó felé mutat.
	  </dd>
	  <dt>rekurzív üzenet</dt>
	  <dd>
		Az objektum saját magának küld üzenetet, miközben fő tevékenysége felfüggesztődik
		a kiszolgálás idejére. Nyitott hegyű nyílban végződő folyamatos vonallal
		jelüljük, ami a hívótól a önmaga felé mutat.
	  </dd>
	</dl>
  </dd>
  <dt>Megjegyzések</dt>
  <dd>
	A diagram bal szélén megjegyzések, megszorítások és időbeliségre utaló jelölések
    helyezhetők el.
  </dd>
</dl>

Az UML 2.0 verziótól kezdve a nyelv bevezette a *„komplex interakció”* fogalmát, azaz
az üzeneteket (interakciókat) kombinálhatjuk, és a köztük levő viszonyokat operátorokkal
fejezhetjük ki. Egy komplex interakció jele egy téglalap. A téglalap bal felső
sarkában a rá vonatkozó operátort tüntetjük fel, vízszintesen pedig „átfogja” az
interakciókban érintett objektumok életvonalait. A szekvencia során ábrázolhatunk:
* *feltételes szakaszt* (**opt**), amely csak a feltétel teljesülésekor hajtódik végre
* *elágazást* (**alt**), ahol a feltétel függvényében különböző ágakat hajthatunk végre
* *ciklust* (**loop**), ahol a tevékenységet a feltétel függvényében többször is végrehajtjuk
* *párhuzamos szakaszt* (**par**), ahol egyszerre párhuzamosan végezzük a tevékenységeket
* *kritikus szakaszt* (**critical**), amely nem végezhető párhuzamosan.

![Imgur](https://imgur.com/mgWtjlS.png)

### Egy konkrét példa<sup id="7">[[7]](#note7)</sup>

Tatjána levelet ír, majd elküldi Anyeginnek. Ha Anyegin ivott vodkát, akkor többször
is elolvassa a levelet, majd készít egy gyönyörű, aranyozott szamovárt, és elküldi
Tatjánának, aki (mivel nem erre számított) megsemmisíti a szamovárt. Ha azonban
Anyegin nem ivott, akkor csak egyszer olvassa el a levelet, majd bundát csinál, és
ezt a bundát küldi Tatjánának.

![Imgur](https://imgur.com/PgB2769.png)

## 6. Ismertesse és magyarázza el az objektum-orientált fejlesztés négy tanult alapelvét.

Az objektum orientált programozás (OOP) gyakorlatilag egy teljesen új szemléletmódot
követel a programok megvalósításának tekintetében. Amíg egy strukturált rendszerben
egymásra épülő, sorban lefutó algoritmusokkal valósítottuk meg egy probléma megoldását,
addig itt úgynevezett objektumok segítségével kell mindezt megtennünk. Nem a
programrészek megírása a fő cél, hanem az objektumok hierarchiája és kapcsolata áll a
középpontban. Ennek a rendszernek a pontos megtervezése és megvalósítása adja a feladat
megoldását.

Az objektumorientáltság egy szemléletmód, amelyben a valós világ dolgait egymással
kapcsolatban lévő objektumoknak tekintjük, olyan tervezési stratégia, amelyben a
rendszertervezők műveletek és funkciók helyett „dolgokban” (objektumokban) gondolkodnak.
Egy objektumorientált tervezési folyamat az osztályoknak és azok közötti kapcsolatoknak
a megtervezéséből áll.

Az osztály a valóság mintájára tulajdonságokkal és viselkedésekkel felruházott zárt
egység, a való világban található dolgok (létezők) elvont informatikai leképezése.
A programozásban alkalmazott osztályok egy-egy való világbeli dolognak a megoldandó
programozási probléma szempontjából releváns lényegét foglalják magukba, és mint
ilyenek típusokként is értelmezhetők. A legtöbb objektumorientált nyelv osztály
alapú, azaz az objektumok osztályok példányai, és típusuk az osztály. Az osztály
az egyes objektumok elvi tervrajzát, működését definiálja, olyan elvont objektumminta
vagy típus értendő alatta, mely alapján konkrét példányokat (objektumokat) lehet
létrehozni.

### Alapelvek

<dl>
  <dt>Egységbezárás (enkapszuláció)</dt>
  <dd>
	Az objektum egységbe foglalja az állapotát tároló adatokat és azok szerkezetét,
	valamint a rajtuk végrehajtott, az objektum viselkedését meghatározó műveleteket.
	Az adatokat ismerik mezők, attribútumok, tulajdonságok vagy adattagok néven is,
	a műveleteket metódusokként szokták emlegetni. Az objektum állapotát adattagokkal,
	viselkedését pedig metódusokkal (tagfüggvényekkel) tudjuk leírni. Az objektum
	által tartalmazott adatokon általában az objektum metódusai végeznek műveletet.
  </dd>
  <dt>Öröklés (Inheritencia)</dt>
  <dd>
	<p>Az öröklődés/leszármaztatás alapján az osztály fogalma kategóriaként is felfogható.
	Ez esetben az osztályhoz tartozás már nem csak azt jelenti, hogy a dolog azonos
	önmagával (az adott dolgot leíró osztály egy konkrét példánya), hanem azt is,
	hogy egy tágabb, általánosabb kategóriának/osztálynak is leszármazottja. Az
	objektumosztályok egy generalizációs vagy öröklődési hierarchiába szervezhetők,
	amely az általános és a specifikus objektum­osztályok közötti kapcsolatot jeleníti
	meg. Egy objektum példánya saját osztályának, de az öröklődési hierarchiában
	egyben példánya valamennyi ősosztálynak is (pl. a Lada nem csak személygépkocsi,
	hanem gépkocsi, jármű, gép, létező is egyben).</p>
	<p>Az öröklődés a kód újrahasznosításának gyakori módja és hatékony eszköz a kódduplikálás
	felszámolására. Minden megismételt kód nehezíti a karbantarthatóságot, hiszen
	ha módosítanánk a viselkedésén, akkor azt minden duplikátum esetében meg kellene
	tenni. A programozás egyik igen fontos elve a DRY (Don't repeat yourself), vagyis
	kerüljük az ismétlődő elemeket (ugyanis abban rejlik egy minta, amit le tudunk
	rövidíteni), ezért a hasonló osztályok közös metódusait ki lehet emelni egy
	ősosztályba és ebből származtatni őket.</p>
	<p>A kiterjesztett, vagy származtatott osztály minden tulajdonággal és metódussal
	rendelkezik, ami a kiindulási osztályban megvolt (örökli az ős tulajdonságait
	és metódusait). Amit hozzáadunk a kiindulási osztályhoz, azt nevezzük
	kiterjesztésnek.</p>
  </dd>
  <dt>Többalakúság (polimorfizmus)</dt>
  <dd>
	<p>Amikor létrehozunk egy származtatott osztályt, abban új metódusokat, vagy adattagokat
	is elhelyezhetünk, sőt, arra is van lehetőségünk, hogy átírjuk a szülőtől örökölt
	kódot. Ezzel a technikával az azonos szülőtől származó osztályok specializálhatók.
	Ezt hívják <b>altípusos polimorfizmus</b>nak, ami egy egységes interfészre utal, amit
	különböző osztályok valósítanak meg. Ha egy leszármazott osztály egy örökölt metódust
	újraimplementál	(<i>overriding</i>), a metódus szignatúrája (neve és paraméterlistája)
	változatlan marad, de az implementáció más lehet az öröklődési vonalon.</p>
	<p>Polimorfizmus megvalósítható még <b>metódus túéterheléssel</b> is, ahol
	a metódus neve minden esetben változatlan marad, de az argumentumok száma és
	típusa eltérhet, ezért a metódus ennek megfelelően különféleképpen viselkedhet.</p>
  </dd>
  <dt>Adatrejtés</dt>
  <dd>
	<p>Az egységbezárás és az adatrejtés igen gyakran összemosódó objektum-orientált
	alapfogalmak. Az egységbezárás azt mondja ki, hogy az adatokat és a rajtuk
	végezhető műveletekért felelős eljárásokat egy egységként kell kezelni. Minden
	eljárást úgy kell meghatározni, hogy az csak az objektum saját adataival végezhessen
	műveleteket. Ehhez szorosan kapcsolódik az adatrejtés, ami pedig azt mondja,
	hogy az objektumoknak el kell rejteni a külvilág felől az adataikat. Az adatokhoz
	mindig csak valamilyen ellenőrzött metódus formájában lehessen hozzáférni.</p>
	<p>Az objektum orientált tervezési ajánlás az, hogy az objektum adatait csak
	az objektum saját eljárásai (metódusai) kezeljék. Az objektumok adatai így az
	objektum „tudta" nélkül nem változtathatók meg. Ennek előnyei akkor mutatkoznak,
	ha egy objektum adatát csak úgy lehet megadni, hogy előtte az adat érvényességét
	és a többi adattal való összefüggését megvizsgáltuk az objektum saját metódusában.</p> 
	<p>A két fogalom jelentőségét együttesen lehet meghatározni. Ha az objektum zárt,
	és a külvilág felé rejtetett, akkor az egyes osztályok jól meghatározott publikus
	interfészeken keresztül kommunikálnak egymással. Ezzel azt érjük el, hogy ha egy
	osztály megvalósítja a használója számára elérhető műveleteket, akkor a belső
	működése, adatszerkezete a többi modul befolyásolása nélkül is megváltozhat.</p>
  </dd>
</dl>

Az objektum-orientált eljárás egységes programozási módszert nyújt a programfejlesztéshez,
megkönnyíti a résztvevők közötti információcserét, és a tesztmódszerek is egységesen
tervezhetőek, továbbá megkönnyíti a programok módosítását is. A kiegészítések, új
osztályokat kezelő programrészek rendszerbe illesztése nem érinti a már megírt
programrészeket.

## 7. Ismertesse a RUP módszertant

Az Egységesített Eljárás Módszertan (RUP, Rational Unified Process) egy
[iteratív és inkrementális szoftverfejlesztési módszertan](https://hu.wikipedia.org/wiki/Iterat%C3%ADv_%C3%A9s_inkrement%C3%A1lis_m%C3%B3dszertanok),
amelyet a Rational Software Corporation (2002 óta az IBM része) fejlesztett ki a
90-es évek közepétől. Első publikált változata 1998-ban jelent meg, az utolsó pedig
már az IBM égisze alatt, 2005-ben. A RUP nem egy szokásos, egyszerű eljárás, hanem
inkább egy feladatokra adaptálható keretrendszer, amelyből minden feladattípushoz
az ahhoz illeszkedő módszereket, eszközöket alkalmazhatjuk.

A RUP módszertan létrehozásának célja az volt, hogy kiküszöbölje a fejlesztési
folyamatban felmerülő, a projekt sikerét megakadályozó problémákat. A fejlesztési
projektek sikerességét három tényező alapján mérjük:
1. költségkeret betartása,
2. határidő betartása,
3. a követelményeknek való megfelelés.

A három tényező nyilvánvalóan összefüggésben áll egymással. A 80-as és 90-es évek
kutatásai a problémák okaként elsősorban nem technológiai, hanem módszertani
hiányosságokat jelöltek meg, ezen belül is elsősorban a fejlesztés ideje alatt
bekövetkező változások követésének, illetve az együttműködéskommunikáció problémáira
világítottak rá. A RUP ezekre a problémákra a
* fejlesztési folyamat és a folyamat során elvégzendő tevékenységek,
* a tevékenységek egymásra épülésének, egymásutániságának, ugyanakkor
* a változások követésének
definiálásával, megoldásával és előírásával próbál válaszolni.

A módszertan elméleti módszertan, ami azt jelenti, hogy ajánlásait, mintáit és módszereit
a különböző típusú fejlesztési feladatok esetében mindig át kell vizsgálni, és a
helyzetnek megfelelően kell azokat alkalmazni.

A RUP a rendszerfejlesztés folyamatát alapvetően három perspektívából írja le:
* **dinamikus perspektíva**, amely a modell fázisait mutatja
* **statikus perspektíva**, amely a végrehajtandó folyamattevékenységeket mutatja
* **gyakorlati perspektíva**, amely gyakorlatokat javasol a folyamat alatt

### A RUP módszertan jellemzői

<dl>
  <dt>Követelményvezérelt jelleg</dt>
  <dd>
	A módszertan egyik fő szempontként emeli ki a követelménymenedzsment fontosságát 
	és érvényesíti is mind a nézethierarchiában, mind a fejlesztési munkafolyamatokban.
	A követelménymenedzsment folyamatos tevékenység, amely végigkíséri a fejlesztés
	teljes folyamatát. Célja a követelmények feltárása, rendszerezése, dokumentálása.
	További fontos feladata a követelmények változásának nyomon követése és ezek
	érvényesítése a fejlesztési folyamatra
  </dd>
  <dt>Architektúra központúság</dt>
  <dd>
	Architektúra alatt egy rendszer meghatározó összetevőit és ezek kapcsolatait értjük.
	Az architektúra célja:
	<ul>
		<li>átláthatóvá teszi a fejlesztést;</li>
		<li>könnyebben felismerhetők az újrafelhasználható elemek;</li>
		<li>átlátható projektmenedzsment;</li>
		<li>kockázatok csökkentése;</li>
		<li>lehetővé válik a párhuzamos fejlesztés.</li>
	</ul>
	<p>Az alkalmazást rétegekkel és a réteg által biztosított interfészekkel modellezik.
	Az egyes rétegeknek jellegzetesen különböző feladatkörük van, mint például felhasználói
	felület, vezérlés, adattárolás. Az elvileg ideális esetben minden egyes réteg csak
	és kizárólag a vele szomszédos rétegekkel tart kapcsolatot.</p>
  </dd>
  <dt>Iteratív és inkrementális jelleg</dt>
  <dd>
	A módszertan által preferált fejlesztési folyamat fázisiterációk-mérföldkövek
	felépítése előírja ezt a fajta megközelítést. Egyszerű, kicsiny rendszerek esetében
	még alkalmazható a feladat definiálása, tervezés, kódolás, tesztelés szekvenciális,
	„vízesésszerű” fejlesztési mód. Nagyobb, bonyolultabb rendszerek esetében más
	módszert kell keresni. A megrendelői, felhasználói igények is folyamatosan változnak.
	A hagyományos „vízesés modell” alkalmazásakor számos hiányosság, félreértés,
	hiba csak a fejlesztés végén, a tesztelési fázisban bukik elő. Ugyanakkor ez
	a „vízesés modell” nagyon nehezen viseli el a fejlesztési célok menet közbeni
	megváltozását. Ezzel szemben az iteratív fejlesztés
	<ul>
		<li>tolerálja a követelmények megváltozását</li>
		<li>biztonságosabb, hibatűrőbb alkalmazást eredményez</li>
		<li>lehetővé teszi a résztvevők folyamatos tanulását, a módszertan finomítását</li>
		<li>lerövidíti a fejlesztés időtartamát</li>
		<li>tervszerű</li>
	</ul>
  </dd>
</dl>

### A projekt életciklus szakaszai

A RUP szemléletében egy fejlesztés életciklusa a munka megkezdésétől a késztermék
egy üzemszerű működésre szánt változatának átadásáig tart. Az RUP a projekt életciklusát
négy szakaszban határozza meg. Minden fázis a fejlesztés egy-egy jól meghatározott
mérföldkövét jelenti, azaz olyan pontot, ahol egy célt elértünk, illetve ahol kritikus
döntéseket kell meghozni. Minden fázis végén megvizsgáljuk az elért eredményeket és
döntünk a fejlesztés folytatásról.

**A négy fázis:**

<dl>
  <dt>Előkészítés (inception)</dt>
  <dd>
	Az előkészítés elsősorban üzleti szempontból írja le a fejlesztést és
	meghatározza az alkalmazás határait. Az üzleti szempont röviden a következőket jelenti:
	<ul>
	  <li>sikertényezők meghatározása</li>
	  <li>kockázati tényezők felmérése</li>
	  <li>erőforrás-becslés</li>
	  <li>projekterv: a mérföldkövek dátumainak meghatározása</li>
	</ul>
	A fázis végén meghatározzuk az egyes iterációs ciklusok célját és döntünk a
	folytatásról.
  </dd>
  <dt>Kidolgozás (elaboration)</dt>
  <dd>
	A kidolgozás során a problémát elsősorban szakterületi szempontból
	elemezzük. Elsődleges cél az elemzéssel azonosított legfontosabb kockázati tételek
	enyhítése e szakasz végéig. Ebben a fázisban elkészül a problémakör elemzése,
	és a projekt architektúrája megkapja alapvető formáját. Az architektúrára vonatkozó
	helyes döntéseket csak a teljes rendszer megismerése után hozhatunk, ezért szükséges,
	hogy a használati esetek döntő részét specifikáljuk, valamint, hogy meghatározzuk
	a nem-funkcionális követelményeket. A fázis végén kiválasztottuk az architektúrát
	és megszüntetettük a főbb kockázati tényezőket. A mérföldkőnél itt is elemezzük
	az elért eredményeket és döntünk a folytatásról.
  </dd>
  <dt>Megvalósítás (Construction)</dt>
  <dd>
	A megvalósítási fázis legfőképpen a rendszertervvel, a programozással és a teszteléssel
	foglalkozik. Az elsődleges cél a szoftverrendszer felépítése. Ebben a szakaszban
	a fő hangsúly a rendszer komponenseinek és egyéb tulajdonságainak fejlesztésére
	kerül. Ebben a szakaszban történik a kódolás nagy része. Nagyobb projektekben több
	építési iterációt lehet kidolgozni annak érdekében, hogy a felhasználási eseteket
	kezelhető szegmensekre bonthassák, és megfelelő prototípusokat állítsanak elő.
	A rendszer különböző részei párhuzamosan fejleszthetők, majd ez alatt a fázis
	alatt integrálhatók. A fázis végén már rendelkezünk egy működő szoftverrendszerrel
	és a hozzá csatlakozó dokumentációval, amely készen áll, hogy leszállítsuk a
	felhasználónak.
  </dd>
  <dt>Átadás (Transition)</dt>
  <dd>
	Az elsődleges cél a rendszernek a fejlesztésről a termelésre történő átvitele,
	hozzáférhetővé tétele és a végfelhasználó számára történő megértése. E szakasz
	tevékenységei között szerepel a végfelhasználók és karbantartók képzése is.
	Ez a fázis tipikusan az alkalmazás béta-tesztjével kezdődik. A rendszer hangolása
	miatt szükség lehet kiegészítő fejlesztésekre és a megjelenő hibákat ki kell
	küszöbölni, illetve a még hiányzó részeket ki kell fejleszteni.
	A fázis végén dönteni kell, hogy elértük-e a fejlesztés során kitűzött célokat, illetve,
	hogy indítanunk kell-e újabb fejlesztési ciklust. Ugyancsak célszerű, hogy a projekt
	tapasztalatait elemezve vizsgáljuk meg azt, hogy miként módosíthatunk a fejlesztési
	módszerünkön. 
  </dd>
</dl>

A fejlesztés nagyobb egységeit jelentő fázisok további kisebb egységekre, iterációkra
(iteration) bonthatók. Az iteráció végén a rendszer újabb, bővített funkcionalitású
verziója készül el. Minden iteráció egy teljes, illetve részben önálló fejlesztési
ciklust jelent. Az iterációk számát nem rögzíti a szabvány, fázisonként illetve
fejlesztésenként eltérő számú iterációra lehet szükségünk.

Minden egyes iterációban „kicsiben” megvan minden, ami egy fejlesztési projekt
szerves része. Kezdődik az üzleti modellezéssel, követelményelemzéssel, folytatódik
elemzéssel, tervezéssel, implementálással, teszteléssel, és befejeződik a telepítéssel.
Az iteráción belül a feladatokat kilenc munkafolyamatra (újabb megfogalmazás szerint
tudományterületre) osztják. A tevékenység jellegének megfelelően megkülönböztetünk
mérnöki, illetve támogató folyamatokat. A mérnöki folyamatok hozzák létre a szoftverterméket,
míg a támogató munkafolyamatok a fejlesztés irányításával, a környezet biztosításával,
a változáskövetéssel, azaz a menedzsment feladataival foglalkoznak.

**Mérnöki munkafolyamatok:**

* Üzleti folyamatok elemzése (*Business Modeling*)
* Követelmények elemzése (*Requirements*)
* Elemzés és tervezés (*Analysis & Design*)
* Implementáció (*Implementation*)
* Tesztelés (*Test*)
* Átadással kapcsolatos tevékenységek (*Deployment*)

**Támogató munkafolyamatok:**

* Konfiguráció és változáskövetés (*Configuration & Change Management*)
* Projektvezetés (*Project Management*)
* Fejlesztői környezet felállítása (*Environment*)

A fejlesztés különböző fázisaiban az iterációk lényegesen különbözőek lehetnek. Míg a
fejlesztés kezdeti szakaszában az üzleti modellezés és a követelményelemzés a hangsúlyosabb,
s a tesztelés, telepítés lehet, hogy ki is marad, addig a középső szakaszban az implementálás,
a legvégső szakaszban a telepítés, a tesztelés a domináns. A fejlesztés bizonyos szakaszaiban
egyes munkafolyamatok erőforrásigénye szinte nullára is csökkenhet. Ezt szemlélteti
az alábbi diagram:

![Imgur](https://imgur.com/ZmpQ0Qp.png)


## 8. Ismertesse a dinamikus szoftvertesztelési módszereket

A verifikáció és a validációt (*V & V*) általánosan **szoftvervalidációnak** nevezik.
Legfőbb célja, hogy megmutassa, a rendszer konform a saját specifi­kációjával, és
hogy megfelel az ügyfél elvárásai­nak. A V & V két, egymást kiegészítő különböző
perspektíva segítségével végzi az ellenőrzési folyamatot:

* **Statikus**: szoftverátvizsgálások. Az átvizsgálási technikák közé tartoznak a
programátvizsgálások, az automatizált forráskód elemzés és formális verifikáció.
Magát a programot nem futtatjuk.
* **Dinamikus**: a klasszikus értelemben vett szoftvertesztelés. Valamely tesztadatok
segítségével ellenőrzi, hogy a rendszer adott inputra megfelelő outputot nyújt-e.
A kimenetek eredményei lehetőséget adnak anomáliák, problémák feltárására.
A szoftvertesztelés, mint dinamikus V & V a gyakorlatban inkább alkalmazott technika.
Ezen tesztelés két fajtája ismert:
	* **Hiányosságtesztelés**: célja a program és a specifikációja között meglévő ellentmondások
	felderítése. Az ilyen teszteket a rendszer hiányosságainak feltárására tervezik, nem a
	valós működés szimulálására. Hiányosságtesztelés esetén a tesztet akkor nevezzük
	sikeresnek, ha az felderít egy olyan hibát vagy hiányosságot, amely a rendszer helytelen
	működését eredményezi.
	* **Validációs tesztelés**: a program teljesítményének és megbízhatóságának tesztelése
	valós körülményeket szimulálva. Annak megmutatása, hogy a szoftver megfelel-e a vásárlói
	igényeknek. A tesztelés során azt várjuk a rendszertől, hogy az olyan tesztesetekre,
	amelyek az általános használatát tükrözik, helyesen működjön, és akkor nevezzük a
	tesztelést sikeresnek, ha ez teljesül.

**A dinamikus tesztelés elvi alapjait a következőben foglalhatjuk össze:**
* A tesztelés képes felfedni a hibákat, de azt nem, hogy nincs hiba. Ugyanakkor a
szoftver minőségét és megbízhatóságát növeli.
* Nem lehetséges kimerítő teszt, minden bemeneti kombinációt nem lehet letesztelni
(csak egy 10 hosszú karakterláncnak 256^10 lehetséges értéke van) és nem is érdemes.
Általában csak a magas kockázatú és magas prioritású részeket teszteljük.
* Érdemes a tesztelést az életciklus minél korábbi szakaszában elkezdeni, mert minél
hamarabb találunk meg egy hibát, annál olcsóbb javítani.
* A tesztelésre csak véges időnk van, ezért a tesztelést azokra a modulokra kell
koncentrálni, ahol a hibák a legvalószínűbbek, illetve azokra a bemenetekre kell
tesztelnünk, amelyre valószínűleg hibás a szoftver (pl. szélsőértékek).
* Ha az újratesztelés során mindig ugyanazokat a teszteseteket futtatjuk, akkor
egy idő után ezek már nem találnak több hibát (mintha a hibák alkalmazkodnának a
teszthez). Ezért a tesztjeinket néha bővíteni kell.
* Másképp tesztelünk egy atomerőműnek szánt programot és egy beadandót. Másképp tesztelünk,
ha a tesztre 10 napunk vagy csak egy éjszakánk van.
* Nincs hibátlan rendszer, hiába javítjuk ki a hibákat a szoftverben, azzal nem lesz
elégedett a megrendelő, ha nem felel meg az igényeinek. Azaz használhatatlan szoftvert
nem érdemes tesztelni.
* A program tesztelését csak a program írójától különböző személy képes hatékonyan
elvégezni. Ennek oka, hogy a tesztelés nem *„jóindulatú”* tevékenység, saját munkájának
vizsgálatához mindenki úgy áll hozzá, hogy önkéntelenül jónak feltételezi.

A dinamikus ellenőrzési technikák legfőbb jellemzője, hogy a vizsgált forráskód a
folyamat során végrehajtásra kerül. A dinamikus tesztek tervezése alapvetően az
alábbi három lépésből áll:

<dl>
  <dt>Tesztesetek (test cases) specifikálása</dt>
  <dd>
	A teszteset nem más, mint a teszthez szükséges inputok és a rendszertől várt
	outputok speci­fikációja. A tesztadatok kifejezetten a rendszer tesztelésére
	létrehozott inputok. A tesztadatok néha automatikusan generálhatók, az automatikus
	teszteset-generálás viszont általában nem lehetséges. A tesztek outputjait csak
	azok tudják előre megjósolni, akik értik, hogy a rendszernek mit kellene csinálnia.
	Teszteseteket mind az érvénytelen, mind az érvényes adatokra kell készíteni.
  </dd>
  <dt>A tesztelés alanyának, céljának meghatározása (test condition)</dt>
  <dd>
	A tesztelés alanya lehet a rendszer egy olyan jellemzője, amely ellenőrizhető
	egy vagy több teszt esettel. Ilyen lehet például: funkció, tranzakció, képesség (feature),
	minőségi jellemző, vagy strukturális elem.
  </dd>
  <dt>Teszt folyamat (test procedure) specifikálása</dt>
  <dd>
	Egy teszteset végrehajtásához szükséges tevékenységek sorozatának a leírása.
	Szokás teszt forgatókönyvnek (manual test script) is nevezni.
  </dd>
</dl>

**A tesztelési folyamathoz kapcsolódó fogalmak:**
* **teszt készlet** (test suite): tesztesetek és hozzájuk tartozó teszt specifikációk
halmaza. Csoportosítható egy teszt alanyra, vagy egy vizsgált hibára.
* **hibamodell**: azon (feltételezett) szoftver hibák halmaza, amelyre a teszt
tervezés irányul. A tesztesetek tervezéséhez ad támpontokat.
* **lefedettség** (test coverage): a számszerű értékelése annak, hogy a tesztelési
tevékenység mennyire alapos, illetve hogy egy adott időpontban hol tart. A lefedettségi
mérőszámok arra nézve adnak információt, hogy milyen készültségi szinten áll a tesztelési
tevékenység, és a tesztelési terv részeként meghatározzák, hogy milyen feltételek
esetén tekinthetjük a tevékenységet késznek.

### A dinamikus tesztelési módszerek csoportosítása

<dl>
  <dt>Feketedoboz-módszerek</dt>
  <dd>
	<p>Ezek a módszerek a teszteseteket közvetlenül a rendszer specifikációjából (modelljéből)
	vezetik le. Ezért is nevezzük ezeket Black-box technikáknak, mert az egyes szoftver
	modulok belső szerkezetének (vagyis a forráskód) ismerete nélkül, az egyes modulok
	által teljesítendő funkcionalitások alapján tervezhetjük meg a teszteseteket. Az
	ilyen teszteket jellemzően nem a fejlesztő csapat végzi.</p>
	<p>A tesztelő a felhasználói interfészen keresztül szolgáltatja a bemeneteket, és vizsgálja
	a kimeneteket. Közepesen képzett tesztelők nagy számban tesztelhetik az alkalmazást,
	anélkül, hogy ismernék az implementációt, a programozási nyelvet vagy az operációs
	rendszert.</p>
  </dd>
  <dt>Fehérdoboz-módszerek</dt>
  <dd>
	Ezek a módszerek a kód ismeretében határozzák meg a teszteseteket. Általában az
	alrendszer belsejéhez való hozzáférés megkönnyíti az alrendszer megértését; például,
	ha egy programozó vizsgálhatja a forráskódot, az algoritmus gyengeségei sokkal
	könnyebben feltárhatók. Emiatt a fehérdobozos tesztelés sokkal hatékonyabb, mint
	a feketedobozos tesztelés, de jelentősen nehezebb az alrendszer-tesztelő részéről
	a szükséges alapos megértés miatt. A tesztelőnek meg kell ismernie a forráskódot,
	meg kell értenie, ezért magasan képzettnek kell lennie.
  </dd>
</dl>

Mivel sem a fehérdoboz-módszerrel, sem a feketedoboz-módszerrel nem lehetséges a
kimerítő tesztelés, el kell fogadnunk, hogy nem tudjuk egyetlen program hibamentességét
sem szavatolni. A további cél ezek után az összes lehetséges teszteset halmazából
a lehető leghatékonyabb teszteset-csoport kiválasztása lehet.

### A dinamikus tesztelés szintjei

<dl>
  <dt>Komponensteszt</dt>
  <dd>
	A komponensteszt a rendszer önálló részeit teszteli általában a forráskód ismeretében
	(fehér dobozos tesztelés). Gyakori fajtái:
	<dl>
	  <dt>Egységteszt (unit test)</dt>
      <dd>
		A unit egy rendszer legkisebb önálló egységként tesztlehető része. Ez a
		legalacsonyabb szintű tesztelés, a programot felépítő egységek tesztelése.
		Az egységeket egymástól izoláltan kell tesztelni. Az egységteszt a metódusokat
		teszteli. Adott paraméterekre ismerjük a metódus visszatérési értékét (vagy
		mellékhatását). A unit-teszt megvizsgálja, hogy a tényleges visszatérési
		érték megegyezik-e az elvárttal. A tesztek eredménye egy boolean érték,
		futásuk vagy sikeres, vagy sikertelen. Elvárás, hogy magának a unit-tesztnek
		ne legyen mellékhatása.
	  </dd>
	  <dt>Modulteszt</dt>
      <dd>
		A modulteszt önálló modulokból álló programrendszer moduljainak egyenkénti
		tesztelése, a többi modultól függetlenül. Általában a modul nem-funkcionális
		tulajdonságát teszteli.
	  </dd>
	</dl>
  </dd>
  <dt>Integrációs teszt (Integration Level Testing, ILT)</dt>
  <dd>
	<p>A fejlesztés során az integrált komponensek lehetnek megvásárolt, újrafelhasználható,
	illetve újonnan kifejlesztett komponensek. A komponensek tesztelését és integrációját
	követően kerül sor az integrációs tesztelésre, amelynek célja, hogy az integrált
	komponensek együttműködésében található hibákat felderítsük. Az integrációs
	tesztelés elsődlegesen azt ellenőrzi, hogy ezek a komponensek képesek-e együttműködni
	azaz, hogy megfelelően vannak-e meghívva és interfészeiken keresztül a megfelelő
	adatokat, megfelelő típussal, megfelelő sorrendben és megfelelő időben küldik-e át.
	Az integrációs teszteket érdemes minél hamarabb elvégezni, mert minél nagyobb
	az integráció mértéke, annál nehezebb meghatározni, hogy a fellelt hiba honnan
	származik.</p>
	<p>A részrendszerek összeépítésére és a tesztesetek megtervezésére és futtatására
	különböző stratégiák alakultak ki.</p>
	<dl>
	  <dt>Big-bang integráció</dt>
	  <dd>
		Feltételezzük, hogy a rendszer minden egység rendelkezésre áll, és ezekből
		egyből a teljes rendszer építjük fel, azaz valójában a tulajdonképpeni
		integrációs teszt kimarad, és egyből a rendszerteszt következik. 
	  </dd>
	  <dt>Inkrementációs integrációs és tesztelési stratégia</dt>
	  <dd>
		<p>A rendszer elemeit fokozatosan integráljuk, és minden egyes integrációs
		szinten teszteket hajtunk végre. A kibővített rendszeren újra kell futtatnunk
		az előzőleg már sikeresen lefutott teszteket is, hiszen nem lehetünk biztosak
		abban, hogy az újabb modulok integrációja nem okoz hibát a korábbi modulok
		működésében. Ez a futtatandó tesztesetek számának exponenciális növekedését
		jelenti.</p>
		<p>Mivel a tesztelés tárgya mindig csak egy részrendszer, annak működtetéséhez
		tesztelési környezetet kell biztosítani, ami attól függ, milyen integrációs
		módszert alkalmazunk. Elvben két lehetséges megközelítés közül választhatunk:
		top-down integráció (a hierarchia legfelső szintjén álló elem tesztelésével
		kezdjük) és bottom-up integráció  (a hierarchia legalsó szintjén álló
		elem tesztelésével kezdjük). Többnyire a két megközelítés valamilyen ötvözetét
		használják a gyakorlatban.</p>
	  </dd>
	</dl>
  </dd>
  <dt>Rendszerteszt (System Level Testing, SLT)</dt>
  <dd>
	<p>A rendszer összes komponensének teljes körű tesztelése. Leggyakrabban a fejlesztés
	során alkalmazott végső teszt, mely ellenőrzi, hogy az átadandó rendszer megfelel-e
	a specifikációnak, célja pedig a lehető legtöbb programhiba megtalálása. A rendszerteszt
	során a rendszer funkcionális és nem funkcionális követelményeit is vizsgálni
	kell. A rendszertesztet a fejlesztő szervezet végzi ellenőrzött tesztkörnyezetben,
	amelynek a lehető legjobban kell hasonlítania a végfelhasználási vagy termelési
	környezetre.</p>
	<p>A rendszerteszt egy végső ellenőrzési fázis a fejlesztési folyamatban, melyben
	a rendszert több szempont szerint tesztelhetik:</p>
	<dl>
	  <dt>Szolgáltatás tesztelés</dt>
	  <dd>
		Célja annak megállapítása, hogy a rendszer minden funkcionális követelményt
		implementál, és azok helyesen működnek.
	  </dd>
	  <dt>Használhatósági tesztelés</dt>
	  <dd>
		A rendszer egy meghatározott felhasználó által, egy meghatározott felhasználási
		körben használva, meghatározott célok hatékony és produktív elérésére, mennyire
		kielégítő és mennyire vezet megelégedésre. Minden felhasználói szerepkört,
		minden használati módot meg kell vizsgálni.
	  </dd>
	  <dt>Teljesítménytesztelés</dt>
	  <dd>
		A teljesítmény vagy a hatékonyság mérése különböző terheléseknél és konfigurációkra
		meghatározott válaszidők és feldolgozási sebességek formájában.
	  </dd>
	  <dt>Mennyiségi tesztelés</dt>
	  <dd>
		A szoftver működését nagy mennyiségű adattal teszteljük a kapacitáskorlátok
		ellenőrzésére. Ellenőrizzük, hogy az adatmennyiség nem okoz-e hibás működést.
	  </dd>
	  <dt>Terheléses tesztelés (Stressz-tesztelés)</dt>
	  <dd>
		A tesztelt rendszert valamilyen szempontból erős terhelésnek teszi ki. Fontos
		feladata a megfelelő válaszidők ellenőrzése. Ennek érdekében:
		<ul>
		  <li>Vizsgálni kell, hogy a rendszer adott időkorláton belül hogyan teljesít
		  nagy mennyiségű adatokon dolgozva.</li>
		  <li>Intenzív feldolgozást kívánó helyzeteket kell teremteni, melyek szélsőségesek,
		  de előfordulhatnak.</li>
		  <li>A robosztusság ellenőrzésére érdemes a terhelést olyan szintre is emelni,
		  amely (elvileg) a használat során nem fordulhat elő.</li>
		</ul>
	  </dd>
	  <dt>Biztonsági tesztelés</dt>
	  <dd>
		Az adatbiztonsággal és adatvédelemmel kapcsolatos hibák vizsgálata. A mai,
		elosztott architektúrájú, gyakran (legalább részben) Web alapú rendszerek
		esetén egyre nagyobb a jelentősége.
		Biztonsági teszt során többek közt vizsgálni kell, hogy
		<ul>
		  <li>a program ellenőrzi-e a felhasználótól kapott adatokat?</li>
		  <li>hibás adatokkal meg lehet-e zavarni működését?</li>
		  <li>ellenőrzi-e a szükséges perifériák, file-ok létét, típusát, a file-ok
		  elhelyezkedését a háttértáron?</li>
		</ul>
		<p>A támadás ellenállóság tesztelése általában feketedobozos teszt. Történhet
		a rendszer kiadása előtt vagy után is. Ha utána történik, akkor általában
		etikus törési kísérletről beszélünk. Ehhez általában külső szakembereket,
		fehér kalapos hacker-eket szoktak felkérni. Ha a kiadás előtt történik,
		akkor általában a legmagasabban képzett belső tesztmérnökök feladata.</p>
	  </dd>
	</dl>
  </dd>
  <dt>Átvételi teszt</dt>
  <dd>
	<p>A felhasználó vagy a megrendelő által a végterméken végzett feketedoboz teszt,
	amely azt hivatott eldönteni, hogy a termék megfelel-e a megfogalmazott üzleti
	elvárásoknak. Az átvételi teszt végrehajtásához szükség van egy tesztkörnyezetre,
	amely a lehető legpontosabban reprezentálja a valós termelési környezetet. Itt
	a projekt során korábban alkalmazott tesztelési módszertől eltérő módon, a
	végfelhasználó szemszögéből kell tesztelni a rendszert.</p> 
	<p>Tömegpiacra fejlesztett, dobozos szoftverek esetén az átvételi tesztet gyakran
	két szakaszban hajtják végre:</p>
	<dl>
	  <dt>Alfa-teszt</dt>
	  <dd>
		A fejlesztő szervezetnél egy potenciális felhasználókból és a fejlesztői
		szervezet tagjaiból álló csoport használja a rendszert, közben a fejlesztők
		megfigyelik a felhasználókat és dokumentálják a problémákat.
	  </dd>
	  <dt>Béta-teszt</dt>
	  <dd>
		A rendszert külső tesztelésre küldik felhasználók bizonyos csoportjához,
		akik telepítik és valós feltételek mellett használják a rendszert. A
		felhasználók a rendszerrel kapcsolatos incidensekről, működési rendellenességekről
		készített feljegyzéseiket megküldik a fejlesztő szervezetnek, ahol a
		programhibákat kijavítják. 
	  </dd>
	</dl>
  </dd>
</dl>


## 9. Ismertesse a Scrum módszertant.

A Scrum a szoftverfejlesztés egy [inkrementális, iteratív módszere](https://hu.wikipedia.org/wiki/Iterat%C3%ADv_%C3%A9s_inkrement%C3%A1lis_m%C3%B3dszertanok),
amit gyakran használnak az [agilis szoftverfejlesztés](https://hu.wikipedia.org/wiki/Agilis_szoftverfejleszt%C3%A9s)
eszközeként. 1986-ban *Hirotaka Takeuchi* és *Ikujiro Nonaka* írtak le egy módszert, amely
nagyban felgyorsítja és flexibilisebbé teszi új termékek fejlesztését. A tradicionális
vízesés módszert, amelyben az egymást sorban követő fejlesztési fázisokat más-más
szakembercsapat kezeli, a váltófutáshoz hasonlítják, ahol egyszerre csak egy ember
fut, és a futók egymásnak adják a stafétát. Az új módszert, amiben a fázisok erősen
átlapolódnak, és a különböző területeket képviselő szakemberek egy kis csoportja
végig, minden fázisban együtt dolgozik, a rögbihez hasonlítják, ahol egyszerre az
egész csapat fut, és egymás között passzolgatják a labdát. Ezt a szemléletmódot
hangsúlyozandó a Scrum fogalmait az amerikai futballból meríti. Ilyen maga az elnevezés
is, amely dulakodást jelent.

A Scrum keretrendszer a Scrum Csapatokból, valamint a hozzájuk rendelt szerepekből,
eseményekből, munkaanyagokból (artifacts) és szabályokból áll. A módszertan jelentős
szerepet tulajdonít a csoporton belüli összetartásnak. A csoporton belül sok a találkozó,
a kommunikáció, lehetőség van a gondok megbeszélésre is. Az ajánlás szerint jó, ha
a csapat egy helyen dolgozik és szóban kommunikál.

A keretrendszeren belül minden egyes komponens meghatározott célt szolgál, és mindegyik
alapvetően szükséges a Scrum sikeréhez és használatához. A Scrum szabályai kapcsolják
össze az eseményeket, szerepköröket és a munkaanyagokat, meghatározva a köztük lévő
viszonyokat és kölcsönhatásokat. A Scrum szabályait a [Scrum Guide](https://scrumguides.org/docs/scrumguide/v2020/2020-Scrum-Guide-Hungarian.pdf) ismerteti.

### Scrum események

Minden Scrum esemény egy formális lehetőség a Scrum munkaanyagok felülvizsgálatára
és a szükséges korrekció elvégzésére. Ezen események a szükséges átláthatóság biztosítására
lettek tervezve. 

<dl>
  <dt>Futam (Sprint)</dt>
  <dd>
	A Sprint minden egyéb esemény gyűjtője. A következetesség jegyében egy hónapos,
	vagy annál rövidebb idejű, rögzített hosszúságú események. Az új Sprint közvetlenül
	az előző lezárása után indul. Kezdődik a Sprint Planning-gel, majd a Retrospective-vel
	zárul. Ez a Scrum úgynevezett iterációs ciklusa, addig kell ismételni, amíg a
	Product Backlog-ról el nem tűnnek a megoldásra váró felhasználói sztorik. Alapelv,
	hogy minden sprint végére egy potenciálisan leszállítható szoftvert kell előállítani
	a csapatnak, azaz egy prototípust. 
  </dd>
  <dt>Sprint Tervezés (Sprint Planning)</dt>
  <dd>
	A Sprint Planning a Sprintet úgy indítja el, hogy meghatározza a Sprint alatt
	elvégzendő munkákat. Ez a terv az egész Scrum Team közös munkájának eredménye.
	A csapat a Product Owner-rel megbeszéli, majd teljes mértékben megérti, hogy
	a vevő mit szeretne az adott sztoritól, így elkerülhetőek az esetleges félreértésekből
	adódó problémák. 
  </dd>
  <dt>Napi Scrum-megbeszélés (Daily Scrum)</dt>
  <dd>
	A sprint ideje alatt minden nap kell tartani egy rövid megbeszélést, ami maximum
	15 perc, és egy előre megbeszélt időpontban, a csapattagok és a Scrum Master
	jelenlétében történik (mások is ott lehetnek, de nem szólhatnak bele). Érdekesség,
	hogy nem szabad leülni, mindenki áll, ezzel is jelezve, hogy ez egy rövid találkozó.
	Bárki részt vehet, de csak a „disznók” beszélhetnek. Három kérdésre kell válaszolnia
	a csapat minden tagjának, ezek a következőek:
	<ol>
	  <li>Mit csináltál a tegnapi megbeszélés óta?</li>
	  <li>Mit fogsz csinálni a következő megbeszélésig?</li>
	  <li>Milyen akadályokba ütköztél az adott feladat megoldása során?</li>
	</ol>
  </dd>
  <dt>Futam áttekintés (Sprint Review)</dt>
  <dd>
	Minden sprint végén összeülnek a szereplők, és megnézik, hogy melyek azok a
	sztorik, amelyeket sikerült elkészíteni, illetve az megfelel-e a követelményeknek.
	Ekkor a sztori állapotát készre állítják. Fontos, hogy egy sztori csak akkor
	kerülhet ebbe az állapotba, ha minden taszkja elkészült, és a Review-on elfogadták.
	Ezen a megrendelő is jelen van.
  </dd>
  <dt>Sprint Visszatekintés (Sprint Retrospective)</dt>
  <dd>
	A Sprint Retrospective zárja a Sprintet. Időtartama legfeljebb három óra egy
	hónapos Sprint esetén. Rövidebb Sprintek esetében az esemény általában rövidebb.
	Ez az egyik legfontosabb meeting. A Scrum egyik legfontosabb funkciója, hogy
	felszínre hozza azokat a problémákat, amelyek hátráltatják a fejlesztőket a
	feladatmegoldásban, így ha ezeket az akadályokat megoldjuk, a csapat jobban
	tud majd alkalmazkodni a következő sprint alatt a feladathoz. Problémák a Daily
	Scrum-on is előkerülnek, de ott inkább a személyeket érintő kérdések vannak
	napirenden, míg itt a csapatmunka továbbfejlesztése az elsődleges.
  </dd>
</dl>

### Szerepkörök

A módszertan kétféle szerepkört különböztetett meg, ezek a disznók és a csirkék. A
megkülönböztetés alapja egy [üzleti mese](https://en.wikipedia.org/wiki/The_Chicken_and_the_Pig),
amely egy projekt vagy ügy iránti elkötelezettségről szól és így hangzik:

![Imgur](https://imgur.com/wyC32nH.png)

A disznók azok, akik elkötelezettek a szoftver projekt sikerében. Ők azok, akik a
„vérüket” adják a projekt sikeréért, azaz felelősséget vállalnak érte. A csirkék
is érdekeltek a projekt sikerében, ők a haszonélvezői a sikernek, de ha esetleg
mégse sikeres a projekt, akkor az nem az ő felelősségük. A mesét 2011-ben [eltávolították](https://www.scrum.org/resources/chickens-and-pigs)
a hivatalos Scrum Guide-ból, mert sokan becsmérlőnek érezték a metafórát. Így lett
a disznóból „alkalmazott” vagy „résztvevő”, akikre összességében Scrum Team-ként is
hivatkoznak, a csirkéből pedig „érdekelt fél”. A Scrum alapvető egysége tehát ez
a néhány emberből alkotott csapat, azaz a Scrum Team. A Scrum három specifikus
felelősségi kört különböztet meg a Scrum Teamen belül: 

<dl>
  <dt>Scrum mester</dt>
  <dd>
	Lényegében ő a projekt menedzser. Ez egy támogató vezető szerepkör, fő célja
	a csapat teljesítményének növelése és a munkát akadályozó tényezők elhárítása,
	amelyek gátolják a csapatot abban, hogy a sprint célját megvalósítsa. A scrum
	mester nem a csapat vezetője (a csapat önszerveződő), hanem a csapat és a külső
	tényezők közötti összekötő. Ügyel arra, hogy a scrum folyamatot megfelelően
	alkalmazzák. Ő tartatja be a scrum szabályait. A Scrum Master felelős a Scrum
	Team eredményességéért. Ezt úgy teszi meg, hogy lehetővé teszi a Scrum csapat
	számára, hogy saját munkamódszereit javítsa, a Scrum keretein belül maradva.
	Kulcsfontosságú feladatának számít annak biztosítása, hogy a csapat az elvégzendő
	feladatokra koncentráljon.
  </dd>
  <dt>Terméktulajdonos (Product Owner)</dt>
  <dd>
	A termék „szakértője”, aki képviseli az érintetteket, és az ügyfél hangja. Ő
	felel a termék fejlesztési irányáért. A megrendelő szerepét tölti be, ő a felelős
	azért, hogy a csapat mindig azt a részét fejlessze a terméknek, amely éppen a
	legfontosabb, vagyis a felhasználói sztorik fontossági sorrendbe állítása a
	feladata a Product Backlog-ban (Termék Teendőlista). A Product Owner és a Scrum
	Master nem lehet ugyanaz a személy.
  </dd>
  <dt>Fejlesztők (Developers)</dt>
  <dd>
	A fejlesztők (általában 5-9 fő) azért felelősek hogy a termék elkészüljön. A
	csapattagok különféle képességei lehetővé teszik, hogy a feladatot közösen
	megoldják (fejlesztő, tervező, tesztelő stb.). A fejlesztők olyan szakemberek,
	akik azon dolgoznak, hogy minden egyes Sprint végén leszállítható legyen a
	termék egy „Kész” potenciálisan kibocsátható növekménye. A növekmény elkészítésében
	csak a ők vesznek részt.
  </dd>
</dl>

A Scrum Teamek keresztfunkcionálisak, ami azt jelenti, hogy rendelkeznek mindazon
kompetenciával, ami ahhoz szükséges, hogy minden Sprintben értéket teremtsenek. Ezen
kívül önmenedzselőek, azaz csapaton belül döntik el, hogy ki milyen munkát végez el,
mikor és hogyan. A Scrum Team megfelelően kicsi, hogy gyors maradjon és elég nagy,
hogy jelentős mennyiségű munkával készüljön el egy Sprinten belül. Tipikusan 10
vagy kevesebb emberből áll.

A Scrum Team feladata minden termékkel kapcsolatos tevékenység: az érdekelt felekkel
való együttműködés, ellenőrzés, karbantartás, üzemeltetés, kísérletek végrehajtása,
kutatás és fejlesztés, valamint bármi más, amire szükség lehet.

Az **egyéb érintettek** (ők voltak a 2011 előtti terminológiában a *„csirkék”*) nem
részei a scrum folyamatnak, de figyelembe kell venni őket. Az agilis szoftverfejlesztés
egyik fontos aspektusa, hogy bevonják a felhasználót a fejlesztési folyamatba, a
tőlük érkező visszajelzéseket figyelembe veszik a sprintek tervezésénél.

<dl>
  <dt>Üzleti szereplők (Stakeholders)</dt>
  <dd>
	Azok az emberek, akik lehetővé teszik a projekt létrehozását és akiknek a termék
	hasznot fog hozni (megrendelők, forgalmazók). Közvetlenül csak a sprintáttekintő
	megbeszélésen (Sprint Review) vesznek részt a folyamatban.
  </dd>
  <dt>Menedzserek</dt>
  <dd>
	A fejlesztésben részt vevő szervezeti egységek munkakörnyezetét teremtik meg.
  </dd>
</dl>


### Scrum munkaanyagok (Scrum artifacts)

Az agilis fejlesztés a működő szoftvert előnyben részesíti az átfogó dokumentációval
szemben. A Scrum 3 munkaanyag (artifact) meglétét írja elő:

<dl>
  <dt>Termék teendőlista (Product Backlog)</dt>
  <dd>
	A Terméktulajdonos által vezetett lista, ami tartalmazza az összes szükséges funkciókat,
	követelményeket (sztorikat), amit a termékben a jövő során fejleszteni kell.
	Sohasem végleges a lista. Dinamikusan változik, mivel az érdekekelt felekkel
	együtt kerül egyeztetésre. A Terméktulajdonos minden sztorihoz prioritást, fontossági
	sorrendet rendel, így tudja szabályozni, hogy melyeket kell elsősorban elkészíteni,
	így a Sprint Planning során a csapattagok láthatják, hogy ami a Backlog-ban
	legfelül van, azt szeretné a vevő leghamarabb készen látni.
  </dd>
  <dt>Sprint teendőlista (Sprint Backlog)</dt>
  <dd>
	Ebben a dokumentumban az aktuális sprintre bevállalt munkák, storyk vannak felsorolva,
	ezeket kell adott időn belül a csapatnak megvalósítania. A sztorik tovább vannak
	bontva taszkokra, és ezeket a taszkokat vállalják el a tagok a Daily Meeting
	során. Ez a feldarabolása a feladatoknak a feladat minél jobb megértését segíti.
  </dd>
  <dt>Növekmény (Increment)</dt>
  <dd>
	A Növekmény (más szóval Inkrementum) a Sprintben leszállított Termék Backlog
	elemeknek és az összes megelőző Sprint során szállított növekmények értékének
	összessége. A Sprint végére az új növekménynek „Kész”-nek, azaz használhatónak
	kell lennie, és meg kell felelnie a Scrum Csapat által meghatározott „Kész”
	definíciójának (a Definition of Done az Inkrementum állapotának formális leírása
	abban az időpillanatban, amikor megfelel a termék számára előírt minőségi
	kritériumoknak). Felhasználható állapotban kell lennie független attól, hogy
	a Terméktulajdonos úgy dönt, hogy ténylegesen kibocsátja-e azt.
  </dd>
</dl>


## 10. Ismertesse az Adapter tervezési mintát.

Az informatikában a programtervezési mintának (Software Design Patterns) nevezik a
gyakran előforduló programozási feladatokra adható általános, újrafelhasználható
megoldásokat. A tervminták nem nyújtanak kész tervet, amit közvetlenül le lehet
kódolni. Céljuk az, hogy leírást vagy sablont nyújtsanak. Segítik formalizálni a
megoldást.

Objektum orientált programok esetében a tervezési minta leírása megadja azokat az
egymással kommunikáló objektumokat, osztályokat, amelyek együttes viselkedése az
adott problémára megoldás lehet. A legtöbb tervminta objektumorientált környezetre
van kidolgozva. A tervezési minták alacsonyabb szintűek, mint az architekturális
minták, amelyek a teljes rendszer általános felépítését jellemzik (pl. MVC).

A programtervezési minták a 90-es évek elején (1994) tettek szert népszerűségre,
amikor a négyek bandájaként (*„Gang of Four”* vagy **GoF**) emlegetett *Erich Gamma*,
*Richard Helm*, *Ralph Johnson* és *John Vlissides* programozó négyes kiadta a
[Programtervezési minták](https://www.libri.hu/konyv/erich_gamma.programtervezesi-mintak.html) című könyvüket,
amely ma is alapjául szolgál az objektumorientált programozási minták kutatásának.
Ez a könyv összesen 23 mintát mutat be, és a következő kategóriákba sorolja őket:
* **létrehozási minták** (a példányosítási folyamat elvont ábrázolásai),
* **szerkezeti minták** (megkönnyítik a szoftver tervezését az entitások közötti kapcsolatok
egyszerű azonosításával, felderítésével),
* **viselkedési minták** (az osztályok és objektumok közötti kommunikációval, a felelősségi
körök kijelölésével foglalkoznak).

Az **Illesztő** (*Adapter*) tervezési minta a *szerkezeti minták* csoportjába tartozik.
A nem összeillő interfészek együttműködését teszi lehetővé, akkor használjuk, amikor
két különböző osztály nem kompatibilis interfészét szeretnénk együttműködésre bírni.
Az adapter tervezési minta megoldást nyújt arra az esetre, amikor van egy osztályunk,
ami alkalmas egy bizonyos feladat elvégzésére, de az általa nyújtott interfész
eltér attól, amit a szolgáltatást igénybevevő osztály (ügyfél) elvár. Az adapter
minta konvertálja az osztály interfészét az ügyfél által elvárt alakra.

**Alkalmazása:**
* Egy meglévő osztály felhasználásánál, aminek felülete nem megfelelő,
* Újra felhasználható osztály létrehozásánál, ami képes előre nem ismert osztályokkal
együtt működni.

**Kétfajta illesztő minta lehetséges:**

<dl>
  <dt>Objektum illesztő</dt>
  <dd>
	Az illesztő tartalmazza annak az osztálynak egy példányát, amelyet becsomagol,
	hívásokat indít a becsomagolt példány objektum felé és ezek eredményét adja át
	a kliensnek.
  </dd>
  <dt>Osztály illesztő</dt>
  <dd>
	Úgy készül, hogy megvalósítja vagy örökli mind várt (ügyfél) interfészt, mind
	a már korábban létező (szolgáltató) interfészt, vagyis az Adapter az illesztendő
	(szolgáltató) osztály leszármazottja. 
  </dd>
</dl>

## 11. Ismertesse és hasonlítsa össze az MVC és MVP tervezési mintákat.

A szoftver teljes architektúráját definiáló mintákat nevezzük **architekturális
mintáknak** (*architectural pattern*). Az architekturális minta felvázolja egy
szoftver architektúrájának kialakítását, definiálva az architekturális elemeket
és azok kapcsolatait, a teljes rendszer általános felépítését jellemzi.

### MVC

A modell-nézet-vezérlő (model-view-controller, MVC) egy architekturális minta. Összetett,
sok adatot a felhasználó elé táró számítógépes alkalmazásokban gyakori fejlesztői
kívánalom az adathoz (modell) és a felhasználói felülethez (nézet) tartozó dolgok
szétválasztása, hogy a felhasználói felület ne befolyásolja az adatkezelést, és az
adatok átszervezhetők legyenek a felhasználói felület változtatása nélkül. A modell-nézet-vezérlő
ezt úgy éri el, hogy elkülöníti az adatok elérését és az üzleti logikát az adatok
megjelenítésétől és a felhasználói interakciótól egy közbülső összetevő, a vezérlő
bevezetésével. Az MVC egy olyan tervezési architekturális minta, mely megfelelő
útmutatást ad az alkalmazás funkcionális részeinek szétválasztására, de a megvalósítás
részleteit nem elemzi.

A mintát Trygve Reenskaug írta le először 1979-ben, miután a Smalltalk nyelv fejlesztésén
dolgozott a Xerox kutatói laborban. Az eredeti megvalósítás részletesen az *Applications
Programming in Smalltalk-80: How to use Model-View-Controller* című tanulmányban olvasható.
A megjelenés elválasztása az modelltől platformtól függetlenül jól alkalmazhatónak
bizonyult, de asztali grafikus alkalmazásokban a felhasználói felületben gyakran
összeolvadt a nézet és a vezérlő. A webes világ szerver-kliens architektúrájában
azonban ez a két szerep szükségszerűen szétvált: míg a nézet elsősorban a kliensen
megjelenítendő adatot definiálta, addig a vezérlő a szerveren futott. A jól bevált
(platformfüggetlen) alapelvek mellett tehát az alkalmazások felépítése is indokolta
az MVC-minta alkalmazását a weben. Ahogy a kétezres években a web mindinkább teret
nyert, gyakorlatilag de-facto szabvánnyá vált és mára szinte eretnekségnek számít
nem MVC-re építeni egy webes alkalmazást.

*Az MVC-minta az alábbi részekből áll:*

* **Modell**: Az alkalmazás adatait és az ahhoz tartozó üzleti logikát tartalmazza.
Maga a minta nem definiálja, hogy egy többrétegű architektúrában pontosan meddig is
tart a modell. Tágabb értelemben a leghátsó adattárolási réteget, az adatbázisokat
is beleértjük, szűkebb értelemben a vezérlővel közvetlen kapcsolatban lévő üzleti
logikai réteg osztályai tartoznak csak ide. Általában a modell a legnagyobb és
legbonyolultabb része egy nagyobb alkalmazásnak, hiszen az adatok tárolásán túl itt
történik azok leképezése szemantikailag jobban értelmezhető üzleti objektumokká
és üzleti logikává (itt kapnak pontos jelentést a nyers adatok, mondhatni: itt
lesz az adatból információ).
* **Nézet**: Megjeleníti a modellt egy megfelelő alakban, mely alkalmas a felhasználói
interakcióra, jellemzően egy felhasználói felületi elem képében. Különböző célokra
különböző nézetek létezhetnek ugyanahhoz a modellhez.
* **Vezérlő**: Az eseményeket, jellemzően felhasználói műveleteket dolgozza fel és
válaszol rájuk, illetve a modellben történő változásokat is kiválthat. Az egyes
vezérlők előtti közös műveletek elvégzéséért felelős vezérlőt *elővezérlőnek*, vagy
az angol terminológia alapján **Front Controller**nek hívjuk. Az elővezérlő biztosítja
az alkalmazás egyetlen belépési pontját, segítségével mindegyik vezérlő rajta
keresztül hívódik meg. Az objektumorientált programozás elve szerint az elővezérlőt
is meg lehet valósítani osztályként (tipikusan Egyke, azaz Singleton).
* **Szolgáltatás (Service)**: A vezérlő és a modell közötti réteg. Hívják még Business
Logic rétegnek is. A modelltől kér le adatokat és a vezérlőnek adja azt. Ennek a
rétegnek a segítségével az adat tárolás (modell), adat lekérés (szolgáltatás) és
az adat kezelés (vezérlő) elkülöníthetőek egymástól. **Mivel ez a réteg nem része
az eredeti MVC mintának, ezért használata nem kötelező**.

A vezérlés menete általánosságban a következőképp működik:

1. A felhasználói felületen a felhasználó eseményt vált ki.
2. A vezérlő átveszi a bejövő eseményt a felhasználói felülettől, gyakran egy bejegyzett
eseménykezelő vagy visszahívás útján.
3. A vezérlő az eseménynek megfelelően kapcsolatot teremt a modellel, annak adatokat
adva át. A modellben tárolt adatok akár meg is változhatnak.
4. A vezérlő meghívja a nézetet, amely a modelltől elkéri az adatokat, és azokat
megjeleníti. A nézet a modellből nyeri az adatait. A modellnek nincs közvetlen tudomása
a nézetről.
5. A felhasználói felület újabb eseményre vár, mely az elejéről kezdi a kört.

### MVP

A **modell-nézet-prezenter** (*Modell-View-Presenter*, *MVP*) egy architekturális
minta, amely az MVC-mintából alakult ki. Az MVP-modell főleg olyan alkalmazásokban
nyújt jelentős előnyöket – hasonlóan az MVC-hez –, ahol komplex adathalmazokon kell
műveleteket végezni, és ezek eredményeit a felhasználó elé tárni. A mintát felhasználó
alkalmazások a minta sajátosságaiból eredően könnyedén alávethetőek egységteszteknek
(unit test).

Az MVP modell három rétegre osztja az alkalmazást. Mindhárom rétegnek jól körülírható
feladatai vannak, és csak a szomszéd réteggel kommunikálhatnak. Ez nagyfokú rugalmasságot
ad: a két szélső komponens egymás tudta nélkül bármikor lecserélhető. Például egy új
adatbázismotor támogatásához nem kell módosítani a felhasználói felületet, illetve
egy új publikus interfész bevezetése sem igényli a modell módosítását.

A háromrétegű architektúrában a felhasználóval a nézet réteg tartja a kapcsolatot,
amely ezért tartalmazza a felületi logikát. A felületi logika feladatai:
* felhasználói interakció fogadása, feldolgozása, és továbbítása az üzleti logika számára
* az adatok megjelenítése (a megjelentéshez szükséges konverzióval)
* a megfelelő nézet előállítása, új nézetek létrehozása.

A felületi logika és maga a megjelenítés két jól elhatárolható feladatkör, amelyet
célszerű szeparálni (a megjelenítés elsősorban nem programozói, hanem tervezői
feladatkör). A Model-View-Presenter (MVP) architektúra lehetőséget ad a felületi
logika leválasztására egy prezentáció (presenter) számára.


Az MVP minta részei:
* A **modell** az alkalmazás által megjelenített és feldolgozott adatok reprezentációja.
* A **nézet** megjeleníti a modellben tárolt adatokat a felhasználó számára, illetve
a felhasználói interakció során bekövetkező eseményeket továbbítja a prezenter felé.
* A **prezenter** tartalmazza a felhasználói interakció feldolgozásáért felelős
tevékenységeket:
	* továbbítja a kéréseket az üzleti logika számára
	* megadja az interakcióra válaszoló nézetet
	* összegyűjti az adatokat, illetve formázza a nézet számára feldolgozható módon.

Az MVP architektúra két esete különböztethető meg:

* **Passzív nézet** (Passive View): passzívnak akkor nevezzük a View réteget, ha
a megjelenítésen kívül nem végez semmilyen feladatot. Ebben az esetben garantáltan
minden logika a Presenter rétegen van. A nézet elsősorban grafikus vezérlők halmazának
tekinthető, nem ismeri a modellt, így a prezentáció adja át a nézet számára a munkafolyamat
állapotot.
* **Felügyelő nézet** (Supervisor View): akkor beszélünk Supervisor View-ről, ha
a View nem csak passzívan megjeleníti az adatokat, hanem egyes vezérlési feladatokat
saját maga is ellát. A nézet ismeri a modellt (le tudja kérni a munkafolyamat
állapotot), és el tud végezni alapvető tevékenységeket.

### Az MVC és MVP tervezési minták összehasonlítása

Az MVC minta Controller eleme az MVP mintában Prezenterként jelenik meg, hasonló, de
nem azonos feladatkörrel. A Prezenter tartalmazza a megjelenítési logikát is, e mellett
a Nézet és a Model között csak rajta keresztül lehetséges a kommunikáció. A Model
az MVP mintában közvetlenül nem válthat ki eseményt a Nézetben, csak a Prezenteren
keresztül.

## 12. Ismertesse a programozási nyelvek generációk szerinti osztályozását.

A programnyelvek változásának egy-egy fontosabb állomását a programozási nyelvek
generációjának nevezzük. Az elektronikus számítógépek nagy generációi tulajdonképpen
meghatározták a programozási nyelvek generációit is.

### Első generáció (1GL)

Az első programozási nyelv a gépi kód volt. Teljes mértékű processzorfüggőség jellemezte.
Az utasítások bitsorozatok voltak, amelyeket a gép előlapján lévő kapcsolókkal
lehetett megadni. Ennek a nyelvnek az utasításait a számítógép képes volt közvetlenül,
minden átalakítás nélkül végrehajtani, értelmezni. A problémákat nagyon precízen
kellett megfogalmazni, lépésekre bontani. Emellett a nyelv erősen gépfüggő
volt, hiszen minden gépen más és más utasításokat használt, az adott problémát minden
géptípus esetén másképpen kellett leírni, megfogalmazni, alkalmazkodva a számolóegység
sajátosságaihoz. Előnyei:
* A leggyorsabb programot eredményezi, mivel nem tartalmaz felesleges utasításokat.
* A CPU és az egyéb hardware-elemek hatékonyságának maximális kihasználása.

A gépi kódot tulajdonképpen nem is lehet igazi programnyelvnek tekinteni, hiszen
a klasszikus értelemben vett programnyelvi elemek (utasítások, vezérlőszerkezetek,
kifejezések) nem jellemzőek rá. Manapság szinte soha senki nem ír programot közvetlenül
gépi kódban, mivel ekkor számos olyan részletre kellene odafigyelni, melyeket egy
magasabb szintű nyelv automatikusan kezelne, valamint minden egyes utasításhoz
számkódokat kellene megjegyezni vagy kikeresni egy listából.

### Második generáció (2GL)

A programnyelvek második generációját képviselik az alacsony szintű (gépközeli)
nyelvek. Ezen nyelveknél megmarad a számítógép erőforrásainak maradéktalan kihasználhatósága,
a memóriacímek, a regiszterek, a verem és a megszakítások közvetlen elérhetősége,
programozhatósága.

Ilyen második generációs nyelv az [Assembly](https://hu.wikipedia.org/wiki/Assembly),
melynek fordítóprogramja az [assembler](https://hu.wikipedia.org/wiki/Assembler).
Az alacsony szintű nyelveknél minden gépi utasításnak megfelel egy nyelvi utasítás
(egy nyelvi utasítás azonban állhat több gépi utasításból is). Az utasítások már
egyszerűsített angol szavak, így sokkal könnyebb megjegyezni őket. Az utasítások
számkódjait néhány betűs (2-3-4 betűs) ún. **mnemonikokkal** helyettesítették. Egy
ilyen mnemonik (emlékeztető szócska) a gépi kódú utasítás jelentéstartalmára utalt.
Például a *„memória-tartalom beolvasása egy regiszterbe”* (bemozgatás) az angol
MOVE = mozgatni szó alapján a ```MOV``` mnemonikot kapta. A *„két szám összeadása”*
az angol ```ADD``` = összeadni mnemonikot kapta.

Megjelennek az adatok és az adatok helyfoglalását, a programkód memóriába helyezését
definiáló utasítások is. A memóriacímek azonosítóval való ellátására is van lehetőség.
Elnevezhetjük az adatok kezdőcímét, ebből alakul ki később a változó fogalma. Az
Assembly primitív típusnevei (dword, word, byte,...) még nem jelölték az azonosítók
tényleges típusát, a fordító ezeket mindössze a tárigény-szükséglet kiszámítására
használta fel.

Habár az egyes architektúrák assembly nyelvei hasonlóak, mégis különböznek annyira,
hogy az assembly kód ne legyen hordozható. Minden egyes processzor-családnak saját
assembly nyelve van.

### Harmadik generáció (3GL)

A számítógépek alkalmazási területének bővülése szükségessé tette a programok fejlesztési
idejének csökkentését, azaz felmerült az igény, hogy a programokat minél gyorsabban írják
meg a programozók. A gépi kód és az assembly nehézkessége, géphez igazodása miatt nem
volt erre alkalmas.

A 60-as évek elején jelentek meg az első **magas szintű programozási nyelvek**. Az új
nyelvek struktúrája már nem a számítógép sajátosságaihoz, hanem a problémához igazodott,
a programozóknak itt már nem kellett a gépi végrehajtással foglalkoznia. A magas szintű
elnevezés arra utal, hogy nagyobb mértékű az elvonatkoztatás (absztrakció) a gépi kódtól.

A programnyelvek e generációjánál a változófogalom pontosabb megjelenése az egyik
legfontosabb tulajdonság. **A változó azonosítója nem memória-kezdőcímet, hanem egy
egész memóriatartományt jelöl**. A változófogalom mellett kialakul a típusfogalom,
és lehetőség van arra, hogy a programozó saját típusokat is létrehozzon.

Az assembly nyelv ugróutasításaiból megszervezhető vezérlési szerkezetek körét
csökkentették, és rögzítették azokat:
* **szekvencia**: az utasításokat a forráskódban rögzített sorrendben kell végrehajtani,
* **szelekció**: feltételes elágazás,
* **iteráció**: adott programrész ismétlése (ciklus).

A vezérlési szerkezetek e formája áttekinthető, egyszerű, könnyen olvasható kódot
eredményez. Mills bizonyította, hogy minden algoritmus kódolható a fenti három
vezérlési szerkezet használatával, így az ugró utasítások szükségtelenné váltak.
Természetesen, amikor a fordítóprogram a gépi kódú változatot generálja, akkor a
fenti szerkezeteket ugró utasítások formájában valósítja meg – hiszen a gépi kódban
csak ezek szerepelnek.

Az eljárás (és függvény) nyelvi elemmé vált. Az eljárásoknak neve volt, és rögzített
paraméterezése (formális paraméterlista). Ez leírta, hogy az eljárás meghívása során
milyen adatokat, értékeket kell az eljárás számára átadni. Az eljárásoknak lehetnek
név, illetve cím szerint átadott paraméterei is.

A harmadik generációs programnyelveket feladatorientált vagy eljárásorientált
(procedurális) nyelveknek is nevezzük, mivel felépítésükből fakadóan a programfejlesztő
számára egy program adott részfeladatainak megoldására szolgáló struktúrákat (eljárásokat)
kínálnak. A procedurális nyelvek már nem processzor függőek. A fordítóprogram ismeri
az adott számítógép processzorának gépi kódját – és a procedurális nyelven megírt
magas szintű kódot az adott gépi kódra fordítja. Amennyiben a programot más platformon
is szeretnénk futtatni, úgy a magas szintű forráskódot az adott számítógépre írt
fordítóprogrammal újra kell fordítani – a forráskód bármilyen változtatása nélkül.

Harmadik generációs nyelvek:
* [Fortran](https://hu.wikipedia.org/wiki/Fortran)(1957)
* [ALGOL](https://hu.wikipedia.org/wiki/ALGOL)(1958)
* [COBOL](https://hu.wikipedia.org/wiki/COBOL)(1959)
* [BASIC](https://hu.wikipedia.org/wiki/BASIC)(1964)
* [C](https://hu.wikipedia.org/wiki/C_(programoz%C3%A1si_nyelv))(1972)

A harmadik generációs programnyelveket a mai napig használják. Igen sokféle probléma
megoldására alkalmasak. Némelyek mára objektumorientált elemekkel bővültek (Fortran,
COBOL).

### Három és feledik generáció (3.5GL)

A harmadik generációs programnyelvek nyitva hagytak egy nagyon fontos problémát:
a felhasználó által definiált típusokhoz nem lehet operátorokat definiálni, emiatt
kifejezésekben nem lehet az új típusokat felhasználni. Vagyis a felhasználói adattípus
kevesebbet ér, mint a gyári, eleve létező elemi típus. Az objektum orientált programozási
nyelvek (OOP nyelv) ezen a ponton jelentenek fejlődést. A felhasználó sokkal egyszerűbben
és szabadabban készítheti el a saját típusait. Meglévő típusok továbbfejlesztésével
(öröklődés) kevés munkával készíthet új típusokat. A saját típusaihoz (általában)
készíthet operátorokat is (melyeknek jelentését természetesen le kell programozni).
Ezek után a saját típus szinte minden szempontból egyenragúvá válik a nyelvi
alaptípusokkal. A saját típusokhoz nem csak operátorokat rendelhet, hanem megadhat
függvényeket és eljárásokat is, amelyek az adott típusú adatokkal végeznek valamilyen
műveletet. Mivel ezen függvények és operátorok az adott típushoz tartoznak, a típus
részeinek tekintendők. Az egy típusba sorolt adattároló változók (mezők), a hozzájuk
tartozó műveletek és operátorok csoportját (halmazát) osztálynak nevezzük.

A nyelvek logikája közelít az emberi gondolkodáshoz. Az OOP nyelvek inkább
csak szemléletmódban mások (melyik eljárást és függvényt hova írjuk meg), mint kódolási
technikákban. Ezért az OOP nyelveket nem tekintik külön generációnak.

Az első objektumorientált nyelv a [Simula](https://hu.wikipedia.org/wiki/Simula)
(1967) volt, amit szimulációhoz fejlesztettek ki. Az objektumok voltak a legfontosabb
információreprezentációk. Az objektumorientáció azonban csak a [Smalltalk](http://nyelvek.inf.elte.hu/leirasok/Smalltalk/index.php?chapter=1)
után vált ismertebbé (1972-1980). Ezzel párhuzamosan kezdett el fejlődni az objektumorientáció
elmélete is.

Vannak tisztán objektumorientált nyelvek, ahol következetesen minden objektum, a
primitívektől kezdve az osztályok, prototípusok, modulok, blokkok is. Arra tervezték
őket, hogy megkönnyítsék, vagy kikényszerítsék az objektumorientációt (Python, Ruby,
Scala, Smalltalk, Eiffel). Vannak más nyelvek, amelyeket főként objektumorientációra
terveztek, de procedurális elemekkel, nyitva hagyva a lehetőséget további paradigmák
bevezetésére (Java, C++, C#, Delphi/Object Pascal, VB.NET). Végül vannak eredetileg
procedurálisnak tervezett, utólag objektumorientált elemekkel bővített nyelvek (PHP,
Perl, Visual Basic, COBOL 2002, Fortran 2003, Pascal).

### Negyedik generáció (4GL)

A negyedik generációs nyelvek közé tartoznak a *nagyon magas szintű programozási
nyelvek*, melyek használata általában egy specifikus alkalmazásra, célra, vagy
feladattípusra korlátozódik. Ezen nyelvek jellemzője, hogy nagyon kevés nyelvi elemmel
dolgoznak, és nagyon egyszerű, szinte mondatszerűen olvasható utasítások fogalmazhatók
meg. Az absztrakció itt még magasabb szintet ér el, próbál a nyelv még emberbarátabb
lenni. Sok esetben már szinte természetes emberi nyelvnek tűnik az, amit a programban
olvasunk. Habár nem általános programnyelv, hanem adatbáziskezeléshez tervezték,
az SQL is a ebbe a csoportba sorolható.

A negyedik generációs nyelvek deklaratív szemléletű nyelvek (szemben a harmadik
generáció imperatív szemléletével), amelyekben a programozó erőfeszítései inkább
az alkalmazáslogikára összpontosulnak (mit) mint a megvalósítás részleteire (hogyan).
A deklaratív programozás két válfaját szokás megkülönböztetni: a logikai és a funkcionális
programozást. A negyedik generációs nyelvek ez utóbbihoz tartoznak. A programozó
deklarálja a kívánt eredmény tulajdonságait, de nem azt, hogy hogyan kell azt
kiszámítani.

### Ötödik generáció (5GL)

Az 5. GL kialakításának a célja az volt, hogy a számítógép oldja meg a problémát
programozó szakember igénybevétele nélkül. Az 5GL a „programozónak” csak azt kell
a számítógép tudtára adni mi a probléma, milyen feltételek mellet kell megoldani,
de a hogyan már a számítógép dolga. Kiderült azonban, hogy nagyobb feladat esetén
a probléma részekre bontása továbbra is embert (programozót) igényel. Felhasználása
pl. központilag vezérelt számítógép-hálózatok, döntéstámogató rendszerek fejlesztése;
valamint a mesterséges intelligenciát fejlesztők eszköze.

Az ötödik generációs nyelvek szintén deklaratív szemléletűek, de már logikai
programozási nyelvek, erősebben kötődnek a matematikai logikához. A logikai programozás
alapgondolata, hogy egy, a matematikai logikán alapuló nyelvet használjunk programozási
nyelvként, végrehajtási módszerként pedig logikai következtetési és tételbizonyítási
módszereket alkalmazzunk. Ez utóbbi már nem a programozó, hanem az adott logikai
nyelvet megvalósító rendszer feladata. A kívánt eredményt tények és szabályok rendszerével
kapcsolatos kérdésre adott válaszként deklarálják.

A legelterjedtebb logikai programozási nyelv a [Prolog](https://hu.wikipedia.org/wiki/Prolog)
(PROgramming in LOGic), ami 1995-ben ISO szabvány lett. Professzionális, gyakorlati
feladatok megoldására alkalmas megvalósításai a deklaratív nyelvi elemek mellett imperatív
elemeket is tartalmaznak és fejlett programozási eszközöket megvalósító könyvtára van.
Más logikai programozási nyelvek is vannak, pl. az [OPS5](https://en.wikipedia.org/wiki/OPS5),
a CLP (Constraint Logical Programming) nyelvcsalád, vagy a Mercury.

### Jegyzetek:
* <span id="note1">[[1]](#1)</span> Ian Sommerville: Szoftverrendszerek fejlesztése - Software Engineering, 64. oldal
* <span id="note2">[[2]](#2)</span> Ian Sommerville: i. m., 65. oldal
* <span id="note3">[[3]](#3)</span> „Noha első látásra hasonlónak tűnhetnek, a diagramok
	és a modellek különböznek egymástól. A modell elvont ábrázolás, amely a modellezett
	dolog céljának meghatározásához szükséges összes elemet (üzleti, kapcsolati,
	rendszer- és egyéb tényezőket)tartalmazza. A diagram ezzel szemben konkrét
	rálátást ad valamire, amit meghatározott környezetben akarunk megérteni. A diagram
	csupán a modell egészének vagy részének egy adott nézőpontja. Egy bizonyos modellezési
	elem csak egyszer szerepelhet a modellben, de ugyanaz az elem több diagramban is
	megjelenthet. [...] A modellek (tehát) több diagramból állnak, a diagramok pedig
	az elemek és azok más elemekkel való kölcsönhatásának ábrázolásai.”
	(Robert A. Maksimchuk - Eric J. Naiburg: UML földi halandóknak, 14. oldal Kiskapu Kiadó Budapest, 2006.)
* <span id="note4">[[4]](#4)</span> Az elvetemült példa forrása: Mészáros Marika – [UML use-case diagram – Megoldások](https://docplayer.hu/2650239-Uml-use-case-diagram-rajzolas-megoldasok-uml-use-case-diagram-megolda-sok.html)
van ott még, ahol ez volt...
* <span id="note5">[[5]](#5)</span> „Amikor egy osztályt tervezünk, egy jól meghatározott
	feladat érdekében tesszük, a feladat leírásában segít, ha olyan állításokat is megfogalmazhatunk,
	melyek mindig igazak egy osztály esetén. Akár azt is mondhatjuk, hogy ezek az logikai
	állítások – bizonyos szempontból – konzisztens állapotban tartják az osztályt. Az
	osztályinvariánsban megfogalmazott állításban osztály attribútumok és függvények
	közötti relációk is megfogalmazhatók. **Az invariáns kifejezés onnan ered, hogy olyan
	feltételeket határoz meg, melyek az osztály példányainak életciklusa alatt minden
	kitüntetett időpillanatban a példányokon végzett műveletek során megőrzik igaz értéküket**.
	Más szóval ezek olyan logikai kifejezések, melyek mindegyike True logikai értékkel
	rendelkezik és változásokra érzéketlen. Egy invariáns általában több logikai állításból
	áll össze, az osztályinvariánst képző logikai állítások az and then logikai operátorral
	vannak összekapcsolva a forráskódban meghatározott fizikai sorrend szerint. Természetesen,
	szigorúan véve egy osztály példány életciklusának minden pillanatában az invariáns nem
	lehet igaz, előfordulhatnak olyan állapotok – tipikusan feldolgozási vagy transzformációs
	lépések közben – amikor az invariáns nem teljesül. Ha jól meggondoljuk, akkor látjuk,
	ilyen esetekben nincs is szükség arra, hogy az invariáns teljesüljön. Ennek megfelelően
	az osztályinvariánsok kiértékelésre csak a nyilvános eljárások meghívása előtt és
	után (mint kitüntetett időpillanat) kerül sor.”
	(Nyékyné Gaizler Judit, Herczeg István: [Az Eiffel programozási nyelv](http://nyelvek.inf.elte.hu/leirasok/Eiffel/index.php?chapter=9#section_8))
* <span id="note6">[[6]](#6)</span> A példa Ficsor Lajos, Krizsán Zoltán, Mileff Péter: [Szoftverfejlesztés](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverfejlesztes/index.html)
	című könyvéből van (10.3 fejezet).
* <span id="note7">[[7]](#7)</span> A példa a Vik Wiki [UML szekvencia diagram – megoldások](https://vik.wiki/images/archive/e/e8/20150113175911%21Szofttech_jegyzet_UML_szekvenciadiagram_mo.pdf)
	című dokumentumából származik.


### Felhasznált (ajánlott) irodalom:

* Wikipédia: [Szoftverfejlesztési folyamat](https://hu.wikipedia.org/wiki/Szoftverfejleszt%C3%A9si_folyamat)
* Wikipédia: [Unified Modeling Language](https://hu.wikipedia.org/wiki/Unified_Modeling_Language)
* Wikipédia: [vízesésmodell](https://hu.wikipedia.org/wiki/V%C3%ADzes%C3%A9smodell)
* Wikipédia: [V modell](https://hu.wikipedia.org/wiki/V_modell_(szoftverfejleszt%C3%A9s))
* Microsoft 365 Team: [Egyszerű útmutató az UML típusú diagramkészítéshez és adatbázis-modellezéshez](https://www.microsoft.com/hu-hu/microsoft-365/business-insights-ideas/resources/guide-to-uml-diagramming-and-database-modeling)
* Online diagram-készítő program: [Diagrams.net](https://app.diagrams.net/)
* Dr. Daróczi, Miklós: [Projektmenedzsment](https://regi.tankonyvtar.hu/hu/tartalom/tamop412A/2010-0019_Projektmenedzsment/index.html)
	* [27. fejezet - A Gantt-diagram](https://regi.tankonyvtar.hu/hu/tartalom/tamop412A/2010-0019_Projektmenedzsment/ch27.html)
	* [28. fejezet - A hálótervezés alapjai](https://regi.tankonyvtar.hu/hu/tartalom/tamop412A/2010-0019_Projektmenedzsment/ch28.html)
* Ficsor Lajos, Krizsán Zoltán, Mileff Péter: [Szoftverfejlesztés](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverfejlesztes/index.html)
	* [A szoftverfejlesztés életciklus modelljei](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverfejlesztes/ch02.html)
	* [RUP folyamatmodell](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverfejlesztes/ch02s06.html)
	* [A használati eset modell](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverfejlesztes/ch08.html)
	* [Objektumorientált tervezés](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverfejlesztes/ch06s02.html)
	* [Állapotgép diagram](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverfejlesztes/ch10s03.html)
* Rétsághy Zsolt, Lajtos Gábor: [Objektumorientált tervezés, UML](http://centroszet.hu/tananyag/OOT/index.html)
* Ficsor Lajos, Kovács László, Kusper Gábor, Krizsán Zoltán: [Szoftvertesztelés](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/index.html)
	* [A szoftver életciklusa](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch02s02.html)
	* [V-modell](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch02s03.html#id551431)
	* [Scrum](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch02s03.html#id552054)
	* [A tesztelés alapfogalmai](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch01.html)
	* [A tesztelés szintjei](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch01s03.html)
	* [Teszt tervezési technikák](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch04.html)
	* [Biztonsági tesztelés](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch06.html)
* Dr. Ulbert Zsolt: [Szoftverfejlesztési folyamatok és szoftver minőségbiztosítás](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/)
	* [A szoftverfolyamat modelljei](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch03.html#d0e518)
	* [Objektumorientált tervezés](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch05.html)
	* [Szekvencia diagram](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch06.html#d0e2808)
	* [A rendszer definiálása](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch07.html#d0e3333)
	* [Scrum](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch04.html#d0e1422)
	* [Az UML diagramok típusai](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch06.html#d0e2238)
	* [Rational Unified Process szoftverfejlesztési módszertan](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch03.html#d0e783)
	* [Szoftvertesztelés](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch09.html)
* Szabolcsi Judit: [Szoftvertechnológia](http://johanyak.hu/files/u1/segedlet/szoftvertechnologia/Szabolcsi_Judit_Szoftvertechnologia_2012.pdf)
* Panem Könyvkiadó: [Szoftvertechnológia](https://gyires.inf.unideb.hu/GyBITT/31/index.html)
* Dr. Szepesné Stiftinger Mária: [Rendszertervezés](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0027_RSZ5/index.html)
* Wikipédia: [Dinamikus rendszerfejlesztés folyamata](https://hu.wikipedia.org/wiki/Dinamikus_rendszerfejleszt%C3%A9s_folyamata)
* Wikipédia: [Scrum](https://hu.wikipedia.org/wiki/Scrum)
* Ken Schwaber és Jeff Sutherland: [A Scrum útmutató](https://scrumguides.org/docs/scrumguide/v2020/2020-Scrum-Guide-Hungarian.pdf)
* Wikipedia: [Egységesített racionális fejlesztési módszer](https://hu.wikipedia.org/wiki/Egys%C3%A9ges%C3%ADtett_racion%C3%A1lis_fejleszt%C3%A9si_m%C3%B3dszer)
* Wikipedia: [Programtervezési minta](https://hu.wikipedia.org/wiki/Programtervez%C3%A9si_minta)
* Wikipedia: [Illesztő programtervezési minta](https://hu.wikipedia.org/wiki/Illeszt%C5%91_programtervez%C3%A9si_minta)
* Wikipedia: [Modell-nézet-vezérlő](https://hu.wikipedia.org/wiki/Modell-n%C3%A9zet-vez%C3%A9rl%C5%91)
* Wikipedia: [Modell-nézet-prezenter](https://hu.wikipedia.org/wiki/Modell-n%C3%A9zet-prezenter)
* Bartók Roland: [Az Egységesített Eljárás módszertan](http://mazsola.iit.uni-miskolc.hu/~bartok3/digit/RUP.pdf)
* Vég Csaba: [Rational Unified Process](http://logos2000.weaveworld.org/it/doc/RUP.pdf)
* Csilinkó Ádám: [Agilis módszertan összefoglaló nem csak IT-soknak](https://gantt.hu/agilis-modszertan-osszefoglalo/)
* BME gyakorlati jegyzet: [Dinamikus ellenőrzési technikák](https://ftsrg.mit.bme.hu/rete-lab-lecture-notes/ivt-lab6-dynamic-exercises.html)
* Gregorics Tibor, Heizlerné Bakonyi Viktória, Horváth Győző, Menyhárt László, Pap Gábor Sándorné,
Papp-Varga Zsuzsanna, Szlávi Péter, Zsakó László: [Programozási alapismeretek](http://progalap.elte.hu/downloads/seged/eTananyag/index.html)
	* [Tesztelés](http://progalap.elte.hu/downloads/seged/eTananyag/lecke25_lap1.html)
* Sallai András: [Tesztelés](http://www.szit.hu/doku.php?id=oktatas:programozas:teszteles#dinamikus_teszteles)
* Kollár Lajos, Sterbinszky Nóra: [Programozási technológiák](https://gyires.inf.unideb.hu/GyBITT/21/index.html)
	* [GoF tervezési minták katalógusa](https://gyires.inf.unideb.hu/GyBITT/21/ch04s02.html)
	* [Tervezési minták alkalmazása a gyakorlatban](https://gyires.inf.unideb.hu/GyBITT/21/ch04s03.html)
* Antal Gábor, Dr. Ferenc Rudolf, Dr. Jász Judit, Keleti Márton György, Kicsi András, 
Szarka Tibor Alex, Gercsó Márk: [Programozás I. jegyzet](https://okt.sed.hu/prog1/gyakorlat/)
	* [Tervezési minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/mintakAttekintese/)
	* [Gyártási minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/gyartasiMintak/)
	* [Szerkezeti minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/szerkezetiMintak/)
	* [Viselkedési minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/viselkedesiMintak/)
* Balogh Gergő, Tóth László, Szatmári Attila: [Rendszerfejlesztés II. gyakorlati jegyzet](https://okt.sed.hu/rf2/gyakorlat/kovetelmenyek/)
	* [UML és egyéb diagramok](https://okt.sed.hu/rf2/gyakorlat/UML/)
	* [Unit tesztelés a gyakorlatban](https://okt.sed.hu/rf2/gyakorlat/unit_testing/)
	* [Agilis módszertanok](https://okt.sed.hu/rf2/gyakorlat/agile/)
* Tamás Ferenc: [Programozási nyelvek generációi](https://tferi.hu/programozasi-nyelvek-generacioi)
* Szabó Mária: [Programozás - Strukturált programozás a gyakorlatban](https://www.nive.hu/Downloads/Szakkepzesi_dokumentumok/Bemeneti_kompetenciak_meresi_ertekelesi_eszkozrendszerenek_kialakitasa/7_1155_018_100915.pdf)
* Dr. Nyakóné dr. Juhász Katalin, Dr. Terdik György, Biró Piroska, Dr. Kátai Zoltán: [Bevezetés az Informatikába](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_bevezetes_az_informatikaba/index.html)
	* [A programozás alapjai](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_bevezetes_az_informatikaba/ch09s03.html)
* Dr. Kovács Emőd, Hernyák Zoltán, Radványi Tibor, Király Roland: [A C# programozási nyelv a felsőoktatásban](http://csharptk.ektf.hu/online/index.html)
	* [Történeti áttekintő](http://csharptk.ektf.hu/online/ch01s02.html)
* Bóta András: [Korlát-logikai programozás és alkalmazásai](https://core.ac.uk/download/pdf/160916133.pdf)

[Kezdőlap](../README.md)
