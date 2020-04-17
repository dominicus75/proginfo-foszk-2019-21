[Kezdőlap](../README.md)

# Az informatikai biztonság alapjai – szóbeli tételek

## 1. tétel: Az informatikai biztonság fogalma, feladata.

Az adatvédelem és az adatbiztonság NEM szinonimái egymásnak! Adatvédelem alatt a
személyes és érzékeny adatok jogszabályi ([Infotv](https://net.jogtar.hu/jogszabaly?docid=a1100112.tv))
védelmét érti a jogalkotó, adatbiztonság alatt pedig a számítógépes rendszerekben
tárolt, feldolgozott, vagy továbbított adatok biztonságának fenntartására kell
gondolnunk.

Az informatikai biztonság az informatikai rendszer olyan kedvező állapota, amelyben
a kezelt adatok **bizalmassága (confidentiality)**, **sértetlensége (integrity)** és
**rendelkezésre állása (availability)** biztosított (**CIA elv**), valamint a
rendszer elemeinek biztonsága szempontjából zárt, teljes körű, folytonos és a kockázatokkal
arányos.

*  **bizalmasság**: csak az arra jogosultak ismerhetik meg az információt;
*  **sértetlenség**: az információ tartalma és formája az elvárttal megegyezik,
beleértve az is, hogy az elvárt forrásból származik (*hitelesség*), igazolható,
hogy megtörtént (*letagadhatatlanság*), egyértelműen azonosítható az információval
kapcsolatos műveletek végzője (*elszámoltathatóság*), továbbá rendeltetésének
megfelelően használható;
*  **rendelkezésre állás**: az a tényleges állapot, amikor egy informatikai rendszer
szolgáltatásai az arra jogosultak számára egy meghatározott időben rendelkezésre
állnak és a rendszer működőképessége sem átmenetileg, sem pedig tartósan nincs akadályozva;
*  **zártság**: az összes releváns veszélyt (fenyegetést) figyelembe veszi;
*  **teljes körűség**: a rendszer minden elemére kiterjed a védelem;
*  **folytonosság**: időben folyamatosan megvalósul a védelem;
*  **kockázatokkal arányosság**: a rendszer várható működésének időtartamában a
védelem költsége arányban van a lehetséges kárral.

Az informatikai biztonságot csak egy előre megtervezett, majd a terv alapján felépített
védelmi rendszer garantálhatja, mely teljes körű, zárt és a kockázatokkal arányos.

### 1.1 Mely területeken alkalmazható és milyen biztonsági módszerek vannak.

Az informatikai biztonság két alapterületet foglal magába:
* az **információvédelmet**, amely az adatok által hordozott információk sértetlenségének,
hitelességének és bizalmasságának elvesztését hivatott megakadályozni.
* az **informatikai rendszer megbízható működtetését**, amely az adatok
rendelkezésre állását és a hozzájuk kapcsolódó alkalmazói rendszerek funkcionalitását
hivatott biztosítani.

### 1.2 A biztonsági stratégia meghatározása, biztonsági követelmények, IBSZ (Információbiztonsági szabályzat).

Az informatikai biztonság tervezéséhez, a stratégia kialakításához szükséges, hogy
ismerjük a rendszer különböző területeinek kockázatát. Az informatikai kockázatelemzés
nem védelmi intézkedés, elvégzése önmagában nem erősíti a védelmet, de segít hogy
létrejöjjön a biztonságos informatikai rendszer.

Főbb összetevői:
* Eszközgazdálkodási audit eredménye.
* Fenyegetések felmérése.
* Informatikai sérülékenység felmérése.

Az **Informatikai Biztonsági Szabályzat** az Informatikai Biztonsági Irányelvek
lebontását és a vállalkozás informatikai rendszereire specifikált részletes szabályozást
tartalmazza. Az Informatikai Biztonsági Szabályzat még tovább finomítható, és ennek
kapcsán elkészíthetők az egyes rendszerek informatikai biztonság specifikus beállításait
részletesen szabályozó Biztonsági Konfigurációs Szabályzatok.

Az Informatikai Biztonsági Szabályzat (IBSZ) célja, hogy az adott szervezet által
működtetett informatikai rendszerre vonatkozóan a biztonsági intézkedéseket szabályozza,
meghatározza a számítástechnikai eszközök beszerzésének és használatának, a szoftverkészítés
és alkalmazás, az adatkezelés folyamatának biztonsági szabályait, továbbá az informatikai
szerepköröket, és előírja az egyes szereplők informatikai biztonságot érintő feladatait.

**Az IBSZ által biztosítható:**

* A titok-, vagyon- és tűzvédelemre vonatkozó előírások betartása.
* A személyiségi jogok kellő védelme.
* Az üzemeltetett számítástechnikai eszközök, hardverek, szoftverek, hálózatok,
rendeltetésszerű használata és megfelelő üzemvitele.
* Az üzembiztonságot szolgáló műszaki fenntartási és karbantartási teendők elvégzése.
* Az illetéktelen hozzáférésből és felhasználásból eredő károk megelőzése,
illetve minimális mértékűre való csökkentése.
* Az adatállományok formai és tartalmi helyességének és épségének megőrzése.
* Az alkalmazott szoftverek sértetlenségének, megbízható működésének biztosítása.
* Az adatállományok biztonságos mentése.
* A felhasznált és keletkezett írásos dokumentumok megfelelő kezelésének biztosítása.
* A szervezet vezető beosztású és az informatikai feladatokat irányító dolgozóinak
feladatai, felelőssége és a jogköre az informatikai biztonság tekintetében.
* A jogosultság és a hozzáférés rendszerének dokumentált kialakítása.

A célok elérése érdekében a védelemnek működnie kell az egyes rendszerelemek fennállásának
teljes ciklusa alatt – a megtervezéstől az alkalmazáson (üzemeltetésen) keresztül
a felszámolásukig, és azt követően az elévülés, illetve a selejtezhetőség időtartama
alatt.

### 1.3 A kár jellege, kár érték szintek.

**A károk csoportosítása:**
* közvetlen anyagi (pl. a mindenkori amortizált értékkel vagy az elmaradt haszonnal arányos),
* közvetett anyagi (pl. a helyreállítási költségekkel, perköltségekkel arányos),
* társadalmi-politikai, humán,
* személyi sérülés, haláleset,
* jogszabály által védett adatokkal történő visszaélés vagy azok sérülése (jogsértés).

**Kár érték szintek**

**0: jelentéktelen kár**
* közvetlen anyagi kár 10 000 Ft-ig
* közvetett anyagi kár 1 embernappal állítható helyre
* társadalmi-politikai hatás: nincs bizalomvesztés, a probléma a szervezeti egységen belül marad
* testi épség jelentéktelen sérülése 1-2 embernél
* nem védett adat bizalmassága vagy hitelessége sérül

**1: csekély kár**
* közvetlen anyagi kár 100 000 Ft-ig
* közvetett anyagi kár 1 emberhónappal állítható helyre
* társadalmi-politikai hatás: kínos helyzet a szervezeten belül
* könnyű személyi sérülés 1-2 embernél
* hivatali, belső intézményi szabályozóval védett adat bizalmassága vagy hitelessége sérül

**2: közepes kár**
* közvetlen anyagi kár 1 000 000 Ft-ig
* közvetett anyagi kár 1 emberévvel állítható helyre
* társadalmi-politikai hatás: bizalomvesztés a szervezet középvezetésében, a szervezet jó hírneve sérül
* több könnyű, vagy 1-2 súlyos emberi sérülés
* személyes adatok bizalmassága vagy hitelessége sérül
* egyéb jogszabállyal védett (üzleti, orvosi, stb.) titok bizalmassága vagy hitelessége sérül

**3: nagy kár**
* közvetett anyagi kár 10 000 000 Ft-ig
* közvetett anyagi kár 1-10 emberévvel állítható helyre
* társadalmi-politikai hatás: bizalomvesztés a szervezet felső vezetésével szemben, a
szervezet jó hírneve súlyosan sérül
* több súlyos, vagy tömeges könnyű sérülés
* szolgálati titok bizalmassága vagy hitelessége sérül
* szenzitív személyes adatok, nagy tömegű személyes adat bizalmassága vagy hitelessége sérül
* banktitok, közepes értékű üzleti titok bizalmassága vagy hitelessége sérül

**4: kiemelkedően nagy kár**
* közvetlen anyagi kár 100 000 000 Ft-ig
* közvetett anyagi kár 10-100 emberévvel állítható helyre
* társadalmi-politikai hatás: súlyos bizalomvesztés a szervezet felső vezetésével szemben,
a szervezet működésbeli és/vagy gazdaságbeli helyzete súlyos veszélybe kerül
* 1-2 ember halála, vagy tömeges sérülések
* államtitok, katonai, szolgálati titok bizalmassága vagy hitelessége sérül
* nagy tömegű szenzitív személyes adat bizalmassága vagy hitelessége sérül
* nagy értékű üzleti titok bizalmassága vagy hitelessége sérül

**4+: katasztrofális kár**
* közvetlen anyagi kár 100 000 000 Ft felett
* közvetett anyagi kár több, mint 100 emberévvel állítható helyre
* társadalmi-politikai hatás: súlyos bizalomvesztés a szervezet felső vezetésében és
kormányzati szinten, személyi konzekvenciákkal
* tömeges halálesetek
* különösen fontos államtitok bizalmassága vagy hitelessége sérül


## 2. tétel: A megbízható működés és a rendelkezésre állás.

Az **informatikai rendszer megbízható működtetése**, az adatok rendelkezésre állását
és a hozzájuk kapcsolódó alkalmazói rendszerek funkcionalitását hivatott biztosítani.
Az ITB 12. számú ajánlás a megbízható működés területekre 3 biztonsági osztályt
határoz meg. Az osztályba sorolás alapja az adott osztályban tárolandó adatok
érzékenysége. A három osztály a következő:
* **megbízható működési alapbiztonsági (MM-A) osztály**: 95,5%-nál alacsonyabb
rendelkezésre állású rendszerek
* **megbízható működési fokozott biztonsági (MM-F) osztály**: 99,5%-nál alacsonyabb
rendelkezésre állású rendszerek
* **megbízható működési kiemelt biztonsági (MM-K) osztály**: 99,95%-nál magasabb
rendelkezésre állású rendszerek.

**Rendelkezésre állás = (Összes szolgáltatási idő – Leállás) / Összes szolgáltatási idő * 100**

A rendelkezésreállás javítására két fő lehetőség van:
* csökkenteni kell a hibánkénti állásidőt,
* csökkenteni kell az adott időtartamon belüli hibák számát.

Problémát jelenthet a külső szolgáltatóktól való függés, mivel az általuk vállalt
elhárítási idők meghatározzák a vállalható szolgáltatási szint célokat.

### 2.1 Rendelkezésreállás menedzsment.

A rendelkezésreállás az informatikai elem vagy szolgáltatás egy adott időpontban
vagy időintervallumban normál működésre kész állapotát jelenti. Ez a jellemző adott
időintervallumra vonatkoztatva a rendelkezésreállás tényleges és előírt értékének
hányadosával jellemezhető. A rendelkezésreállás menedzsment célja az üzleti igényeknek
megfelelő rendelkezésreállás tervezése, figyelése és a szolgáltatások, informatikai
infrastruktúra ilyen jellegű képességeinek folyamatos javítása.

Az informatikai rendszerek és szolgáltatások főbb tervezési szempontjai, melyeknek
teljes életciklusuk során, a tervezéstől, a megszüntetésükig meg kell felelniük:

* **Megbízhatóság (reliability)**: egy információtechnológiai összetevő azon képessége,
hogy ellásson egy megkívánt funkciót meghatározott körülmények között, egy meghatározott
időtartamra (jellemzi az informatikaszolgáltatás hibatűrő képességét).
* **Karbantarthatóság (maintainability)**: egy számítógépes komponens vagy szolgáltatás
azon képessége, hogy meg lehet tartani egy olyan állapotban, vagy vissza lehet állítani
egy olyan állapotba, amelyben képes ellátni a megkívánt funkciót.
* **Szolgáltatási képesség (serviceability)**:  külső fél által biztosított szolgáltatásokra
vonatkozó, szerződés keretén belül biztosított rendelkezésreállási, megbízhatósági
és karbantarthatósági jellemzők.
* **Biztonság (security)**: lehetővé teszi a számítógépes komponensek vagy informatikai
szolgáltatások elérését biztonságos körülmények között.

A rendelkezésreállás menedzsment tevékenységek két fő részre bonthatók. A kockázatok
felmérését végző **kockázat analízisre** és a bekövetkező negatív hatások kezelését
végző **kockázat menedzsmentre**.

A **kockázat analízis** során felmérjük az informatikai erőforrásokat, meghatározzuk
az őket érintő szándékos és véletlen jellegű veszélyeket, és megállapítjuk az
erőforrások sebezhetőségi szintjét. Az informatikai erőforrásokba a hardver és
szoftver elemeken kívül az adatok és a személyzet is bele tartozik.

A kockázat kezelése (**kockázat menedzsment**) során intézkedéseket teszünk az eszközök
sebezhetőségének csökkentésére. A kockázat számításakor figyelembe vesszük az esemény
hatását és a bekövetkezés valószínűségét. A kockázatok kezelése olyan intézkedésekben
nyilvánul meg, amely a tervezést és az infrastruktúra kialakítást is magában foglalja.

A fizikai környezet kialakításánál a számítástechnikai központok elhelyezkedését,
az infrastruktúra elrendezését és a környezeti paramétereket meghatározó tényezőket
(klíma, áramellátás) vesszük figyelembe. Az elhelyezkedésnél a szabotázs, árvíz,
robbanásveszély és egyéb katasztrófákat igyekezünk elkerülni, illetve készülünk
fel a hatás csökkentésére. Elrendezést tekintve a hardver egységek több helyszínen
történő elhelyezésével készülünk fel. A kritikus hardver egységeknek megfelelő
környezeti tényezőket biztosíthatunk klíma berendezés, szünetmentes tápegység,
generátor alkalmazásával.

A rendelkezésreállás menedzsment tevékenységek sikeres megvalósításával elérhető,
hogy kevesebb megszakítás történjen az informatikaszolgáltatásban. Amennyiben mégis
bekövetkezik a leállás, a gyors helyreállítással minimalizálható az üzletmenetre
gyakorolt kedvezőtlen hatás. A leállási idők csökkentésével közvetlen a pénzügyi
veszteségek csökkenthetők, vagy elkerülhetők. A karbantarthatósági és a szervizelhetőségi
tevékenységek menedzselésével a kitűzött célok elérése mellett kézben tarthatók a
kiadások is.

## 3. tétel: Vállalati biztonság.

Ma már a vállalatok is egyre inkább belátják, hogy nem lehet csak informatikai
biztonsággal, és elkülönítve a vagyonbiztonság egyes elemeivel foglalkozni, hanem
**a vállalat biztonsága integrált biztonságirányítást és rendszert kíván meg a
vállalatirányításon belül**. A biztonságszervezésnek a problémákat rendszerszemlélettel
kell megközelíteni. Ennek kifejezője a vállalat minden pontján az egyenszilárdságú
biztonság követelménye.

Az informatikai biztonságmenedzsment az [MSZ ISO/IEC 17799:2002](http://mszt.hu/web/guest/ingyenes-szabvanylista;jsessionid=2BF6D7C231411A8839E92975F6FB740E?p_p_id=msztwebshop_WAR_MsztWAportlet&p_p_lifecycle=1&p_p_state=normal&p_p_mode=view&p_p_col_id=column-1&p_p_col_count=1&_msztwebshop_WAR_MsztWAportlet_ref=122644&_msztwebshop_WAR_MsztWAportlet_javax.portlet.action=search) *„Az informatikai biztonság
menedzselésének eljárás rendje”*, és az [MSZ ISO/IEC 27001:2014](http://www.mszt.hu/web/guest/ingyenes-szabvanylista?p_p_id=msztwebshop_WAR_MsztWAportlet&p_p_lifecycle=1&p_p_state=normal&p_p_mode=view&p_p_col_id=column-1&p_p_col_count=1&_msztwebshop_WAR_MsztWAportlet_ref=157993&_msztwebshop_WAR_MsztWAportlet_javax.portlet.action=search)
*„Informatika. Biztonságtechnika. Információbiztonság-irányítási rendszerek. Követelmények”*,
szabványokon, a [COBIT](https://hopet.hu/index.php?menu=cobit) 3, és 4-en, és egyéb
[ISACA](https://engage.isaca.org/budapestchapter/aboutchapter/about) anyagokon alapul.

A biztonság egy vállalat esetében üzleti követelmény. A vállalati biztonság elfogadható,
ha a vállalat (a vállalatot alkotó rendszerek) erőforrásainak bizalmasságának, sértetlenségének
és rendelkezésre állásának fenyegetettsége, azaz a kockázatok (belső, és külső)
megfelelnek a stratégiában meghatározott biztonsági szintnek. **A vállalati biztonság
elemi feltétele, hogy a menedzsment felismerje ennek szükségességét, és gondoskodjon
a megfelelő védelmi intézkedésekről**. Ez azonban nem tartozik a könnyen megoldható
kérdések közé, mivel egy évben a szükséges költségek elérhetik a vállalati költségek
akár 5%-át is.

A vállalati biztonsági rendszer a vagyonbiztonság, üzembiztonság és az informatikai
biztonsági alrendszerekből áll, amelyek hivatottak az erőforrások (üzleti, termelési
és informatikai) fenyegetettségét, a kockázatokat az üzleti célkitűzések megvalósításához
szükséges mértékűre csökkenteni.

### 3.1 A központi menedzsment lehetőségei.

A védelmi rendszer kiépítése a vállalat, mint rendszer megközelítését, azaz **rendszerszemléletet
kíván meg**. Ez nem kevesebbet jelent, mint azt, hogy a védelmi rendszert az egész
vállalatra kiterjedően, *az elemek kapcsolatait figyelembe véve, egységesen kell
kiépíteni*. Nem lehetséges a biztonsági kockázatokat megfelelően csökkenteni, ha
egyes kiragadott problémákat oldunk meg, csak további védelmi intézkedésekkel
együtt. **Az informatikai védelem vagyonvédelem nélkül nem hozhatja a kívánt eredményt**.
A biztonsági szabályozási és kontroll rendszert tehát integrált módon, bevált
szabványok és ajánlások felhasználásával kell megvalósítani. Az így kialakított
védelmi rendszert *információbiztonság irányítási rendszernek (IBIR)* nevezzük.

Az információbiztonsági szabályozási rendszer felépítése háromszintű:
1. a szervezet vezetése által megfogalmazott **irányelvek, magas szintű elvárások**
  (információbiztonsági irányelv/politika, IBP);
2. az információbiztonsági irányelvek megvalósítását meghatározó **operatív szabályozás**,
  (információbiztonsági szabályzat);
3. az egyes gyakorlati kérdések részletes szabályozását tartalmazó **eljárásrendek,
munkautasítások, ellenőrző listák**, amelyek az IBSZ részeként lehetnek kötelezőek,
vagy ajánlottak.

A kontroll rendszer megvalósítása során, a kockázatok ismeretében három alapvető
kontroll típus kombinációját kell alkalmazni:
*  **megelőző kontroll**: megelőzi, vagy korlátozza egy hiba bekövetkezését, mint
például a fizikai hozzáférés megakadályozása, vagy a szoftverek jogosultságainak
korlátozása;
*  **feltáró kontroll**: lehetőség szerint mielőbb feltárja a bekövetkezett hibákat,
hiányosságot, mint például az ellenőrző összeg a számítási műveleteknél;
*  **helyesbítő kontroll**: a bekövetkezett hibákat, hiányosságokat segít megszüntetni,
hatásukat csökkenteni, az *informatikai katasztrófa-helyreállítási terv* alapján.

A központosított menedzsment célja az, hogy mind a rendszerek működését, mind a
bekövetkezett biztonsági eseményeket figyelemmel kísérjük. Erre egyrészt a hagyományos
rendszer- és hálózatfelügyeleti szoftverek használata, másrészt a biztonsági események
elemzéséhez központi naplógyűjtő rendszer és naplóelemzési jelentések kialakítása
szükséges, amely a lényeges kockázatok szoros felügyeletét teszi lehetővé. A fejlett
biztonsági monitoring része ma már az automatikus sérülékenység vizsgáló eszközök
alkalmazása, amelyek segítik a rendszerek naprakész frissítését, és javaslatot
tesznek a szükséges változtatások telepítésére.

### 3.2 Adatbiztonság, adatvédelem a vállalati környezetben.

Az adatvédelem és az adatbiztonság NEM szinonimái egymásnak! Az adatok kezelését,
gyűjtését, továbbítását jogszabályok határozzák meg. A hazai adatvédelmi szabályozás
egyike a legszigorúbbaknak nemzetközi szinten, alapjait az információs önrendelkezési
jogról és az információszabadságról szóló [2011. évi CXII. törvény](https://net.jogtar.hu/jogszabaly?docid=a1100112.tv)
fekteti le, különös tekintettel a [GDPR](https://eur-lex.europa.eu/legal-content/HU/TXT/HTML/?uri=CELEX:02016R0679-20160504&from=HU)
vonatkozó rendelkezéseire. Adatvédelem alatt tehát a személyes és érzékeny adatok
jogszabályi (GDPR, Infotv) védelmét érti a jogalkotó, adatbiztonság alatt pedig a
számítógépes rendszerekben tárolt, feldolgozott, vagy továbbított adatok biztonságának
fenntartására kell gondolnunk.

Az adatbiztonság az adatok sérülését megakadályozó, a használhatóságát és bizalmas
kezelését lehetővé tévő technológiák és módszerek összessége. A berendezések, adathordozók,
a kommunikációs hálózat és a hozzáférések védelme kiemelt fontosságú az információs
technológia területén.

Az információs rendszerek védelmi intézkedéseit annak megfelelően kell meghatározni,
hogy azokban tárolt, feldolgozott vagy közvetített adatokat milyen biztonsági osztályba
sorolták az adatgazdák. A biztonsági osztályba sorolás során meghatározzák, hogy milyen
kategóriába (pl. alacsony, fokozott, kiemelt) kerülnek bizalmasság, sértetlenség,
és rendelkezésre állás szempontjából.

#### Adatbiztonsági technológiák, módszerek

* **RAID (Redundant Array of Independent Disks):** az adatokat nem egy, hanem a
RAID szintektől függően 2-5 fizikailag független merevlemezen tároljuk, amelyek egy
logikai lemezt alkotnak. Minden RAID szint alapjában véve vagy az adatbiztonság
növelését vagy az adatátviteli sebesség növelését szolgálja.

* **Időzített biztonsági mentés (Backup):** szerver beállításairól, megosztott mappákról
időzített mentés. Típusai:
    * Teljes (Full Backup): a rendszer minden adata válogatás nélkül mentésre kerül.
    A mentési folyamat ezért egyszerű, ellenben sok ideig tart. Amennyiben adataink
    olyanok, hogy nem változnak túl sűrűn, a gyakori teljes mentés sok fölösleges
    adat tárolását okozza. Előnye azonban, hogy a visszaállítás viszonylag gyors.
    * Napi (Daily Backup): csak a biztonsági mentés napján módosult fájlokat archiválja,
    nem módosítja az archiválási bitet.
    * Különbségi (Differencial Backup): a legutolsó normál vagy növekményes biztonsági
    mentés óta létrehozott vagy módosított fájlokról készít biztonsági másolatot,
    a mentést a rendszer nem jelöli a fájlokon (nem törli az archiválandó attribútumot).
    * Növekményes (Incremental Backup): csak a legutolsó normál vagy növekményes
    biztonsági mentés óta létrehozott vagy módosított fájlokról készít biztonsági
    mentést. A biztonsági mentés végrehajtását a rendszer jelöli a fájlokon (törli
    az archiválandó attribútumot).

* **Replikáció:** a védendő és a biztonsági rendszer gyakorlatilag folyamatosan
kapcsolatban áll egymással, és tükrözéssel mindig egyforma állapotban vannak. Ez
a megoldás szinte azonnali helyreállítást kínál.

* **Tükrözés:** egy adathalmaz valós-idejű redundáns tárolása. A különbség a tükrözés
és a másolás vagy biztonsági mentés között az, hogy utóbbiak csak a rendszer egy
adott pillanatban érvényes állapotát rögzítik, míg előbbi folyamatosan követi azt,
így a tükör tartalma minden időpillanatban pontosan egyezik a mintául szolgáló adathalmazéval.
A tükrözésnek elsősorban a hibatűrő rendszerek megvalósításában van szerepe, ahol
lehetővé teszi, hogy az elsődleges tároló egység meghibásodása esetén a másodlagos
eszköz transzparens módon, adatvesztés nélkül vegye át annak feladatait.

Míg a replikáció azonos gépen zajlik (másik partícióra vagy merevlemezre), addig a
tükrözés egy másik gépre történik.

#### Szerverhelység megfelelő kialakítása

A szerverszobák és az adatközpontok áramellátása és általános fizikai infrastruktúrája
különleges figyelmet igényel, hiszen az IT biztonságos működésének alapjait jelenti.
A megbízható fizikai infrastruktúra rendszer alapvető részei:
* a biztonságos áramellátás (szünetmentes tápellátó berendezések, túlfeszültség-, és
  zavarvédelmi megoldások),
* érintésvédelem (üzemszerűen feszültség alatt nem álló, de meghibásodás esetén
feszültség alá kerülő vezető részek érintéséből származó balesetek elkerülésére
szolgáló műszaki intézkedések összessége)
* szabályozott, állandó páratartalom és hőmérséklet,
* a tűzvédelem külső és belső tüzek esetén egyaránt,
* a felügyeleti és menedzsment rendszer,
* a biztonságtechnikai-, beléptető-, vagyonvédelmi rendszerek kialakítása.

#### Adatmegsemmisítés

Az adatmegsemmisítés célja lehet:
* lemezterület felszabadítása
* ismétlődő vagy szükségtelen adatok eltávolítása
* érzékeny információk elérhetetlenné tevése mások számára.

Az adatok minősített törlésére az adatszivárgás megelőzése érdekében van szükség,
mivel az operációs rendszerekbe épített törlési és formázási parancsok magukat az
adatokat a legtöbb esetben érintetlenül hagyják, így pedig azok bármikor visszaállíthatóak.
A **formázás során az operációs rendszer az adatokhoz vezető útvonalakat törli,
nem magukat az adatokat**. Ezért az adatok fizikailag még ott maradnak az adathordozón, és
egy egyszerűen kezelhető, ingyenes visszaállító szoftver segítségével a legtöbb
esetben visszaállíthatóak. Az operációs rendszer jellemzően csupán a merevlemez 1% és
10% közötti területét foglalja el, ezért újratelepítéskor csupán ekkora terület kerül
felülírásra, a merevlemez többi területén tárolt adatok érintetlenül maradnak.

**A biztonságos adattörlés az adatok felismerhetetlenné tétele oly módon, hogy a
helyreállításuk nem lehetséges**. A biztonságos adattörlés célja az **adatszivárgás**
megelőzése. A rendszertől elvárt alapvető követelmény annak biztosítása, hogy a leselejtezni
kívánt adathordozókon, valamint a szervezeten belül tulajdonost váltó eszközökön a
leselejtezéskor, illetve tulajdonosváltáskor **ne maradjon semmilyen adat**. Fontos az
adattörlést kiterjeszteni a PC-k mellett a mobileszközökre (okostelefonokra, tabletekre),
valamint a flash adathordozókra (memóriakártyákra, USB kulcsokra) is.

A szoftveres adattörlési megoldások nullákkal, egyesekkel vagy véletlen karakterekkel írják
felül a törlendő területet. Amennyiben a szoftveres adattörlési megoldások nem elégségesek,
mert elkerülhetetlen a sérült, használhatatlan eszköz leselejtezése, akkor a **megfelelő
fizikai adatmegsemmisítés a merevlemezek esetében az adathordozó teljes megsemmisítésével
történik**. Ennek során olyan erős mágneses mezők hatásának tesszük ki a merevlemezt –
például a Blancco Degausser segítségével –, hogy arról fizikailag eltűnik az adathordozó
felület.

A minősített megsemmisítés alapelvei szerint minden esetben gondoskodni kell arról, hogy
a megsemmisítés megfelelő fizikai eljárással, lehetőleg a szervezeten belül történjen
meg az adatgazda vagy megbízható kezelőszemélyzet által, és jól dokumentálható,
egyértelműen igazolható legyen.

Az adattörlésre alkalmazott megoldással kapcsolatban megfogalmazott követelmények:

a) Annak érdekében, hogy az adattörlések követhetőek és ellen- őrizhetőek legyenek,
az egyes törlésekről kiállított jegyzőkönyveket visszakereshető módon szükséges tárolni.

b) Azért, hogy a jegyzőkönyveket ne lehessen meghamisítani vagy utólag módosítani,
a jegyzőkönyveket elektronikus aláírással érdemes lepecsételni.

c) Annak érdekében, hogy az adattörlések megbízható módon történjenek meg, kizárólag
olyan minősített adattörlési megoldást lehet használni, mely a legszigorúbb biztonsági
előírásoknak is megfelel, és melynek forráskódját független, megbízható szervezetek tanúsították.

d) A **mechanikai hibával rendelkező merevlemezek leselejtezhetőségének érdekében
ezeket a merevlemezeket meg kell semmisíteni**. A megsemmisítésről kiállított
jegyzőkönyvet ugyanabban a rendszerben, visszakereshető módon célszerű tárolni,
mint a törlésről kiállított jegyzőkönyveket. A meghamisítás elkerülése érdekében
a megsemmisítéséről is egyértelmű bizonyítékot kell tárolni.

e) A törlésre alkalmazott szoftveres megoldásnak a merevlemezek törlése mellett
támogatnia érdemes az okostelefonok törlését, a flash meghajtók és memóriakártyák
törlését, a fájlok törlését, valamint a logikai meghajtók törlését

f) A törlésre alkalmazott szoftveres megoldásnak több minősített algoritmust érdemes támogatnia.

g) A törlésre alkalmazott megoldásnak képesnek kell lennie arra, hogy a törölt
adathordozóra vonatkozó azonosítási adatokat a törlési jegyzőkönyvben rögzítse.

h) A törlésre alkalmazott megoldásnak képesnek kell lennie a vállalati környezetek
támogatására, különös tekintettel a szoftver disztribúciójának elősegítésére a hálózatban
lévő kliensekre.


