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
kívül helyeznek, az üzemelésük helyét megváltoztatják. A dinamikusan változó topológia
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
hálózatokra a csillagpontos topológia és a kapcsolt Ethernet, azaz a Switch-ek é
s a Router-ek mint aktív hálózati elemek használata.

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

![Imgur](https://i.imgur.com/rO4YDxh.png)



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

### 5.2 A TCP protokoll működése: a port fogalma, a TCP fejléc, összeköttetés létesítése és bontása, átviteli politika, torlódáskezelés

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

### 11.2 A statikus és a dinamikus csatornakiosztás lényege, jellemzői

### 11.3 Az ütközés fogalma

### 11.4 Versenyhelyzetes és versenyhelyzet mentes csatornamegosztó protokollok

### 11.5 A CSMA/CD protokoll működése


## 12. tétel

### 12.1 Az adatkapcsolati réteg helye és feladatai

### 12.2 Keretképzés, a keret fő részei

### 12.3 Fizikai cím

### 12.4 Hibavédelem az adatkapcsolati rétegben: ellenőrző összeg

### 12.5 A pont-pont (PPP) protokoll

### 12.6 Forgalomszabályozás (a gyors adók, lassú vevők problémája)


## 13. tétel

### 13.1 Az Ethernet-típusú hálózati szabványok és főbb jellemzőik: közegelérési protokoll, adatátviteli sebesség, kábelezés

### 13.2 Ethernet keretformátumok

### 13.3 Az ütközésérzékelés és a maximális szegmenshossz

### 13.4 Ethernet szegmensek összekapcsolása a fizikai rétegben (ismétlőkkel)


[Kezdőlap](README.md)
