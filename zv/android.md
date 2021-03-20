[Kezdőlap](../README.md)

# Android

## 1. Fejlesztőkörnyezet, SDK Manager, AVD Manager. Fizikai eszközön való futtatás megvalósítása.

**Fejlesztőkörnyezet:**
Android fejlesztés hivatalos fejlesztőkörnyezete az Android Studio, amely egy IntelliJ alapú IDE. 
Számos hasznos funkciót biztosít a hatékony fejlesztés érdekében:
* Grade-alapú fordítás támogatása
* Emulátorok létrehozása
* Instant run funkció: megváltozott kód futtatása új apk létrehozása nélkül
* Mintakódok és projektsablonok
* Git integráció
* Tesztelési funkciók
* Teljesítménymérő eszközök
* C++, Android NDK támogatás
* Google felhőszolgáltások integrációjának elősegítése
* Database Inspector: Emulátoron vagy fizikai eszközön futtatott alkalmazás SQLite adatbázisának kezelése

A fejlesztőkörnyezet telepítése előtt az Oracle Java (Java SE Development Kit) SDK telepítése szükséges.
Az Android Studio Windows, Mac, Linux és Chrome OS operációs rendszerekre egyaránt elérhető.

*Felhasználói felület*
Minden projekt Android Studio-ban egy vagy több modulból áll, mely forrás- és erőforrásállományokat tartalmaznak.
Alapértelemezett az Andoid nézet, ami projektünket alkalmazásra (app) és gradle script-ekre bontva láthatjuk.
app-on belül további három könyvtárra választja szét az alkalmazást:
* manifests: alkalmazás manifest állománya (AndroidManifest.xml), amely az engedélyeket, komponenseket, stb. definiálja
* java: forrásállományok helye, beleértve a teszteket is
* res: erőforrásállományok (minden, ami nem forrásállomány) helye: XML layout, szövegek, képek, animációk, hangfájlok, stb.

*Kódkiegészítés és navigáció*
A kódkiegészítés minden fejlesztőeszköz kiemelkedően fontos funkciója, amely a programkód megírását gyorsítja.
Az eszköz által javasolt módosítások segítségével jobb minőségű forráskódot tudunk létrehozni,
egységesebb kódbázist kaphatunk és megismerkedhetünk új megoldásokkal is.
Android Studio-ban ennek három szintje létezik, ezeket billentyűkombinációkon keresztül érhetjük el:
* Basic completion (Control + Space): Alapvető javaslatokat tesz változók, típusok, metódusok, kifejezések kiegészítése.
* Smart completion (Control + Shift + Space): Kód környezetétől függően tesz pontosabb javaslatokat.
* Statement completion (Control + Shift + Enter): Aktuális kifejezés kiegészítése (hiányzó zárójelek, formázás, stb.).

Gyors funkciók közül kiemelendő még az Alt + Enter kombináció, amivel javítási javaslatokat tesz.
Ilyenek lehetnek például a hiányzó import-ok, interface metódusainak implementálása, stb.
Az Android Studio ezeket a javítanivalókat maga is jelzi a code editor bal oldali sávjában a kódsorok számozása mellett.

**SDK Manager:**
Android Studio telepítése után is van lehetőségünk az új Android verziókat és fejlesztési eszközöket letölteni és azokkal új alkalmazásokat létrehozni, meglévőket pedig frissíteni.
Az SDK Manager ablakában (vagy az sdkmanager parancssori tool-lal) megtekinthetjük a letölthető Android verziókat (SDK Platforms) és SDK eszközöket. 
Az elkészült alkalmazásunkat korábbi Android verziójú rendszereken tesztelhetjük, így biztosítva azt, hogy a lehető legtöbb készüléken működjön az alkalmazásunk.

