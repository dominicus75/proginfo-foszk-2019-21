[Kezdőlap](README.md)

# 2019/20 I. félév szóbeli tételek


## 1. tétel

### 1.1 Ethernet szegmensek összekapcsolása az OSI 2. rétegben

Az Ethernet az [IEEE 802.3-as szabványt](https://hu.wikipedia.org/wiki/IEEE_802.3)
megvalósító, korábban [busz](https://hu.wikipedia.org/wiki/Busztopol%C3%B3gia), ma
inkább [csillag](https://people.inf.elte.hu/moaqaci/szamalap_beadando_1/szamitogepes_halozatok_vilaga.htm#_Toc213477392)topológiát alkalmazó helyi hálózat ([LAN](https://hu.wikipedia.org/wiki/Helyi_h%C3%A1l%C3%B3zat)).

**Ethernet szegmens** az Ethernet-hálózat két aktív eszköz (bridge vagy switch) közötti
része, amelyben minden eszköz ugyanazt a fizikai réteget (átviteli közeget) használva
kommunikál. A szegmensek méretét az átviteli közeg elektromos paraméterei határozzák
meg. Egy szegmens hossza UTP kábellel legfeljebb 500 méter, üvegszálas kábellel
akár 2000 méter is lehet.

Az Ethernet szegmenseit akár fizikai, akár adatkapcsolati szinten is össze lehet
kapcsolni. A hálózati híd (network bridge) hálózati szegmenseket tud összekötni
az Adatkapcsolati réteg szintjén, a hardveres MAC-cím alapján irányítva a kereteket.
A hidak feltérképezik az egyes csomópontok (gépek, HUB-ok, stb.) Ethernet címeit,
és csak a szükséges forgalmat engedik át a hídon. Mivel ez szétválasztja a két
hálózatot önálló ütközési tartományokra, több gépet lehet a hálózatra kötni. E
technológia segítségével a közös közeg szegmensekre osztható, melyek belső forgalma
nem zavarja a többi szegmenst, illetve külön szegmensek kapcsolhatók össze, amelyek
így kommunikálhatnak egymással.

### 1.2 Bridge protokollok (statikus, dinamikus)

Bár a híd nem útválasztó, útválasztási táblázatot használ a kézbesítési információk
kiderítéséhez. Figyeli az összes (vele összeköttetésben levő) szegmenst, és felépít
egy arra vonatkozó táblázatot, hogy melyik fizikai cím melyik szegmensben található.
Amikor adattovábbítás zajlik, a híd megnézi a célállomás címét, és összeveti az
útválasztó táblával. Ha a célállomás ugyanabban a szegmensben van, mint ahonnan
az adatcsomag érkezett, akkor a híd nem foglalkozik tovább az adatokkal. Ha azonban
másik szegmensbe kell eljutnia a csomagnak, akkor továbbítja azt a megfelelő helyre.

Amikor a hidakat először kapcsolják be, a tábláik üresek. Egyik híd sem tudja,
hogy a célállomások merre helyezkednek el, így az elárasztásos algoritmust használják:
minden bejövő keretet, amelynek címzettje ismeretlen, továbbadják az összes hozzájuk
kapcsolódó LAN-hoz, kivéve azt, amelyiktől érkezett. Ahogy telik az idő, a fentiek
alapján a hidak lassan megtanulják, hogy a célállomások merre találhatók. Miután
egy célállomás ismertté vált, a felé irányuló keretek már nem képezik elárasztás
tárgyát, hanem csakis a megfelelő LAN felé kerülnek továbbításra. Az az algoritmus,
amit a transzparens hidak használnak, a hátrafelé tanulás (backward learning).

A hálózat topológiája változhat, ahogy állomásokat és hidakat üzembe vagy üzemen
kívül helyeznek, az üzemelésük helyét megváltoztatják. A **dinamikusan változó topológia**
kezelése érdekében minden alkalommal, amikor létrejön egy táblabejegyzés, eltárolják
a keret beérkezésének időpontját is. Amikor egy olyan keret érkezik, amely feladójáról
helyes bejegyzés szerepel a táblában, az időinformációt az aktuális időponttal
írják felül. Ilyen módon a tábla bejegyzéseihez rendelt időpontok megadják, hogy
a híd mikor vett utoljára keretet az adott állomástól. Egy folyamat a hídban időről
időre végignézi a táblát, és törli onnan a néhány percnél régebbi bejegyzéseket.
Ily módon elérhető, hogy kézi beavatkozás nélkül, néhány percen belül ismét visszaálljon
egy olyan állomás normális működése, amelyet levettek a hálózatról, majd annak egy
eltérő pontjára csatlakoztattak vissza.

Egy beérkező keret forgalomirányítása tehát függ attól, hogy melyik LAN felől
érkezett (forrás LAN), valamint melyik LAN irányában (cél LAN) van a célja:
* Ha a forrás és cél LAN azonos, akkor a keretet el kell dobni.
* Ha a forrás és a cél LAN különböző, akkor a keretet továbbítani kell.
* Ha a cél LAN ismeretlen, akkor elárasztást kell alkalmazni.

### 1.3 Feszítőfás hidak

A redundáns topológiák létrehozásának célja az egyetlen hálózati elem meghibásodásából
fakadó leállások kivédése. A nagy megbízhatóságú hálózatok mindegyikében szükség
van redundanciára. A Spanning-tree, azaz feszítőfa protokoll (STP) a redundánsan
kiépített LAN eszközök esetén használt algoritmus, amely kapcsolt vagy hídtechnológiát
alkalmazó hálózatokban biztosítja az útvonalak redundanciáját, de megakadályozza
a nemkívánatos hurkok kialakulását.

A Spanning Tree Protocolt (STP) 1983-ban dolgozta ki Radia Perlman. Az STP egy
minimális konfigurálást igénylő, lényegében önállóan működő protokoll. Azok a
kapcsolók, melyeken engedélyezett az STP az első bekapcsoláskor ellenőrzik a
kapcsolt hálózatok esetleges hurkait. Hurok észlelésekor letiltják az érintett
portok valamelyikét, míg a többi porton aktív marad a kerettovábbítás.

Két hálózati szegmens között kettő vagy több fizikai útvonal létezik. Az
STP feladata, hogy egy időben csak egy útvonal legyen használatban. Az STP a
hálózat összes kapcsolóját egy faszerkezetű, kiterjesztett csillag topológiájú
hálózattal kapcsolja össze. Ezek a kapcsolók folyamatosan ellenőrzik a hálózatot
annak érdekében, hogy ne alakulhassanak ki hurkok és a portok megfelelően
működjenek.

A topológia csúcsán az un. root híd áll, ennek meghatározása egy választási folyamat
eredménye. Minden hálózatban csak egy gyökérponti híd létezik, melyet a kapcsolók
a hídazonosító (bridge ID, BID) alapján választanak ki. Mivel általában a kapcsolók
az alapértelmezett értéket használják prioritásnak, így alapértelmezetten a
legkisebb MAC-című kapcsoló lesz a gyökérponti híd.

Az STP nem azonnal reagál a változásokra. Ha egy összeköttetés meghibásodik,
akkor az STP észreveszi a hibát és kiszámolja a legjobb útvonalakat a hálózaton.
Ez a számítás akár 30-50 másodpercet is igénybe vehet. Ezen idő alatt nincs
adatforgalom az újraszámításban érintett portokon.

### 1.4 Távoli hidak

A hidak lehetnek távoli hidak is, ebben az esetben a híd két csatolófelülete két
különböző helyen lesz elhelyezve és a két „fél” híd között egy üvegkábel kerül
felhasználásra. Így általában max. 2 km hidalható át Ethernet rendszer esetén.


### 1.5 A switching technológia (kapcsolt Ethernet)

Ahogy újabb és újabb állomások csatlakoznak a klasszikus Ethernethez, minden
állomás egyre csökkenő részt kap a rögzített kapacitásból. Esetenként a LAN
telítődhet. Korábban a lokális hálózatok legáltalánosabb aktív elemei a Hub-ok
(elosztók), a Repeater-ek (ismétlők), és a Bridge-k (hidak) voltak, jellemzően koax-
kábellel összekötve, maximum 10Mb/s átviteli sebességgel. A mai hálózatokat
nem csak a sebesség és a kábel típusa különbözteti meg a korábbi megoldásoktól,
hanem a topológia és a hálózat aktív elemei is. Manapság legtöbbször 100Mb/s vagy
1Gb/s sebességű csavart érpárral működő, illetve 1Gb/s vagy 10Gb/s sebességű
optikai hálózatokkal találkozunk. Szinte kivétel nélkül jellemző a lokális
hálózatokra a csillagpontos topológia és a kapcsolt Ethernet, azaz a Switch-ek
és a Router-ek mint aktív hálózati elemek használata.

Ahogy a koax-kábeleket egyre jobban kiszorította a csavart érpár, ennek jellegéből
valamint a már kiépített telefonközpont orientáltságú felépítmény azaz a csillagpontos
topológiából fakadóan a hálózat hosztjait is „telefonközpont jellegű” eszközzel
lehetett csak összekapcsolni. Az ezt megvalósító hálózati összekötő, összekapcsoló
eszköz a Switch (kapcsoló).

Egy LAN switch logikai funkciójában megegyezik a bridge-k funkciójával, azaz
elkülönült hálózati szegmenseket kapcsol össze és a lokális forgalmat nem engedi
ki. A különbség csupán annyi, hogy a swicth képes a portjai között egymástól
függetlenül is kereteket továbbítani. A Switch tehát egy hálózati összekötő elem,
ami alapesetben az adatkapcsolati rétegben dolgozik. A Switch a hozzá csatlakoztatott
eszközök közötti adatáramlást biztosítja. A Switch lényegében egy gyors működésű
többportos (2. rétegbeli) híd. Mindegyik port külön ütközési tartományt hoz létre.

A Switch működése – kapcsoló jellegéből következően – lehetővé teszi, hogy a
keretek az adó állomástól közvetlenül csak a MAC címben szereplő vevő állomáshoz
jussanak el. Ahhoz, hogy ezt a Switch megtehesse, rendelkeznie kell azzal az
információval, hogy melyik portjára milyen MAC című állomás csatlakozott. Ez az
információ egy táblázatban (MAC Address Table), a Switch memóriájában tárolódik,
és a beérkező keretek forráscímeinek segítségével töltődik fel. Mivel minden állomás
a Switch egy-egy egyedi portjára csatlakozik, ha egyszerre több portra érkezik
keret, akkor sem lép fel ütközés, mivel a portok egymástól függetlenek.

A Switch-ek legfontosabb tulajdonságai: a portok száma és típusa (réz/üveg); a
sebesség (10/100/1000); a duplexitás (Full/Half); az áteresztő vagy kapcsolási
képesség (Backplane speed).

### 1.6 Az Ethernet swich-ek típusai

**Kapcsolási módok**
* **Vonalkapcsolt (áramkörkapcsolt) technológia:** az információátvitel előtt
dedikált kapcsolat (kommunikációs áramkör) épül ki a két végpont között, s ez
folyamatosan fennáll, amíg a kommunikáció tart.
* **Üzenetkapcsolt (store-and-forward) technológia:** nem épül ki áramkör, hanem a
teljes üzenet kapcsolóközpontról kapcsolóközpontra halad, mindig csak egy
összeköttetést terhelve.
* **Csomagkapcsolt technológia:** az információt (korlátozott maximális méretű)
részekre (csomagokra) darabolják, s a csomagokat (mint önálló egységeket)
üzenetkapcsolt elven továbbítják.
* **Tárol és továbbít:** A keret továbbítása a teljes keret megérkezése után kezdődik
meg. A kapcsoló újraszámítja a keretellenőrző összeget (CRC, vagy más néven Frame
Control Sequence, FCS), s ha a keret hibás, eldobja.
* **Közvetlen kapcsolás:** A célcím (6 bájt) megérkezése után azonnal megkezdődik
a keret továbbítása a kimeneti porton.
* **Töredékmentes kapcsolás:** A minimális keretméret (64 bájt) megérkezése után
kezdődik a keret továbbítása a kimeneti porton. (Esetlegesen ütköző keret nem
kerül továbbításra).


## 2. tétel

### 2.1 A hálózati réteg helye és legfontosabb feladatai

A hálózat réteg az alatta elhelyezkedő adatkapcsolati réteg szolgáltatásait igénybe
véve, valamint saját szolgáltatásai segítségével szolgálja ki a felette elhelyezkedő
szállítási réteget. Információs alapegysége a csomag. Legfontosabb feladata az,
hogy a csomagok a forrás hoszttól a cél hosztig eljussanak. A hálózati réteg feladata
– tehát az általa nyújtott szolgáltatás – az útvonalválasztás és a forgalomirányítás.
A szolgáltatást olyan módon kell biztosítani, hogy a szállítási réteg már csak a
számára releváns adatokat kapja meg. Ehhez arra van szükség, hogy a szolgáltatások
függetlenek legyenek a hálózat – azon belül is – az útválasztók (Router-ek)
kialakításától.

### 2.2 Datagram és virtuális áramkör alapú szolgáltatás

A felkínált szolgáltatás típusától függően kétfajta szerveződés lehetséges. Az
*összeköttetés nélküli szolgáltatás* esetében a hálózatba érkező csomagok egyenként
és egymástól függetlenül kerülnek továbbításra; előzetes összeköttetés-felépítésre
nincs szükség. Ebben az összefüggésben a csomagokat gyakran **datagramoknak
(datagrams, DG)**, a hálózatot pedig datagramalapú hálózatnak (datagram network)
is nevezik, a távirat (telegram) kifejezés mintájára. Az internetprotokoll
(IP, Internet Protocol), amely a teljes internet alapját képezi, meghatározó
példája az összeköttetés nélküli hálózati szolgáltatásnak. Minden csomag tartalmazza
a címzett IP-címet, amelyet az útválasztók használnak az egyes csomagok egyesével
történő továbbításához.

Az *összeköttetés-alapú szolgáltatás*hoz szükség van egy virtuális áramkör-alapú
hálózatra. A **virtuális áramkörök** alapötlete, hogy elkerülik azt, hogy minden
egyes csomag számára újra és újra útvonalat kelljen választani. Ehelyett, már az
összeköttetés felépítésekor kiválasztanak a küldő és a címzett hoszt között egy
utat, amelyet az útválasztók az összeköttetés kiépítése keretében tárolnak a
táblázataikban. Ezt az utat használják azután a kapcsolat teljes forgalmának
lebonyolítására. Amikor az összeköttetés megszűnik, a virtuális áramkör is bomlik.
Az összeköttetés-alapú szolgáltatás esetén minden csomag tartalmaz egy azonosítót,
amely megmondja, hogy a csomag melyik virtuális áramkörhöz tartozik.

A virtuális áramkörök a szolgáltatásminőségi garanciák és a hálózaton belüli
torlódáskezelés területén rendelkeznek némi előnnyel, mert az erőforrásokat
(puffereket, sávszélességet, processzoridőt) előre, az összeköttetés felépítésekor
le tudják foglalni. Mire a csomagok megérkeznek, a szükséges sávszélesség és ú
tválasztó-kapacitás már rendelkezésre fog állni. Datagramalapú hálózatokban a
torlódások elkerülése bonyolultabb kérdés.

### 2.3 Alapvető forgalomirányítási algoritmusok: az elárasztás, a legrövidebb út algoritmus, a távolságvektor alapú forgalomirányítás

A hálózati réteg fő feladata, hogy a csomagokat a forrásgéptől a célgépig irányítsa.
A legtöbb hálózatban a csomagoknak ehhez több útválasztón kell keresztülhaladni,
több ugrást kell megtenni. Az útválasztó/forgalomirányító algoritmus (routing
algorithm) a hálózati réteg szoftverének azon része, amely azért a döntésért
felelős, hogy egy bejövő csomag melyik kimeneti vonalon kerüljön továbbításra.
Ha a hálózat belül datagramokat használ, ezt a döntést újra meg újra meg kell
hozni minden beérkező adatcsomagra, mivel lehet, hogy a legjobb útvonal a legutóbbi
meghatározás óta változott. Ha a hálózat belül virtuális áramköröket használ, akkor
útválasztó döntéseket csak új virtuális áramkör felépítésekor kell meghozni.
Ezután az adatcsomagok már csak az előzőleg kialakított útvonalat követik. Ezt az
utóbbi esetet néha viszony-útválasztásnak (session routing) is nevezik, mivel az ú
tvonal érvényben marad a teljes felhasználói viszony (mint például a VPN-en
keresztüli bejelentkezés) alatt.

A számítógép-hálózatokban sokféle útválasztó algoritmus használatos. A statikus
algoritmusok közé tartozik például a **legrövidebb útalapú útválasztás** és az
**elárasztás**, dinamikus algoritmus például a **távolságvektor-alapú útválasztás**.
A legtöbb meglévő hálózat ezek valamelyikét használja.

**Elárasztás**

Az útválasztó algoritmus megvalósításakor minden útválasztónak helyi ismeretek
alapján kell döntéseket hoznia, nem pedig a hálózat teljes képe alapján. Egy
egyszerű helyi módszer az elárasztás (flooding), amelyben minden bejövő csomagot
minden kimenő vonalon kiküldünk, kivéve azon, amelyiken beérkezett. Az elárasztás
sok csomag elküldésénél nem praktikus, de van néhány fontos alkalmazási helye.
Először is, ez biztosítja, hogy egy csomag a hálózat összes csomópontjához eljusson.
Ez azonban pazarlás lehet, ha egyetlen címzettnek van szüksége a csomagra, de
adatszórásnál hatékony módszer.

**Legrövidebb út algoritmus**

Az optimális útvonal nem feltétlenül jelenti a fizikailag legrövidebb útvonalat,
mivel számos egyéb tényező is befolyásolhatja az optimális választást. Mértékadó
információ lehet például a csomópont átlépések száma, az az idő, amennyi alatt a
csomag eljut a céljáig, illetve a vonalhasználat költségei. Általánosan egy adott
szakasz mértékét a távolság, az adatátviteli sebesség, az átlagos forgalom, a
kommunikációs költség, az átlagos sorhossz vagy más egyéb tényezők alapján határozzák
meg. A legrövidebb út tehát sok paraméter együttes vizsgálata után az egyes
komponensek súlyától (súlyfüggvényétől) függően több különböző út is lehet.

A [módszer](https://hu.wikipedia.org/wiki/Dijkstra-algoritmus) (a szemafort is kiagyaló) Edsger Wybe Dijkstra holland matematikustól származik, 1959-ből.

**Távolságvektor alapú forgalomirányítás**

A számítógép-hálózatok általában dinamikus algoritmust használnak, ami lényegesen
összetettebb, mint az elárasztás, de sokkal hatékonyabb is, mivel megtalálja a
legrövidebb utat az aktuális topológiában.

A távolságvektor-alapú útválasztás (distance vector routing) alapja, hogy minden
útválasztónak egy táblázatot (vagyis egy vektort) kell karbantartania, amelyben
minden célhoz szerepel a legrövidebb ismert távolság, és annak a vonalnak az
azonosítója, amelyiken a célhoz lehet eljutni. A táblázatokat a szomszédokkal való
információcsere útján frissítik. Végül minden útválasztó tudni fogja a legjobb
adatkapcsolatot minden célcím megtalálásához.

A távolságvektor-alapú útválasztó algoritmust néha máshogy is nevezik, mint például
elosztott Bellman–Ford útválasztó algoritmus – az algoritmust kifejlesztő kutatók
után. Ez volt az ARPANET eredeti útválasztó algoritmusa és ezt használták az
interneten is RIP néven (lásd 4.2 tétel).

## 3. tétel

### 3.1 Az IP protokoll helye és feladatai

Az IP a klasszikus OSI besorolás alapján a 3., a hálózati rétegben helyezkedik el.
Csomagkapcsolt hálózatot valósít meg, azaz nem építi fel a kapcsolatot a forrás
és a cél között, hanem minden egyes csomagot külön irányít (route-ol). Hibadetektálást
és hibajavítást nem végez (ezeket nevezzük „megbízhatatlan” protokollnak), ezeket
a funkciókat főleg a szállítási rétegben elhelyezkedő protokollokra bízza (például TCP).
Ennek oka az, hogy az egyszerűségre törekedtek. Így a hibajavítás terhe főképp a
forrás és a cél számítógépeknél jelentkezik, és nem terheli feleslegesen az
egyébként is leterhelt hálózati útirányválasztó csomópontokat (router).

### 3.2 Az IPv4 és IPv6 csomagok fontosabb fejrész információi

**Az IPv4 fejrész információi**

![Imgur](https://i.imgur.com/a8doquy.png)

**Verzió (4 bit):** Ez a mező teszi lehetővé, hogy azonos hálózatban eltérő IP verziók
működhessenek, egy-egy átállás így folyamatosan mehet végbe, nem kell egyszerre
az egész hálózat összes berendezését átállítani. Jelenleg évek óta tart például
az IPv4-ről IPv6-ra történő migrációja az internetnek. A verziószámot 4 biten
tárolja, értéke 4 (0100) ha IPv4, 6 (0110) amennyiben IPv6 protokollhoz tartozik
a csomag.

**A fejléc hossza (Internet Header Length, IHL, 4 bit):** Az IP fejléc hossza nem állandó,
ez a mező hordozza a fejléc hosszára vonatkozó információt. A hosszt 32 bites
szavakban adja meg, 5 és 15 között vehet fel értéket, ami minimum 20 maximum 60
bájtos fejlécet jelent (a fejléchossz az opciók változó száma miatt nem állandó).

**Differenciált szolgáltatások (Differentiated Services Code Point, DSCP, 8 bit):**
eredeti neve Szolgáltatás típusa (Type of Service) volt. Akárcsak régen, ma is
az a célja, hogy különbséget tegyen az eltérő szolgáltatási osztályok között. A
differenciált szolgáltatások kialakításakor az IETF újra felhasználta a mezőt.
Jelenleg 6 bitet használnak a csomag szolgáltatási osztályának jelzésére, 2 bit
explicit torlódásértesítési információt hordoz.

**Teljes hossz (Total Length, 16 bit):** a datagram minden része beleértendő, a fejrész
is és az adatrész is. A maximális hossz 65 535 bájt. Jelenleg ez a felső korlát
még elegendő, de a jövőbeni gigabites hálózatoknál nagyobb datagramokra lehet
majd szükség, mivel az IPv6-ban már van lehetőség ún. Jumbogram vagy Jumbo frame
küldésre, mely elméleti maximális csomagmérete 1 bájt híján 4 GB.

**Azonosító (Identification, 16 bit):** a daraboláskor szükséges ahhoz, hogy a
címzett hoszt eldönthesse, melyik datagramhoz tartozik az újonnan érkezett darab.
Egy datagram minden darabja ugyanazt az Azonosító értéket tartalmazza.

*A következő egy kihasználatlan bit (az ábrán sötétszürkével jelölve), amelynek
nincs funkciója, csak van...*

**DF (Do not fragment! – Ne darabold!):** Egyetlen jelzőbit, beállításával az üzenet
darabolását lehet tiltani. Ilyenkor a routerek elkerülik a kiscsomagos hálózatokat.

**MF (More Fragments – Több darab):** Szintén egyetlen bit, mely jelzi, hogy létezik
még több darabja az üzenetnek. Egy darabolt üzenet minden darabjának a fejléce
tartalmazza, kivéve az utolsót.

**Darabeltolás (Fragment offset, 13 bit):** megmondja, hova tartozik a mostani darab a
datagramban. Egy datagram minden darabjának – kivéve az utolsót – 8 bájt többszörösének
kell lennie, mert ez az elemi darabméret. Mivel 13 bit áll rendelkezésre, ez
legfeljebb 8192 darabot jelent datagramonként, amely 65 536 bájtos maximális
datagramhosszt eredményez, eggyel nagyobbat, mint amit a Teljes hossz mező lehetővé
tesz. Az Azonosítás, MF és Darabeltolás mező együtt valósítja meg a darabolást.

**Élettartam (TTL, Time To Live, 8 bit):** Ezzel a mezővel korlátozzák egy csomag hálózatban
eltölthető idejét, illetve egyúttal a megoldás azt is biztosítja, hogy ne maradhassanak
a hálózatban vég nélkül keringő csomagok. Kezdőértéke 255 lehet maximálisan, melyet
minden router csökkent eggyel továbbításkor. Ha eléri a nullát, egyszerűen eldobja.

**Protokoll (Protocol, 8 bit):** Ez a mező jelzi, hogy a csomag milyen protokoll
számára szállít. Amikor a csomagokból összeállítja az üzenetet a vételi oldal, ez
alapján továbbítja a felsőbb réteg megfelelő protokolljának (ált. TCP vagy UDP).

**Fejrész ellenőrző összeg (Header checksum, 16 bit):** Csak a fejrészre vonatkozik! Az
élettartam mező miatt minden alkalommal újra kell számolni.

**Az IPv6 fejrész információi**

Az IPv6 fejléc egyszerűbb lett, mint az IPv4-es. Alapesetben csak az útvonalválasztáshoz
szükséges információkat tartalmazza. A fejléc nagy részét a forrás és cél állomások
128 bites címei teszik ki.

![Imgur](https://i.imgur.com/M5C8iiq.png)

**Verzió (4 bit):** Az internet protokoll verziója, értéke 6. A célja megegyezik
az IPv4 csomag azonos nevű mezőjével.

**Forgalom osztály (Traffic Class, 8 bit):** megegyezik az IPv4-fejléc differenciált
szolgáltatások (Differentiated Services, DS) mezőjével. Szintén egy 6 bites DSCP
(Differentiated Services Code Point) érték osztályozza a csomagokat és egy 2
bites ECN (Explicit Congedtion Notification) mező szolgál torlódásvezérlésre.

**Folyamcímke (Flow Label, 20 bit)**: lehetővé teszi a valós idejű alkalmazások
speciális kezelését. Segítségével értesíthetők a forgalomirányítók és a kapcsolók,
hogy egy csomagfolyam esetén ugyanazt az útvonalat használják, így a csomagokat
nem kell összerendezni.

**Adatmező hossza (Payload Length, 16 bit):** megegyezik az IPv4-fejléc Total Length
(Teljes hossz) mezőjével. A teljes csomag méretét adja meg a fejrésszel és az
opcionális kiegészítésekkel együtt.

**Következő fejléc (Next Header, 8 bit):** megegyezik az IPv4 Protokoll nevű
mezőjével. Ez adja meg a csomagban lévő adattartalom típusát, lehetővé téve ezzel
a hálózati réteg számára, hogy az adatokat a megfelelő felsőbb rétegbeli protokollnak
továbbítsa. A mezőt akkor is használják, ha az IPv6-csomagban opcionális kiterjesztések
vannak.

**Ugrás korlát (Hop Limit, 8 bit):** megfelel az IPv4 csomag TTL-mezőjének. Értéke mindig
eggyel csökken, amikor egy forgalomirányító továbbítja a csomagot. Amikor a számláló
eléri a 0 értéket, a csomagot az adott forgalomirányító eldobja és egy ICMPv6
üzenettel értesíti a küldő állomást arról, hogy a csomag nem érkezett meg a célhoz.

**Forrás IP-cím (Source Address, 128 bit)** ez a mező adja meg a küldő állomás
IPv6 címét.

**Cél IP-cím (Destination Address, 128 bit):** ez a mező adja meg a fogadó állomás
IPv6-címét.

Az IPv6-csomag kiterjesztett fejléct (Extension Header, EH) is tartalmazhat, ami
további hálózati rétegbeli információkat biztosít. Ez a kiterjesztett fejléc
opcionális és az IPv6-fejléc és az adat között helyezkedhet el. Használják például
csomagok feldarabolása vagy biztonság és mobilitás támogatás esetén is.

### 3.3 Az IPv4 címzési rendszere, az IPv4 cím szerkezete

Egy hagyományos IP cím 32 darab bináris számjegyből áll, amely egy 32 bites címet
alkot. Mivel ember számára gyakran nehezen értelmezhető ez a forma, így fel szokták
bontani pontokkal elválasztott nyolcas csoportokra (oktett), és ezeket egy-egy
decimális számként értelmezzük, melyek 0-255 közötti értéket vehetnek fel. A
hálózatok hierarchiáját úgy valósítjuk meg, hogy az IP címet két részre osztjuk.
A 32 bites cím első valahány bitje a hálózatot fogja jelölni (Net ID), az utána
következők pedig az egyes állomásokat (Host ID).

### 3.4 A hálózat címe és az üzenetszórási (broadcast) cím

Egy IPv4 hálózaton az első cím a **hálózatcímnek** van fenntartva. Ez a cím a hoszt
részen csupa nullákat tartalmaz (a hálózat azonosító bithelyeken pedig a hivatkozott
hálózat azonosítóját). A hálózat minden állomása ugyanazt a hálózatcímet használja.

Minden végberendezésnek egyedi címmel kell rendelkeznie a hálózati kommunikációhoz.
IPv4-címek esetén a hálózatcím és a szórási cím közötti címeket rendelhetjük hozzá
a végberendezésekhez. A cím nullák és egyesek bármely kombinációját tartalmazhatja
a hoszt részen, kivéve a csupa nulla (ez a hálózat címe) és a csupa egyes (ez pedig
a szórási vagy broadcast cím) címet.

Az IPv4 **szórási cím** egy speciális címe az alhálózatoknak, amelynek segítségével
minden állomással egyszerre kommunikálhatunk. Ehhez a küldőnek egyszerűen egy
csomagot kell küldenie a hálózat szórási címére, ezt a hálózat minden állomása
megkapja és feldolgozza. A szórási cím a hálózat tartományának legmagasabb címe.
Ez az a cím, ahol az hoszt részben minden bit 1-es. Ha egy oktett bináris alakban
csupa 1-eseket tartalmaz, akkor a decimális értéke 255.

### 3.5 Az IP címek osztályozása

![Imgur](https://i.imgur.com/YjE6LCg.png)

A teljes IP-cím két részre osztható: egy hálózati és egy hoszt azonosítókból áll.
A hálózati rész értéke az egy hálózaton – például Ethernet LAN-on – lévő összes
hoszt esetén megegyezik. A hálózati azonosító hossza változó méretű lehet, azt a
teljes cím első bitjei határozzák meg, az IP-címeket ez alapján címosztályokba
soroljuk. **Az A osztályú címekben 8 biten ábrázolták a hálózatazonosítót, a B
osztályúakban 16 biten, a C osztályúakban pedig 24-en**. Ezt a rendszert aztán
később kiegészítették az úgynevezett alhálózatokkal (subnet), amelyek helyi szinten
nagyobb szabadságot adtak a hálózat strukturálásában.

| Osztály | Net ID mérete (bit)   | Hálózatok száma | Hoszt ID hossza (bit) | Hosztok száma |
|:-------:|-----------------------|-----------------|-----------------------|---------------|
| **A** | 8  | 2<sup>7</sup> - 2 = **126** | 24 | 2<sup>24</sup> - 2 = **16777214** |
| **B** | 16 | 2<sup>14</sup> = **16384**  | 16 | 2<sup>16</sup> - 2 = **65534** |
| **C** | 24 | 2<sup>21</sup> = **2097152**| 8  | 2<sup>8</sup> - 2 = **254** |

### 3.6 Az alhálózati maszk szerepe: a hálózat felosztása alhálózatokra

Annak az érdekében, hogy a szervezetek a nekik kiosztott címosztályokat további
alhálózatokra bonthassák, vezették be az alhálózatot jelölő maszkot. Ezzel lehetővé
válik pl. egy B osztályú cím két vagy több tartományra bontása, így elkerülhető
további internetcímek igénylése. Az alhálózati maszk szintén 32 bitből áll: az
IP-cím hálózati részének hosszáig csupa egyeseket tartalmaz, utána nullákkal
egészül ki. Mivel az előtag hossza nem következtethető ki magából az IP-címből,
az útválasztó protokolloknak át kell adniuk az előtagokat az útválasztóknak.
Bizonyos esetekben az előtagokat egyszerűen a hosszuk írja le, mint a „/16” esetében
(amelyet „per 16”-nak mondanak). Az előtag hossza megfelel az 1-esek bináris maszkjának
a hálózati részben. Az ilyen írásmódot **alhálózati maszknak (subnet mask)** hívják.
Ha ezt ÉS kapcsolatba hozzuk az IP-címmel, megkapjuk a hálózati részt.

A **CIDR ( Classless Internet Domain Routing)** egy olyan, sokkal inkább a valós
igényekhez alkalmazkodó címzési séma, mellyel az útválasztási táblákban egész
címblokkok adhatók meg. A CIDR rendszer működése nem támaszkodik egy előre
meghatározott hosszúságú (8, 16 vagy 24 bites) hálózatazonosító használatára.
Helyette egyetlen szám, az úgynevezett **CIDR előtag (CIDR prefix)** adja meg a
hálózat azonosítására használt bitek számát. Ezt az előtagot szokás **változó
hosszúságú alhálózati maszknak (Variable Length Subnet Mask; VLSM)** is nevezni.

A CIDR jelölésben a cím után egy perjel következi, utána pedig egy tízes számrendszerbeli
szám, amely azt mutatja meg, hogy az adott címből hány bit azonosítja a hálózatot.
A 205.123.196.183/25 CIDR formátumú cím például azt jelenti, hogy a cím első 25
bitje a hálózatazonosító. Ez a korábbi rendszerben gondolkodva a 255.255.255.128
alhálózati maszknak felel meg.

### 3.7 Az alapértelmezett átjáró (default gateway)

Az a hálózati csomópont, amelynek a gép azokat a csomagokat küldi, amelyek nem a
helyi hálózat valamely állomásának szólnak. Az alapértelmezett átjáró feladata a
távoli csomópontok felé az adatok továbbítása, illetve az onnan érkező információk
fogadása a gép számára.

Megegyezés szerint az alapértelmezett átjáró a hálózat legkisebb címe.


## 4. tétel

### 4.1 Autonóm hálózatok, a belső és külső átjáró protokoll (IGP/EGP) fogalma

Az interneten autonóm rendszer (**Autonomous System, AS**), önálló rendszer vagy
útválasztási tartomány (**routing domain**) az IP-hálózatok olyan csoportja, melyen
belül egyetlen, jól meghatározott útválasztási irányelv (**routing policy**) érvényesül.
Az autonóm rendszer tulajdonképpen útválasztók (routerek) csoportja, amelyeket
egységesen vezérelnek egy adminisztratív entitás (például egy internetszolgáltató,
egy nagyvállalat vagy egy egyetem) megbízásából.

Az internet nagyszámú autonóm rendszerből tevődik össze. Minden autonóm rendszert
egyedi számmal azonosítanak: **Autonomous System Number (ASN)**.

Az autonóm rendszerek három kategóriába oszthatók, kapcsolódásaik és működtetési
irányelveik szerint.

* A **többkapcsolatú (multihomed)** autonóm rendszer olyan AS, ami egynél több
más AS-hez kapcsolódik. Így internetkapcsolata akkor is megmarad, ha valamelyik
kapcsolata teljesen csődöt mond. Nem enged át saját magán két másik AS közötti
forgalmat.
* A **stub („csonk”)** autonóm rendszer egyetlen más AS-hez kapcsolódik.
* A **transit** autonóm rendszer olyan AS, ami lehetővé teszi hogy rajta keresztül
kapcsolódjanak más hálózatokhoz. Az internetszolgáltatók (ISP) mindig tranzit AS-ek,
hiszen kapcsolatot biztosítanak két hálózat között.

**[Interior Gateway Protocol (IGP, belső átjáró protokoll)](https://gyires.inf.unideb.hu/GyBITT/30/ch05s06.html#d0e20447)**

Az autonóm rendszeren belüli forgalomirányításra szolgáló protokoll, mint az
OSPF (Open Shortest Path First – nyílt hozzáférésű, a legrövidebb utat előrevevő
protokoll). Az egyes autonóm rendszerek különböző típusú IGP-vel rendelkezhetnek,
az EGP azonban egységes az egész Internetre.

**[Exterior Gateway Protocol (EGP, külső átjáró protokoll)](https://www.szabilinux.hu/trendek/trendek5321.html)**

Az autonóm rendszerek közötti forgalomirányításra szolgáló protokoll, mint pl.
a BGP (Border Gateway Protocol – határátjáró protokoll).

A EGP 3 feladatot lát el:

* Szomszédok felderítése, melynek során két EGP router megegyezik, hogy elérhetőségi
információkat adnak át egymásnak
* Szomszédok elérhetőségének tesztelése, mely folyamatosan zajlik (Hello és IHU
(I Heard You) csomagok cseréjével)
* Elérhetőségi információk cseréje

### 4.2 Forgalomirányítás az IP hálózaton: a RIP és az OSPF protokoll

A számítógép-hálózatokban sokféle útválasztó algoritmus használatos. A statikus
algoritmusok közé tartozik például a legrövidebb útalapú útválasztás és az
elárasztás. A dinamikus algoritmus a távolságvektor és a kapcsolatállapot-alapú ú
tválasztás. A legtöbb meglévő hálózat ezek valamelyikét használja.

**RIP (Routing Information Protocol – útválasztási információ protokoll)**

A RIP egy a [Bellman–Ford-algoritmusra](http://tamop412.elte.hu/tananyagok/algoritmusok/lecke26_lap1.html#hiv3)
épülő távolságvektor-alapú protokoll, ami azt jelenti, hogy az alapján választja
ki az adatcsomagok számára kijelölt utat, hogy melyikkel jár együtt a legkevesebb
útválasztó érintése. Ez kis rendszerekben jól működött, de ahogy a hálózatok nagyobbak
lettek, egyre kevésbé volt elfogadható, ezért fokozatosan felváltják újabb protokollok,
például az OSPF.

A RIP azt igényli az útválasztóktól, hogy más útválasztókra figyelve információkat
szerezzenek az útvonalakról és lépésszámokról, és ezt építsék be a saját táblájába.
A RIP szereplői aktív és passzív eszközök. Aktív RIP csomópontnak hívjuk azokat
az útválasztókat, amelyek részt vesznek a távolságvektor-adatokra vonatkozó
információcserében. Elküldik útválasztó tábláikat a többi útválasztónak és figyelik
a tőlük érkező frissítéseket. A passzív RIP eszközök csak beépítik a frissítéseket,
de nem publikálják a saját útválasztó táblájukat. Passzív RIP csomópontnak számítanak
a normál hálózati számítógépek is.

Két táblázattal rendelkezik:
* *Forgalomirányító tábla:* A célhálózat címének ismeretében a táblázatból
megállapítható a következő ugrás IP címe
* *ARP tábla:* A cél interfész IP címének ismeretében kikereshető annak MAC címe

Az útvonalak jóságát a két forgalomirányító közötti hálózatok számával (hop = ugrás)
fejezi ki. A metrika az ugrások számával azonos. Ha túl sok útválasztó van, akkor
a táblák lassú átadása problémákhoz vezethet. Emiatt a RIP beállít egy maximumot
arra vonatkozóan, hogy hány útválasztón haladhatnak át a táblák, míg a feladótól
a címzettig megérkeznek. Ez a lépésszám-küszöbérték a RIP esetében 15 (a 16-os
lépésszám/költség a „végtelent”, az elérhetetlen célpontot jelöli).

**OSPF (Open Shortest Path First – nyílt hozzáférésű, a legrövidebb utat előrevevő protokoll)**

Az OSPF egy kapcsolatállapot alapú útválasztó protokoll, amely nem ugrásszám, hanem
a sávszélesség alapján választja ki a legrövidebb (és hurokmentes) útvonalat. Az
OSPF nagy és nagyon nagy összetett hálózatokhoz is képes alkalmazkodni. A hálózat
topológiájában bekövetkezett változásokhoz való újrakonfigurálás is gyorsabb, mint
a RIP esetében.

Az OSPF által alkalmazott kapcsolatállapot alapú módszernél az útválasztók a
hálózati topológiát térképezik fel. Az útválasztók az útválasztó-azonosító alapján
azonosítják egymást a topológián belül. Az útválasztó-azonosító (általában) az
útválasztó hatáskörébe tartozó, számszerűleg legnagyobb IP-cím. Minden útválasztó
fastruktúrába rendezi az útválasztókat, amelynek ő maga a gyökere. Ennek a hálózati
fastruktúrának a neve „legrövidebb út gráf” (SPT, Shortest Path Tree). A hálózat
útvonalai megfeleltethetőek ezen gráf éleinek Az útválasztó kiszámítja az egyes
útvonalak költségét. A költség mérésébe belefoglalható a lépésszámon kívül sok más
információ is, például a kapcsolat sebessége vagy az összeköttetés megbízhatósága.


### 4.3 Dinamikus állomáskonfiguráló protokoll (Dynamic Host Configuration Protocol, DHCP)

A DHCP protokoll feladata, hogy a TCP/IP hálózatra csatlakozó hálózati végpontok (például
számítógépek) automatikusan megkapják a hálózat használatához szükséges beállításokat.
Ilyen például az IP-cím, hálózati maszk, alapértelmezett átjáró stb. A DHCP
szerver-kliens alapú protokoll, nagy vonalakban a kliensek által küldött DHCP
kérésekből, és a szerver által adott DHCP válaszokból áll. A DHCP-vel dinamikusan
oszthatóak ki IP-címek, tehát a hálózatról lecsatlakozó számítógépek
IP-címeit megkapják a hálózatra felcsatlakozó számítógépek, ezért hatékonyabban
használhatóak ki a szűkebb címtartományok.

3 féle IP-kiosztás lehetséges DHCP-vel:
* kézi (MAC cím alapján)
* automatikus (DHCP-vel kiadható IP-tartomány megadásával)
* dinamikus (IP-tartomány megadásával, de az IP címek „újrahasznosításával”)

### 4.4 Az ARP és az RARP címfeloldási protokoll

A TCP/IP rendszerében a logikai címeket az ARP és a RARP protokollok alakítják
fizikai címekké és vissza. E két protokoll tehát nem más, mint kétirányú kapocs
a felhasználó által beállítható IP cím, és a felhasználó számára gyakorlatilag
láthatatlan fizikai cím között.

Az **ARP (Address Resolution Protocol, névfeloldási protokoll)** egy IP-címnek megfelelő
fizikai (MAC) cím meghatározására használatos. A TCP/IP-hálózatokon minden állomás
fenntart egy ARP-gyorsítótárat (ez egy tábla, amely az IP-címeket fizikai címeknek
felelteti meg).

Az ARP-gyorsítótár frissítéséről a legtöbb esetben a protokollszoftver gondoskodik.
Az ARP gyorstár frissítése dinamikusan történik. Ha a gép nem találja a szükséges
címet a táblázatban, akkor üzenetszórással kiküld egy ARP kérést (ARP request frame)
a teljes alhálózatba. Ez a mindenkinek kiküldött ARP kérés a helyi gép által
feloldani kívánt IP címet tartalmazza, illetve benne van annak a gépnek a fizikai
címe is, amitől a kérdés származik. A szegmens gépei megkapják az üzenetet,
kiolvassák belőle a feloldandó IP címet, összehasonlítják a sajátjukkal, és az,
amelyik a saját IP címét találja a kérésben, visszaküldi a fizikai címét a kérdezőnek.
Ez az újonnan feloldott IP cím fizikai cím páros természetesen bekerül az ARP
táblába, vagyis a következő alkalommal ezt a folyamatot már nem kell végigjátszani.
Az ARP tábla bejegyzései egy bizonyos előre meghatározott idő után elévülnek. Az
elévült bejegyzéseket a rendszer törli a gyorstárból, így amikor ismét szükség lenne
rájuk, megint lefut a címfeloldási folyamat, és a táblába friss bejegyzés kerül.

A **RARP (Reverse ARP)** protokoll épp a fordítottját teszi annak, mint ami az
ARP protokoll rendeltetése. A RARP ismert fizikai cím alapján képes IP címet
szolgáltatni. A RARP leggyakoribb felhasználási területe a merevlemez nélküli
munkaállomások üzemeltetése.

## 5. tétel

### 5.1 A szállítási réteg helye és feladatai

A **szállítási réteg (transport layer)** az OSI-modell (alulról) negyedik (a Hálózati
réteg fölötti) és a TCP/IP-modell harmadik (az Internet réteg fölötti) rétege.
Legfontosabb feladata az, hogy adatokat fogadjon a viszonyrétegtől, – ha szükséges –
feldarabolja azokat kisebb egységekre, továbbítsa ezeket a hálózati rétegnek, és
biztosítsa azt, hogy minden kis egység hibátlanul megérkezzen a másik oldalra.
Ráadásul, mindezt hatékonyan kell elvégezni és oly módon, hogy a felsőbb rétegek
számára rejtve maradjanak a hardvertechnikában az idő folyamán jelentkező változások.
A szállítási réteg egy igazi végpontok közötti réteg, a forráshoszttól egészen a
célkosztig tart. Vagyis: a forrásgépen futó egyik program beszélget egy hasonló
programmal a célgépen, felhasználva az üzenetek fejléceit és a vezérlőüzeneteket.
Az alacsonyabb szintű rétegek protokolljait a gépek a közvetlen szomszédjukkal
való kommunikációhoz használják, nem pedig a tényleges küldő és a fogadó kommunikál
velük, hiszen ezeket több útválasztó is elválaszthatja egymástól.

A szállítási szolgáltatást egy, a szállítási entitások között használt szállítási
protokoll valósítja meg. Némely tekintetben a szállítási protokollok az adatkapcsolati
protokollokra emlékeztetnek. Mindkettőnek többek között hibakezelést, sorszámozást
és forgalomszabályozást kell végeznie.

Az internet két fő protokollt használ a szállítási rétegben, az egyik *összeköttetés-alapú*,
a másik *összeköttetés nélküli*. A két protokoll kiegészíti egymást. Az összeköttetés
nélküli protokoll az **UDP (User Datagram Protocol – felhasználói datagram protokoll)**,
amely majdnem semmit sem tesz azon túl, hogy csomagokat továbbít alkalmazások között,
rájuk bízva, hogy erre egy olyan protokollt építsenek, amilyenre szükségük van.
Az összeköttetés-alapú protokoll pedig a **TCP (Transmission Control Protocol
– átvitelvezérlő protokoll)**, amely szinte mindent elintéz. Összeköttetéseket hoz
létre, újraküldéssel megbízhatóvá teszi azokat, emellett forgalomszabályozást és
torlódáskezelést is megvalósít, mindezt az alkalmazás helyett teszi.

### 5.2 A TCP protokoll működése: a port fogalma, a TCP fejléc, összeköttetés létesítése és bontása, átviteli politika, torlódáskezelés

A legtöbb internetes alkalmazás megbízható, sorrendhelyes kézbesítést igényel. Az
UDP ezt nem tudja nyújtani, ezért egy másik protokollra is szükség van. Ez az internet
legfontosabb igáslova, a **TCP (Transmission Control Protocol – átvitelvezérlő
protokoll)**, az internet gerincét alkotó TCP/IP protokollcsalád egyik fő protokollja.
Arra tervezték, hogy dinamikusan alkalmazkodjon az összekapcsolt hálózatok tulajdonságaihoz,
valamint hogy nagymértékben ellenálló legyen sokféle meghibásodással szemben.

Minden TCP-t támogató gép rendelkezik egy TCP szállítási entitással, amely lehet
egy könyvtári eljárás, egy felhasználói folyamat vagy leggyakrabban a kernel része.
A TCP-folyamokat és az IP-réteg felé használható interfészeket minden esetben a
TCP-entitás kezeli. A helyi folyamatoktól kapott felhasználói adatfolyamokat a
TCP-entitás 64 KB-ot meg nem haladó méretű darabokra szedi szét (a gyakorlatban
sokszor 1460 adatbájtos darabokra, mert így az IP- és TCP-fejrészekkel együtt is
beleférnek egy Ethernet-keretbe). Az egyes darabokat önálló IP-datagramokban küldi
el. Amikor egy géphez TCP-adatokat tartalmazó datagram érkezik, az a TCP-entitáshoz
kerül, amely visszaállítja az eredeti bájtfolyamokat. Minden TCP-összeköttetés
duplex és kétpontos. A duplex azt jelenti, hogy a forgalom egyszerre haladhat
minkét irányba. A kétpontos azt jelenti, hogy minden összeköttetésnek pontosan
két végpontja van. A TCP nem támogatja az adatszórást és a többesküldést.

#### A port fogalma

A portok egy hálózati kommunikációs csatorna végpontjai. A portok használata teszi
lehetővé, hogy egy adott számítógépen futó alkalmazások – ugyanazt a hálózati
erőforrást használva – a beérkező csomagokból csak a nekik szólókat kapják meg.
A portokat száma 0 és 65535 között lehet.

**A portokat három csoportba soroljuk:**

* **jól ismert portok (well known ports):** 0-1023-as sávban lévő portok, amelyeket
általában csak rendszerfolyamatok vagy rendszerprogramok használnak, és ezek
szorosan kötődnek valamilyen szolgáltatáshoz (a 20 és 21-es port az FTP-hez, 22-es
az SSH-hoz, 23-as a telnethez, 25-ös az SMTP-hez, a 80-as a HTTP-hez).
* **regisztrált portok (1024-49151):** kevésbé kötődnek egy-egy szolgáltatáshoz,
ilyen portszám többféle célra is felhasználható.
* **dinamikus vagy privát portok (49152-65535):** nem kapcsolódik hozzájuk semmilyen
kijelölt szolgáltatás, ezek az egyes programok által szabadon felhasználhatók.

**Minden portnak három állapota lehet az adott rendszertől függően:**

* **Nyitott/Open:** teljesen nyitott az internet felé. Ha van nyitott portunk,
számítógépünk sebezhető.
* **Zárt/Closed:** a port zárva van ugyan, de látszik az internet felé. Különböző
hacker eszközökkel a számítógép így is sebezhető.
* **Lopakodó/Stealth:** Ez a port teljesen láthatatlan az internet felé. Az automatizált
támadások ellen a Stealth portok jelentik az egyetlen védekezési módot.

### 5.3 Az UDP protokoll


## 6. tétel

### 6.1 A DNS (körzeti névkezelő rendszer) leírása

### 6.2 A doménnév szerverek működése, kapcsolat a doménnév szerverek között

### 6.3 Doménneves azonosítóhoz tartozó IP cím megállapításának menete

### 6.4 Hálózati védelem lehetséges esetei tűzfal, proxy használatával


## 7. tétel

### 7.1 Vezeték nélküli átviteli szabványok

### 7.2 Vezeték nélküli hálózatok osztályozása

### 7.3 WLAN hálózatok szabványai

### 7.4 Add-Hoc és infrastruktúrált hálózatok

### 7.5 Vezeték nélküli hálózatok adatvédelmi lehetőségei


## 8. tétel

### 8.1 A számítógép-hálózat fogalma, hálózatok csoportosítása, jellemző alkalmazási területek

### 8.2 A kommunikációs hálózat fogalma és típusai: üzenetszórásos, pont-pont közötti és csatornákból felépülő hálózat

### 8.3 Az OSI modell rétegei és az egyes rétegek feladatai

![Imgur](https://i.imgur.com/RJVjieT.png)

### 8.4 A rétegközi interfész és a protokoll fogalma


## 9. tétel

### 9.1 Hálózatok összekapcsolása a hálózati rétegben

### 9.2 A forgalomirányító (router) feladata és működése

### 9.3 A router és a híd (kapcsoló) összehasonlítása

### 9.4 Különböző típusú hálózatok összekapcsolása

### 9.5 A csomagküldés folyamata különböző típusú, összekapcsolt hálózat esetén


## 10. tétel

### 10.1 Az adatátviteli sebesség fogalma

Az adatátviteli sebesség (hálózati sebesség, sávszélesség, bitráta, bandwidth),
az információáramlás sebességének mértéke, amely az adatátviteli berendezések által
másodpercenként átvitt jelek avagy bitek számát adja meg. Tömören: **az időegység
alatt átvitt információ mennyisége**. Mértékegysége a bit/másodperc, b/s, bps. Az
adatátviteli sebességet tipikusan a csatorna kapacitásának mérésére, jelzésére
használják.

Nagyobb egységek:
* 1 kb/s = 1000 b/s
* 1 Mb/s = 1000 kb/s
* 1 Gb/s = 1000 Mb/s

### 10.2 A fizikai csatorna vágási frekvenciája és sávszélessége

Azt a frekvenciatartományt, amelyen belül a csillapítás mértéke nem túl nagy,
sávszélességnek (bandwidth) nevezzük. A gyakorlatban a csillapítás megváltozása
nem igazán éles, ezért a sávszélesség 0-tól addig a frekvenciáig tart, amelynél
a jel teljesítménye az eredeti jel teljesítményének felére csökken. A sávszélesség
az átviteli közeg fizikai tulajdonsága, amely többek között a rézvezeték vagy az
üvegszál kialakításától függ. Gyakran használnak szűrőket, hogy tovább korlátozzák
egy jel sávszélességét.

### 10.3 Maximális adatátviteli sebesség zajmentes csatornán (Nyquist tétele)

A [Henry Nyquist](https://hu.wikipedia.org/wiki/Harry_Nyquist) által 1924-ben
felismert összefüggés kimondja, hogy még egy tökéletesen csillapítás- és
torzításmentes csatornának is megvan a maximális átviteli kapacitása. A csatornán
átvitt adatok értelmezése, azaz az adatok visszaállítása Nyquist bizonyítása
szerint a következő. Ha egy tetszőleges jelet egy **B** sávszélességű, aluláteresztő
szűrőn (*olyan áramkör, mely a jel alacsony frekvenciás összetevőit átengedi, a
magas frekvenciásakat kiszűri*) bocsájtunk át, akkor a szűrt jelből másodpercenként
pontosan **2B** minta vételezésével a jel visszaállítható. Másodpercenként 2B-nél
több mintavételre azért nincs szükség, mivel az aluláteresztő szűrő a magasabb
frekvenciájú komponenseket már eleve kiszűrte.

Amennyiben a jelnek V diszkrét szintje van, akkor a Nyquist tétel kimondja, hogy:

**Maximális adatsebesség = 2B*log<sub>2</sub>(V) [bit/sec]**

A B mértékegysége Hertz (Hz).

Például egy zajmentes, 3 kHz sávszélességű csatornán bináris (azaz kétszintű)
jelek továbbítása esetén nem lehet 6000 b/s-nál nagyobb adatsebességet elérni.

### 10.4 A jel-zaj viszony jellemzése, a decibel érték

Jel-zaj viszony, angol kifejezéssel **Signal-to-noise ratio (rövidítésekben SNR vagy S/N)**
a hasznos és a zavaró jel (zaj) aránya [decibelben](https://hu.wikipedia.org/wiki/Decibel)
kifejezve, vagyis a jel (információ) és a háttérzaj teljesítményének hányadosa.

A decibel (dB) két mennyiség arányának logaritmikus mértéke. Ha S/N = 10, akkor
ez 10 dB, ha S/N = 100, akkor ez 20 dB, ha S/N = 1000, akkor ez 30 dB és így tovább.

### 10.5 Maximális adatátviteli sebesség zajos csatornán (Shannon tétele)

1948-ban [Claude Shannon](https://hu.wikipedia.org/wiki/Claude_Shannon) folytatta
Nyquist munkáját, és kiterjesztette a véletlen zajnak kitett csatornákra is.
Shannon mintavételezési tétele értelmében egy időben folytonos jel teljes mértékben
rekonstruálható diszkrét, egyenlő időközű mintákból, ha a mintavételezett jel
legmagasabb frekvenciájú összetevője kisebb, mint a mintavételi frekvencia fele.
A mintavételi frekvencia felét Nyquist-frekvenciának nevezzük.

Shannon tétele azt mondja ki, hogy egy **B** sávszélességű, **S/N** jel-zaj viszonyú
csatorna esetében mekkora az elérhető maximális adatsebesség:

**Maximális adatsebesség = B*log<sub>2</sub>(1+S/N) [bit/sec]**

A B mértékegysége Hz, az S/N-é dB.

### 10.6 Vezetékes adatátvitel: sodrott érpár, alapsávú és szélessávú koaxiális kábel

**Sodrott érpár (twisted pair)**

![Imgur](https://i.imgur.com/pkW2zvQ.jpg)

A legrégebbi, de még ma is a legelterjedtebb átviteli közeg. A sodrott érpár két
szigetelt rézhuzalból áll, melyek tipikusan kb. 1 mm vastagságúak. A huzalok a
DNS-hez hasonlóan spirálszerűen egymás köré vannak sodorva. A sodrás oka az, hogy
az egyes sodrott huzalokból érkező hullámok kioltják egymást, tehát az eredményül
kapott huzal kevésbé sugároz. Általában minden érpár esetén az egyik vezeték
egyszínű, a másik pedig fehér alapú csíkozással van ellátva.

A sodrott érpárnak számos változata van. A sok irodaházban telepített közönséges
változatát *5-ös kategóriájú (Category 5) vagy „Cat 5”-ös* kábelezésnek nevezzük.
Az 5-ös kategóriájú sodrott érpár két finoman egymás köré sodrott, szigetelt
vezetékből áll. Általában négy ilyen érpárt fognak össze egy műanyag köpennyel,
ami védi, és egyben tartja a nyolc vezetéket.

A Cat 6 kategóriáig terjedő vezetéktípusokat gyakran nevezik UTP-nek (*Unshielded
Twisted Pair – árnyékolatlan sodrott érpár*), mivel egyszerűen vezetékekből és
szigetelésekből állnak. Ezzel szemben a 7-es kategóriájú (Cat 7) kábelek esetén
az egyes sodrott érpárokat árnyékolják, csakúgy, mint a teljes kábelt (de még a
műanyag védőköpenyen belül). Az árnyékolás csökkenti a szomszédos vezetékek
közötti külső interferenciával és az áthallásokkal szembeni érzékenységet annak
érdekében, hogy megfeleljenek az elvárt teljesítőképességre vonatkozó előírásoknak.

**Koaxiális kábel**

![Imgur](https://i.imgur.com/dBottkf.png)

A koaxiális kábel közepén tömör rézhuzalmag van, amelyet szigetelő vesz körül.
A szigetelő körül sűrű szövésű hálóból álló rézvezető található. A fémháló szerepe
az elektromos árnyékolás, azaz a belső éren továbbított jel megóvása a külső
zavaroktól. Ezt műanyag burkolattal vonják be mechanikai védelem céljából. A
koaxiális kábel kialakítása és árnyékolása a nagy sávszélesség és a
kiváló zajérzéketlenség jó kombinációját adja. Az elérhető sávszélesség a kábel
minőségétől és hosszától függ. A mai modern kábelek sávszélessége néhány GHz.

*Alapsávú koaxiális kábel*

Ezt a koaxiális kábelt régebben elterjedten használták számítógépes lokális hálózatban,
valamint távbeszélőrendszerekben is nagytávolságú átvitelre. A mindenkori sávszélesség
a kábel hosszától függ. 1 km-nél kisebb távolságon 10 Mbit/s-os átviteli sebesség
valósítható meg.

Alkalmazták az Ethernet hálózatokban is, ahol megkülönböztetünk: vékony koaxiális
(10Base2) és vastag koaxiális (10Base5) kábeleket. A típusjelzésben szereplő 2-es
és 5-ös szám az Ethernet hálózatban kialakítható maximális szegmenshosszra utal:
vékony kábelnél ez 200 méter, vastagnál 500 méter lehet.

*Szélessávú koaxiális kábel*

Ez a fajta kábelrendszer a kábeltelevíziózás szabványos kábelein keresztül analóg
jelátvitelt tesz lehetővé. A szabványos kábeltelevíziós technikából adódóan az
ilyen széles sávú hálózatok esetén az analóg jelátvitelnek megfelelően (ami kevésbé
kritikus, mint a digitális) a kábel akár 100 km-es távolságra, 300 MHz-es, de
néha 450 MHz-es jelek átvitelére is alkalmas.

### 10.7 Fényvezető szálas adatátvitel

Egy optikai összeköttetés optikai adóból, fényvezető szálból és optikai vevőből
áll. Az optikai adó az elektromos jelet alakítja át fénnyé, az optikai szál az
átviteli közeg, a vevő pedig a torzult optikai jelet alakítja vissza elektromos
jellé.

A fényforrás egy LED, vagy lézer dióda. Ezek az eszközök félvezetők, melyek nagyon
jól fókuszálható fényt állítanak elő a rajtuk átfolyó áram erősségétől függő
intenzitással. Fényérzékelőként fototranzisztort alkalmaznak. Ez szintén félvezető,
ami a rá eső fény erősségétől függő kimeneti jelet állít elő.

Ennél az átviteli közegnél a legproblémásabb és legfontosabb kérdés a jelek be és
kicsatolása, amire alapvetően kétféle csatolótípust alkalmaznak. A passzív illesztő
két, az optikai szálra kapcsolódó csatlakozóból áll. Az egyik egy LED-et, míg a
másik egy fényérzékelő félvezetőt tartalmaz. Az aktív illesztő annyiban több mint a
passzív, hogy a vett jeleket átalakítja villamos mennyiséggé, felerősíti,
visszaalakítja fényimpulzusokká és újra a közegre kapcsolja.

### 10.8 Egy- és többmódusú optikai kábelek

*A módusok az optikai szálban haladó egyes fényhullámok „útvonalát” írják le. A
többmódusú szálakban több úton terjed a fény, míg az egymódusúban csak egyetlen
módon, az optikai szál magjával párhuzamosan.*

![Imgur](https://i.imgur.com/dEo1zEe.jpg)

**Egymódusú szál (Single Mode, SM):** Olyan optikai szál, mely csak egy adott frekvencián
– és annak közvetlen környezetében – képes a fény átvitelére, más frekvenciákon
a szál csillapítása igen erős. Az egymódusú kábel esetében a cső átmérője a fény
hullámhosszával megegyező így a fényimpulzusok nem torzulnak ezért valamivel
nagyobb sávszélességen képesek jelátvitelre, mint a multimódusú szálak.
Monomódusú optikai szálak esetén a sávszélesség korlátlannak tekinthető. A kis
csillapítás (SM: 0,25-0,4 dB/km; MM: 0,7-3,5 dB/km), nagy távolságok (egymódusú
szálaknál akár 70-100 km) áthidalását teszi lehetővé erősítők beiktatása nélkül.

**Többmódusú szál (Multi Mode, MM):** több frekvencián is képes a fény nagyobb
távolságra való eljuttatására. Az egyes frekvenciák körüli sávszélesség némileg
kisebb, mint az egymódusú szál esetében, mert a fényforrásból különböző szögben
kilépő fénysugarak különböző szögben verődnek vissza a két optikai közeg határáról,
ezért a fényimpulzusok torzulnak. Emiatt az adatátviteli sebesség csökken. Az
olcsóbb, multimódusú szálakra épülő rendszereket rövidebb távolságok (max. 2 km)
áthidalásánál használják.

**Többmódusú, emelkedő törésmutatójú szál (Multi Mode Graded):** A mag anyagának
törésmutatója a tengelytől távolodva növekszik. Ez mintegy fókuszálja a fényt. E
típus tulajdonságai az előző kettő közé tehetők.

### 10.9 Csillapítás jellemzése fényvezető szálakban

A fényvezetőszálak alapvető minőségi jellemzője a veszteség, illetve az egységnyi
szálhosszra eső csillapítás. A csillapítás által az optikai szálban okozott
jelerősség veszteség matematikai leírásához az egységnyi csillapítás paraméterét
használják (*jele: a*), melyet 1 km szakaszon mértek. Mértékegysége: dB/km.

A csillapítás exponenciálisan növekszik a szál hosszával együtt, korlátozva ezzel
az adatátvitel hatótávot. A 3 dB csillapítás növekedés megfelel a propagált
jelerősség 50%-os csökkenésének.

### 10.10 A fénykábelek fizikai felépítése

Az optikai szál egy igen tiszta, néhány tíz (a technológia megjelenése idején még
néhány száz) mikrométer átmérőjű üvegszálból és az ezt körülvevő, kisebb optikai
törésmutatójú héjból álló vezeték. Működési elve a fénysugár teljes visszaverődésén
alapul: a fénykábel egyik végén belépő fényimpulzus a vezeték teljes hosszán teljes
visszaverődést szenved, így a vezeték hajlítása esetén is – minimális
energiaveszteséggel – a szál másik végén fog kilépni.

![Imgur](https://i.imgur.com/Yx8chPY.png)

Egy kábelben több – jellemzően páros számú – fényvezető szálat szoktak elhelyezni.

## 11. tétel

### 11.1 A közegelérési alréteg (MAC) helye és feladata

Az adatkapcsolati réteg közegelérési alrétegének (MAC) két fő feladata van:
1. adatbeágyazás
2. közeghozzáférés-vezérlés.

A MAC-alréteg interfészként működik a logikai kapcsolatvezérlő (LLC) alréteg és
a hálózat fizikai rétege között.

**Az adatbeágyazási folyamat** magában foglalja a keret összeállítását a továbbítás
előtt, és a szétbontását a kézhezvétel után. A keret felépítésekor a MAC-réteg
egy fejlécet és egy utótagot ad a hálózati réteg PDU-jához.

Az adatbeágyazás három fő funkciót biztosít:
* *Keret határolás:* a keretezési folyamat fontos határolókat biztosít, amiket a
keretet alkotó bitek csoportjának azonosítására használnak. Ez biztosítja a
szinkronizációt az adó és a vevő csomópontok között.
* *Címzés:* a beágyazási folyamat az adatkapcsolati réteg címzését is biztosítja.
Minden Ethernet keret fejléce tartalmazza a fizikai címet (MAC-cím), amely lehetővé
teszi a keret kézbesítését a rendeltetési helyére.
* *Hibafelismerés:* mindegyik Ethernet keret tartalmaz egy utótagot a keret tartalmára
vonatkozóan, ami egy ciklikus redundancia ellenőrzés (CRC). Egy keret vétele után
a fogadó csomópont is készít egy CRC-t, hogy összehasonlítsa azt a keretben lévővel.
Ha a két CRC-számítás eredménye megegyezik, a keret nagy valószínűséggel hiba nélkül
érkezett.

**A közeghozzáférés-vezérléshez** tartoznak azok a protokollok, amelyek az adatszóró
csatorna használatának vezérléséért felelősek. A MAC-alréteget megvalósító hardver
a közeghozzáférés-vezérlő. A MAC-alréteg különösen fontos szerepet tölt be a
LAN-hálózatokban, különösen a vezeték nélküli LAN-hálózatokban, mert ezek
természetükből adódóan adatszóró csatornák. Ezzel szemben – a műholdas rendszerek
kivételével – a WAN-hálózatok kétpontos összeköttetésekből állnak össze.

### 11.2 A statikus és a dinamikus csatornakiosztás lényege, jellemzői

A csatorna minden esetben fizikai összeköttetést biztosít a hozzá csatlakozó
felhasználók között. Bármelyik felhasználó, aki a csatornát használja, zavarni
fogja a többieket, akik ugyanúgy használni szeretnék a csatornát. A közegelérés-vezérlési
eljárások azokat a szabályokat tartalmazzák, amelyek megadják, mikor és mennyi
ideig használhatja egy állomás az adatcsatornát.

A statikus csatornakiosztás vagy az időt vagy a sávszélességet osztja fel előre
az állomások között. Ez a módszer azonban pazarló (ha egy állomás nem ad, akkor is
megkapja a rá eső időt/sávszélességet). A dinamikus csatornakiosztás azt jelenti,
hogy ezeket a fix, azaz statikus korlátokat lebontjuk. A dinamikus csatornakiosztás
célja az igényekhez való rugalmas alkalmazkodás, a csatorna lehető legjobb
kihasználása változó körülmények között is.

*Csatornakiosztásos (statikus) protokollok*

* **TDM (Time Division Multiplexing, időosztásos nyalábolás):** a versenyhelyzeteket
a legegyszerűbben úgy kerülhetjük el, ha előre meghatározott időközönként a csatornát
más-más állomás használja.

* **FDM (Frequency Division Multiplexing, frekvenciaosztásos nyalábolás):** a
csatorna sávszélességét osztják fel annyi részre, amennyi állomás kapcsolódik a
csatornára. Mindenkinek külön frekvencia-sávja van.

*Csatornafigyelő (dinamikus) protokollok*

* **CSMA (Carrier Sense Multiple Access, vivőjel-érzékelés többszörös hozzáféréssel):**
ha egy állomás küldeni akar, de a csatorna foglalt, akkor addig vár, amíg az fel
nem szabadul. Amint ez bekövetkezik, az állomás útnak indítja a keretet. Ha ütközés
lép fel, akkor véletlen ideig várakoznia kell, majd ismét meg kell próbálnia elküldeni a
keretet. Az „1-perzisztens” kifejezés azt jelenti, hogy amint felszabadul a csatorna,
az adásra kész állomás pontosan 1 valószínűséggel (azaz biztosan) fog keretet küldeni.

* **CSMA/CD (Carrier Sense Multiple Access with Collision Detection, vivőjel-érzékelés
többszörös hozzáféréssel, ütközés detektálással):** a CSMA protokoll kiterjesztése
ütközésvizsgálattal. Mindegyik állomás állandóan figyeli a hálózati forgalmat.
Ha talál olyan adatcsomagot, amelyet neki címeztek leveszi, a többit figyelmen
kívül hagyja. Az adatküldésre készülő állomás is hallja a közegen zajló forgalmat,
és ha azt érzékeli, hogy valaki már adásban van, azaz vivőt érzékel (Carrier Sense),
akkor várakozik az adás megszűnéséig. Amikor elcsendesül a közeg, megkezdi az adást,
amelyet egyedül csak a megcímzett állomás fog átvenni.

* **CSMA/CA (Carrier Sense Multiple Access with Collision Avoidance, ütközés elkerülés):**
a készülék megvizsgálja a közeget, hogy érzékelhető-e adatjel. Ha a közeg szabad,
akkor a készülék küld egy értesítést a média használati szándékáról. A készülék
ezután elküldi az adatokat. Ezt a módszert használják a 802.11 vezeték nélküli
hálózati technológiák.

### 11.3 Az ütközés fogalma

Ütközésről beszélünk, ha egy közös adatátviteli csatornán két (vagy több) csomópont
egy időpillanatban továbbít információt.

### 11.4 Versenyhelyzetes és versenyhelyzet mentes csatornamegosztó protokollok

Azokat a rendszereket, amelyekben a közös csatorna használata konfliktushelyzetek
kialakulásához vezethet, **versenyhelyzetes (contention)** rendszereknek nevezzük.

**Versenyhelyzetes protokollok**

* **ALOHA:** lényege hogy a felhasználó bármikor adhat, ha van továbbítandó
adata. De ha bárki bármikor adhat, akkor valószínű, hogy ütközések lesznek. A küldő
azonban figyelheti a csatornát, így meg tudja állapítani hogy a keret tönkrement-e
vagy sem. Ha a keret megsérült akkor a küldő újraküld véletlenszerű várakozási
idő után. Egy keret akkor nem szenved ütközést, ha elküldésének első pillanatától
kezdve egy keret ideig más állomás nem próbálkozik keretküldéssel. Az egyszerű
ALOHA elven működő hálózatok maximális kihasználtsága 18%.
* **Réselt ALOHA:** képes arra hogy egy egyszerű ALOHA rendszer kapacitását megduplázzák.
A módszer lényege, hogy az időt szeletekre osztják, oly módon hogy minden felhasználónál
ugyanazok az időintervallum határok pontos helyei-ezt egy szinkronjel segítségével
határozzák meg. Az állomások az ütközést azzal detektálják, hogy nem kaptak az
üzenetükre nyugtakeretet. Az állomás a következő időszeletben véletlenszerűen
kezd adásba (véletlenszerű ideig várakozik), ez csökkenti az ütközés valószínűségét.
Előfordulhat a véletlenszerű várakozás miatt az is, hogy egyetlen állomás sem
kezdeményez adást. A réselt ALOHA a rendszerben nem kezdhető küldés bármikor, hanem
előbb meg kell várni az időrés kezdetét. Ha véges számú állomást tételezünk fel,
akkor a kihasználtság növekedhet. Réselt ALOHA-s hálózatokban a maximális
kihasználtság 37%-os.

**Versenyhelyzet mentes protokollok**

* **Vezérjeles gyűrűprotokoll (token ring protocol IEEE 802.5):** a hálózat topológiája
határozza meg az állomások adásának a sorrendjét. Az állomások egymásután egy gyűrűbe
vannak kapcsolva. A vezérjel továbbadása a következő állomáshoz egyszerűen abból áll,
hogy egy állomás fogadja az egyik irányból a vezérjelet és továbbadja a másik
irányba. A keretek is a vezérjel haladásának irányában továbbítódnak. Ennek
megfelelően a keretek körbehaladnak a gyűrű mentén, és elérik a címzett állomást.
Hogy egy adatkeret ne körözzön a hálózatban a végtelenségig (úgy, mint a vezérjel),
valamelyik állomásnak el kell távolítania a gyűrűről. Ez lehet az az állomás,
amelyik eredetileg küldte a keretet, vagy a keret célállomása.

### 11.5 A CSMA/CD protokoll működése

**CSMA/CD (Carrier Sense Multiple Access with Collision Detection, vivőjel-érzékelés
többszörös hozzáféréssel, ütközés detektálással):** közös kommunikációs csatorna
több fél közötti dinamikus elosztásának módját és szabályait meghatározó rendszer.
Szabályrendszere biztosítja, hogy a közös csatornán kommunikáló felek képesek
legyenek a szimultán adások és az ezekből következő ütközések detektálására,
valamint ezek elhárítására.

A CSMA/CD a CSMA protokoll kiterjesztése ütközésvizsgálattal. Mindegyik állomás
állandóan figyeli a hálózati forgalmat. Ha talál olyan adatcsomagot, amelyet neki
címeztek leveszi, a többit figyelmen kívül hagyja. Az adatküldésre készülő állomás
is hallja a közegen zajló forgalmat, és ha azt érzékeli, hogy valaki már adásban
van, azaz vivőt érzékel (Carrier Sense), akkor várakozik az adás megszűnéséig.
Amikor elcsendesül a közeg, megkezdi az adást, amelyet egyedül csak a megcímzett
állomás fog átvenni.

## 12. tétel

### 12.1 Az adatkapcsolati réteg helye és feladatai

Az adatkapcsolati réteg (Data Link Layer) az OSI hivatkozási modell második rétege,
amely a Hálózati réteg alatt és a Fizikai réteg fölött helyezkedik el. Feladata az,
hogy biztosítsa azt, hogy az adó oldali adatok a vevő oldalra is adatként jussanak
el, és ne legyen belőle értelmetlen jelek sorozata. Ezt úgy valósítja meg, hogy
az adatokat egyértelműen azonosítható adatkeretbe tördeli szét, ellátja a szükséges
vezérlőbitekkel, majd sorrendben továbbítja azokat. A vevő oldal pedig a kapott
kereteket megfelelő sorrendben összeállítja. Az adó oldal ezenkívül még a vevő
által küldött nyugtázásokat is feldolgozza. Mivel a fizikai réteg a biteket értelmezés
nélkül továbbítja, ezért az adatkapcsolati réteg feladata, hogy meghatározza illetve
felismerje a keretek határait. Így a felette elhelyezkedő réteg már hibáktól
mentes adatokat kap. Másik fontos feladata az, hogy a kétirányú átvitel esetén
az esetleges ütközésekből adódó problémákat megoldja, és hogy forgalomszabályozást
végezzen – tájékoztassa az adót a vevő fogadási szándékáról.

### 12.2 Keretképzés, a keret fő részei

Az adatkapcsolati réteg legtipikusabb feladata a keretezés (nyilván adó oldalon a
keretekbe tördelés, vevő oldalon a keretek eltávolítása – jellemzően az adó oldali
funkciókat tárgyaljuk részletesen). A réteg alapegysége az adat keret (Data Frame).
Önmagában a keretekre tördelés nem megoldás, szükség van (például) egy ellenőrző
összegre, ami megmutatja, hogy az adott keret sérülésmentesen érkezett-e meg a
vevő oldalra. Amennyiben az ellenőrző összegben eltérés van, akkor az egész keretet
meg kell ismételni.

A négy legáltalánosabban használt keretezési módszer a következő
* **karakterszámlálás, bájtszámlálás:** a keret hosszának, azaz a benne foglalt
bájtok számának megfelelő adatot írja bele egy fejlécbe, az úgynevezett
bájtszám mezőbe. Ennek az algoritmusnak az a (potenciális) hibája, hogy az átviteli
hiba szerencsétlen esetben pont a bájtszám mezőt érintheti, azaz ronthatja el.
Így az átvitel kiesik a szinkronból, képtelenség lesz megtalálni a következő
keret elejét (illetve végét). Ez a módszer ma már jellemzően nincs használatban.
* **kezdő és végkarakterek beszúrása:** a keret elejét és a végét is egy-egy
különleges jelzőbájttal (Flag) látjuk el (jellemzően egy escape karakterrel).
* **kezdő és végbitek beszúrása:**  lehetővé teszi, hogy tetszőleges számú bit
legyen a keretben, sőt, hogy a karakterkódok is tetszőleges számú bitből (ne csak
8 bitből) álljanak. Minden keret egy speciális bitmintával indul, amit szintén
jelzőbájtnak (Flag) nevezünk. Tartalmilag így néz ki: `01111110` azaz 6 db egymást
követő 1-es. A bitbeszúrásos módszerrel egyértelműen felismerhetők a kerethatárok.
A szinkron elvesztése esetén meg kell keresni a 6 db egymást követő 1-est, és így
meg is találjuk a kerethatárokat, hiszen a 6db 1-es csak ott fordulhat elő.
* **fizikai rétegbeli kódolás megsértése:** bizonyos kódolások esetén léteznek
olyan jelsorozatok, jelváltások, amelyek az adatátvitel során objektíve nem
fordulhatnak elő. Így ezek felhasználhatóak jelzésekre, mivel az átvitt adattal
semmiképpen sem téveszthetőek össze. Ezek a kódok, azaz jelsorozatok könnyen
azonosíthatóak, és így a keretek beazonosításához nincs szükség az átvitt adatok
módosításárra (majd visszaalakítására). Összességében ez az eljárás terheli meg
a legkevesebb „feleslegesen” átvitt adattal az adatátvitelt.

Az legtöbb adatkapcsolati protokoll a gyakorlatban, a nagyobb biztonság érdekében
(még ha ezzel jelentősen meg is növeli az átvitt adatok mennyiségét) a fenti
módszerek valamely kombinációját alkalmazza. Például a keret az IEEE802.11 protokollban
egy 72 bites, az IEEE802.3 protokollban egy 56 bites előtaggal (Preamble) kezdődik.

**A keret részei:**

1. Az **előtag (preamble)** váltakozva tartalmaz egyeseket és nullákat. 7 darab
10101010 tartalmú bájtból álló sorozat. A 10 Mbit/s-os és kisebb sebességű
Ethernet-megvalósításoknál az órajel szinkronizálása ennek a mezőnek a segítségével
történik. Az Ethernet gyorsabb változatai szinkron működésűek, ezeknél időzítési
információkra nincs szükség; ennek ellenére, a kompatibilitás érdekében a mező
megmaradt.

2. Az előtagot egy egy oktettből álló mező a keretkezdő (**Start Frame Delimiter, SFD**)
követi, amely az időzítési információk végét, a keret tényleges kezdetét jelzi.
Tartalma az 10101011 bitsorozat.

3. Ezután a **cél (destination)** és **küldő (source) állomás** 48-bites címei
következnek. Az Ethernet hálózaton minden állomást egy egyedi, 48-bites (6 bájtos)
ún. **MAC (Media Access Control) cím** azonosít. Ezen címek kiosztását az
IEEE kontrollálja.

4. A **hossz/típus mező**t kétféle célra lehet használni. Ha értéke a decimális
1536-nál, vagyis a hexadecimális 0×600-nál kisebb, akkor a benne szereplő érték
hosszt ad meg, egyébként típus értékként azt adja meg, hogy az Ethernet folyamatainak
lezárulása után melyik felsőbb rétegbeli protokoll fogja kapni az adatokat. A
hossz a mező követő adatrészben található bájtok számát adja meg.

5. Az **adat mező** és a szükség szerinti kitöltés hossza tetszőleges lehet,
azonban a keret mérete nem haladhatja meg a felső mérethatárt. A **maximális átviteli
egység (maximum transmission unit, MTU)** az Ethernet esetében 1500 oktett (bájt),
az adatok mérete tehát ezt nem haladhatja meg. A mező tartalma nincs meghatározva.
Ha nincs elég felhasználói adat ahhoz, hogy a keret mérete elérje a minimális
kerethosszt, akkor előre meg nem határozott mennyiségű adat kerül beillesztésre,
közvetlenül a felhasználói adatok mögé. Ezt a többletadatot nevezzük kitöltésnek.
Az Ethernet keretek hosszának 64 és 1518 oktett között kell lennie.

6. A keret végén szereplő **FCS (Frame Check Sequence - Keret Ellenőrző Sorozat)**
mezőben 4 bájton CRC ellenőrző összeg helyezkedik el. Ha a vevő által számolt és
a keretben lévő összeg nem egyezik, a keret eldobásra kerül.

### 12.3 Fizikai cím

A **MAC-cím** (**Media Access Control**, a hardvercím, MAC-rétegbeli cím és fizikai
cím elnevezés is használatos) egy hexadecimális számsorozat, amellyel még a
gyártás során látják el a hálózati kártyákat. A hálózat többi eszköze ezt használja
a hálózat előre meghatározott portjainak azonosítására. Ezek mellett az irányítótáblák
és egyéb adatszerkezetek létrehozására és frissítésére is alkalmas.

Minden eszköznek saját MAC-címe van. A több interfésszel rendelkező eszközöknek
célszerűen több is lehet. A címet (címtartományokat) a szabványügyi hivatal adja
ki a gyártónak, és ezt a gyártó fizikailag beégeti vagy szoftverrel beállítja az
interfészben. A címet 12 darab hexadecimális számjegy formájában szokták megadni,
amelyből az első hat hexadecimális számjegy kiosztását az IEEE felügyeli, ezek a
gyártót vagy az eladót azonosítják. A MAC-címnek ezt a részét egyedi
szervezetazonosítónak (Organizational Unique Identifier, OUI) nevezzük. A fennmaradó
hat hexadecimális számjegyet a gyártó adminisztrálja saját körben.

A fizikai cím egy Ethernet hálózaton (LAN) megegyezik az Ethernet címmel. Ha egy
számítógép csatlakozik az internetre, akkor az IP-címe és a MAC-címe össze van
rendelve egy megfeleltetési táblázatban. A telekommunikációs rétegek adatkapcsolási
(2.) rétege használja, ezen belül van egy külön alréteg a fizikai címek számára.

### 12.4 Hibavédelem az adatkapcsolati rétegben: ellenőrző összeg

A **keretellenőrző (Frame Check Sequence, FCS) mezőt** (4 bájt) a hibák észlelésére
használják a keretben. Ez a **[ciklikus redundancia kódot (Cyclic Redundancy Code,
CRC)](https://hu.wikipedia.org/wiki/Hibajav%C3%ADt%C3%A1s#Ciklikus_redundancia-ellen%C5%91rz%C3%A9s_(Cyclic_redundancy_check_%E2%80%93_CRC))** használja. A küldő készülék beleteszi a CRC-számítás
eredményét a keret FCS-mezejébe. A fogadó készülék megkapja a keretet, és szintén
generál egy CRC-t a hibakereséséhez. Ha a számítások megegyeznek, nem történt hiba.
Ha a számítások nem egyeznek, az azt jelzi, hogy az adat megváltozott, ezért a
keretet el kell dobni. Az adatban bekövetkezett változás annak a következménye
lehet, hogy a biteket képviselő elektromos jelekben zavar keletkezett.

### 12.5 A pont-pont (PPP) protokoll

A **Pont-pont vagy kétpontos protokoll (PPP, Point-to-Point Protocol)** egy magas
szintű adatkapcsolati protokoll kétpontos vonalakhoz. Széleskörűen alkalmazott
megoldás az Internetben. A PPP egy korábbi, egyszerűbb protokoll továbbfejlesztése,
amelyet **SLIP-nek (Serial Line Internet Protocol – soros vonali internetprotokoll)**
neveznek. A PPP-protokollt hibakezelésre, kapcsolatok konfigurálására, több protokoll
támogatására, hitelesítésre és több más célra használják.

Szolgáltatásai:

* Olyan keretezési módszert vezet be, mely egyértelműen ábrázolja a keret végét
és a következő keret elejét. A keretformátum egyúttal megoldja a hibajelzést is.
* Adatkapcsolat-vezérlő protokollt tartalmaz **(LCP - Link Control Protocol)** a
vonalak felélesztésére, tesztelésére, vonalak bontására.
* Különböző hálózati vezérlő protokollokat **(NCP - Network Control Protocol)**
tartalmaz mindegyik támogatott hálózati réteghez.

A PPP keretformátuma

| Mező mérete (bájtban)| 1 | 1 | 1 | 1 vagy 2 | Változó | 2 vagy 4 | 1 |
|----------------------|---|---|---|----------|---------|----------|---|
| Mező | Jelző (01111110) | Cím (11111111) | Vezérlő (00000011) | Protokoll | Hasznos teher | Ellenőrző összeg | Jelző (01111110) |

Minden PPP keret a szabványos jelző bájttal (01111110) kezdődik. Ezután következik
a Cím mező, mely mindig az 11111111 értékre van állítva annak jelzésére, hogy
minden állomásnak vennie kell a keretet. A harmadik mező a Vezérlő mező, mely
alapesetben a 00000011 értékre van állítva, mely a számozatlan keret jelzésére
szolgál. Alapesetben a PPP nem biztosít megbízható átvitelt, de zajos környezetben
(pl. vezeték nélküli hálózat) a megbízható átvitel megoldható a számozott mód
használatával (sorszámok és nyugták alkalmazásával). A következő mező a Protokoll
mező, mely azt jelzi, milyen csomag van az adat mezőben (pl. LCP, NCP, IP, IPX,
stb.). Következik az adat mező, mely változó hosszúságú, de alapértelmezésként
maximum 1500 bájt. Ezután jön az Ellenőrző összeg mező, mely általában 2 bájt,
de lehet 4 bájt is.

### 12.6 Forgalomszabályozás (a gyors adók, lassú vevők problémája)

Egy az adatkapcsolati rétegben (de a legtöbb magasabb szintű rétegben is) előforduló
probléma az, hogy a gyors adók adatelárasztással fenyegetik a lassú vevőket. Valamilyen
forgalomszabályozási mechanizmust kell beépíteni annak érdekében, hogy az adók
tudhassák, hogy a vevők egy adott pillanatban mekkora szabad puffer területtel
rendelkeznek.

A **flow control** az ethernet folyamat szabályozását végzi olyan módon, hogy a
hálózati eszköz képes megmondani a közvetlen szomszédjának, hogy túl van terhelve
adatokkal. Ilyen például amikor az eszköz gyorsabban kap adatokat, mint ahogyan
azt fel tudná dolgozni. A flow control lehetővé teszi, hogy a túlterhelt készülék
küldjön egy szünet keretet, melyben azt kéri, hogy a vezeték túl oldalán lévő
készülék állítsa meg az adatküldést ideiglenesen.

A gyakorlatban két megközelítés terjedt el
* **Visszacsatolás-alapú forgalomszabályozás (feedback-based flow control):** a
vevő információt küld vissza a feladónak, amelyben engedélyt ad neki további adatok
küldésére, vagy legalábbis tájékoztatja saját pillanatnyi állapotáról.
* **Sebességalapú forgalomszabályozás (rate-based flow control):** a protokollba
be van építve egy sebességkorlát, amelyet minden küldőnek minden adattovábbítás
során tiszteletben kell tartania. Ez a megoldás a fogadó részéről semmilyen
visszacsatolást nem igényel.


## 13. tétel

### 13.1 Az Ethernet-típusú hálózati szabványok és főbb jellemzőik: közegelérési protokoll, adatátviteli sebesség, kábelezés

A DEC, Intel és Xerox cégek által kidolgozott alapsávú LAN-ra vonatkozó specifikáció,
amelyet az IEEE 802.3 számon szabványosított 1983-ban. Az [IEEE 802.3](https://hu.wikipedia.org/wiki/IEEE_802.3)
egy szabványgyűjtemény, amely az IEEE szabványokkal meghatározott, Ethernet
kábelezést használó fizikai rétegnek és adatkapcsolati rétegnek a megvalósításait
írja le. Ez egy általánosan használt LAN technológia, amely fizikai kapcsolatot
hoz létre a hálózati csomópontok és/vagy az infrastruktúra eszközei (hubok,
switchek, routerek) között, különböző és sokféle réz- és optikai kábelek segítségével.

A szabvány főbb változatai:

**Klasszikus Ethernet, 1983 (IEEE 802.3):** Az Ethernet szinte azonnal – a klasszikus
Ethernet egyetlen hosszú kábelt tartalmazó architektúrájának megjelenését követően
– továbbfejlődött. A kábel töréseivel vagy az érintkezési hibák megtalálásával
összefüggő probléma egy új vezetékezési mintát kényszerített ki, amelyben minden
állomás saját kábellel csatlakozik egy központi elosztóhoz (hub). Az elosztó
egyszerűen villamos kapcsolatot létesít a hozzá csatlakozó vezetékek között, mintha
összeforrasztották volna azokat.

A megnevezés első száma az átviteli sebességet jelöli (Mb/s). Az Ethernet hálózatok
fajtáinak a jelölésére használjuk a Base szót, ami azt fejezi ki, hogy a jelátvitel
alapsávon történik, ami azt jelenti, hogy a jelátvivő közegen csak az Ethernet
jel közlekedik. A következő szám, koaxiális kábel esetén a kábel hosszát adja
meg 100 méteres egységekre kerekítve.

A klasszikus Ethernet kábelek leggyakoribb típusai:

| Megnevezés | Kábelezés | Max szegmenshossz | Csomópont/szegmens |
|------------|-----------|-------------------|--------------------|
| 10Base5  | vastag koax | 500 méter | 100 |
| 10Base2  | vékony koax | 185 méter | 30 |
| 10Base-T | sodrott érpár | 100 méter | 1024 |
| 10Base-F   | optikai   | 2000 méter| 1024 |


**Gyors Ethernet, 1995 (IEEE 802.3u):** a klasszikus Ethernet továbbfejlesztése,
100 Mbit/s átviteli sebességgel.

A Gyors Ethernet kábelek leggyakoribb típusai:

| Megnevezés | Kábelezés | Max szegmenshossz |
|------------|-----------|-------------------|
| 100Base-T4 | sodrott érpár | 100 méter |
| 100Base-TX | sodrott érpár | 100 méter |
| 100Base-FX | optikai | 2000 méter |


**Gigabites Ethernet, 1998 (IEEE 802.3z):**

A gigabites Ethernet – eltérően a klasszikus Ethernet-től – pont-pont felépítésű.
A legegyszerűbb topológiánál a két számítógép van gigabites Ethernettel összekapcsolva.
Gyakoribb az a megoldás, amikor egy kapcsoló vagy elosztó köt össze több számítógépet,
vagy további elosztókat vagy további kapcsolókat. Minden esetben egy Ethernet kábel
végén pontosan egy-egy eszköz található csak.

A gigabites Ethernet két működési módot támogat: a duplex és félduplex működést.
„Normális” esetnek a duplex módot tekintik, a forgalom mindkét irányban egyidőben
folyhat. Ezt akkor használják, ha egy központi kapcsolót vagy a periférián lévő
gépekkel, vagy más kapcsolókkal kötnek össze. Ekkor minden adatot pufferelnek, így
bármelyik gép és kapcsoló tetszés szerinti időben küldheti el az adatait (kereteit).
Az adónak nem kell figyelnie a csatorna forgalmát, mert a versengés kizárt. Míg
az elosztók esetében az összes állomás egy ütközési tartományt (collision domain)
képez, **kapcsoló esetén, minden porthoz saját ütközési tartomány tartozik**.

A Gigabites Ethernet kábelek leggyakoribb típusai:

| Megnevezés | Kábelezés | Max szegmenshossz |
|------------|-----------|-------------------|
| 1000Base-SX | optikai | 550 méter |
| 1000Base-LX | optikai | 5000 méter |
| 1000Base-CX | 2 pár STP | 25 méter |
| 1000Base-T  | 4 pár UTP | 100 méter|


**Közegelérési protokollok**

Az Ethernet hálózat eszközei a legtöbb esetben egy közös fizikai csatornát használnak
a kommunikáció megvalósításához. Az IEEE 802.3 szabvány szerinti Ethernet hálózatba
kapcsolt állomások mindegyike egyenlő jogokkal rendelkezik a közeg használatát
illetően. Szükség van egy olyan protokollra, amely versenyhelyzet esetén eldönti,
hogy a csatornára igényt tartók közül ki nyerje el a jogot az adásra. Ezzel a
problémával az adatkapcsolati réteg egy alrétege, a közegelérési alréteg
**(MAC, Medium Access Control)** foglalkozik. A közegelérés-vezérlési eljárások
azokat a szabályokat tartalmazzák, amelyek megadják, mikor és mennyi ideig használhatja
egy állomás az adatcsatornát.

*Csatornakiosztásos (statikus) protokollok*

* **TDM (Time Division Multiplexing, időosztásos nyalábolás):** a versenyhelyzeteket
a legegyszerűbben úgy kerülhetjük el, ha előre meghatározott időközönként a csatornát
más-más állomás használja.

* **FDM (Frequency Division Multiplexing, frekvenciaosztásos nyalábolás):** a
csatorna sávszélességét osztják fel annyi részre, amennyi állomás kapcsolódik a
csatornára. Mindenkinek külön frekvencia-sávja van.

*Csatornafigyelő (dinamikus) protokollok*

* **CSMA (Carrier Sense Multiple Access, vivőjel-érzékelés többszörös hozzáféréssel):**
ha egy állomás küldeni akar, de a csatorna foglalt, akkor addig vár, amíg az fel
nem szabadul. Amint ez bekövetkezik, az állomás útnak indítja a keretet. Ha ütközés
lép fel, akkor véletlen ideig várakoznia kell, majd ismét meg kell próbálnia elküldeni a
keretet. Az „1-perzisztens” kifejezés azt jelenti, hogy amint felszabadul a csatorna,
az adásra kész állomás pontosan 1 valószínűséggel (azaz biztosan) fog keretet küldeni.

* **CSMA/CD (Carrier Sense Multiple Access with Collision Detection, vivőjel-érzékelés
többszörös hozzáféréssel, ütközés detektálással):** a CSMA protokoll kiterjesztése
ütközésvizsgálattal. Mindegyik állomás állandóan figyeli a hálózati forgalmat.
Ha talál olyan adatcsomagot, amelyet neki címeztek leveszi, a többit figyelmen
kívül hagyja. Az adatküldésre készülő állomás is hallja a közegen zajló forgalmat,
és ha azt érzékeli, hogy valaki már adásban van, azaz vivőt érzékel (Carrier Sense),
akkor várakozik az adás megszűnéséig. Amikor elcsendesül a közeg, megkezdi az adást,
amelyet egyedül csak a megcímzett állomás fog átvenni.

* **CSMA/CA (Carrier Sense Multiple Access with Collision Avoidance, ütközés elkerülés):**
a készülék megvizsgálja a közeget, hogy érzékelhető-e adatjel. Ha a közeg szabad,
akkor a készülék küld egy értesítést a média használati szándékáról. A készülék
ezután elküldi az adatokat. Ezt a módszert használják a 802.11 vezeték nélküli
hálózati technológiák.

**Adatátviteli sebesség**

Az adatátviteli sebesség (hálózati sebesség, sávszélesség, bitráta, bandwidth),
az információáramlás sebességének mértéke, amely az adatátviteli berendezések által
másodpercenként átvitt jelek avagy bitek számát adja meg. Tömören: **az időegység
alatt átvitt információ mennyisége**. Mértékegysége a bit/másodperc, b/s, bps. Az
adatátviteli sebességet tipikusan a csatorna kapacitásának mérésére, jelzésére
használják.

Nagyobb egységek:
* 1 kb/s = 1000 b/s
* 1 Mb/s = 1000 kb/s
* 1 Gb/s = 1000 Mb/s

### 13.2 Ethernet keretformátumok (IEEE 802.3)

Az ethernet hálózatokon az adatok keretekben jutnak el a címzettől a feladóig. A
keretek valójában nem mások, mint mezőkre osztott bitsorozatok. Az információ adóoldali
szétdarabolását és vevő oldali összeillesztését az Ethernet a felsőbb rétegekre
bízza, ahogy a hibajavítást is.

A mezőkben a következők szerepelhetnek:

1. Az **előtag (preamble)** váltakozva tartalmaz egyeseket és nullákat. 7 darab
10101010 tartalmú bájtból álló sorozat. A 10 Mbit/s-os és kisebb sebességű
Ethernet-megvalósításoknál az órajel szinkronizálása ennek a mezőnek a segítségével
történik. Az Ethernet gyorsabb változatai szinkron működésűek, ezeknél időzítési
információkra nincs szükség; ennek ellenére, a kompatibilitás érdekében a mező
megmaradt.

2. Az előtagot egy egy oktettből álló mező a keretkezdő (**Start Frame Delimiter, SFD**)
követi, amely az időzítési információk végét, a keret tényleges kezdetét jelzi.
Tartalma az 10101011 bitsorozat.

3. Ezután a **cél (destination)** és **küldő (source) állomás** 48-bites címei
következnek. Az Ethernet hálózaton minden állomást egy egyedi, 48-bites (6 bájtos)
ún. **MAC (Media Access Control) cím** azonosít. Ezen címek kiosztását az
IEEE kontrollálja.

4. A **hossz/típus mező**t kétféle célra lehet használni. Ha értéke a decimális
1536-nál, vagyis a hexadecimális 0×600-nál kisebb, akkor a benne szereplő érték
hosszt ad meg, egyébként típus értékként azt adja meg, hogy az Ethernet folyamatainak
lezárulása után melyik felsőbb rétegbeli protokoll fogja kapni az adatokat. A
hossz a mező követő adatrészben található bájtok számát adja meg.

5. Az **adat mező** és a szükség szerinti kitöltés hossza tetszőleges lehet,
azonban a keret mérete nem haladhatja meg a felső mérethatárt. A **maximális átviteli
egység (maximum transmission unit, MTU)** az Ethernet esetében 1500 oktett (bájt),
az adatok mérete tehát ezt nem haladhatja meg. A mező tartalma nincs meghatározva.
Ha nincs elég felhasználói adat ahhoz, hogy a keret mérete elérje a minimális
kerethosszt, akkor előre meg nem határozott mennyiségű adat kerül beillesztésre,
közvetlenül a felhasználói adatok mögé. Ezt a többletadatot nevezzük kitöltésnek.
Az Ethernet keretek hosszának 64 és 1518 oktett között kell lennie.

6. A keret végén szereplő **FCS (Frame Check Sequence - Keret Ellenőrző Sorozat)**
mezőben 4 bájton CRC ellenőrző összeg helyezkedik el. Ha a vevő által számolt és
a keretben lévő összeg nem egyezik, a keret eldobásra kerül.

### 13.3 Az ütközésérzékelés és a maximális szegmenshossz

Az ütközésérzékelés (Collision Detection) esetén a készülék figyeli, hogy van-e
adatjel a közegen. Amennyiben az adatjel hiányzik, jelezve hogy a közeg szabad,
a készülék továbbítja az adatokat. Ha ezek után adatjeleket érzékelünk – ami azt
jelzi, hogy egy másik készülék is ugyanabban az időben forgalmazott –, minden más
eszköz leállítja a küldést és később újra próbálkozik. Az Ethernet hagyományos
változatait ennek a módszernek a használatára fejlesztették ki.

A kapcsolt technológiák széles körű elterjedése a modern hálózatokban jórészt
feleslegesé tette a CSMA/CD által használt folyamatokat. A LAN-eszközök között
szinte az összes vezetékes kapcsolat manapság full-duplex, vagyis a készülék
egyszerre képes küldeni és fogadni is. Míg az Ethernet hálózatokat a CSMA/CD-technológiára
tervezték, a mai közvetítő eszközöknél ütközések nem fordulnak elő.

A maximális szegmenshossz – az alkalmazott szabvány változat függvényében – 25 és
5000 méter között változhat.

### 13.4 Ethernet szegmensek összekapcsolása a fizikai rétegben (ismétlőkkel)

Minden Ethernet-verzió rendelkezik egy legnagyobb megengedett szegmensenkénti
kábelhosszal (erősítetlen hossz), amely távolságra a jel terjed. Hogy nagyobb
hálózatokat lehessen kialakítani, több kábelszegmenst ismétlőkkel (**repeater**)
kell összekapcsolni. **Az ismétlők fizikai rétegben működő eszközök, amelyek
fogadják, erősítik (azaz regenerálják, újra előállítják) és mindkét irányba
kiküldik a jelet**. Szoftverszempontból a kábelszegmensek ismétlőkkel összekapcsolt
sorozata nem különbözik egy egyszerű kábeltől (leszámítva az ismétlők által
behozott kismértékű késleltetést). Az ismétlőkkel összekapcsolt hálózat egyetlen
nagy LAN-ként viselkedik, az összes gép ugyanabban a broadcast domain-ben van.

Ezeken a kábeleken keresztül az információt a [Manchester-kódolás](https://hu.wikipedia.org/wiki/Manchesteri_k%C3%B3dol%C3%A1s)
használatával továbbítják. Egy Ethernet-hálózat több kábelszegmenst és több ismétlőt
tartalmazhat, de **két adó-vevő nem lehet messzebb egymástól 2,5 km-nél, valamint
bármelyik két adó-vevő között legfeljebb csak négy ismétlő lehet**.

A jelismétlőket elterjedten a busz topológiájú LAN-oknál használják, hiszen gyűrű
topológia esetén minden állomás eleve jelismétlőként működik: fogadja az üzenetet,
és a szintjére visszaállított jelet küld tovább. Jelismétlők használatánál mindegyik
hálózati szegmensnek ugyanolyan típusúnak kell lennie.

A **hub**okat tipikusan helyi hálózatokban használják számítógépek és más eszközök
összekötésére.

Az egyszerűbb **passzív hub**ok csupán fizikai összekötő pontként szolgálnak, nem
módosítják vagy figyelik a rajtuk keresztülhaladó forgalmat. Működésük során a
bemeneti kapura érkező csomagokat értelmezés és válogatás nélkül minden más kapura
kimenetként másolják, így azt minden az adott hubba csatlakozó hálózati eszköz
megkapja.

Ezzel szemben az **aktív vagy intelligens hub**ok többportos ismétlőként működnek, a
fogadott csomagokat értelmezik, és csak arra a kapura továbbítják, amelyiken a
csomag célállomása található.

A legelterjedtebbek a 8, 16, 24 portos eszközök, de találkozhatunk kisebb, 4
portossal is. A passzív hubok elektromos tápellátást nem igényelnek. Az intelligens
hubok aktív hubként üzemelnek, mikroprocesszorral és hibakereső képességekkel
rendelkeznek.


[Kezdőlap](README.md)
