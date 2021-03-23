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

**Erőforrások**
Az Android platformra való fejlesztésnél alapvető szempont, hogy egy alkalmazás módosítás nélkül képes legyen futni különböző méretű, hardverű és Android verziójú eszközökön.
Ez megoldható lehetne például fordítási variánsok használatával, azonban ekkor minden konfigurációra külön telepítőre lenne szükség, ami egy valós projekt esetében fenntarthatatlan.
A probléma megoldására egy olyan rendszert hoztak létre, amelyben az alkalmazás a futtató hardver és rendszer tulajdonságaitól függően tud különböző elemeket betölteni.
Az alkalmazás ezen „változó” részeit ún. erőforrás-állományoknak hívjuk.
Az erőforrások között találhatóak meg a felhasználói felületek, szövegek, képek és animációk is.
Lehetőség van statikus tartalmak hozzáadására is, viszont a legtöbb erőforrást XML fájlokban definiálhatjuk.
Az erőforrás fájlok a *res* könyvtárban találhatóak, azon belül pedig tartalmuk alapján további mappákra vannak csoportosítva. 
A legfontosabb könyvtárak:

* `anim/` - animációk
* `color/` - színek
* `drawable/` - képek és vektorgrafikus tartalmak
* `mipmap/` - alkalmazás ikon
* `layout/` - felhasználó felületek
* `menu/` - menük
* `raw/` - statikus fájlok
* `values/` - egyszerű értékek:
  | Könyvtár   | Erőforrás típusa  | Példa                                          |
  |------------|-------------------|------------------------------------------------|
  | arrays.xml | erőforrás tömbök  |                                                |
  | styles.xml | stílusok és témák |                                                |
  | colors.xml | szín értékek      | `<color name="white">#FFFFFF</color>`          |
  | dimens.xml | dimenzió értékek  | `<dimen name="padding_size_small">8dp</dimen>` |
  | string.xml | szöveges értékek  | `<string name="ok_button">OK</string>`         |

