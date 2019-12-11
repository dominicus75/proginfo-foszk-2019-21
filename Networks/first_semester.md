[Kezdőlap](README.md)

# 2019/20 I. félév szóbeli tételek


## 1. tétel

### 1.1 Ethernet szegmensek összekapcsolása az OSI 2. rétegben

Az Ethernet az [IEEE 802.3-as szabványt](https://hu.wikipedia.org/wiki/IEEE_802.3)
megvalósító, korábban [busz](https://hu.wikipedia.org/wiki/Busztopol%C3%B3gia), ma
inkább [csillag](https://people.inf.elte.hu/moaqaci/szamalap_beadando_1/szamitogepes_halozatok_vilaga.htm#_Toc213477392)topológiát alkalmazó helyi hálózat ([LAN](https://hu.wikipedia.org/wiki/Helyi_h%C3%A1l%C3%B3zat)),
amelynek sebessége 10Mb/s vagy 100Mb/s.

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


### 1.5 A switching technológia

Egy LAN switch logikai funkciójában megegyezik a bridge-k funkciójával, azaz
elkülönült hálózati szegmenseket kapcsol össze és a lokális forgalmat nem engedi
ki. A különbség csupán annyi, hogy a swicth képes a portjai között egymástól
függetlenül is kereteket továbbítani.

### 1.6 Az Ethernet swich-ek típusai


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

### 10.2 A fizikai csatorna vágási frekvenciája és sávszélessége

### 10.3 Maximális adatátviteli sebesség zajmentes csatornán (Nyquist tétele)

### 10.4 A jel-zaj viszony jellemzése, a decibel érték

### 10.5 Maximális adatátviteli sebesség zajos csatornán (Shannon tétele)

### 10.6 Vezetékes adatátvitel: sodrott érpár, alapsávú és szélessávú koaxiális kábel

### 10.7 Fényvezető szálas adatátvitel

### 10.8 Egy- és többmódusú optikai kábelek

### 10.9 Csillapítás jellemzése fényvezető szálakban

### 10.10 A fénykábelek fizikai felépítése


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
