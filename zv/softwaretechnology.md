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
    <th>Fejlesztési ág</th>
    <th align="right">Tesztelési ág</th>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Követelmények meghatározása</dt>
        <dd></dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Felhasználói átvételi tesztelés</dt>
        <dd></dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Rendszertervezés</dt>
        <dd></dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Rendszerteszt</dt>
        <dd></dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Architektúrális tervezés</dt>
        <dd></dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Integrációs teszt</dt>
        <dd></dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td>
      <dl>
        <dt>Komponens tervezés</dt>
        <dd></dd>
      </dl>
    </td>
    <td align="right">
      <dl>
        <dt>Egységteszt</dt>
        <dd></dd>
      </dl>
    </td>
  </tr>
  <tr>
    <td colspan="2" align="center"><h2>Implementáció</h2></td>
  </tr>
</table>


### A két életciklusmodell összehasonlítása

A V-modell hasonlóan a vízesés modellhez nagyon merev, de alkalmazói kevésbé ragaszkodnak
ehhez a merevséghez, mint a vízesés modellnél. Ennek megfelelően jobban elterjedt.
Fő jellemzője a teszt központi szerepe.

| Vízesésmodell | V modell |
|---------------|----------|
|  |  |
|  |  |
|  |  |
|  |  |
|  |  |



## 3. Ismertesse részletesen a használati eset diagramot és annak elemeit (egy konkrét példa is szükséges).

## 4. Ismertesse az állapotautomatát/állapotgép diagramot (state machine, egy konkrét példa is szükséges).

## 5. Ismertesse a sorrend diagramot (egy konkrét példa is szükséges).

## 6. Ismertesse és magyarázza el az objektum-orientált fejlesztés négy tanult alapelvét.

## 7. Ismertesse a RUP módszertant.

## 8. Ismertesse a dinamikus szoftvertesztelési módszereket

## 9. Ismertesse a Scrum módszertant.

## 10. Ismertesse az Adapter tervezési mintát.

## 11. Ismertesse és hasonlítsa össze az MVC és MVP tervezési mintákat.

## 12. Ismertesse a programozási nyelvek generációk szerinti osztályozását.

### Jegyzetek:
* <span id="note1">[[1]](#1)</span> Ian Sommerville: Szoftverrendszerek fejlesztése - Software Engineering, 64. oldal
* <span id="note2">[[2]](#2)</span> Ian Sommerville: i. m., 65. oldal

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
* Ficsor Lajos, Kovács László, Kusper Gábor, Krizsán Zoltán: [Szoftvertesztelés](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/index.html)
	* [A szoftver életciklusa](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch02s02.html)
	* [V-modell](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch02s03.html#id551431)
	* [Scrum](https://regi.tankonyvtar.hu/hu/tartalom/tamop425/0046_szoftverteszteles/ch02s03.html#id552054)
* Dr. Ulbert Zsolt: [Szoftverfejlesztési folyamatok és szoftver minőségbiztosítás](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/)
	* [A szoftverfolyamat modelljei](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch03.html#d0e518)
	* [Objektumorientált tervezés](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch05.html)
	* [Szekvencia diagram](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch06.html#d0e2808)
	* [A rendszer definiálása](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch07.html#d0e3333)
	* [Scrum](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch04.html#d0e1422)
	* [Az UML diagramok típusai](http://moodle.autolab.uni-pannon.hu/Mecha_tananyag/szoftverfejlesztesi_folyamatok_magyar/ch06.html#d0e2238)
* Szabolcsi Judit: [Szoftvertechnológia](http://johanyak.hu/files/u1/segedlet/szoftvertechnologia/Szabolcsi_Judit_Szoftvertechnologia_2012.pdf)
* Panem Könyvkiadó: [Szoftvertechnológia](https://gyires.inf.unideb.hu/GyBITT/31/index.html)
* Wikipédia: [Dinamikus rendszerfejlesztés folyamata](https://hu.wikipedia.org/wiki/Dinamikus_rendszerfejleszt%C3%A9s_folyamata)
* Wikipédia: [Scrum](https://hu.wikipedia.org/wiki/Scrum)
* Wikipedia: [Programtervezési minta](https://hu.wikipedia.org/wiki/Programtervez%C3%A9si_minta)
* Kollár Lajos, Sterbinszky Nóra: [Programozási technológiák](https://gyires.inf.unideb.hu/GyBITT/21/index.html)
	* [GoF tervezési minták katalógusa](https://gyires.inf.unideb.hu/GyBITT/21/ch04s02.html)
	* [Tervezési minták alkalmazása a gyakorlatban](https://gyires.inf.unideb.hu/GyBITT/21/ch04s03.html)
* Antal Gábor, Dr. Ferenc Rudolf, Dr. Jász Judit, Keleti Márton György, Kicsi András, 
Szarka Tibor Alex, Gercsó Márk: [Programozás I. jegyzet](https://okt.sed.hu/prog1/gyakorlat/)
	* [Tervezési minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/mintakAttekintese/)
	* [Gyártási minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/gyartasiMintak/)
	* [Szerkezeti minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/szerkezetiMintak/)
	* [Viselkedési minták](https://okt.sed.hu/prog1/gyakorlat/eloadas/TervezesiMintak/viselkedesiMintak/)

[Kezdőlap](../README.md)
