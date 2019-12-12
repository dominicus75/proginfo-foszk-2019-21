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

### 2.2 Datagram és virtuális áramkör alapú szolgálat

### 2.3 Alapvető forgalomirányítási algoritmusok: az elárasztás, a legrövidebb út algoritmus, a távolságvektor alapú forgalomirányítás


## 3. tétel

### 3.1 Az IP protokoll helye és feladatai

### 3.2 Az IPv4 és IPv6 csomagok fontosabb fejrész információi

### 3.3 Az IPv4 címzési rendszere, az IPv4 cím szerkezete

### 3.4 A hálózat címe és az üzenetszórási (broadcast) cím

### 3.5 Az IP címek osztályozása

### 3.6 Az alhálózati maszk szerepe: a hálózat felosztása alhálózatokra

### 3.7 Az alapértelmezett átjáró

### 3.8 Példa több alhálózatot (és routert) tartalmazó IP hálózatra


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

| 1 kb/s | 1000 b/s  |
| 1 Mb/s | 1000 kb/s |
| 1 Gb/s | 1000 Mb/s |

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

### 10.5 Maximális adatátviteli sebesség zajos csatornán (Shannon tétele)

Shannon tétele azt mondja ki, hogy egy **B** sávszélességű, S/N jel-zaj viszonyú
csatorna esetében mekkora az elérhető maximális adatsebesség:

**Maximális adatsebesség = B log<sub>2</sub>(1+S/N) [bit/sec]**

A B mértékegysége Hz, az S/N-é dB.

### 10.6 Vezetékes adatátvitel: sodrott érpár, alapsávú és szélessávú koaxiális kábel

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