**AVD Manager:**
Android alkalmazások futtatásához egy fizikai vagy virtuális eszközre lesz szükségünk. 
Virtualizációs megoldásnál jóval több lehetőségünk van mivel telefont, tabletet,
viselhető eszközt vagy akár Android-os TV-t is emulálhatunk. Virtuális eszközök létrehozására az AVD Manager szolgál. 
Amikor létrehozunk egy ilyen eszközt egyaránt választhatunk a Google referenciakészülékeiből
és saját magunk is felparaméterhetünk egyet, amely magában foglalja az Android verzióját,
felbontást, memória mennyiségét és a CPU típusát is. Az így létrehozott hardware profilt menthetjük
vagy egy korábbit importálhatunk is az AVD Manager segítségével.

**Fizikai eszközön való futtatás megvalósítása:**
Az alkalmazásunkat fordítás után többféle módon is futtathatjuk fizikai eszközön:
* Az elkészült *apk* fájlt rámásoljuk a készülékre és a készülék beépített fájböngészője segítségével telepítjük.
Ebben az esetben a beállításokban engedélyezni kell az ismeretlen forrásból származó alkalmazások telepítését.
* Az Android Studió *Run* funkciójának használatához a fizikai eszözt egy adatkábel segítségével
a számítógépre kell kötni, és a beállításokban engedélyezni kell a fejlesztői beállításokat.
Ezek után az IDE a fordításkor létrejött apk állományt telepíti a készülékre és el is indítja azt.

## 2. Android komponensek részletezése: Activity, Service, BroadcastReveiver, ContentProvider.

Android rendszeren általában egy alkalmazás egy vagy több komponensből is állhat. 
Mivel a legtöbb alkalmazás rendelkezik felhasználói felülettel, ezért szinte minden applikáció megjelenik az alkalmazásindítóban. 
Itt viszont nem maga az alkalmazás, hanem a telepített alkalmazások komponensei jelennek meg, egy alkalmazás akár több komponense is megjelenhet az alkalmazásindítóban. 
A komponensek közül nem mindegyik érhető el közvetlenül a felhasználó számára, egyes komponensek háttérben futó műveleteket végeznek, vagy különböző események hatására aktiválódnak. 
Négy komponenst különböztetünk meg az Android platformon, ezek mindegyike eltérő funkcionalitással bír:
* Activity
* Service
* ContentProvider
* BroadcastReceiver