### 3.3 AZ [ITIL](https://hu.wikipedia.org/wiki/ITIL)

Az **ITIL (Information Technology Infrastructure Library – informatikai infrastruktúra
könyvtár)** az Informatikai Szolgáltatás Módszertana. Eredetileg az angol
*CCTA (Central Computing and Telecommunications Agency – Központi Számítástechnikai
és Távközlési Ügynökség)* ajánlása volt. Mivel a gyakorlati alkalmazás tapasztalatai
kedvezőek voltak, a módszertant a piaci környezetben is egyre inkább használni kezdték,
majd elterjedt a szigetországon kívül is. Az ITIL-hez kapcsolódó brit szabvány, a
**BS 15000 ISO/IEC 20000** számon mára szintén nemzetközi szabvány lett, meghatározó
módszertanná vált az informatikai infrastruktúra és informatikaszolgáltatás irányítása
területén. Az ITIL harmadik változatát 1996-ban az Informatikai Tárcaközi Bizottság
Infrastruktúra menedzsment címen [15. számú
ajánlásaként kiadta](https://dsd.sztaki.hu/mockups/itb/ajanlasok/a15/index.html)
adta ki.

Az ITIL-t jó minőségű, költséghatékony informatikai szolgáltatások támogatása céljából
fejlesztették ki, mely kiterjed azok teljes életciklusára, így a tervezésre, bevezetésre,
működtetésre és újabb szolgáltatások bevezetésére. Tartalmazza az informatikai iparágban
elfogadott eljárások és a legjobb gyakorlati módszertanok gyűjteményét az informatikai
szolgáltatások menedzselésének területén. Leírja és definiálja a kulcsfolyamatokat
és egy keretet ad az informatikai szolgáltatás irányítására.

Az ITIL definíciója 5 fő kötetből illetve az ezekhez kapcsolódó kiegészítő anyagokból
áll. A kötetek az alábbi folyamatokat ismertetik:

* A **szolgáltatásstratégia (Service Strategy):** azonosítja azokat a (piaci) lehetőségeket,
amelyeket új szolgáltatások bevezetésével ki lehetne aknázni. Az eredmény egy stratégiai
dokumentum, amely felvázolja az új szolgáltatás tervezésének, megvalósításának, üzembe
helyezésének és folyamatosan javuló minőségben történő nyújtásának folyamatát. A kötet
legfontosabb fejezetei a *Szolgáltatás-portfólió kezelése* és *Pénzügyi menedzsmentje*.
* A **szolgáltatástervezés (Service Design):** eredményeként projekt-terv készül
az előző lépésben keletkezett stratégia által felvázolt szolgáltatás konkrét
megvalósítására. A terv részletezi az új szolgáltatás bevezetésének minden vonatkozását,
a bevezetéshez és üzemeltetéshez szükséges támogató folyamatokkal együtt. A kötet
legfontosabb fejezetei az *Üzemeltetés és üzemvitel biztosítása*, *Kapacitástervezés*
valamint az *Informatikai- és üzembiztonság*.
* A **szolgáltatáslétesítés és -változtatás (Service Transition):** a megtervezett
szolgáltatás létesítéséhez és a környezet módosításához szükséges folyamatok leírása.
Fontos fejezetek a *Változás- és verziókezelés*, *Konfigurációmenedzsment* és *Dokumentációkezelés*.
* A **szolgáltatásüzemeltetés (Service Operation):** kötet tárgyalja a szolgáltatás
folyamatos és hibamentes üzemeltetéséhez szükséges folyamatokat és szervezési kérdéseket.
Legfontosabb fejezetek a *Hiba- és igény- és incidenskezelés*.
* Az **állandó szolgáltatásfejlesztés (Continual Service Improvement):** c. kötet
tárgyalja a szolgáltatás folyamatosan javuló minőségben nyújtásának feltételeit.
Kiemelt fejezetek a *Szolgáltatási szint mérése, riportolása (jelentése) és menedzsmentje*
c. fejezetek.

Az informatikai szolgáltatásmenedzsment az összefoglaló neve azoknak a folyamatoknak
és eljárásoknak, amelyek egy szervezet üzleti, működési igényeit jó minőségben
kielégítik és támogatják. Az ITIL a szolgáltatásmenedzsmenthez tartozó témaköröket
két fő csoportba szervezte:
#### Szolgáltatásbiztosítás
* Szolgáltatási szint menedzsment
* Rendelkezésreállás menedzsment (lásd 2.1 tétel)
* Informatikaszolgáltatás-folytonosság menedzsment
* Kapacitásmenedzsment
* Informatikaszolgáltatás pénzügyi irányítása
#### Szolgáltatástámogatás
* Ügyfélszolgálat
* Incidensmenedzsment
* Problémamenedzsment
* Változáskezelés
* Konfigurációkezelés
* Kiadáskezelés


### 3.4 Az [MSZ ISO/IEC 27001:2014](http://www.mszt.hu/web/guest/ingyenes-szabvanylista?p_p_id=msztwebshop_WAR_MsztWAportlet&p_p_lifecycle=1&p_p_state=normal&p_p_mode=view&p_p_col_id=column-1&p_p_col_count=1&_msztwebshop_WAR_MsztWAportlet_ref=157993&_msztwebshop_WAR_MsztWAportlet_javax.portlet.action=search) jellemzői.

Az ISO 27001 a 27000-es szabványcsalád tagja. A 27000-es szám a nemzetközi szabványosítás
területén az információbiztonság és annak menedzselése témakörének van fenntartva,
több mint egy tucat szabvány tartozik ide. 2005-ben tették közzé, legutóbbi verziója
2013-ban jelent meg.

Az MSZ ISO/IEC 27001:2014 szabvány követelményeket ad meg egy információbiztonság-irányítási
rendszer kialakítására, bevezetésére, fenntartására és folyamatos fejlesztésére az
érintett szervezet környezetében. Követelményeket tartalmaz az információbiztonsági
kockázatoknak a szervezet igényeihez igazodó felmérésére és kezelésére is. Az ezen
szabványban felállított követelmények általános érvényűek, és szándék szerint minden
szervezetre alkalmazandók – tekintet nélkül azok típusára, méretére vagy jellegére.

A szabvány megfogalmazza továbbá azokat a követelményeket, melyek a szervezet
információbiztonsági irányítási rendszerének külső szakértő általi ellenőrzését,
illetve tanúsíthatóságát teszik lehetővé. Vagyis **egy szervezet auditálásához
szükséges (megfelelőségi) előírásokat tartalmazza**. Így a 4-10. fejezetben megadott
egyetlen követelmény kizárása sem fogadható el, amikor egy szervezet e nemzetközi
szabványnak való megfelelést állítja.


## 4. tétel: Felhasználó azonosítás.

### 4.1 Hardver eszközökkel való azonosítás.

### 4.2 Biometriai azonosítás.


## 5. tétel: Jelszavak szerepe, fontossága.

### 5.1 Jelszó használati lehetőségek, és azok támadási eszközei.


## 6. tétel: A kriptográfia fogalma, alapvető feladatai.

### 6.1 A kriptográfia története.


## 7. tétel: Szimmetrikus kulcsú titkosítás jellemzője, fajtái.

### 7.1 Aszimmetrikus kulcsú titkosítás jellemzői, fajtái.

### 7.2 Digitális aláírás.

### 7.3 RSA titkosítás.

### 7.4 Szoftveres titkosítási lehetőségek.


## 8. tétel: Az emberi tényező az IT biztonságban.

### 8.1 A Social Engineering mechanizmusa (humán és számítógép alapú támadások).


## 9. tétel: PC védelmi lehetőségek.

### 9.1 Adatok megsemmisítésének lehetőségei.

### 9.2 Informatikával kapcsolatos törvények.


## 10. tétel: Tűzfalak ismertetése, fajtái, kategóriái.

### 10.1 A proxy működése és jellemzői.

### 10.2 Vállalati routerek hozzáférési listái.

### 10.3 IDS rendszerek, Honeypotok.


### Felhasznált (ajánlott) irodalom:

* Az [informatikai biztonság fogalma](https://hu.wikipedia.org/wiki/Informatikai_biztons%C3%A1g)
* Az [információbiztonság fogalma](https://hu.wikipedia.org/wiki/Inform%C3%A1ci%C3%B3biztons%C3%A1g)
* Göcs László: [Informatika biztonság alapjai](http://www.gocslaszlo.hu/oktatas/infobizt.html) – nappalis prezentációk
* [TCSEC (Trusted Computer System Evaluation Criteria – Biztonságos Számítógépes Rendszerek Értékelési Kritériumai, »Narancs Könyv«)](https://hu.wikipedia.org/wiki/Trusted_Computer_System_Evaluation_Criteria)
* [ITSEC](https://hu.wikipedia.org/wiki/ITSEC)
* Informatikai Tárcaközi Bizottság [12. ajánlása](https://hu.wikipedia.org/wiki/MeH_ITB_12._sz%C3%A1m%C3%BA_aj%C3%A1nl%C3%A1s)
* Informatikai Tárcaközi Bizottság [15. ajánlása](https://dsd.sztaki.hu/mockups/itb/ajanlasok/a15/index.html)
* Horváth Gergely Krisztián: [Közérthetően az IT biztonságról](https://kifu.gov.hu/sites/default/files/IT_brosura_v7.pdf)
* NKI: [IT biztonsági tudástár](https://nki.gov.hu/it-biztonsag/tudastar/)
* Papp Attila, Kürti Sándor: [Az információbiztonság sarokkövei: szabványok és ajánlások](https://index.hu/tech/biztonsag/info/sarokko/)
* dr. Haig Zsolt: [Az információbiztonság szabályzói és szervezeti keretei](http://hadmernok.hu/kulonszamok/robothadviseles7/haig_rw7.pdf)
* Muha Lajos, Krasznay Csaba: [Az elektronikus információs rendszerek biztonságának menedzselése](http://m.ludita.uni-nke.hu/repozitorium/bitstream/handle/11410/11173/Az%20elektronikus%20inform%C3%A1ci%C3%B3s%20rendszerek%20biztons%C3%A1g%C3%A1nak%20menedzsel%C3%A9se_2018.pdf?sequence=1&isAllowed=y)
* Muha lajos: [Informatikai biztonsági szabványok és irányelvek](http://real.mtak.hu/11149/1/1228885.pdf)
* KFKI: [ITIL - az informatikaszolgáltatás módszertana](http://www.itsmf.hu/documents/itil2modszertan_osszefoglalo_v3.1.pdf)
* Vasvári György: [Vállalati biztonságirányítás](http://www.tiphaz.hu/partner/vasware/Vallalati_Biztonsagiranyitas_Szakkonyv.pdf)

[Kezdőlap](../README.md)
