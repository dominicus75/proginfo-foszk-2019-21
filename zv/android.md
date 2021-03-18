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
## 3. Erőforrás-állományok. Manifest állomány.
## 4. Minősítők, mértékegységek.
## 5. Activity életciklusmodellje.
## 6. Felület létrehozása. Vezérlőelemek. View. Felugró értesítések.
## 7. Felület létrehozása. Layout management megoldások. ViewGroup.
## 8. Intent felépítése és működése. Implicit és explicit Intent. Activity indítás formái.
## 9. Fragmentek és navigáció megvalósítása.
## 10. Listák létrehozása. Adapter.

### Felhasznált (ajánlott) irodalom:

[Kezdőlap](../README.md)