**Activity**
Az [Activity](https://developer.android.com/guide/components/activities/intro-activities) komponens felel a felhasználói felület megjelenítéséért, ezért a legtöbb
alkalmazás rendelkezik legalább egy Activity-vel.
Egy alkalmazás több Activity-t is tartalmazhat, és a megfelelő konfigurációval akár több Activity is megjelenhet az alkalmazásindítóban.
Az Activity komponens saját [életciklussal](#5.-Activity-életciklusmodellje.) rendelkezik, amelyben változás bekövetkezhet felhasználó interakció vagy rendszerművelet hatására.
Lehetőség van az alkalmazásban definiált Activity komponenseket más alkalmazások számára elérhetővé tenni, így az egyes komponensek új komponenseket indíthatnak el.
Egy mobilos alkalmazás eltér az asztali alkamazásoktól olyan tekintetben, hogy a felhasználói interakciók nem mindig ugyanazon a helyen kezdődnek.
Például ha az alkalmazásindítóból nyitjuk meg az email appot, akkor egy email listát látunk.
Azonban ha egy közösségi média alkalmazás nyitja meg az email appot, lehet, hogy egyből az email írása képernyő nyílik meg.
Az Activity osztály úgy lett tervezve, hogy megkönnyítse ennek a paradigmának a használatát.

**Service**
A [service](https://developer.android.com/guide/components/services) (szolgáltatás) komponenst háttérben futtatható műveletek elvégzésére használjuk.
A szolgáltatások nem rendelkeznek felhasználói felülettel, és futásuk nem áll le, ha az alkalmazásunk háttérbe kerül.
Hosszan futó műveleteket hajthat végre a háttérben.
Leggyakoribb felhasználásai között van a hálózati kérések lebonyolítása, zenelejátszás, adatszinkronizáció és fájlműveletek elvégzése.
Fontos viszont, hogy a szolgáltatás által futtatott kód a fő (UI) szálon kerül végrehajtásra, így az idő és erőforrás igényes feladatok végrehajtását külön szálon kell megvalósítani.
A szolgáltatások 3 különböző típusát használhatjuk:
* Foreground service, amely a felhasználó számára észrevehető műveletet hajt végre, például zenelejátszás.
Ezen szolgáltatásoknál kötelező egy értesítés megjelenítése, amely mindaddig látszik, amíg a szolgáltatás fut.
* Background service, amely olyan háttérben futó feladatot lát el, amit a felhasználó közvetlenül nem láthat. Pl.: adatszinkronizáció.
Az újabb és újabb Android verziók mind egyre komolyabb megszorításokat vezetnek be, hogy mikor engedik futtatni ezeket a szolgáltatásokat.
* Bound service, amely egy olyan szolgáltatás, amihez egy másik komponens kapcsolódik.
A kapcsolódó komponens lehet másik alkalmazásból is, és a kapcsolódás kommunikációs lehetőséget biztosít a szolgáltatás és a komponens között.
Több komponens is kapcsolódhat egy szolgáltatáshoz, viszont a szolgáltatás leáll, ha már egy komponens sem csatlakozik hozzá.

**ContentProvider**
A [ContentProvider](https://developer.android.com/guide/topics/providers/content-providers) egy tartalomszolgáltató komponens, amely lehetővé teszi az alkalmazások közötti adatmegosztást.
Az tartalomigénylőnek nem kell tudnia milyen adatforrás tartalmazza az adatokat, csak a tartalomszolgáltatót kell ismernie.
Az Android rendszer több tartalomszolgáltatóval is rendelkezik, és ezeken keresztül biztosítja az alkalmazások számára például a névjegyzék, a naptár, vagy a híváslista elérését.

**BroadcastReceiver**
A [BroadcastReceiver](https://developer.android.com/guide/components/broadcasts) egy olyan komponens, amely bizonyos üzenetek hatására aktiválódik.
Működését úgy kell elképzelni, hogy a BroadcastReceiver meghatározza, milyen üzenetek szeretne fogadni, majd egy ilyen üzenet létrejöttekor az Android rendszer megkeresi az összes telepített komponens közül azokat, amelyek fogadhatják az üzenetet.
Például amikor az eszköz bekapcsolt, kapcsolódott a Wifire, vagy megkezdődött az akkumulátor töltése.
Az üzenetek létrejöhetnek valamilyen rendszeresemény hatására, de az alkalmazások is hozhatnak létre saját üzeneteket.
Az üzenet hatására a végrehajtandó műveletet az adott BroadcastReceiver osztály határozza meg.

## 3. Erőforrás-állományok. Manifest állomány.
## 4. Minősítők, mértékegységek.
## 5. Activity életciklusmodellje.
## 6. Felület létrehozása. Vezérlőelemek. View. Felugró értesítések.
## 7. Felület létrehozása. Layout management megoldások. ViewGroup.
## 8. Intent felépítése és működése. Implicit és explicit Intent. Activity indítás formái.
## 9. Fragmentek és navigáció megvalósítása.
## 10. Listák létrehozása. Adapter.

### Felhasznált (ajánlott) irodalom:

[Hivatalos Android fejlesztői oldal - angol](https://developer.android.com/index.html)
Eszéki Dániel - Bolla Kálmán Milán [Android szoftverfejlesztés](https://oszkdk.oszk.hu/storage/00/03/17/37/dd/1/03_Esz__ki_D__niel_Bolla_K__lm__n_Mil__n_Android_szoftverfejleszt__s.pdf)

[Kezdőlap](../README.md)