Ezekben a mappákban található fájlok lesznek az ún. alapértelmezett erőforrások.
Ezek az erőforrások nem rendelkeznek [minősítővel](##-4.-Minősítők,-mértékegységek.), így ha a rendszer nem talál az eszköz és rendszer tulajdonságaihoz megfelelő erőforrást, akkor az alapértelmezettet használja fel.

A rendszer fordítás során minden erőforráshoz egy egyedi azonosítót rendel, majd ezeket az erőforrások típusai szerint különböző osztályokba sorolja.
Minden erőforráshoz generálódik egy static int típusú változó, mely az erőforrás azonosítóját tartalmazza.
Az azonosítókat az *R* osztály tartalmazza, majd ezen belül további osztályok találhatóak az erőforrás típusoknak megfelelően.
A megfelelő erőforrás kiválasztását a rendszer teljesen automatikusan végzi, így a rájuk való hivatkozáskor csak az erőforrás azonosítóját kell megadni.
Az erőforrásokra a következőképpen hivatkozhatunk a kódban vagy az XML fájlokban:

| Kód                 | XML                                |
|---------------------|------------------------------------|
| `R.string.app_name` | `android:label="@string/app_name"` |

Statikus (nem módosítható) fájlok elérésére két lehetőséget biztosít a rendszer.
Ha az adott fájlok tartalmát csak szimplán be szeretnénk tölteni (például hang, videó fájlok) akkor a *raw* könyvtár használata javasolt.
Ha viszont ennél komplexebb megoldásra van szükségünk, akkor érdemes az *assets* könyvtárat használni.
Ebben tetszőlegesen hozhatunk létre könyvtárakat és fájlokat, és a tartalmát az *AssetManager* osztály segítségével tudjuk olvasni.

A lokalizáció megvalósításához fel tudjuk használni az [erőforrás](##-4.-Minősítők,-mértékegységek.) minősítőket.
Ennek megvalósításához viszont feltétlen szükséges, hogy az alkalmazásban a felhasználó számára megjelenő összes szöveg string erőforrásként legyen rögzítve.
Így ha az alkalmazásban található a rendszer nyelvi beállításainak megfelelő minősítővel ellátott erőforrás, akkor azok kerülnek megjelenítésre.
Előfordulhatnak olyan szövegek, amelyeket nem szeretnénk vagy nem szükséges fordítani, ezeket a `<string>` tag-en használható `translatable="false"` tulajdonsággal adhatjuk meg.

| /values/strings.xml                                         | /values-hu/strings.xml                    | /values-de/strings.xml                  |
|-------------------------------------------------------------|-------------------------------------------|-----------------------------------------|
| `<string name="yes_button">Yes</string>`                    | `<string name="yes_button">Igen</string>` | `<string name="yes_button">Ja</string>` |
| `<string name="ok_button" translatable="false">Ok</string>` |                                           |                                         |

**Manifest állomány**
Minden Android alkalmazás vagy könyvtár modulnak elengedhetetlen eleme az *AndroidManifest.xml* állomány, amely információt szolgáltat az alkalmazásról és a benne lévő komponensekről a fordító eszközök, az operációs rendszer és az alkalmazás-áruházak számára.
A végleges állomány a fordítás során készül el, ahol a függőségekben lévő AndroidManifest fájlok tartalma is összefésülésre kerül az alkalmazáshoz tartozó adatokkal.
Végeredményképp egy olyan fájlt kapunk, amely tartalmazza az alkalmazás és az összes függőség komponensét, jogosultságát, és tulajdonságát.
Harmadik féltől származó komponensek használatakor érdemes megnézni, hogy pontosan miket tartalmaz a Manifest állomány.
Előfordulhat, hogy például olyan jogosultságokat kér, amelyek miatt a felhasználók nem telepítik az alkalmazást.
A Manifest fájl gyökér eleme a `<manifest>` tag, melynek tartalmaznia kell az alkalmazás csomagnevét, valamint a verziókódot és verziónevet.
A csomagnév általában megegyezik a projektben használt Java névtérrel, és a package tulajdonsággal állíthatjuk be.
A verziókódot és a verziószámot nem kell külön feltüntetni, a végleges Manifest fájlban a Gradle állítja be a megfelelő értékeket.
Az alkalmazáshoz tartozó tulajdonságok beállítására az `<application>` tagot kell használni, ezen megadhatjuk az alkalmazás nevét (`android:label`), ikonját (`android:icon`) vagy akár a használt témát (`android:theme`).

```
<manifest xmlns:android="http://schemas.android.com/apk/res/android" package="com.example.app">
  <application
    android:icon="@mipmap/ic_launcher"
    android:label="@string/app_name"
    android:roundIcon="@mipmap/ic_launcher_round"
    android:theme="@style/AppTheme">
  </application>
</manifest>
```

Az `<application>` tagon belül kell felsorolni az egyes alkalmazás komponenseket, mégpedig a következő elemekkel:
| Komponens         | XML tag      |
|-------------------|--------------|
| Activity          | `<activity>` |
| Service           | `<service>`  |
| BroadcastReceiver | `<receiver>` |
| ContentProvider   | `<provider>` |

Az operációs rendszer egyes funkcióihoz és bizonyos hardveres eszközök használatához az alkalmazásunknak engedélyekre van szüksége.
Ezek az engedélyek telepítés előtt a felhasználó számára fel vannak tüntetve, valamint az Android 6.0 verziótól kezdve bizonyos jogosultságokat már az alkalmazás futása közben külön jóvá kell hagynia a felhasználónak.
Az Android rendszerben meghatározott jogosultságokon kívül készíthetünk saját jogosultságokat, valamint használhatunk más alkalmazások által létrehozottakat.
Egy jogosultság használatához a `<uses-permission>`, létrehozáshoz pedig a `<permission>` tagot használhatjuk.

```
<manifest>
   <uses-permission android:name="android.permission.CAMERA" />
   <uses-permission android:name="android.permission.INTERNET" />
</manifest>
```

A példában megadott szabályok alapján az alkalmazás nem lesz telepíthető olyan eszközökre, amelyek nem rendelkeznek Bluetooth hardverrel. Az alkalmazás viszont rendelkezik olyan funkciókkal, amelyek a kamerát is használatba vennék, viszont megléte nem feltétlen szükséges az alkalmazás használatához.

## 4. Minősítők, mértékegységek.
## 5. Activity életciklusmodellje.
## 6. Felület létrehozása. Vezérlőelemek. View. Felugró értesítések.
## 7. Felület létrehozása. Layout management megoldások. ViewGroup.
## 8. Intent felépítése és működése. Implicit és explicit Intent. Activity indítás formái.
## 9. Fragmentek és navigáció megvalósítása.
## 10. Listák létrehozása. Adapter.

### Felhasznált (ajánlott) irodalom:

* [Hivatalos Android fejlesztői oldal - angol](https://developer.android.com/index.html)
* Eszéki Dániel - Bolla Kálmán Milán [Android szoftverfejlesztés](https://oszkdk.oszk.hu/storage/00/03/17/37/dd/1/03_Esz__ki_D__niel_Bolla_K__lm__n_Mil__n_Android_szoftverfejleszt__s.pdf)

[Kezdőlap](../README.md)
