[Kezdőlap](../README.md)

# Web-fejlesztés

## 1. HTML nyelv alapjai

A HTML (Hypertext MarkUp Language) egy szöveges jelölőnyelv, más néven leírónyelv,
amelyet weboldalak készítéséhez fejlesztettek ki, mára egyes változatai internetes
szabvánnyá váltak a W3C (World Wide Web Consorcium) jóvoltából. A HTML leírónyelv
egy általános leírónyelvből, az [SGML (Standard Generalized MarkUp Language)](https://hu.wikipedia.org/wiki/Standard_Generalized_Markup_Language)
dokumentumszabványból jött létre. Az SGML 1986-ban lett ISO szabvány, dokumentumok
általános leírására szolgált, ennek elődje volt a GML (Generalized MarkUp Language),
amelyet az 1960-as években fejlesztettek ki az IBM-nél.

A HTML nem programozási nyelv, azaz nem valósíthatunk meg vele *szelekciót* (feltételektől
függő elágazást), sem *iterációt* (ismétlődést, ciklusokat). A három vezérlési szerkezet
közül csakis a *szekvencia* (parancsok egymásutáni végrehajtása) valósítható meg vele.

### 1.1 A HTML fontosabb verziói

**HTML 1.0 (1990)**: a dokumentum tartalmára vonatkozó címkék a fejléchez és a
törzsrészhez. Ekkor jelentek meg a headingek, a hiperhivatkozások, a bekezdések
és a listák jelölői. Képek megjelenítésére még nem volt mód, de a dokumentum
típusdeklarációját (**DTD**) már ekkor is meg lehetett adni a dokumentum
legelején, a ```<head>``` jelölő előtt.

**HTML 2.0 (1995)**: képek, szövegformászás (félkövér és dölt). Az űrlapok bevezetésével
a HTML dokumentum interaktívvá vált (adatküldési lehetőség a szerver felé).

**HTML 3.0 (1996)**: java appletek és scriptek beillesztése, melyekkel le lehetett
kérdezni, hogy milyen böngészőt és mekkora felbontást használ a felhasználó.
Megjelent a ```<style>``` jelölő és megadhatóvá vált a karakterek betűtípusa;
továbbá megjelent a táblázat készítés eleme is.

**HTML 4.0 (1997)**: a W3C **1998 áprilisában hivatalos szabványnak mondta ki**.
A HTML nyelv szabályai sokáig nem voltak teljesen egyértelműek, számos verziószámot élt
meg a leírónyelv, amely fokozatos szigorításokon ment keresztül, mégis a HTML csak a 4.0-
ás verziótól kezdődően tesz eleget az ISO 8879 előírásnak és az SGML szabványnak egyaránt.
Megjelent a nemzetközi karakterkészletek és a balról jobbra olvasás támogatása is.
Hivatalossá tették a keretek (frame-k) használatát, továbbfejlesztették a táblázatok
és űrlapok használatát is. A HTML változatai közül az 1999 decemberében kijött
**HTML 4.01** volt az utolsó SGML-en alapuló verzió.

A HTML 4.01 után egy ideig az XML alapú XHTML szabvány volt használatban, de annak
2.0-ás verzójának fejlesztését felfüggesztették, pedig nagyon sok remény fűződött
hozzá a szigorítások révén. AZ **XHTML 1.0** 2000 januárjában, az **XHTML 1.1**
pedig 2001 májusában vált hivatalos W3C ajánlássá.<sup id="1">[[1]](#note1)</sup>

**HTML 5.0 (2014)**: kompatibilis a korábbi HTML és XHTML verziókkal, támogatják
a mobileszközök is. A HTML korábbi verzióihoz képest a HTML5 egy erősen átdolgozott
változat, kifejlesztésének célja az volt, hogy a weboldalak működéséhez ne legyen
szükség pluginek telepítésére (pl. Adobe Flash). 2004-ben alakult meg a **WHATWG
(Web Hypertext Application Technology Working Group)** − függetlenül a W3C-től −, akik
nem az XHTML-t, hanem a HTML-t kezdték továbbfejleszteni. 2007-ben a W3C hivatalosan
bejelentette, hogy a következő HTML-szabvány a HTML5 lesz és nem dolgozott tovább
az XHTML2-n.

### 1.2 Nyelvtani szabályok, fontosabb elemcsoportok és elemek

A HTML dokumentumok alapvetően formázatlan szövegeket tartalmaznak, szerepelnek bennük:
* a weboldalon megjelenő szövegrészek,
* objektumhivatkozások (más állományokra való hivatkozások, elérési utak),
* szöveges utasítások.

A szöveges utasításokat a HTML-ben kisebb és nagyobb jelek (kacsacsőr) közé tesszük
és tageknek, magyarul jelölőknek vagy HTML elemeknek nevezzünk (pl: ```<img>```,
```<table>```). Szokás címkéknek is nevezni őket, mert a jelentéstartalmukon
túl egyben címkét is jelentenek, amellyel a HTML egyes részeit jelöljük meg. A címkék
elvileg kis-, és nagybetű érzéketlenek, viszont célszerű őket csupa kisbetűvel írni (XHTML
hagyomány).

Léteznek páros (nyitó és záró elemmel is rendelkező) és páratlan címkék. Egy tartalom
elejét és végét jelölheti a páros tag, például egy címet, vagy bekezdést a szövegben, esetleg
egy táblázatot. A címkék egymásba is ágyazhatók (a matemaikában szokásos zárójelezési
szabályok szerint).

Léteznek blokkszintű és soron belüli elemek is. A blokkszintű elemek (mint a div vagy a p)
után a böngésző egy térközt hagy, a sorszintű elemek (span, strong, b) után nem.

A HTML állományok három fő részre bonthatóak:
1. a kód a dokumentum típusát megadó (doctype) elemmel kezdődik, ezt a ```<html>```
gyökérelem követi, amely az alábbi két főrészt foglalja magában:
2. a HTML fejléce, amelyet ```<head>``` és ```</head>``` elemek
közé írunk, ide kerülnak a technikai és dokumentációs (meta) adatok
3. a HTML törzsrésze ```<body>``` és ```</body>``` elemek között megadva, amely a
böngészőben megjelenítendő információkat és azok szerkezetét tartalmazza


### 1.3 Tulajdonságok

Az egyes elemekhez meg lehet adni tulajdonságokat/jellemzőket, ezeket attribútumoknak
nevezzük. Legtöbb attribútumnak a megadása opcionális, azaz nem kötelező. A tulajdonságok
név-érték párokkal (attributum="érték") adhatók meg, egymástól szóközzel elválasztva
akár több is.

Léteznek globális (minden tagnél használható) és elemspecifikus (csak bizonyos elemeknél
alkalmazható) tualajdonságok is. A globális attribútumok a következők:

* **accesskey**: gyorsbillentyű megadására szolgál. Bármilyen (1 karakter hosszú) karaktert megadhatunk. A kis- és nagybetűk különböznek.
* **class**: az elemhez CSS-osztályt társíthatunk.
* **contenteditable**: true (igaz) és false (hamis) értéket vehet fel. Ezzel jelezhetjük, hogy az adott elem szerkeszthető-e.
* **contextmenu**: helyi menü létrehozására szolgál. Értéke egy menü elem egyedi azonosítója kell, hogy legyen.
* **dir**: arra szolgál, hogy megadhassuk, az adott nyelvet balról jobbra (ltr), vagy jobbról balra kell-e olvasni (rtl). "auto" érték esetén automatikusan kerül meghatározásra.
* **draggable**: true (igaz), false (hamis) és auto (automatikus) értéket vehet fel. Ezzel jelezhetjük, hogy az adott elem vonszolható-e. Az "auto" megadás esetén a böngésző alapértelmezett beállítása szerint történik a működés.
* **dropzone**: az adott elemet olyan területté alakíthatjuk, amely képes vonszolt elemeket kezelni. Ha "copy" az értéke (vagyis másolás), akkor a vonszolt elem másolásra kerül. Ez egyébként az alap beállítás is. Ha "move" az értéke, akkor a vonszolt elem az új helyre lesz áthelyezve. A "link" érték esetén a vonszolt elemre történő hivatkozás lesz feldolgozva. Ezen kívül stringet (karakterláncot) is megadhatunk, ami a string: vagy file: karakterlánccal kezdődhet. Ezzel befolyásolhatjuk, hogy a területre milyen elemeket lehet ráhúzni. Pl. dropzone="copy file:image/png file:image/jpeg"
* **hidden**: logikai attribútum. Ha szerepel, akkor az adott elem rejtetté válik.
* **id**: az elemet egyedi azonosítóval láthatjuk el.
* **inert**: logikai attribútum. Ezzel jelezhetjük, hogy az adott terület érzéketlen, ami azt jelenti, hogy a böngésző ugyan megjeleníti, de a tartalmára nem lehet rákeresni a lapon belül, nem lehet kijelölni a tartalmát, nem működnek rajta az interakciót támogató események sem (pl. mouseover – amikor az egeret a terület fölé visszük.)
* **lang**: segítségével megadhatjuk az adott elem nyelvét. (pl. hu, en, en-us, stb.)
* **spellcheck**: azt adhatjuk meg, hogy az elem tartalmát ellenőrizze-e helyesírási szempontból a böngésző, vagy sem. True (igaz) esetén megtörténik az ellenőrzés, false (hamis) esetén nem.
* **style**: az elemhez beágyazott stílust rendelhetünk.
* **tabindex**: megadhatjuk, hogy a tab billentyű hatására milyen sorrendben kapjanak fókuszt az elemek. Nullát és pozitív egész számokat adhatunk meg:0,1,2,3.
* **title**: az elemhez tartozó feliratot adhatjuk meg, amely legtöbbször akkor jelenik meg, ha az elem fölé visszük az egeret, de speciális jelentése is lehet.
* **translate**: logikai attribútum, yes (igen) illetve no (nem) értékkel. Azt jelezhetjük vele, hogy az elemet szükséges-e lefordítani, ha más nyelvre fordítjuk az oldalt, vagy sem.

A globális attribútumok közé tartozik még az itemid, itemprop, itemref, itemscope,
itemtype is, amelyek lehetővé teszik, hogy az úgynevezett [microdata](https://schema.org/docs/schemas.html) formátum segítségével
további információkat rendeljünk az elemeinkhez, amelyeket például a keresőprogramok
fel tudnak használni.

## 2. A HTML5 újdonságai

A HTML5 sok nyelvi elemet és struktúrát leegyszerűsít, ami a számos új funkció
ellenére könnyebben írható - és még egyszerűbben olvasható - kódot eredményez. A
HTML5-tagek és attribútumaik kevésbé terjengősek, és a szintaktika is egyértelműbb.

### 2.1 Új szemantikus elemek

Bármilyen nyelv szerkezetileg három részből áll: ábécé, szintaktika, szemantika.
Az ábécé a nyelv jelkészlete. A HTML esetén ez azok a karakterek, amelyekkel elkészíthetünk
egy weboldalt. A szintaktika a helyesírási szabályok. A HTML esetén a weblap leírásának
szabályai. A szemantika a nyelv jelentéstana. A formális nyelvek elméletében a szemantika
az adott formális nyelv szintaxisa által meghatározott szavak jelentését definiáló
szabályok összessége. Így a szemantikus HTML nem más, mint a HTML tagok jelentésének
betartása, rendeltetésszerű használata. Például, egy bekezdést nem használunk fel
menü kialakításához.

A HTML 5 szabványban új, szemantikus jelentéssel bíró strukturális elemeket vezettek be:

* ```<header>...</header>```: az oldal vagy egy tartalmi egység fejléce. Nemcsak az
oldal egészére, de akár egy különálló részre (article, section) vonatkozóan is. Ebből kifolyólag akár
többször is használható egy oldalon belül.
* ```<footer>...</footer>```: az oldal vagy egy tartalmi egység lábléce. Nemcsak az
oldal egészére, de akár egy különálló részre (article, section) vonatkozóan is. Ebből kifolyólag akár
többször is használható egy oldalon belül.
* ```<nav>...</nav>```: navigációs menü, tipikus tartalma linkek listája
* ```<aside>...</aside>```: érintőlegesen kapcsolódó tartalom. Általában oldalsáv
formájában jelenik meg, ami olyan elemeket tartalmaz, mint kapcsolódó kommentek/linkek
vagy címkefelhők. Jól használható idézetek megjelenítésére, vagy szószedet készítésére.
* ```<main>...</main>```: az oldal fő tartalmi egységének megjelölésére szolgál.
Csak egy ilyen elemet helyezhetünk el a dokumentumban, és ez az elem nem lehet gyerekeleme
más oldalszerkezet elemeknek
* ```<section>...</section>```: logikai egység, az azonos témakörbe tartozó elemeket foglalja egy csoportba
* ```<article>...</article>```: önálló tartalom, ez lehet egy fórumbejegyzés, újságcikk,
blogbejegyzés, vagy bármilyen más független tartalom
* ```<address>...</address>```: kontakt információ megadására használható, amely a
legközelebbi ```<article>```, vagy ```<body>``` elemre vonatkozik. Általában a
```<footer>``` elemben kerül elhelyezésre.

A HTML 5 előtt is használt szemantikus jelentéssel bíró elemek:

* ```<head>...</head>```: a dokumentumfej (fejléc) a weboldalra vonatkozó információk megadását teszi lehetővé.
Ezek nem lesznek megjelenítve, de befolyásolják a tartalom megjelenítését. Lehetőség van
itt külső erőforrások illesztésére (pl. CSS, Java, JavaScript, ikon), a böngésző vagy
a keresők számára szükséges információk (meta adatok) megadására  
* ```<body>...</body>```: a html dokumentum törzse, az oldalon megjelenő tartalmakat
(szöveg, kép, táblázat stb.) leíró jelölőket tartalmazza
* ```<h1>...</h1>```, ```<h2>...</h2>```, ...```<h6>...</h6>```: a címsorok (heading)
a szövegszerkesztő alkalmazásokban az oldalak logikai felosztását, a fejezetek meghatározását
teszik lehetővé.

A fenti tagek kivétel nélkül blokkszintű (block) elemek, a ```<div>```-hez hasonlóan.

Ezek a tagek - az általános célú ```<div>``` és ```<span>``` tagekkel ellentétben - szemantikai
jelentéssel bírnak, tehát egyértelműen meghatározzák a tartalmuk jelentését (pl.
egy ```<header>```-ről tudjuk, hogy egy fejlécet jelöl). Szokás őket oldalszerkezet elemeknek is
nevezni, amelyekkel precízen megadható az oldalrészek szemantikus jelentése.

### 2.2 Forms 2.0

A HTML űrlapok (from) a nyelv második főverziójában jelentek meg, 1995-ben. A
[Web forms 2.0](https://www.w3.org/Submission/web-forms2/) szabványt 2005-ben adta ki a
W3C, mint a HTML 4.01 verzó [űrlapokról szóló fejezetének](https://www.w3.org/TR/html4/interact/forms.html)
kiterjesztését, ami a HTML 5 megjelenésével már a [HTML szabvány szerves részévé](https://html.spec.whatwg.org/multipage/forms.html#forms)
vált. 

Az űrlapok összes eleme a ```<form>``` és ```</form>``` tageken belül helyezkedik el,
ahol az egyes űrlapelemeket más-más tagekkel definiálhatjuk. Az űrlap (alapesetben)
akkor kerül elküldésre, ha egy megfelelő (úgynevezett submit) gombot is elhelyezünk
az űrlapban, és azt a felhasználó a kitöltés végén meg is nyomja (esetleg más módon
aktiválódik a gomb).

A ```<form>``` elem attribútumai (az itt is alkalmazható globális attribútumokon felül):

* **action**: ez határozza meg a szerveroldali feldolgozást végző programot (php vagy asp),
de e-mail cím (pl. ```mailto:akarmi@example.com```) is megadható itt, ekkor a bekért
adatokat egyszerűen elküldi a megadott címre. A mailto: protokollt használva az üzenet
a számítógép alapértelmezett levelezőprogramjával kerül továbbításra.
* **method**: ezzel adható meg, hogy a kliens milyen (HTTP) metódussal küldje át
az adatokat a szervernek:

	* *get*: ekkor az űrlap adatai (űrlapelemek neve és értékei) az action paraméterben
	megadott URI után kerülnek paraméterként, a ? jellel elválasztva. Ez az alapértelmezett beállítás.
	* *post*: ekkor a HTTP kérés törzsében továbbítódnak az adatok. Ha e-mailben akarunk
	küldeni adatokat, akkor ezt a beállítást kell használnunk

* **enctype**: az elküldött adatok kódolási típusát állíthatjuk be:

	* *application/x-www-form-urlencoded*: az űrlap egyes mezőinek nevei és az értékei közé = jelet rak,
	a szóközöket lecseréli + jelekre, a speciális karaktereket %xx alakú jelekké konvertálja,
	ahol az xx az adott karakter hexadecimális ASCII-kódja. 
	* *multipart/form-data*: fájlok küldését is lehetővé teszi post metódussal.
	* *text/plain*: egyszerű szöveges kódolás. Ha az adott űrlap tartalmát e-mailen keresztül
	küldjük el, célszerű a text/plain kódolást beállítani, így olvasható marad a szöveg.

* **name**: az űrlapnak egyedi nevet adhatunk a segítségével, amely alapján a
feldolgozóprogram azonosítja a bevitt adatot.

Az űrlap vezérlőelemei (control) információbeviteli (input) mezők vagy választást
lehetővé tevő alakzatok (select, radio, checkbox, datalist). Az űrlapokhoz háromféle
beviteli mező tartozhat:

* a ```<textarea></textarea>``` több soros, páros címke,
* az ```<input>``` páratlan (zárótaggel nem rendelkező) elem, a type (típus) attribútum
értéke határozza meg az űrlapelem típusát (pl. beviteli mező, jelölőnégyzet, választókapcsoló,
dátum, fájlfeltöltő stb.),
* a ```<select></select>``` lenyíló lista nyitó és záró címkéje között elhelyezett ```<option>```
címkékben megadott értékek közül lehet kiválasztani alapesetben egyet, de a multiple
jellemző megadása esetén akár többet is.

A (később a HTML 5 szabványba integrált) Web forms 2.0 előtt az input elem type
attribútuma a következő értékeket vehette fel:

* **submit**: az űrlap elküldésére szolgáló gomb, a rajta szereplő szöveget a value
tulajdonság segítségével lehet beállítani.
* **reset**: az űrlap kiinduló helyzetbe állítására szolgál, megnyomásakor az összes
űrlapelem felveszi az alapértelmezett értékét (ha van neki). A rajta szereplő szöveget
a value tulajdonság segítségével lehet beállítani.
* **button**: nyomógomb
* **hidden**: rejtett űrlapmező, amelynek egy karakterláncot adhatunk értékül (pl. [CSRF támadások](https://hu.wikipedia.org/wiki/Cross-site_request_forgery)
kivédéséhez ebbe a mezőbe szoktak egy egyedi tokent rakni, amit a felhasználó nem lát,
a szerver felé viszont jelzi, hogy onnan jött az űrlap, ahová az ki lett küldve) 
* **text**, **search** és **password**: egyszerű szöveg bevitelére szolgáló mező,
ahol nincsenek sortörések (a password esetében a bevitt szöveg nem látszik)
* **checkbox**: jelölőnégyzet (azonos jelölőnégyzet-csoportból nulla, egy vagy több elem jelölhető ki)
* **radio**: választókapcsoló (több lehetőség közül csak egy választható)
* **file**: nulla, vagy több fájl feltöltésére mime típussal és opcionálisan a fájl
nevének megadásával
* **image**: kép típusú gomb, az img elemhez hasonló módon meg kell adni a helyettesítő
szöveget (alt), valamint megadható a kép mérete is (width és height). A mező különlegessége
az, hogy azt is elküldi, hogy a kattintás a kép melyik koordinátájú pontján történt.
Ezt a koordinátát név.x, illetve név.y formában kapjuk meg. Ezzel lehetőségünk van
olyan tesztek készítésére is, ahol az a cél, hogy a kép megfelelő részére kattintson
rá a látogató.

Az input elem a type és a globális attribútumok mellett a következő tulajdonságokkal
rendelkezhetett:

* **value**: lehetőséget ad kezdőérték beállítására, az űrlap elküldésekor, tartalma
az elem nevével együtt érkezik az adatok feldolgozását végző scripthez
* **size**: a beviteli mező szélessége, karakterben megadva (int)
* **maxlength**: az űrlapelebe írható szöveg maximális hossza (int)

Ezek a Web forms 2.0/HTML 5 megjelenése óta a következő tulajdonságokkal gazdagodtak:

* **minlength**: az űrlapelebe írható szöveg minimális hossza (int)
* **readonly**: logikai tulajdonság, ha be van állítva, az elem csak olvasható lesz
(nincs külön értéke, ha szerepel az attribútum neve, az képviseli az igaz értéket,
ha nem, az az alapértelmezett hamis)
* **required**: logikai attribútum, amely kötelezővé teszi az űrlapelem kitöltését
(nincs külön értéke, ha szerepel az attribútum neve, az képviseli az igaz értéket,
ha nem, az az alapértelmezett hamis)
* **multiple**: logikai attribútum, amely ha szerepel akkor az adott mezőben több
érték is megadható (nincs külön értéke, ha szerepel az attribútum neve, az képviseli
az igaz értéket, ha nem, az az alapértelmezett hamis)
* **pattern**: [reguláris kifejezés](https://hu.wikipedia.org/wiki/Regul%C3%A1ris_kifejez%C3%A9s),
amellyel megadhatjuk, hogy milyen formátumú adatot várunk az adott mezőben (a következő
típusú input attribútumokkal használható: text, password, url, tel, email, és search)
* **min** és **max**: numerikus beviteli mezők esetén a minimum és maximum értékek
megadására szolgálnak (a következő input típusokkal használható: number, range, date
datetime, datetime-local, month, time, week)
* **list**: egy olyan listaelem azonosítója, amit a felhasználónak fel kívánunk kínálni
választási lehetőségként. Ezen listát ```<datalist>``` és ```</datalist>``` elemek között
kell elhelyezni, úgy hogy az egyes választási lehetőségek ```<option>``` és ```</option>```
tag-ek között helyezkedjenek el. A ```<datalist>``` elemnek adott egyedi azonosító (id)
lesz a list paraméter értéke.
* **placeholder**: helyőrző szöveg, ami eltűnik, ha a felhasználó gépelni kezd a mezőbe

A Web forms 2.0 a fentebb felsorolt type értékeket az alábbi új típusokkal
(a HTML 5. szabvány összesen *[21 lehetséges értéket sorol fel](https://html.spec.whatwg.org/multipage/input.html#states-of-the-type-attribute)
a type attribútumhoz)* egészítette ki:

* **tel**: telefonszám bekérésére használatos űrlapmező. Az url és email típusú
mezőkkel ellentétben itt nincs alapértelmezett szintaxis elemzés, mivel számos telefonszám
formátum létezik. Ezért érdemes a pattern paraméterrel megadni azt a reguláris kifejezést,
ami az adott bevitelnél releváns
* **url**: abszolút webcím (url) bekérésére szolgáló űrlapmező
* **email**: email cím, vagy címek bekérésére szolgál. Amennyiben a multiple paramétert
szerepeltetjük, akkor több e-mail cím is megadható vesszővel elválasztva.
* **date**: időpont (dátum) megadására szolgáló elem
* **month**: időpont (hónap) megadására szolgáló elem
* **week**: időpont (hét) megadására szolgáló elem
* **time**: időpont (idő) megadására szolgáló elem
* **datetime-local**: időpont (lokalizált dátum) megadására szolgáló elem
* **number**: olyan beviteli mezők esetén használjuk, ahol számot kell megadnia a felhasználónak
* **range**: olyan beviteli mezők esetén használjuk, ahol számot kell megadnia a felhasználónak,
amelynek egy megadott intervallumba kell esnie (csúszkaként jelenik meg a böngészőben)
* **color**: szín megadására szolgál, a mező értéke a kiválasztott szín hexa kódját adja vissza

Megjegyzendő, hogy a bekért adatok kliensoldali ellenőrzése (html vagy javascript)
csak a jóhiszemű felhasználók esetleges elgépelései ellen nyújt védelmet (nem engedi
elküldeni a nem megfelelő típusú, vagy a reguláris kifejezésre nem illeszkedő bemenetet),
rosszindulatú támadás ellen nem (a javascript kikapcsolható a böngészőben, a letöltött
html űrlap kódját pedig át lehet írni, kivéve belőle az ellenőzést), így nem
helyettesítheti a bejövő adatok szerveroldali vizsgálatát.

**További űrlapelemek**

#### label

Az űrlapelemhez tartozó szöveg (címke) megadására szolgál. A globális attribútumok melett
a következő tulajdonságai lehetnek:
* **for**: azon űrlapmező azonosítóját (id) írjuk ide, amelyhez a címke tartozik.
Fontos, hogy **nem az űrlapmező name paraméterét kell megadni**, hanem id paramétert
is kell adni a mezőnek, de az értékük akár lehet ugyanaz. Ha az oldalon az űrlapmező
előtti címkére kattintunk, akkor a hozzá tartozó űrlapmező automatikusan fókuszba kerül,
vagyis a kurzor megjelenik benne.
* **form**: ezzel explicít módon rendelhetjük hozzá egy adott formhoz az elemet

#### fieldset és legend

Az űrlapok esetén érdemes lehet az egyes elemeket valamiképpen strukturálni, az
azonos témához tartozó mezőket összefogni. A csoportosítani kívánt mezőket a ```<fieldset>```
és ```</fieldset>``` páros tag-ek közé kell zárni. Minden ilyen csoportnak lehet
felirata is, amelyet a ```<legend>``` és ```</legend>``` páros tag-ek között kell megadni.

#### meter és progress

A ```<meter>``` páros tag valamilyen mérési eredmény kijelzésére szolgál. Egy ismert
tartományon belüli skalár érték megmutatására alkalmas. A tag paraméterei a globális
attribútumok mellett:

* *value*: az aktuális érték beállítására szolgál
* *min*: az intervallum minimum értéke
* *max*: az intervallum maximum értéke
* *low*: az alacsony tartomány megadására szolgál
* *high*: a magas tartomány megadására szolgál
* *optimum*: az optimális tartományt adhatjuk meg

A ```<progress>``` tag egy folyamat állapotának jelzésére alkalmas. A tag paraméterei
a globális attribútumok mellett:

* *value*: az aktuális érték beállítására szolgál, értéke lehet egész és törtszám is.
* *max*: az elérhető maximális érték.

### 2.3 Perzisztens helyi tárolás

A felhasználói beállítások és a számítások köztes eredményeinek tárolásához a HTML5 Local
Storage szabványa nyújt lehetőséget. A HTML5 Web Storage API segítségével szabványos
módon tárolhatunk adatot a felhasználók gépén. A szabvány egy domainhez kötött perzisztens
tárhelyet specifikál, melyben kulcs-érték párok formájában tárolhatunk adatokat.
Mivel a megoldás a [HTML5 része](https://html.spec.whatwg.org/multipage/webstorage.html#webstorage),
így nagyon jól támogatott, vagyis gond nélkül használhatjuk a legtöbb böngészőben.

Az adatokat a sütik esetében megszokott kulcs – érték párok segítségével tárolhatjuk.
A kulcs típusa szöveges, míg az érték típusa bármi lehet. Fontos különbség a sütikhez
képest, hogy a Web Storage tároló, csak kliens oldalról érhető el. Amíg a sütik az
adatforgalmat növelve minden egyes HTTP lekérés során együtt utaznak a lekért fájlokkal,
a Storage-ban tárolt adatok nem. További lényeges különbség a tárolható adatmennyiség
(sütik esetében 4 KB, Web Storage esetében ez akár 5 MB).

A HTML Web Storage API két objektumot biztosít az adatok kliensgépen történő tárolásához
(ugyanazokkal a függvényekkel és tulajdonságokkal rendelkeznek, az adatok tárolásának
és elérésnek a módja is megegyezik, csak a lejárati időben térnek el):

* ```window.localStorage```: lejárati dátum nélküli adatokat tárol
* ```window.sessionStorage```: egy munkamenet adatait tárolja (az adatok törlődnek,
amikor a felhasználó bezárja az adott böngésző lapot).

A Web Storage használatához szükséges függvények:

* ```clear()```: a Storage tartalmát tudjuk kiüríteni vele
* ```getItem(key)```: visszaadja a paraméterbe kapott kulcshoz tartozó értéket.
* ```key(index)```: visszaadja a megadott index-hez tartozó kulcsot.
* ```length()```: visszaadja a tárolt kulcs-érték párok számát.
* ```removeItem(key)```: a Storage-ben lévő adott kulcsú adat eltávolítására szolgál.
* ```setItem(key,value)```: ezen függvénnyel tudunk adatot tárolni a Storage-ban.

Ha új adatot tárolunk (setItem), adatot távolítunk el (removeItem) vagy töröljük
a Storage tartalmát (clear) kiváltunk egy ```StorageEvent```-et, ami a következő
tulajdonságokkal rendelkezik:

* event.**storageArea**: Session vagy Local
* event.**key**: a kulcs ami változik
* event.**oldValue**: régi értéke
* event.**newValue**: az új értéke
* event.**url**: az oldal URL-je, melynek a kulcsa megváltozott

### 2.4 Web workers

Régebben a böngészők egy szálon hajtották végre kódjukat, és ugyanezen
a szálon futtatták a szkripteket is. Ez ahhoz vezetett, hogy amennyiben egy szkript
egy tömbben nagy mennyiségű számítást tartalmazott, a megjelenített honlap kezelőeszközei,
sőt rosszabb esetben magának a böngészőnek a felülete is „megfagyott”,
a felhasználó parancsaira érzéketlenné vált. Erre a problémára a Web Workers szabvány
nyújt megoldást.

A szabványban leírt worker-ek külön szálon végrehajtott, a böngészőben futó fő
programtól elszigetelt objektumok, amelyek JavaScript kód futtatását teszik lehetővé a
„háttérben”. A worker nem látja a szülő folyamatban betöltött más javascript modulokat,
a honlap DOM-jához sem fér hozzá (nem lehet vele módosítani a HTML kódot, nem áll
rendelkezésre a *window* és *document* objektum, viszont az *XMLHttpRequest* igen,
így a hálózati kommunikáció lehetséges), a főablakbeli kóddal csak üzenetek formájában
tud kommunikálni (postMessage() metódus), amely a benne futó számításoknak már nemcsak
az operációs rendszertől, de a böngésző más részeitől való teljes elválasztását is
jelenti. Ennek köszönhetően a biztonság terén sem kell csupán a böngészőt fejlesztő
csapat hozzáértésére hagyatkoznunk, hanem a worker-ek következetes alkalmazásával
magunk is gondoskodhatunk arról, hogy a szerverről letöltött kód ne tehessen kárt
a rendszer más részeiben.

A külön szálon való futásnak köszönhetően a böngésző és a főablakban futó
felhasználói felület fennakadásmentesen működik. Többmagos processzorok esetén több
worker indításával minden rendelkezésre álló erőforrást kihasználhatunk. Workereket,
és a workeren belül újabb workereket elméletileg korlátlan számban indíthatunk. Ezek
a „háttérszálak” bonyolult matematikai számításokat végezhetnek, hálózati kérelmeket
adhatnak ki, vagy műveleteket végezhetnek a helyi tárolón, miközben a fő weboldal
arra reagál, ahogy a felhasználó görget, kattint vagy szöveget gépel be. 

Dedikált (egyetlen hívó script által használt) Worker objektumot úgy lehet
létrehozni, hogy a forrásfájl elérési útját paraméterként átadjuk a Worker konstruktorának:

```javascript

var worker = new Worker('hello.js'); 

```

A dedikált workerek mellett léteznek megosztott, több hívó által is használható
[SharedWorker objektumok](https://html.spec.whatwg.org/multipage/workers.html#shared-workers) is.

#### Metódusok

* ```worker.postMessage()```: a hívó scriptből küld adatot a (hivatkozott) Worker-nek,
amihez az az onmessage eseménykezelőn keresztül fér hozzá (```event.data```)
* ```postMessage()```: a Worker-ből küld adatot a hívó scriptnek (mivel csak oda küldhet,
ezért nincs előtte objektum hivatkozás)
* ```worker.terminate()```: leállítja a Worker futását
* ```importScripts('<script_url>')```: globális metódus, amihez a worker is
hozzáfér. Lehetővé teszi további scriptek importálását a workerbe.

#### Eseménykezelők

* ```onerror```: egy olyan eseménykezelő metódust reprezentál, amit akkor kell
meghívni, amikor valamilyen hiba történeik. Szintaxisa: ```myWorker.onerror = function() { ... }; ```
* ```onmessage```: egy olyan eseménykezelő metódust reprezentál, amit akkor kell
meghívni, amikor message esemény történik. Szintaxisa: ```myWorker.onmessage = function(event) { ... }; ```
* ```onmessageerror```: olyan eseménykezelő metódust reprezentál, amit akkor kell
meghívni, ha az üzenet nem deszerializálható. Szintaxisa:
```myWorker.onmessageerror = function() { ... }; ```


### 2.5 Websocket

A HTML5 WebSocket szabvány egy olyan alkalmazásprogramozási felületet (API) határoz meg,
amely lehetővé teszi a weboldalak számára, hogy a WebSocket protokoll segítségével
valódi kétirányú (full duplex) kommunikációt folytassanak egy távoli géppel. Ennek
érdekében bevezeti a WebSocket interfészt és meghatároz egy full-duplex kommunikációs
csatornát, amely egyetlen socketen keresztül működik, TCP protokollon keresztül.
A WebSocket API-t a W3C szabványosította, míg a WebSocket protokollt az IETF az
[RFC 6455](https://tools.ietf.org/html/rfc6455)-ben írta le. Kifejlesztésének fő motivációja az
volt, hogy a webböngészőben futó alkalmazás képes legyen a szerverrel való kétirányú
kommunikációra barkácsmegoldások (pl. több HTTP-kapcsolat nyitva tartása) nélkül.

A WebSocket protokollt úgy tervezték, hogy jól működjön a meglévő webes infrastruktúrával.
Ennek a tervezési elvnek a részeként a protokollspecifikáció meghatározza, hogy a
WebSocket kapcsolat HTTP-kapcsolatként kezdi az életét, garantálva ezzel a teljes
visszafelé való kompatibilitást. A kapcsolat kiépítéséhez HTTP kommunikációra van
szükség, ahol a két fél megegyezik arról, hogy „felfejlesztik” a kommunikációt
WebSocketre. Ezért a kliens egy kézfogási kérelmet küld (handshake request), amire
a szerver kézfogási válasszal (handshake response) felel. Ha kiépült a kapcsolat
a WebSocket adatkereteket full duplex módon lehet a kliens és a szerver között
továbbítani. Innentől már csak TCP fölött kommunikának, amit nagyon kis overheaddel
tud a szerver és a kliens megvalósítani. Maga a kapcsolat a WebSocket
interfész által definiált "onmessage" és "send" metódusok révén valósul meg.

A WebSocket protokoll specifikációja két új URI sémát határoz meg: **ws**: és **wss**:,
a nyílt, illetve a titkosított kommunikációhoz. A séma nevén túl a használt URI
komponensek az URI általános szintaxisának [RFC 3986](https://github.com/dominicus75/fig-standards/blob/master/related-rfcs/3986.md) megfelelnek.

Adatok átviteléhez érdemes az üzeneteket valamilyen struktúrába becsomagolni. Erre
az egyik legegyszerűbb lehetőség a JSON használta. Az XML-hez képest sokkal kisebb
a mérete, sokkal kevesebb memóriát igényel és egyszerűbb a szerializálása, egyetlen
hátránya, hogy nem lehet benne kommentet használni. 

#### Tulajdonságok

* ```WebSocket.readyState``` (unsigned int): az aktuális kapcsolat állapota, amely
a következő osztálykonstansok értékeit veheti föl: ```WebSocket.CONNECTING``` (0, kapcsolódás vagy
újrakapcsolódás folyamatban), ```WebSocket.OPEN``` (1, kapcsolat nyiva), ```WebSocket.CLOSING```
(2, kapcsolat lezárása folyamatban), ```WebSocket.CLOSED``` (3, kapcsolat lezárva).

#### Metódusok

* ```WebSocket.WebSocket(url)``` (konstruktor): új WebSocket objektumot hoz létre, a
társított WebSocket kapcsolattal. Paraméterként egy URL-t vár, amely a szerver oldali
rész elérhetőségét adja meg. Az URL-ben csak "ws" vagy "wss" sémák engedélyezettek.
Az URl a létrejövő objektum (csak olvasható) url attribútumában lesz eltárolva.
* ```send(adat)```: adatot küld a Websocket kapcsolaton keresztül (az adat lehet
szöveg, tömb illetve bináris [blob] vagy ArrayBuffer objektum)
* ```close([kód] [, indoklás])```: lezárja a kapcsolatot, a HTTP üzenetekhez hasonlóan opcionálisan
megadható hozzá [lezárókód](https://developer.mozilla.org/en-US/docs/Web/API/CloseEvent#Status_codes) és
indoklás (amelyben ki lehet fejteni a lezárás okát)

#### Eseménykezelők

* ```onopen```: ha a kapcsolat felépült
* ```onerror```: ha valamilyen hiba történt
* ```onmessage```: ha üzenet érkezett, tartalmazza a szerver által küldött üzenetet
is, ami MessageEvent típusú, amiből a konkrét üzenetet a data property segítségével
érhető el.
* ```onclose```: ha valamilyen hiba miatt megszakad a kapcsolat

### 2.6 Szerver által küldött események (Server-Sent Events, SSE)

A HTML5 szabvány *Server-Sent Events*-el foglalkozó [9.2 fejezete](https://html.spec.whatwg.org/multipage/server-sent-events.html)
egy olyan beépített interfészt határoz meg, amely tartósan fenntartja a kapcsolatot
a szerverrel és lehetővé teszi, hogy a kliens eseményeket (automatikus frissítéseket)
fogadjon tőle. Hagyományosan egy weblapnak az adatokat le kell kérnie a szervertől
(HTTP-kérés formájában), így viszont a kiszolgáló bármikor küldhet újabb adatokat
a kliensnek. Hasonlóan a WebSocket-hez a kapcsolat itt is tartós, viszont van néhány **fontos
különbség is a WebSocket és az EventSource között:**

| WebSocket | EventSource (SSE) |
|-----------|-------------------|
| Kétirányú, a szerver és a kliens is küldhet üzeneteket | Egyirányú, csak a szerver küldhet adatokat |
| Bináris és szöveges típusú adat | Csak szöveges adat |
| [WebSocket (ws:// vagy wss://) protokoll](https://tools.ietf.org/html/rfc6455) | HTTP protokoll |

Alkalmazási területek: Facebook/Twitter frissítések, részvényárfolyam-frissítések,
hírcsatornák, sporteredmények stb.

Az **EventSource** interfész meghatározza az összes olyan metódust, amely kezeli
a kiszolgálóhoz való csatlakozást, események vagy adatok fogadását, a felmerülő
hibákat, illetve a kapcsolat bezárását. 

#### Tulajdonságok

* ```EventSource.readyState``` (unsigned int): az aktuális kapcsolat állapota, amely
a következő osztálykonstansok értékeit veheti föl: ```EventSource.CONNECTING``` (0, kapcsolódás vagy
újrakapcsolódás folyamatban), ```EventSource.OPEN``` (1, kapcsolat nyiva), ```EventSource.CLOSED```
(2, kapcsolat lezárva).
* ```EventSource.lastEventId``` (string): az utolsó elküldött elem azonosítója. A
böngésző újracsatlakozás után a ```Last-Event-ID``` header mezőben küldi el.
* ```EventSource.url``` (string): a szerver által küldött adatokat biztosító script
URL-je.
* ```EventSource.withCredentials``` (bool): true, ha a hitelesítés aktív, egyébként false

#### Metódusok

* ```EventSource.EventSource(url[, { withCredentials: true } ])``` (konstruktor): az
első paraméter megadja az adat/eseményfolyamot biztosító program URL-jét, a második
(opcionális) paraméter értéke kizárólag ``` { withCredentials: true }``` lehet (ha
hitelesítés is kell).
* ```EventSource.close()```: lezárja a kapcsolatot

#### Eseménykezelők

* ```EventSource.onopen```: ha megnyílik a kapcsolat a szerverhez
* ```EventSource.onmessage```: ha üzenet érkezik a szervertől
* ```EventSource.onerror```: ha valamilyen hiba történik

### 2.7 Hang és video

A HTML5 megalkotásának egyik fő célja az volt, hogy a böngészőbe kényszerből telepítendő
plug-inek számát csökkenteni lehessen. Ebből következően a HTML5 képes hang- és
mozgóképtartalmak lejátszására is. Ezeket a ```<audio>``` illetve ```<video>```
html elemek segítségével lehet beágyazni a weboldalba.

Bár mindkét elemhez megadható *src* tulajdonság is, ennek használata nem javallott,
mert az egyes webböngészők más-más formátumokat támogatnak, ezért ugyanazt a médiaállományt
többféle formátumban is meg kell adnunk forrásként. Erre szolgál a ```<source>``` elem,
amelyet az ```<audio>``` illetve a ```<video>``` elembe is be lehet ágyazni. A ```<source>```
a globális attribútumokon felül rendelkezik még az *src* (a médiaállomány forrása) és
a *type* (a médiaállomány típusa) tulajdonságokkal is. Érdemes megadni egy type jellemzővel,
hogy milyen médiafájlokra hivatkozunk, elkerülve ezzel azt, hogy a böngésző az összes
hivatkozott fájlt elkezdje letölteni, és ezzel hatalmas erőforrásokat és sávszélességet
emésszünk fel. A type jellemző három információt tartalmaz: a tárolóformátumot (mime-típust),
a video- és az audiokodeket (utóbbi kettő opcionális, a mime-típus megadása általában
elég). A böngésző végigmegy a ```<source>``` elemekből álló listán, és megvizsgálja,
hogy milyen formátumot tud lejtászani a felsoroltak közül és azt a formátumot tölti
le, majd játssza le.

```html
<video>
	<source type='video/mp4; codecs="avc1.42E01E, mp4a.40.2" src="pelda.mp4">
	<source type='video/ogg; codecs="theora, vorbis"' src="pelda.ogv">
</video>
```

Az ```<audio>``` és a ```<video>``` elemek a globális attribútumok (és a már tárgyalt
src) mellett a következő tulajdonságokkal rendelkezhetnek:

* **autoplay**: logikai attribútum, amely lehetővé teszi, hogy a médiaállomány
lejátszása automatikusan elinduljon letöltés után
* **preload**: ezzel adhatjuk meg a böngészőnek, hogy a felhasználó számára melyik
pufferelési technika lenne az ideális. Ha az autoplay attribútum használatban van,
akkor a preload attribútumot figyelmen kívül hagyja a böngésző. A preload értékei:

	* *auto*: a hanganyag letöltése fontos, még akkor is, ha a felhasználó nem kattint
	rá a lejátszás gombra.
	* *metadata*: nem szükséges pufferelni a hanganyagot, elég a metaadatok (pl. hang hossza)
	lekérése.
	* *none*: ezzel jelezhetjük, hogy az audio állományt nem szükséges pufferelni.

* **loop**: logikai attribútum, amely végtelenített lejátszást engedélyez.
* **muted**: logikai attribútum, alapesetben némítja a lejátszót
* **controls**: logikai attribútum. Akkor érdemes használni, ha a böngészőprogram
által biztosított vezérlő eszköztárat szeretnénk megjeleníteni, nem pedig mi
oldjuk meg ezt scriptek segítségével.
* **mediagroup**: lehetővé teszi több hang- illetve videósáv egyszerre történő,
szinkronizált lejátszását.

A ```<video>``` tag további paraméterei:

* **poster**: kezdőkép beállítása (ha nem indul el a videó automatikusan és csak
egy fekete négyzet látszik a helyén vagy a videó legelső képe semmitmondó és egy
másik kép megfelelőbb)
* **width**: a videó elem szélessége
* **height**: a videó elem magassága

### 2.8 Geolokáció (földrajzi helymeghatározás)

A felhasználó földrajzi helyzetének meghatározása a W3C által kiadott [Geolocation API](https://www.w3.org/TR/geolocation-API/)
szabványában meghatározott API segítségével lehetséges. A [Geolocation](https://www.w3.org/TR/geolocation-API/#geolocation)
objektum a HTML szabványban leírt, a kliens azonosítására és aktuális állapotának
leírására használt [Navigator](https://html.spec.whatwg.org/multipage/system-state.html#the-navigator-object)
objektum (csak olvasható) *geolocation* tulajdonságában található (a *Navigator*
objektum pedig a **Window.navigator** szintén csak olvasható tulajdonságban érhető el).

A Geolocation objektum nem rendelkezik sem saját, sem örökölt tulajdonságokkal,
viszont van három metódusa:

* ```Geolocation.getCurrentPosition()```: meghatározza a kliens eszköz aktuális
helyzetét és visszaadja azt egy koordinátákat (coords) és egy időbélyeget (timestamp)
tartalmazó [GeolocationPosition](https://developer.mozilla.org/en-US/docs/Web/API/GeolocationPosition)
objektumban. Kötelező paraméterként egy visszahívó (callback) függvényt vár,
amely siker esetén hajtódik végre, egyetlen bemenete pedig az ereményül kapott *GeolocationPosition*
objektum. A callback függvényben azt lehet meghatározni, hogy milyen műveleteket
kell végrehajtani a kapott *GeolocationPosition* objektumon (pl. kiírni az adatokat,
logolni az eredményt, stb.)
* ```Geolocation.watchPosition()```: regisztrál egy olyan függvényt, amely mindig
automatikusan meghívódik, amikor az eszköz helyzete megváltozik. Egy egész számmal
tér vissza, amely a regisztrált metódust azonosítja. Paraméterezése megegyezik a
```Geolocation.getCurrentPosition()``` metóduséval.
* ```Geolocation.clearWatch()```: paraméterként a ```Geolocation.watchPosition()```
metódus által visszaadott (egész szám) azonosítót várja, melynek segítségével
törli a regisztrált helyváltoztatás-figyelő függvényt.

A földrajzi helymeghatározás csak biztonságos kapcsolaton (HTTPS) keresztül érhető el,
úgy, hogy a felhasználó mindig értesítést kap, ha a webhely a helyadatait próbálja
lekérdezni. Ehhez minden esetben külön hozzá kell járulnia.

### 2.9 Fogd és vidd (drag and dropp)

„A „*fogd és vidd”*, *„húzd és ejtsd”* (angolul **drag and drop**) a számítógép grafikus
felhasználói felületén használatos funkció, melynek segítségével a képernyőn lévő
valamely absztrakt objektumra egérrel kattintva, majd azt egy másik helyre vagy
objektum fölé húzva valamilyen feladatot tudunk végrehajtani.”<sup id="2">[[2]](#note2)</sup>
Ilyen feladat lehet például fájlok feltöltése, másolása, a kinézet elemeinek átrendezése.
A HTML5 megjelenése előtt ezt a funkcionalitást JQuery vagy más JavaScript függvénykönyvtár
segítségével lehetett megvalósítani. A HTML5 szabvány viszont már natív támogatást
biztosít hozzá (HTML5 szabvány, [6.9 fejezet](https://html.spec.whatwg.org/multipage/dnd.html#dnd)).

Ahhoz, hogy egy HTML elemet húzhatóvá tegyünk, egy (globális, bármely elemhez rendelhető)
```draggable``` logikai attribútumot kell hozzáadni, amely háromféle értéket vehet
fel: ```true``` (húzható), ```false``` (nem húzható) illetve az alapértelmezett
```auto``` (a böngésző alapértelmezett viselkedését alkalmazza), ezt az értéket nem
kell külön feltüntetni. 

Az elemhez eseményfigyelőket is létre kell hozni. A drag and dropp műveletek **DragEvent**
típusú eseményeket válthatnak ki. Minden DragEvent típusú esemény egy globális
eseménykezelőhöz van rendelve:

| DragEvent esemény | HTML eseménykezelő | Eseményt kiváltó elem | Bekövetkezik, ha |
|-------------------|--------------------|-----------------------|------------------|
| ```drag``` | ```ondrag``` | húzható elem | a húzható elemet (HTML elem, vagy kijelölt szöveg) mozgatják |
| ```dragend``` | ```ondragend``` | húzható elem | egy húzási művelet véget ér (egérgomb felengedése vagy esc billentyű lenyomása) |
| ```dragenter``` és ```dragover``` | ```ondragenter``` és ```ondragover``` | fogadó elem (ahová a húzható elem lerakható) | érvényes ejtési célok megjelölésére szolgál, ahol a húzott elemek eldobhatók. A legtöbb HTML elem nem alkalmas húzott elemek fogadására, ezért alapértelmezés szerint nem is engedélyezi azt. Érvényes célelem a következő két módon jelölhető ki: ```ondragenter="return false"``` vagy ```ondragenter="event.preventDefault()"``` |
| ```dragleave``` | ```ondragleave``` | fogadó elem (ahová a húzható elem lerakható) | amikor egy húzható elem elhagyja az érvényes ejtési célelemet |
| ```dragstart``` | ```ondragstart``` | húzható elem | a felhasználó elkezdi húzni az elemet |
| ```drop``` | ```ondrop``` | fogadó elem (ahová a húzható elem lerakható) | egy húzható elem egy érvényes ejtési célra esik |

A szabványos DragEvent eseményobjektum a **MouseEvent** leszármazottja, egyetlen
(csak olvasható) tulajdonsággal rendelkezik, ez a ```DragEvent.dataTransfer```,
amely egy **DataTransfer** objektumban tárolja a húzott adatokat.

#### Tulajdonságok

* ```DataTransfer.dropEffect```: visszaadja az aktuális művelet típusát. Lehtséges
értékei: *none*, *copy*, *link*, és *move*.
* ```DataTransfer.effectAllowed```: beállítja húzható elemhez engedélyezett húzási
művelet típusát. A *dropEffect* attribútum inicializálására szolgál, a *dragenter*
és *dragover* események során. Lehtséges értékei: *none* (az elem nem húzható),
*copy* (a forráselem másolata kerül az célelembe), *copyLink* (másolási vagy linkelési
művelet engedélyezése), *copyMove* (másolási vagy mozgatási művelet engedélyezése),
*link* (hivatkozás az új helyen lévő forrásra), *linkMove* (mozgatási vagy linkelési
művelet engedélyezése), *move* (elem áthelyezése a célelembe), *all* (minden művelet
engedélyezése) és *uninitialized* (alapértelmezett érték, ha a művelet nincs megadva,
egyenértékű az *all* értékkel).
* ```DataTransfer.files```: az adatátvitelhez elérhető helyi fájlok listája, ha nincs
ilyen fájl, akkor a tulajdonság egy üres listát tartalmaz.
* ```DataTransfer.items``` (csak olvasható): az egyes húzott elemeket reperezentáló **DataTransferItem**
objektumokat tartalmazó **DataTransferItemList** objektum. A ```DataTransferItemList.length```
tulajdonság tárolja a listaelemek számát.
* ```DataTransfer.types``` (csak olvasható): string tömb, amely a *dragstart* eseményhez
társított formátumokat tárolja.

#### Metódusok

* ```DataTransfer.clearData(format)```: eltávolítja a megadott formátumhoz társított
adatokat (ha nincs formátum megadva, az összes adatot törli).
* ```DataTransfer.setData(format, data)```: beállítja a megadott adatot a megadott típushoz
* ```DataTransfer.getData(format)```: visszaadja a megadott típushoz tartozó adatot
* ```DataTransfer.setDragImage(element, x, y)```: adott elem segítségével frissíti
a húzási visszajelzéseket.


### 2.10 Canvas

A ```<canvas>``` tag segítségével egy rajzvásznat lehet beilleszteni az oldalba.
A rajzvászon tartalma JavaScript segítségével módosítható. Ezáltal dinamikusan
jeleníthető meg rajta bármilyen kép, vagy grafika.

Minden vászonhoz célszerű egy azonosítót rendelni és előre megadni a méretét. Erre
azért van szükség, mert a vászon tartalmát utólag JavaScript segítségével
tudjuk módosítani, és a vászon elérése az azonosító (id) segítségével lehetséges.

A ```<canvas>``` HTML elem a globális attribútumokon felül csak a *width* (vászon szélessége)
és *height* (vászon magassága) tulajdonságokkal rendelkezik.


```html

<canvas id="myCanvas" width="200" height="100"></canvas>

```

Ha létrehoztuk a vásznat, akkor máris rajzolhatunk rá JavaScript segítségével. Ehhez
először is keressük meg a vásznat az azonosítója segítségével:

```javascript
var canvas = document.getElementById("myCanvas");
```

A canvas nevű változónk egy HTMLCanvasElement típusú objektumot fog tartalmazni,
ennek ```getContext()``` nevű metódusával lehet rajzoló objektumot létrehozni,
a szükséges kontextus megadásával (ez lehet 2d, webgl, webgl2 vagy bitmaprenderer):

```javascript
var ctx = canvas.getContext("2d");
```

A ```HTMLCanvasElement.getContext()``` metódus egy beépített HTML objektummal tér
vissza, amely a rajzoláshoz szükséges tulajdonságokkal és metódusokkal is rendelkezik.
A vászon bal felső sarka a kiindulópont (origó), minden más pont helyezetét ehhez
viszonyítva kell megadni (képpontban).
 

## 3. Weboldalak információtartalmának és kinézetének szétválasztása

A CSS (Cascading Style Sheets, magyarul: lépcsőzetes stíluslapok) egy stílusleíró
nyelv, mely a HTML vagy XHTML típusú strukturált dokumentumok megjelenését írja le.
Ezenkívül használható bármilyen XML alapú dokumentum stílusának leírására is, mint
például az SVG, XUL stb.

A CSS specifikációját a World Wide Web Consortium felügyeli. Nincsenek hagyományos
értelemben vett verziói; viszont vannak szintjei. A CSS minden szintje az előzőekre
épít, finomítja ezek definícióit és funkciókat ad hozzájuk. Jelenleg a 3. szint
(CSS3) van használatban, ami a 2. szintre (megjelent: 1998.) épül és a CSS 2.1
specifikációt (2011.) használja alapul.

A CSS előtt a HTML dokumentumok csaknem minden megjelenéshez kapcsolódó része a
HTML kódon belül volt; a betűtípusok, színek, háttérstílusok, elrendezések, dobozok,
keretek és méretek külön meg voltak adva, gyakran ismétlődően, a HTML kód közepén.
A CSS használatával a tartalom és a forma egymástól élesen elkülönül, a HTML (strukturált
tartalom) és a CSS (formázás, megjelenés, elrendezés) állományokkal ez professzionálisan
megvalósítható. Ez azért fontos, mert így a tartalom és a megjelenés egymástól
függetlenül is változtatható, ez pedig egy sokkal egyszerűbb, kevésbé redundáns
HTML kódot eredményez. A HTML dokumentumok kisebbek lesznek, és mivel a webböngészők
gyakran tárolják a CSS stíluslapokat a gyorsítótárban, a hálózati forgalom is
jelentősen csökkenhet. A CSS használatának legfontosabb előnyei:

* Több lap vagy akár egy teljes webhely stílusait egy helyen lehet tárolni, így gyorsan és könnyen frissíthető
* Különböző felhasználókhoz különböző stílusokat lehet rendelni
* A dokumentum mérete és komplexitása csökken, mivel nem tartalmaz információkat a megjelenítéshez

A stílus információkat háromféle módon rendelhetjük hozzá a HTML dokumentumunkhoz:

* **Külső (external) stíluslap**: ez a legideálisabb eset. Ekkor a HTML állomány
az oldal informatív részét tartalmazza, a külső CSS állomány pedig összegyűjtve
a megjelenítésre vonatkozó formázásokat. A HTML oldalhoz a head elemben elhelyezett
```<link>``` tag vagy az ```@import``` segítségével csatolhatunk külső CSS állományt.
Ha bármit változtatni kell a dizájnon, lényegében csak ezt az egyetlen .css állományt
kell módosítani.
* **Beágyazott (internal) stíluslap**: akkor szokás alkalmazni, ha az oldal egyedi
(a külső stíluslapot nem lehetne másik oldalhoz felhasználni), vagy nagyon egyszerű
stílusról van szó. De ez lehet a megfelelő módszer a HTTP kérések számának csökkentésre
is (SEO megfontolás, kevesebb szál, gyorsabb oldal). A CSS-szabályainkat itt az oldal
```<head>``` elemében található ```<style type="text/css"></style>``` páros elem által
határolt blokkban kell elhelyezni.
* **Soron belüli (inline) stílus**: alkalmazásához a kiválasztott HTML elemet kell
style tulajdonsággal ellátni és ebben megadni a szükséges szabályokat. Az ily módon
elkészített weblapok hátránya, hogy nehézkessé válik az arculatuk illetve a tartalmuk
módosítása, mivel a HTML és a CSS keverve helyezkedik el a forrásban. Az inline
stíluslap használatának másik hátránya, hogy nem tudjuk megfelelően kihasználni a
CSS azon lehetőségeit, hogy különböző média típusokra (pl. képernyő, mobil eszköz,
nyomtatási nézet, képernyőolvasó) más-más stílust rendelhessünk. Alkalmazása nem
igazán javasolt.

Az egymásba ágyazhatóság (kaszkádolás) arra utal, hogy több stíluslapot, meghatározást
is megadhatunk egyszerre, illetve egy stílus lehet több elemre is érvényes, amit
egy másik stílussal felüldefiniálhatunk. Az öröklés az XHTML elemek egymásba
ágyazottságán alapul, így az egymásba ágyazott elemek öröklik az őket tartalmazó
elem beállításait. Ha például a gyökér elemre definiálunk egy stílust, akkor az
többnyire az oldal összes elemére érvényes (a tulajdonságok örökölhetőségétől függően).

Amennyiben több CSS definíció érint egy elemet, akkor azok érvényességi sorrendjét
egy pontosan meghatározott forgatókönyv fogja eldönteni. A kiértékelési sorrend
– ami alapján a böngészők hozzárendelik a stílust a HTML-elemeinkhez – a következő:

1. **Felhasználó áldal definiált stílusok**. Segítségükkel minden stílusutasítást
felülbírálhatunk. A felhasználói stíluslappal például egy gyengén látó felhasználó
megteheti, hogy egyéni, a saját igényeinek megfelelő stíluslapot állít be, hogy
megfelelően olvashassa az adott oldalt. 
2. **HTML-kódba beágyazott (inline) stílusdefiníciók**. A HTML elemek ```style```
attribútuma tartalmazza az elemre vonatkozó szabályokat. Használatuk nem túl szép
és nem is praktikus, ezért csak korlátozottan ajánlott.
3. **Média típusokhoz rendelt stíluselemek** (Media Query). Segítségükkel különböző
kimenetekhez különböző megjelenések társíthatók.
4. **!important kulcsszóval ellátott CSS szabályok**. Egy CSS-deklarációt fontossá
tehetünk, azaz felülbírálhatjuk vele a többi stílusutasítást. Így az eredeti kiértékelési
sorrendet felülbírálva adhatunk meg stílusszabályokat. Ehhez a deklarációban az
érték és a deklarációt záró pontosvessző közzé helyezzük el az *!important* kulcsszót.
5. A CSS szabályokhoz **prioritás** van rendelve. Az ID-szelektorokhoz 100,
az osztályszelektorokhoz 10, míg a HTML-szelektorok 1-es értékkel rendelkeznek. A
szelektorlistákban ezek az értékek összeadódnak. **A magasabb prioritással rendelkező
CSS szabályok felülbírálják az alacsonyabb prioritásúakat.**
6. **Belinkelt és beimportált (external, külső) stíluslapok**.
7. **Szülő elemtől örökölt stílusértékek**.
8. **Böngésző alapértelmezett stílusbeállításai**. Ezek böngészőnként különbözőek
lehetnek, ezért érdemes ezen alapbeállításokat lenullázni a stíluslap elején
([reset.css](https://meyerweb.com/eric/tools/css/reset/)).

### 3.1 CSS nyelvtan, kiválasztók és tulajdonságok, mértékegységek.

A CSS egyszerű szintaxissal rendelkezik, csak néhány angol nyelvű kulcsszót használ
a stílusok tulajdonságaihoz. A stíluslap maga a stílust leíró szabályok sora. Minden
szabályhoz tartozik egy szelektor (kiválasztó) és egy deklarációs szakasz. A szelektor
(lánc, mivel több szelektor is megadható, vesszővel elválasztva) tartalmazza a
formázandó HTML-elem(ek)et. A deklaráció kapcsos zárójelek között pontosvesszővel
elválasztott tulajdonság/érték párokat tartalmaz a következő formában: a tulajdonság
neve, kettőspont, majd az adott tulajdonság értéke (ha az érték több szóból áll,
idézőjelbe kell tenni), végül egy pontosvessző zárja a sort az alább látható módon.

```css

/* Ez itt egy megjegyzés */

szelektor1, szelektor2,...szelektroN {
	tulajdonság1: érték1;
	tulajdonság2: "több szavas érték";
	....
	tulajdonságN: értékN;
}

```

A CSS stíluslapok is tartalmazhatnak megjegyzéseket, amelyeket ```/*``` és ```*/```
jelek közé kell tenni.

#### Kiválasztók (szelektorok)

A kiválasztók (kijelölők vagy szelektorok) azt definiálják, hogy a deklarációs blokkban
található stílusdeklaráció mely HTML elemre vagy elemekre vonatkozzon. Ha több elemre
is szeretnénk ugyanazt a CSS-szabályt alkalmazni, akkor szelektor-csoportot
kell létrehoznunk. Azaz a deklarációs blokk előtt vesszővel elválasztva felsoroljuk
a kívánt szelektorokat, így az összes szelektorra vonatkozik majd a stílusdeklaráció.
Tehát egy szelektorhoz több meghatározás is tartozhat, illetve több elemre is érvényesíthetők
ugyanazok a szabályok.

A szelektorokat a következő csoportokba sorolhatjuk:

* **egyszerű kijelölők** (*simple selector*):

| Típus | Jelölés | Példa | Leírás |
|-------|----------|-------|--------|
| Univerzális kijelölő | ```*``` | ```* { margin: 0; }``` | Az összes elemet kijelöli |
| Csoportos kijelölő | elem,elem2,...elemN | ```div, p { margin: 0; }``` | A felsorolt elemeket választja ki |
| Elem kijelölő | elem_neve | ```header { padding: 1em; }``` | Csak egy konkrét elemet (típust) jelöl ki |
| Osztály kijelölő | .class | ```.left { text-align: left; }``` | Azonos osztályba sorolt elemekre vonatkozik |
| Elem-osztály kijelölő | elem.class | ```p.left { text-align: left; }``` | Adott típuson belül a megadott osztályba tartozó elemeket jelöli ki |
| Azonosító kijelölő | #id | ```#name { font-family: "Times New Roman"; }``` | A megadott egyedi azonosítóval rendelkező elemet jelöli |
* **kombinátorok** (*combinator selector*): az öröklései viszonyok (a dokumentumfa) alapján
történő kijelölést teszik lehetővé.

| Típus | Jelölés | Példa | Leírás |
|-------|----------|-------|--------|
| Származtatott kombinátor | szóköz az ős és a leszármazott elem között | ```div p { margin: 0; }``` | Olyan elem jelölhető ki vele, ami egy másik leszármazottja |
| Gyermek kombinátor | ```>``` |  ```div > p { margin: 0; }``` | Két elem közötti szülő-gyermek viszonyt ír le (közvetlen leszármazás) |
| Közeli testvér | ```+``` |  ```div + p { margin: 0; }``` | Közös szülő a dokumentumfában, az első elem közvetlenül megelőzi a másodikat |
| Általános testvér | ```~``` |  ```div ~ p { margin: 0; }``` | Közös szülő a dokumentumfában, az első elem nem közvetlenül a második előtt található (lehetnek a kettő között más elemek) |
* **pszeudo-osztály kijelölők** (*pseudo-class selector*): segítségükkel az elemeket
tulajdonságaik, állapotuk vagy relatív elhelyezkedésük alapján tudjuk kiválasztani.
Az elemek állapotára történő hivatkozás például a ```:hover``` (egér ráhúzása az
adott elemre), a ```:focus``` (mikor egy elemre kattintunk, és végül elkattintunk),
a ```:visited``` (linkek esetén, ha már látogattuk őket). A pszeudo-osztály neve
előtt egy kettőspontnak kell állni, némelyiket elláthatjuk paraméterrel is, például
ha egy elemet az elhelyezkedése alapján szeretnénk kiválasztani, akkor azt megtehetjük
egy (n) egészszám paraméter átadásával (```:pszeudo-osztály(n) {}```). Az (n) érték
az elem relatív pozícióját határozza meg a dokumentumfában. 
* **pszeudo-elem kijelölők** (*pseudo-element selector*): egy elem meghatározott
részének kijelölésére alkalmasak, az elem és a pszuedo-elem két darab kettősponttal
van elválasztva (```elem::pszeudo-elem```). Ilyen rész lehet a (blokkszintű) elem
első sora (```p::first-line```), első betűje (```p::first-letter```). Más pszeudo
elemekkel a HTML forrásban nem szereplő tartalmat lehet beilleszteni, a kiválasztott
elem elé (```div::before```) vagy után (```div::after```).
* **attribútum kijelelölők** (*attribute-selector selector*): egy HTML elem jellemzője,
vagy annak meghatározott értéke alapján jelöl ki

#### Tulajdonságok

A CSS tulajdonságok a HTML elemek azon paraméterei, melyeket a stíluslapok segítségével
lehet meghatározni. Rendeltetésük szerint a stíluslapok a karakterek térközének,
a szövegek igazításának, az elemek elhelyezésének, az audió fájlok lejátszásának,
a betűtípusok jellemzőinek és még sok egyébnek nagyon pontos beállítását teszik
lehetővé. A CSS több mint 300 különféle tulajdonságot ölel fel, a különböző értékek
száma pedig végtelen. Nem kombinálható minden tulajdonság minden értékkel — minden
tulajdonságnak megvannak a specifikus értékei.A tulajdonság és az érték kombinációja
a CSS-deklaráció.

#### Mértékegységek

Sok CSS tulajdonság vehet fel valamilyen hosszméretet (width, margin, padding,
font-size, stb.). Ezeket kétféleképpen is meg lehet adni: abszolút és relatív
hosszúságmértékekben.

*Abszolút hosszmértékek*

Az abszolút hosszúságértékekhez hozzátartozik az a mértékegység, amiben értelmezendő.

| Mértékegység jele | Leírás |
|-------------------|--------|
| ```cm``` | centiméter |
| ```mm``` | milliméter |
| ```in``` | hüvelyk (1in = 96px = 2.54cm) |
| ```px``` | pixel/képpont (1px = 1/96in = ~0,26mm) |
| ```pt``` | pont (nyomdaipari mértékegység, 1pt = 1/72in = ~0,352mm) |
| ```pc``` | pica vagy cicero (nyomdaipari mértékegység, 1pc = 12pt = ~4,23mm) |

*Relatív hosszmértékek*

A relatív hosszúságértékek önmagukban sosem fejeznek ki semmit, mivel értékük más
értékektől függ. A segítségükkel megváltoztathatjuk egy tulajdonság aktuális vagy
megörökölt értékét.

| Mértékegység jele | Leírás |
|-------------------|--------|
| ```em``` | Az aktuális elem betűmérete (az em elé írt szám jelképezi azt a szorzót ahány szorosára kívánjuk változtatni az aktuális (vagy megöröklött) értéket) |
| ```ex``` | Relatív érték az adott betűtípus kis x betűjének magasságához képest |
| ```ch``` | Relatív érték az adott betűtípus „0” (zero) karakterének szélességhez képest |
| ```rem``` | A gyökérelem betűmérete (a rem elé írt szám jelképezi azt a szorzót ahány szorosára kívánjuk változtatni a gyökérelemből örökölt értéket) |
| ```vw``` | A viewport szélességének 1%-a |
| ```vh``` | A viewport magasságának 1%-a |
| ```vmin``` | A viewport kisebb dimenziójának 1%-a |
| ```vmax``` | A viewport nagyobb dimenziójának 1%-a |
| ```%``` | A százalékos értékek relatívak, azaz értékük más értékekből számolódik ki. Ez általában a szülő elemtől örökölt érték. |

### 3.2 Doboz modell

A doboz-modell írja le minden weboldalon elhelyezett objektum megjelenését. Ebben
a megközelítésben minden elem egy téglalapon belül helyezkedik el, amely különböző
rétegekből áll. A weboldalakon sok esetben ebből a dobozból semmit nem látunk
legfeljebb a benne foglalt szöveget, de ettől függetlenül a többi része is jelen
van. Ezek a dobozok egymásba ágyazhatóak, korlátlan mélységben és mennyiségben,
de a befoglaló elem limitálja a benne foglaltak kiterjedését.

A modell vonatkozásában háromféle elemtípust különböztetünk meg egymástól:
1. **Blokk-szintű (block-level)** elemekhez önálló doboz tartozik, amely rendelkezik
margóval, kerettel, és a kereten belüli belső margóval. Amenynyiben az elem tartalma
szöveg, az sordobozokba rendeződik.
2. A **sordobozok** nem rendelkeznek sem belső sem külső margóval. Ezek tulajdonképpen
a bekezdés sorait jelentik: egymás alá kerülnek a dobozon belül, annak teljes szélességét
kitöltve a doboz belső margóján belül.
3. A **sorbeli elemek (inline-level elements)** rendelkezhetnek önálló dobozzal, amely
kerettel is ellátható, azonban ez a doboz mindig egy sordobozba kerül.

![Imgur](https://imgur.com/WrqY7Fb.png)

A dobozok jól elkülönülő, CSS által stílussal felruházható részei a következők:

* Legbelül a **tartalom (content)** helyezkedik el. Ez az, amiért az elemünket
létrehoztuk. Mérete a megjelenített tartalomtól függ, de a pontos méreteket is
beállíthatjuk a *width (szélesség)* és *height (magasság)* paraméterekkel.
* A tartalmat egy **belső térköz (padding)** öleli körbe.
* A belső térköz (padding) határán helyezkedik el a **doboz szegélye (border)**.
* A szegélyt az **outline (körvonal)** veszi körbe, amire a szegély szegélyeként
tekinthetünk. Például ez a körvonal jelzi, ha fókuszba került egy elem.
* A dobozok külső határát, azok **margója (margin)** alkotja. Ez határozza meg,
hogy a doboz milyen távolságra legyen a szomszédos elemektől.

A **box-sizing** CSS3 tulajdonsággal tudjuk megadni, hogy az adott elem szélessége hogyan
kerüljön kiszámításra. **Ha a box-sizing-nak nem adunk meg értéket, akkor a HTML elem
magasságába és szélességébe beleszámít minden**. Vagyis a tartalom szélessége, a jobb
és bal oldali belső térköz mérete, a jobb és bal oldali szegély mérete valamint a
jobb és bal oldali margó mérete is. Ugyanez vonatkozik a doboz magassága is.

```box-sizing: border-box;``` beállítás esetén a HTML elem renderelt mérete
mindig pontosan annyi lesz, mint a width és height tulajdonság értéke. És ebbe bele
fog számítani a padding és a border is (de nem hozzáadódik, hanem levonódik, tehát
a content mérete ennyivel kisebb lesz). A margin viszont megmarad ezen kívül, mivel
a margó igazából az elemek közötti távolságot fejezi ki.

A box-sizing értéket érdemes a gyökérelemben vagy (ha van) a reset.css-ben beállítani.

### 3.3 Pozicionálás (position)

A position tulajdonság segítségével beállíthatjuk egy elem pozícionálásának típusát.

A position lehetséges értékei:

* **static**: az elemek nincsenek pozícionálva, eredeti helyükre kerülnek. Ilyen
elemet nem lehet máshova pozícionálni, nem lehet elvágni, és a láthatósága sem
változtatható. Ebben az esetben az elemek a számukra előre meghatározott
módon viselkednek. Ilyenkor a blokk-szintű elemek függőlegesen egymás alatt
helyezkednek el. A soron belüli elemek egy adott sorban maradnak, ezért szokták
azokat sordoboz-nak is nevezni. Tehát: oda kerülnek, ahova amúgy is kerülnének, a
böngésző számítja ki a pozíciójukat a megjelenítő méreteit figyelembe véve (képernyő
szélessége, magassága, felbontása, ablak mérete stb.).
* **relative**: az elemek ugyanúgy követik egymást, mint a statikus értéknél, itt
azonban az elem eredeti helyéhez képpest újrapozícionálható (lásd: left, right,
bottom, top paraméter az eltoláshoz). Ilyenkor az elem eredeti helye üresen marad.
* **absolute**: az elem teljesen kikerül a megjelenítés folyamából (A böngésző
nem hagyja ki az eredeti helyét), és a nem statikus pozícionálású szülő elem
helyzetéhez képest pozícionálható.
* **fixed**: az absolute-hoz hasonlóan az elem teljesen kikerül a megjelenítés
folyamából, azonban itt a képernyő adott pontjára pozícionálhatjuk. Azaz az elem
a dokumentum gördítése esetén is a képernyőhöz képest egy helyben marad. Gyakran
használják ezt a felhasználói élmény javítására, például a visszajelzést biztosító
vezérlő elemeket, mindig látható és könnyen elérhető helyen tartják.
* **sticky** ("ragadós"): az elem folyamatosan a böngésző ablakban látható: relativ
a pozicionálás érvényes rá, amíg el nem éri a kijelölt pontot. Ekkor a pozicionálás
átvált fixed-re (a helyére "tapad"). Navigációs menüknél szokták alkalmazni.
* **inherit**: érték esetén a tulajdonság értéke a szülő elemtől öröklődik.

A position tulajdonság értékei **nem öröklődnek**.

A *top*, *bottom*, *left* és *right* tulajdonságokkal – ha a pozícionálás típusa megengedi –
pozícionálhatjuk elemeinket. Megadhatunk tetszőleges hosszúságértékeket. Ekkor az elem
a megadott irányból ennyivel lesz eltolva. Megadhatunk százalékos értéket, ekkor az
eltolás nagysága a szülő elemhez lesz viszonyítva. Negatív érték az ellentétes irányba
mozgatja az elemet. A top, bottom, left és right tulajdonságok értékei nem öröklődnek.

### 3.4 Megjelenítés (display)

A **display** tulajdonság határozza meg a HTML elemhez generált doboz típusát, ezen
keresztül pedig más elemekhez viszonyított megjelenítésének módját. Nem összekeverendő
a *visibility* tulajdonsággal, ami az adott elem láthatóságát befolyásolja. A display
segítségével blokkszintű elemeket is megjeleníthetünk inline (soron belüli) elemként
és fordítva, de számos más beállítási mód is lehetséges. Minden HTML elem rendelkezik
alapértelmezett display értékkel, amely függ az elem típusától (a legtöbb esetben
```block``` vagy ```inline```). Ezeket azonban felül is lehet írni.

**A display lehetséges értékei**:

* ```inline```: az elem és a testvérei vízszintesen balról jobbra lesznek elrendezve,
amíg el nem fogy a vízszintes hely a szülő elemben. Sem előtte sem utána nem jön
létre sortörés. Figyelmen kívül hagyja a szélesség és a magasság tulajdonságokat.
Figyelembe veszi a vízszintes igazítást (vertical-align).
* ```block```: az elem előtt és után sortörés illesztődik be. A blokk elemere alkalmazhatók
a dobozmodellben megismert tulajdonságok (margin, padding), viszont a vízszintes
igazítás (vertical-align) nem. 
* ```contents```: az elem önmaga nem generál külön dobozt, de a gyerekei és pszeudo-elemei
már igen. Ezek a leszármazottak így egy szinttel feljebb kerülnek a dokumentumfán.
* ```flex```: létrehoz egy rugalmas konténert, amelynek mérete a rendelkezésre álló
képernyő mérethez igazodik. Gyermek elemei elrendezhetők bármilyen haladási irányban
(jobbra, balra, lefelé, felfelé), elhelyezhetők egy vagy több sorban, a rugalmas
konténerhez és egymáshoz képest is többféleképpen igazíthatók, a konténer méretének
változásakor automatikusan változtathatják méretüket.
* ```grid```:  létrehoz egy Grid konténert, amelynek elemeit sorokba és oszlopokba
rendezhetjük. A rácsos elrendezés megjelenítésének logikája nagyban hasonlít a táblázatos
elrendezésre. A megvalósítás azonban teljesen másként működik, a gyermekelemek
pozíciói a HTML kód módosítása nélkül csupán CSS jellemzők változtatásával módosíthatók.
* ```inline-block```: blokk dobozt generál. Blokk dobozként formázható de inline
dobozként kerül elhelyezésre az oldalon (nem tölti ki a rendelkezésre álló helyet,
viszont használhatók vele blokk elemekre jellemező a width, height, margin és padding
tulajdonságok). 
* ```inline-flex```: az elemet sorszintű felx-konténerként jeleníti meg.
* ```inline-grid```: az elemet sorszintű grid-konténerként jeleníti meg.
* ```inline-table```: az elemet sorszintű táblázatként jeleníti meg.
* ```list-item```: listaelem megjelenést kölcsönöz az elemnek
* ```run-in```: az elemet blokkként vagy inline-ként jeleníti meg, a kontextustól
függően. Ha az elemet blokk elem követi, akkor annak inline eleme lesz. Ha nem blokk
típusú a következő elem, akkor blokként jelenik meg.
* ```table, table-caption, table-column-group, table-header-group, table-footer-group, table-row-group, table-cell, table-column, table-row```: a nevükből következő
táblázatelemnek megfelelő kinézetet biztosítanak elemnek.
* ```initial```: az alapértelmezett érték használata
* ```inherit```: hatására a szülő elemtől öröklődik a tulajdonság értéke
* ```none```: nem generál dobozt. Kikapcsolja a HTML elem és valamennyi gyermekelemének
megjelenítését. Nem csupán láthatatlanná teszi az elemet, de számára helyet sem
foglal le az oldalon.

### 3.5 Fontosabb média típusok

A mobil eszközök böngészőprogramjai az oldalakat virtuális ablakokban jelenítik
meg (ezt nevezzük viewportnak), amely általában szélesebb, mint a képernyő. Tehát
**a viewport nem más mint a böngésző azon területe, ahol a weboldalak megjelennek**.
A **viewport (nézetablak)** meta elem segítségével felülírhatjuk a böngésző (user
agent) által deklarált nézetablakot. A meta elemen belül a content tulajdonság
értékadásával szabályozhatjuk a fő tulajdonságait és azok értékét. A tulajdonság –
érték párokat vesszővel elválasztva kapcsolhatjuk össze.

```html
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
```

Érdekességként megjegyzendő, hogy a W3C elkezdte készíteni a [hivatalos viewport szabványt](https://www.w3.org/TR/css-device-adapt-1/). Mivel a viewport lényegében
a megjelenésért felel, így a CSS-ben van a helye. A viewport-ot CSS-ben ugyanazokkal
a tulajdonságokkal használhatjuk, mint HTML-ben a meta tag-et. Főbb eltérés, hogy
az initial-scale tulajdonság helyett itt zoom-ot kell használnunk.  

```css
@viewport {
  zoom: 1.0;
  width: device-width;
  min-zoom: 1;
  max-zoom: 3;
  zoom: fixed;
}

```

A szabvány jelenleg még vázlat stádiumban van, így egyelőre a meta elem használata
javallott.

Ahhoz, hogy az általunk készített weboldalon többféle platform, eszközön is jól
használható legyen, törekednünk kell arra, hogy az oldalunk reszponzív legyen.
Ezt viewport meta elem használata mellett a médialekérdezés (media query) segítségével
valósíthatjuk meg. Egy médialekérdezés egy média típus megadásból áll valamint nulla
vagy több kifejezésből, amelyek lekérdezik az aktuális média egyes tulajdonságait.
Egy médialekérdezés egy logikai kifejezésnek tekinthető, ami igaz vagy hamis
értékkel tér vissza. A lekérdezés igaz, ha a megadott média típus megegyezik az eszköz
média típusával, és az összes kifejezés értéke igaz.

A médialekérdezés használatával a stílusszabályok már a stíluslapon csoportosíthatók
médiaelemek szerint. Így akár egyetlen stíluslapon definiálhatók a különböző kimenetekhez
tartozó CSS-szabályok.

**Fontosabb média típusok**

* **All**: összes eszköz
* **Speech**: beszédszintetizátor
* **Braille**: braille-kijelzők számára
* **Embossed**: braille-nyomtató számára
* **Handheld**: kézi, mobil eszközök (kis képernyő)
* **Print**: nyomtatás
* **Projection**: kivetítő
* **Screen**: képernyők
* **Tty**: fix szélességű karakteres megjelenítők
* **Tv**: televízió jellegű eszközök

A média típusok különböző szempontok szerint csoportosíthatóak is, és a stíluslap
megadásánál ezen médiacsoportok nevét is megadhatjuk. Ilyen csoport például a
* *continuous* (folyamatos, mint a monitor, a képernyő vagy a beszédszintetizátor),
* *paged* (lapozható, pl. a hagyományos nyomtató vagy a braille-nyomtató),
* *visual*/*audio* (képernyő, tv)
* *interactive* (projektor)
* *static* (pl. a hagyományos nyomtató vagy a braille-nyomtató).

**Leggyakrabban használt média tulajdonságok**

| Tulajdonság | Értéke | Leírás | ```min/max``` előtag használata | Példakód |
|-------------|--------|--------|---------------------------------|----------|
| ```width``` | hosszúság érték (pl. 300px) | Folytonos média esetén a viewport szélességét jelenti a gördítősávot (ha van) is beleértve. Lapozható média esetén ez az oldal doboz szélességét jelenti. | igen | ```@media screen and (max-width: 992px) {...}``` |
| ```height``` | hosszúság érték (pl. 300px) | Folytonos média esetén a viewport magasságát jelenti a gördítősávot (ha van) is beleértve. Lapozható média esetén ez az oldal doboz magasságát jelenti. | igen | ```@media screen and (min-height: 600px) {...}``` |
| ```device-width``` | hosszúság érték (pl. 300px) | Folyamatos média esetén a képernyő szélességét jelenti, lapozható média esetén az oldallap szélességét. | igen | ```<link rel="stylesheet" media="screen and (device-width: 600px)" href="pelda.css">``` |
| ```device-height``` | hosszúság érték (pl. 300px) | Folyamatos média esetén a képernyő magasságát jelenti, lapozható média esetén az oldallap magasságát. | igen | ```<link rel="stylesheet" media="screen and (device-height: 400px)" href="pelda.css">``` |
| ```orientation``` | portrait/landscape | Elrendezés. Akkor álló (portrait), ha a magasság nagyobb vagy egyenlő a szélességgel, ellenkező esetben landscape (fekvő). | nem | ```@media screen and (orientation: landscape) { ... }``` |
| ```aspect-ratio``` | tört (pl. 16/9) | Viewport méretarány. A szélesség osztva a magassággal | igen | ```<link rel="stylesheet" media="screen and (aspect-ratio: 4/3)" href="pelda.css">``` |
| ```device-aspect-ratio``` | tört (pl. 16/9) | Eszköz méretarány. A device-width szélesség osztva a device-height magassággal. | igen | ```<link rel="stylesheet" media="screen and (device-aspect-ratio: 16/9)" href="pelda.css">``` |
| ```color``` | egész szám | Színmélység. A megjelenítő eszköz színmélységére jellemző szám (bitek száma színkomponensenként). | igen | ```<link rel="stylesheet" media="screen and (min-color: 1)" href="pelda.css">``` |
| ```resolution``` | felbontás érték (pl. 100dpi) | A megjelenítő eszköz felbontása | igen | ```<link rel="stylesheet" media="screen and (min-resolution: 300dpi)" href="pelda.css">``` |

A kifejezésekben különböző operátorokat használhatunk, ilyen az ```and``` (és),
```not``` (tagadás), illetve a ```,``` (vessző, logikai vagy operátor).

## 4. JavaScript szerepe a weboldalakon

A Netscape cég szerette volna, ha böngészőjében a weboldalak interaktívabbá tehetők
egy programozási nyelv által. Felmerült, hogy a Java nyelvet használnák az oldalak
szkriptelésére is, de a nyelvet túl professzionálisnak és nehéznek találták, ezért
inkább egy könnyebben tanulható és alkalmazható szkriptnyelv kidolgozása mellett
döntöttek. Így az új nyelv a Java szintaxisát örökölte, de szkriptnyelv lett. Eredetileg
**Brendan Eich**, a *Netscape Communications* mérnöke fejlesztette ki; neve először
**Mocha**, majd **LiveScript** volt, de a bejelentésekor (1995 decemberében) –
valószínűleg marketinges – okokból **JavaScript**ként hivatkoztak rá. 

A hatalmas sikert meglovagolva a Microsoft is elkészítette Internet Explorer nevű
böngészőjében a JavaScript támogatást, a nevét pedig később szabadalmi okokból
JScriptre változtatta. A Netscape cég a nyelv diverzifikálódását megelőzendő aktív
szabványosítási kampányba kezdett, végül 1997-ben az Európai Számítógépgyártók
Szövetsége (European Computer Manufacturers Association, ECMA) nevű cég szabványosította
ECMAScript néven ([ECMA-262](https://262.ecma-international.org/11.0/)). Az ECMAScript
a JavaScript (Netscape) és a JScript (Microsoft) által létrehozott nyelvekből alkotott szabvány,
amelyet az ISO is elfogadott, jelenlegi változata a **[ISO/IEC 22275:2018 szabvány](https://www.iso.org/standard/73002.html)**.
Az ECMA-szabványnak jelenleg a 11.0 verzója hatályos, de a kiadásokat évszámmal is
szokták jelölni, tehát a 11. változat ECMAScript 2020. néven is ismert.

A szabvány meghatározása szerint a JavaScript egy [általános célú programozási nyelv](https://hu.wikipedia.org/wiki/%C3%81ltal%C3%A1nos_c%C3%A9l%C3%BA_programoz%C3%A1si_nyelv),
amelyet eredetileg webes scriptnyelvnek terveztek, de mára egy teljes funkcionalitású
általános programozási nyelvé vált, amely a programozási feladatok széles skálájára
alkalmazható. A JavaScript egy [többparadigmás](https://hu.wikipedia.org/wiki/Programoz%C3%A1si_paradigma)
programozási nyelv, a szoftver tervezők és programozók eldönthetik hogyan használják
ezen paradigmák elemeit.


### 4.1 Nyelvtani sajátosságok

A JavaScript egy **scriptnyelv**, ami egy adott (web)alkalmazás vagy működési környezet
vezérlését teszi lehetővé. A JavaScript a böngésző és a betöltött dokumentum
állapotát változtatja meg. A kódot a böngészőbe épített JavaScript **értelmező
(interpreter)** értelmezi sorról sorra. Az **értelmezett nyelvekben ugyanis nincsen fordítási
fázis**, nem a lefordított kód fut, hanem az első lehetőségnél az értelmező elkezdi a
program végrehajtását. Az **értelmezett nyelveknél a forrás maga a program**. A böngésző
a HTML oldalt sorfolytonosan tölti be és jeleníti meg. Ha script blokkal találkozik,
akkor az abban lévő JavaScript kódot futtatja. A forrásállomány beolvasása balról
jobbra, a végrehajtás pedig sorrol sorra történik.

A JavaScript C típusú nyelv, szintaxisa nagyban hasonlít a C vagy a Java szintaxisához.
A JavaScript nyelv néhány jellemzője:

* A nyelv kis- és nagybetű érzékeny,
* Az Unicode karakterkódolási szabványt támogatja,
* Az utasításokat (sorokat) konvenció szerint pontosvesszővel (```;```) választjuk
el (nem kötelező, de zavart okozhat az elhagyása),
* Biztonsági okokból a nyelvben nincsen fájlkezelés,
* Megjegyzéseket ugyanúgy lehet írni JavaScriptben, mint más C típusú nyelvben: az
egysoros megjegyzést ```//``` után, a többsorost a ```/* */``` jelek közé.

A JavaScript gyengén típusos nyelv, vagyis a változó értékének megadásával automatikusan
hozzárendelődik a változóhoz a neki megfelelő adattípus. Amennyiben egy adott változó
típusát szeretnénk lekérdezni, ehhez a ```typeof``` unáris operátort használhatjuk, melynek
visszatérési értéke string típusú szöveg lesz, ami a típust megnevezését tartalmazza.
(**A typeof „object”-et ad vissza mind az objektumokra, mind a tömbökre, és a „null” értékre is**.
Ez utóbbit nyelvi hibának lehet tekinteni, amit kompatibilitási okokból nem lehet
javítani, ugyanis számos régebb írt kód nem működne többet helyesen, ha ez nem objektum
típus volna).

A JavaScript nyelv típusait két kategóriába lehet sorolni: primitív és összetett.
A primitív típusok érték szerint, míg az összetettek referencia szerint adódnak át,
vagyis a primitívek értéke átmásolódik, míg az összetett adattípusnak a memóriacíme
tárolódik el.

JavaScriptben a primitív típusok az *undefined* és a *null* kivételével automatikusan
objektummá alakulnak, amikor meghívjuk egy metódusukat, majd automatikusan vissza
is alakulnak primitívvé.

| Primitív típus | Burkoló objektum | 
|----------------|------------------|
| ```string``` | ```String``` |
| ```number``` | ```Number``` |
| ```boolean``` | ```Boolean``` |
| ```undefined``` | nincs |
| ```null``` | nincs |

Tehát minden primitív típusnak létezik egy burkoló (wrapper) objektum megfelelője.
A primitív érték **alakíthatatlan (immutable)**, ugyanakkor becsomagolhatjuk egy
burkoló objektumba, azonban nincs olyan eset, ahol az explicit csomagolás indokolt
volna, ellenben a futtatókörnyezet a primitív értéket automatikusan be- és kicsomagolja.

Két komplex (összetett) adattípus létezik: **függvény (function)**, **objektum (Object)**.
A JavaScriptben a tömb is objektum, így a ```typof``` függvény ez esetben is ```Object```
értékkel fog visszatérni. Az objektum JavaScriptben nem más, mint név-érték (vagy
kulcs-érték) párok gyűjteménye. Leginkább egy asszociatív tömbhöz hasonlít, amelynek
lényege, hogy az egyes elemeket a nevük (vagy kulcsuk) alapján érünk el.

A nyelv prototípus alapú ami azt jelenti, hogy az öröklődést prototípusok (és nem
osztályok) segítségével valósítja meg. JavaScriptben minden objektum rendelkezik
prototípussal, ami alapértelmezetten az ```Object.prototype``` lesz. Új objektum
létrehozásakor a prototípus lánc végéhez adunk egy új elemet, ami rökli a felmenői
tulajdonságait és metódusait.

Az ECMAScript 2015, más néven ES6 bevezette az osztályok ```class``` kulcsszóval
történő létrehozását. Innentől a más nyelveken megszokott módon lehet osztályokat
deklarálni.

### 4.2 Eseményvezérelt programozás

A JavaScript programok nem feltétlenül sorról sorra hajtódnak végre. Eseményeket
is észlelhetnek és válaszolhatnak ezekre. Az események a böngészőben következnek be,
például ha egy felhasználó egy gombra kattint, mozgatja az egérmutatót, vagy a
kiszolgálóról egy weboldalt, vagy képet tölt le. Minden eseménynek van egy társított
objektuma. Az event objektum olyan információkkal szolgál az eseményről, mint
* az esemény típusa (type),
* az egér pozíciója a DOM dokumentumhoz képest (clientX, clientY),
* az egér pozíciója a képernyő bal felső sarkához képest (screenX, screenY),
* az eseményben érintett DOM elemek (target, currentTarget).

Az eseményobjektum konkrét adatai az esemény jellegétől is függenek (pl. egy egéresemény
nem ad információt a lenyomott billentyűzetgomb kódjáról).

Mikor egy esemény bekövetkezik, valamint van eseménykezelője (vagy eseményfigyelője)
az esemény lekezelésére, az eseményobjektum az eseménykezelő függvény első paramétereként
érhető el. Az eseménykezelő függvényt úgy kell meghatározni, hogy az eseményt paraméterként
vegye át. Az eseménykezelők a document vagy más, események fogadására képes objektum
tulajdonságaként tárolódnak.

Eseménykezelőknek adott elem adott eseményéhez történő hozzárendelési folyamatát
az eseménykezelők hozzáadásának, feliratkozásának vagy regisztrálásának nevezik.
**Ez több módon is nyélbe üthető:**

1. A kívánt HTML elemet kell bővíteni egy eseménykezelő attribútummal, amelyben
JavaScript utasításokat vagy eseménykezelő-függvény hívást lehet elhelyezni, idézőjelek
között. Az elem képes az attribútumban kapott JS kód direkt futtatására:

```html
<button onclick="this.innerHTML = Date()">Mennyi az idő?</button>

<!-- vagypedig: -->

<button onclick="displayDate(event)">Mennyi az idő?</button>

<script>
function displayDate(event) {
  document.getElementById("demo").innerHTML = Date() + " A kattintott elem: " + event.target;
}
</script>
<p id="demo"></p>

```

2. Ahelyett, hogy az eseménykezelőt a HTML dokumentumban (valamely elem tulajdonságakét)
határoznánk meg, azt is megtehetjük, hogy egy függvénynek adjuk az eseménykezelő szerepét.
Ehhez szükséges, hogy a HTML elem rendelkezzen egyedi azonosítóval (id tulajdonság),
ami alapján ```document.getElementById()``` függvény segítségével megkereshető, hogy
hozzárendelhessük a megfelelő eseményfigyíelőt.

```html

<button id="gomb">Mennyi az idő?</button>
<p id="demo"></p>

<script>

function displayDate(event) {
  document.getElementById("demo").innerHTML = Date() + " A kattintott elem: " + event.target;
}

obj = document.getElementById("gomb");
obj.onclick = displayDate;

</script>

```

3. A szabványos módszer az ```EventTarget.addEventListener()``` metódus használata.
Az ```addEventListener()``` első várt paramétere az eseménytípus (az alábbi példában:
"click"), amire fel akarunk iratkozni, második paramétere pedig az eseménykezelő
függvény neve, amit tulajdonságként hozzá szeretnénk adni a kiválasztott DOM elemhez
(esetünkben a "gomb" azonosítóval rendelkező button elem). Harmadik (opcionális)
paramétere egy objektum, amely a következő (boolean típusú) tulajdonságokat tartalmazhatja:
	* capture (elkapás iránya)
	* once (egyszeri hívás majd eltávolítás)
	* passive (nincs preventDefault() hívás)

```html

<button id="gomb">Mennyi az idő?</button>
<p id="demo"></p>

<script>

document.getElementById("gomb").addEventListener("click", displayDate);

function displayDate(event) {
  document.getElementById("demo").innerHTML = Date() + " A kattintott elem: " + event.target;
}

</script>

```

Az eseményről a ```EventTarget.removeEventListener()``` metódus segítségével lehet
leiratkozni.

### 4.3 DOM

A Dokumentum Objektum Modell (Document Object Model / DOM) egy platform- és nyelvfüggetlen
szabványos objektummodell amely a HTML, XHTML, XML valamint rokon formátumaiknak
a szerkezetét és az objektumaikkal történő interakciókat modellezi. A DOM egymással
gyerek-szülő kapcsolatban álló objektumok rendszere. A dokumentum tartalmát, illetve
a dokumentum valamennyi összetevőjét magában foglalja. A DOM tehát nem más, mint
az oldal szerkezetéért felelős HTML elemek JavaScript objektum megfelelői, amik
ugyanolyan fastruktúrába szervezve a megjelenítés alapját képezik, és amin keresztül
a dokumentum programozhatóvá válik. Tömören: **a DOM az oldal szerkezetének programozási
felülete**, az a mód, ahogyan a JavaScript látja a webböngésző állapotait és az
általa megjelenített HTML oldalt.

A webböngészők rendszerint a DOM-hoz hasonló belső modellt használnak a dokumentumok
(például egy HTML oldal) megjelenítéséhez. A DOM API-kat weboldalak, illetve egyes
részeik JavaScript kódból történő vizsgálására, vagy módosítására is használják.

A DOM alapját a **[DOM Core szabvány](https://www.w3.org/TR/2004/REC-DOM-Level-3-Core-20040407/)**
jelenti, amelyben egy csomópontokból álló általános fastruktúra ábrázolásához és
működtetéséhez szükséges információk és műveletek vannak leírva. A HTML dokumentum
egy speciális elemekből álló fastruktúra, speciális többletfunkcionalitását a
**[HTML DOM szabvány](https://dom.spec.whatwg.org/)** határozza meg.

A DOM nem más, mint csomópontok fája. Sokféle típusú csomópont létezik, és ez meghatározza
lehetséges tulajdonságaikat és metódusaikat is. Némelyik típusú csomópontnak lehetnek
további gyerekei, mások csak levélelemként szerepelhetnek. A fontosabb csomóponttípusok:

* **dokumentum**: a dokumentumfa gyökere, ez reprezentálja az egész HTML dokumentumot
és biztosítja az elsődleges hozzáférést bármilyen dokumentumbeli adathoz. Mivel minden
további csomóponttípus csak a dokumentumon belül létezhet, ezért biztosít néhány
metódust az elemek elérésére és létrehozására. JavaScriptben ```window.document```
vagy rövidebben ```document``` kulcsszóval hivatkozunk rá.
* **elem**: minden dokumentum egy vagy több elemből áll. Az elemek határát a nyitó
és záró tagek jelölik ki, illetve léteznek üres elemek is, amelyek önmagukban
tekinthetők lezártnak. Minden elemnek lehetnek attribútumai is. Elem például a
```<html>```, ```<p>```, stb.
* **attribútum**: elemhez kapcsolt további információ leírására szolgál. Minden
attribútumnak van neve és értéke.
* **szöveges csomópont**: szöveges adatot tartalmazó csomópont, az oldalakon megjelenő
szövegek ábrázolására szolgál. A DOM feldolgozását nehezíti, hogy az egyes elemek
elválasztására beírt karakterek (pl. újsor karakter) is szöveges csomópontként
jelennek meg.

A DOM egy alkalmazásprogramozási felület (API), ami JavaScripten keresztül érhető
el. Itt **az egyes HTML elemeket objektumok reprezentálják, amelyek különböző tulajdonságokkal**
(ezek zömében megegyeznek az adott HTML elem attribútumaival, amelyeket tetszőlegesen
lehet változtatni) **és metódusokkal** (olyan operációk, amelyek HTML elemeken hajtódnak
végre) **rendelkeznek**. Ezek a metódusok és tulajdonságok alkotják együttesen ezt az
alkalmazásprogramozási felületet.

Amikor a böngésző betölti a kívánt oldalt, akkor ezzel egy időben létrejön az oldalt
leíró dokumentum objektum modell. JavaScriptből ezt a modellt elérve és felhasználva
a következőkre van lehetőségünk egy weboldalon:

* bármelyik HTML elemet és attribútumot szabadon változtathatjuk, ebbe beletartozik
az eltávolításuk, vagy akár új elem, attribútum hozzáadása is
* bármelyik CSS szabályt tetszőlegesen változtathatjuk
* események kezelése, hozzáadása a weblaphoz.

Fentiek végrehajtásához először ki kell választani azokat az elemeket, amelyekkel
valamilyen módon dolgozni szeretnénk. Erre szolgálnak a dokumentumszintű kiválasztó
metódusok:

* ```getElementById(id)```: egy elem kiválasztása az id attribútuma alapján.
* ```getElementsByName(név)```: több elem kiválasztása a name attribútum értéke alapján.
Az elemeket tömbszerű objektumban (NodeList) adja vissza.

**Ezek mellett léteznek dokumentum- és elemszintű kiválasztó metódusok is:**

* ```getElementsByTagName(elemnév)```: az adott elem alá tartozó elemek közül a
megadott nevű elemeket adja vissza.
* ```getElementsByClassName(stílusosztály)```: az adott elem alá tartozó elemek
közül a megadott stílusosztályú elemek kiválasztása.
* ```querySelector(css_szelektor)```: kiválasztás CSS szelektorral. A szelektor
által meghatározott elemek közül az elsőt adja vissza.
* ```querySelectorAll(css_szelektor)```: a CSS szelektor által meghatározott elemeket
adja vissza tömbszerű objektumként.

A több elemet visszaadó metódusok ún. **NodeList** gyűjteményt adnak vissza, amely
úgy viselkedik, mint egy tömb, de a tömbmetódusok nem érhetők el rajta, csupán ```length```
tulajdonságuk van. Feldolgozásuk csak a sima for ciklussal ajánlott.

Elemek kiválasztásával közvetlenül érhetjük el a keresett elemeket. Mivel azonban
a dokumentum egy fa, lehetőség van a dokumentum gyökerétől elindulva elérni az
egyes csomópontokat. Ezt nevezzük a fa bejárásának.

Gyerekelemek lekérdezésére a ```childNodes``` tulajdonság szolgál. Ez az adott elem
alá tartozó összes csomópontot (elemeket és szöveges csomópontot egyaránt) visszaadja.
Az első gyerekelemet a ```firstChild``` tulajdonsággal, az utolsót a ```lastChild```
tulajdonsággal kérhetjük le. A szülőelemre egy adott csomópont ```parentNode```
tulajdonsága mutat. A testvércsomópontok között a ```nextSibling``` és ```previousSibling```
tulajdonsággal tudunk előre, illetve visszafele haladni. A fentiek ```null``` értéket
adnak vissza, ha nincs megfelelő elem.

A bejárás során zavaró lehet, hogy a csomópontok között a szöveges csomópontok is
megjelennek. Ezeket a csomópontok ```nodeType``` attribútuma alapján lehet kiszűrni.
Az elemeknél ez a tulajdonság 1-es, míg szöveges csomópontoknál 3-as értékű.

A kiválasztott elemnek lehetnek HTML attribútumai. Ezeknek a kezelésére a szabvány
a következő műveleteket definiálja:

* ```getAttribute(név)```: adott nevű attribútum értékének lekérdezése.
* ```setAttribute(név, érték)```: adott nevű attribútum értékének beállítása.
* ```hasAttribute(név)```: adott nevű attribútum létezésének vizsgálata.
* ```removeAttribute(név)```: adott nevű attribútum eltávolítása.
* ```attributes```: elem összes attribútumának gyűjteménye.

## 5. JSON.

A JSON (JavaScript Object Notation, JavaScript objektumjelölés) emberek számára is
olvasható–írható, programozottan pedig könnyen feldolgozható és előállítható, pehelysúlyú,
önleíró adatcsere-formátum. A JavaScript programozási nyelv egy részén alapul. A
JavaScripttel való kapcsolata ellenére nyelvfüggetlen, több nyelvhez is van értelmezője.
Formátuma a C családú nyelvekben ismert konvenciókhoz igazodik.

A JSON-t legtöbbször egy szerver és egy kliens számítógép közti adatátvitelre használják
(jellemzően AJAX technológiával), az XML egyik alternatívájaként. Általánosságban
strukturált adatok tárolására, továbbítására szolgál. A téradatok leírására és tárolására
szolgáló változata a [GeoJSON](https://geojson.org/).

A formátumot Douglas Crockford (1955-) specifikálta az [RFC4627](https://tools.ietf.org/html/rfc4627) számú
dokumentumban és először a State Software, egy általa alapított cég használta körülbelül
2001-től. A [json.org](https://www.json.org/json-en.html) honlap 2002-ben indult el.
2005 decemberében a Yahoo! elkezdte némely webes szolgáltatásait JSON-ban kínálni,
majd 2006-tól a Google is használni kezdte. Az ECMA 2013-ban adta ki a JSON szabvány
[első változatát](https://www.ecma-international.org/wp-content/uploads/ECMA-404_1st_edition_october_2013.pdf),
(jelenleg a [2. kiadás](https://www.ecma-international.org/publications-and-standards/standards/ecma-404/) hatályos)
majd 2017-ben az **[Internet Engineering Task Force (IETF)](https://hu.wikipedia.org/wiki/IETF)** is Internetes Szabványnak
ismerte el ([STD 90](https://tools.ietf.org/html/std90)), ugyan ebben az évben az ISO/IEC is
kiadott egy JSON szabványt, [ISO/IEC 21778:2017](https://www.iso.org/standard/71616.html)
szám alatt.

A JSON hivatalos mime-típusa az ```application/json```, fájlkiterjesztése pedig
a ```.json```.

### 5.1 Az JSON adattípusai, szintaxisa.

A JSON-nak két típusú felépítése lehetséges:
* **Név–érték párok halmaza**: ennek megvalósításai az *objektum, rekord, struktúra,
szótár, hasítótábla, kulcsos lista* vagy *asszociatív tömb* lehetnek a különféle
nyelvekben.
* **Értékek rendezett listája**: a legtöbb nyelvben ez *tömb, vektor, lista* vagy
*szekvencia*.

Ezek olyan univerzális adatszerkezetek, amiket gyakorlatilag minden programozási
nyelv támogat valamilyen formában. Ezért a programozási nyelvek kommunikációjához
használatos JSON formátum szintén ezekre az adatszerkezetekre épül, melyek JSON-ban
az alábbi formákban jelennek meg:

* **objektum (object)**: kulcs:érték-párok rendezetlen gyűjteménye, amelyben ```:``` (kettőspont)
karakter választja el a kulcsot és az értéket, a párok egymástól vesszőkkel vannak
elválasztva, a lista pedig kapcsos zárójelek között van; a kulcsok mindig string
típusúak, és különbözniük kell egymástól.
* **tömb (array)**: értékek sorrendhelyes felsorolása vesszővel elválasztva, szögletes
zárójelek között; az értékeknek nem kell azonos típusúnak lennie
* **szöveg (string)**: nulla vagy több, idézőjelek közé zárt Unicode karakter, szükség
szerint balra dőlő törtvonallal (backslash, \) escape-elve
* **szám (number)**:  a C és Java számaihoz hasonló, a különbség az, hogy oktális
és hexadecimális formátum itt nem használható.
* **logikai (boolean)**: ```true``` (igaz) vagy ```false``` (hamis)
* **null**: (szándékosan) üres érték

**Érték lehet idézőjelek közé írt karakterlánc, szám, logikai igaz (true), logikai
hamis (false), null, objektum vagy tömb. A struktúrák egymásba ágyazhatók**.

A feldolgozó által ignorált térköz hozzáadható a „strukturáló karakterek”
(pl. ```[]```, ```{}```, ```:```, ```,```) elé vagy után.

Szemléltetés gyanánt a Laminas Framework [psr7bridge](https://github.com/laminas/laminas-psr7bridge)
csomagjának composer.json állománya:

```json

{
    "name": "laminas/laminas-psr7bridge",
    "description": "Bidirectional conversions between PSR-7 and laminas-http messages",
    "license": "BSD-3-Clause",
    "keywords": [
        "laminas",
        "http",
        "psr",
        "psr-7"
    ],
    "homepage": "https://laminas.dev",
    "support": {
        "docs": "https://docs.laminas.dev/laminas-psr7bridge/",
        "issues": "https://github.com/laminas/laminas-psr7bridge/issues",
        "source": "https://github.com/laminas/laminas-psr7bridge",
        "rss": "https://github.com/laminas/laminas-psr7bridge/releases.atom",
        "chat": "https://laminas.dev/chat",
        "forum": "https://discourse.laminas.dev"
    },
    "config": {
        "sort-packages": true
    },
    "extra": {
    },
    "require": {
        "php": "^7.3 || ~8.0.0",
        "laminas/laminas-diactoros": "^1.7 || ^2.0",
        "laminas/laminas-http": "^2.11",
        "laminas/laminas-zendframework-bridge": "^1.0",
        "psr/http-message": "^1.0"
    },
    "require-dev": {
        "laminas/laminas-coding-standard": "~1.0.0",
        "phpunit/phpunit": "^9.4.1"
    },
    "conflict": {
        "laminas/laminas-stdlib": "< 3.2.1"
    },
    "autoload": {
        "psr-4": {
            "Laminas\\Psr7Bridge\\": "src/"
        }
    },
    "autoload-dev": {
        "psr-4": {
            "LaminasTest\\Psr7Bridge\\": "test/"
        }
    },
    "scripts": {
        "check": [
            "@cs-check",
            "@test"
        ],
        "cs-check": "phpcs",
        "cs-fix": "phpcbf",
        "test": "phpunit --colors=always",
        "test-coverage": "phpunit --colors=always --coverage-clover clover.xml"
    },
    "replace": {
        "zendframework/zend-psr7bridge": "^1.2.0"
    }
}

```

### 5.2 JSON-formázott szöveg értelmezése JavaScript-ben (eval(), JSON.parse()).

Mivel a JSON-formázott szöveg szintaktikailag érvényes JavaScript-kód, értelmezésének
egy egyszerű módja a JavaScriptbe beépített ```eval()``` függvény használata, amely
a függvénynek szöveges formában átadott JavaScript-kifejezések kiértékelésére szolgál.
Így a JSON-értelmező helyett magát a JavaScript interpretert használják a JSON adatok
"lefuttatására", amely ezáltal natív JavaScript-objektumokat hoz létre. 

Az ```eval()``` használata azért veszélyes, mert bármilyen JS kódot végrehajt, amit
odaadunk neki. Éppen ezért sose használjuk olyan kódok végrehajtására amiknek az
eredete nem megbízható vagy éppen ismeretlen. Például, ha a forrás nem megbízható,
akkor az érkező adat lehetséges, hogy egy JavaScriptes kódbeszúrásos támadást idéz elő.
Emellett a bizalom ilyen megsértése okozhat adatlopást, autentikáció-hamisítást, és az
adatok és erőforrások egyéb rossz használatát.

Éppen ezért soha ne használjunk ```eval()```. Bármilyen kód működése, teljesítménye,
ill. biztonsága megkérdőjelezhető amely használja ezt a nyelvi elemet. Semmilyen
megoldás használata nem ajánlott amely első sorban erre épül.

Az **ECMAScript szabvány 5. kiadása (2009)** az ```eval()``` biztonságosabb alternatívájaként
bevezette a ```JSON.parse()``` függvényt, melynek kizárólagos feladata JSON-adatok,
nem pedig JavaScript-kódok értelmezése. A ```JSON.parse()``` függvény egy JavaSript
objektumot ad vissza. Kötelező első paraméterként egy JSON-formázott szöveget, opcionális
második paraméterként egy függvényt vár, amellyel az ereményobjektumon lehet további
műveleteket eszközölni.

```javascript

/* A második paraméterként átadott függvény a city tulajdonság értékét alakítja
csupa nagybetűssé */

var text = '{ "name":"Józsi", "age":"39", "city":"Karakószörcsök"}';
var obj = JSON.parse(text, function (key, value) {
  if (key == "city") {
    return value.toUpperCase();
  } else {
    return value;
  }
});

document.getElementById("demo").innerHTML = obj.name + ", " + obj.city;

```

Az ES5 szabvány a Javascript objektumok szöveges (JSON) formátumba alakítására is
bevezetett egy függvényt. A ```JSON.stringify()``` egy JSON formátumú stringet ad
vissza, kötelező első paramétere a JavaScript objektum, amelyet szövegként akarunk
viszontlátni. Opcionálisan megadható második paraméterként egy függvény, amellyel az
ereményobjektumon lehet további műveleteket eszközölni, illetve harmadik paraméterként
egy szám vagy szöveg, amely a JSON string-ben olvashatóság könnyítési célzattal
elhelyezendő térköz karakterek számát (legfeljebb 10) vagy a beszúrandó karaktereket
(legfeljebb 10 karakter) adja meg.

```javascript

/* A második paraméterként átadott függvény a city tulajdonság értékét alakítja
csupa nagybetűssé */

var obj  = '{ "name":"Józsi", "age":"39", "city":"Karakószörcsök"}';
var text = JSON.stringify(text, function (key, value) {
  if (key == "city") {
    return value.toUpperCase();
  } else {
    return value;
  }
});

/* A második paraméter null, tehát nem lesz átalakítás az eredményen, a harmadik
paraméter pedig 10 szóközös behúzást alkalmaz minden egyes tulajdonság elé */

var text = JSON.stringify(obj, null, 10);

/* Az eremény valahogy így fog festeni: */

"{
          "name": "Józsi",
          "age": "39",
          "city": "Karakószörcsök"
}"

```


### 5.3 JSON objektumok kódolása és dekódolása PHP-ben (json_encode(), json_decode())

JSON objektumok kezelésére a PHP a következő két beépített függvényt biztosítja:

* ```json_encode(mixed $value[, int $flags = 0, int $depth = 512]) : string|false```
Az első paraméterként bekért adatot JSON formátumú szövegként adja vissza. Ha ez nem
sikerül, ```false```-al tér vissza.
Paraméterei:

	1. A kódolandó érték (kötelező paraméter). Ez - resource típus kivételével -
	bármi lehet. A szöveges adatoknak UTF-8 kódolásúaknak kell lenniük.
	2. Bitmaszk (opcionális paraméter). Egész szám típusú érték, amely [JSON konstansok](https://www.php.net/manual/en/json.constants.php)
	értékét veheti fel.
	3. A rekúrzió mélysége (opcionális paraméter). Egész szám típusú érték, mely
	meghatározza, hogy milyen mélységig épülhetnek egymásba az elemek. Pl. ha ez a
	paraméter 4, akkor az alábbihoz hasonló struktúra lehetséges:
	```php

	/* (tömb -> tömb -> tömb -> szöveg) */
	
	array(1) {
	  [1]=>
	  array(2) {
		["English"]=>
		array(2) {
		  [0]=>
		  string(3) "One"
		  [1]=>
		  string(7) "January"
		}
		["French"]=>
		array(2) {
		  [0]=>
		  string(3) "Une"
		  [1]=>
		  string(7) "Janvier"
		}
	  }
	}

	```
	
* ```json_decode(string $json[, bool|null $associative = null, int $depth = 512, int $flags = 0]) : mixed```
Az első paraméterként megkapott JSON formátumú szöveget PHP változóvá alakítja. ```null```
értékkel tér vissza, ha a dekódolás nem sikerül, vagy a kimenet mélysége nagyobb,
mint 3. paraméterben beállított rekúrzió.
Paraméterei:

	1. a dekódolandó (kizárólag UTF-8 kódolású) JSON formátumú szöveg (kötelező paraméter).
	2. kimeneti formátum (opcionális paraméter). Logikai érték, mellyel azt lehet
	beállítani, hogy a JavaScript 	objektumokat PHP objektumként (```false```) vagy
	asszociatív tömbként (```true```) adja 	vissza a függvény. Az alapértelmezett
	érték ```null```, ekkor a negyedik paraméter függvényében objektumot, vagy
	asszociatív tömböt ad vissza.
	3. A rekúrzió mélysége (opcionális paraméter). Egész szám típusú érték, mely
	meghatározza, hogy milyen mélységig épülhetnek egymásba az elemek. 
	4. Bitmaszk (opcionális paraméter). Egész szám típusú érték, amely a következő [JSON konstansok](https://www.php.net/manual/en/json.constants.php)
	értékét veheti fel:
		* ```JSON_BIGINT_AS_STRING```: a nagy egész számokat szövegként adja vissza
		* ```JSON_INVALID_UTF8_IGNORE```: figyelmenkívül hagyja az érvénytelen UTF-8 karaktereket
		* ```JSON_INVALID_UTF8_SUBSTITUTE```: átkonvertálja az érvénytelen UTF-8 karaktereket
		* ```JSON_OBJECT_AS_ARRAY```: a JSON objektumot asszociatív PHP tömbbé alakítja.
		* ```JSON_THROW_ON_ERROR```: [JsonException](https://www.php.net/manual/en/class.jsonexception.php)
		típusú hibaobjektumot dob hiba esetén.


## 6. Az AJAX.

Az **Ajax (Asynchronous JavaScript and XML)** interaktív webalkalmazások létrehozására
szolgáló webfejlesztési technika. Az AJAX technológiával lehetővé válik a szerverrel
való kapcsolattartás a teljes oldal újratöltése nélkül, ezáltal sokkal folyamatosabb,
nagyobb fokú élményt adva a felhasználóknak weboldalak használata közben.

Az Ajax a következő technikák kombinációja:

* **XHTML** (vagy **HTML**) és **CSS**: a tartalom leírására és formázására.
* **DOM**: dinamikus felhasználói felület, interakció.
* **XMLHttpRequest**: aszinkron kliens-szerver adatátvitel.
* **XML, JSON** (vagy sima szöveg): adatleíró és kommunikációs formátum.

Az AJAX lelkét a szabványos [XMLHttpRequest](https://developer.mozilla.org/hu/docs/Web/API/XMLHttpRequest) objektum jelenti, mely segítségével a háttérben
aszinkron módon, azaz a felhasználói felület működtetésével párhuzamosan lehet a
szerver felé kéréseket indítani és az onnan érkező válaszokat feldolgozni. Egy
AJAX-os hívás során a kliens ugyanúgy HTTP protokollon keresztül lép kapcsolatba
a szerverrel, mint a hagyományos oldalkiszolgálás esetén, az egyetlen különbség az,
hogy AJAX esetén nem a böngésző kezdeményezi a kérést, hanem mindezt JavaScript
programmal vezéreljük. A kapcsolattartásért az XMLHttpRequest objektum a felelős.

Az oldalkiszolgálás folyamata a következő:

* a felhasználó valamilyen tevékenységének hatására szükség van szerveroldali kommunikációra;
* ennek érdekében JavaScript segítségével egy XMLHttpRequest objektumon keresztül
kérést intézünk a szerverhez, miközben a felhasználói felület változatlanul használható;
* a szerver kiszolgálja a kérést, a választ elküldi a kliensnek;
* az XMLHttpRequest objektum fogadja a választ, JavaScripttel feldolgozza, és az
oldalon a szükséges módosításokat elvégzi.

### 6.1 Az AJAX céljai és előnyei

A legnyilvánvalóbb ok az Ajax használatára a felhasználói élmény fokozása. Az Ajaxot
használó oldalak viselkedése sokkal inkább hasonlít a desktopos alkalmazásokhoz, mint
a tipikus weboldalakhoz. Amikor egy linkre kattintás hatására a teljes weboldal
újratöltődik, az sokszor időigényes művelet. Az Ajaxot használó oldalak e helyett
képesek rá, hogy csak az oldal szükséges részét frissítsék, így gyorsabb reagálást
biztosítanak a felhasználói interakciókra. Néhányan úgy gondolják, hogy az Ajax lesz
az a feltörekvő technológia, amelynek segítségével a jövőben a webes alkalmazások
minden eddiginél interaktívabbá és így széles körben is sokkal népszerűbbé válhatnak.

Az Ajaxot használó oldalak mérséklik a szerver terhelését, ezáltal rövidebb a válaszidő
is, ugyanis a szervertől HTML formázás nélkül kapják az adatokat. A szervertől kapott
adatokból a HTML kód a böngészőben jön létre javascript segítségével, ami jól optimalizált
programkód esetén legtöbbször gyorsabb – de legalábbis nem lassabb – mintha az erősen
leterhelt szerver hozná azt létre. Ennek oka, hogy ma már a kliens oldalon a felhasználók
viszonylag gyors személyi számítógépekkel rendelkeznek, amelyek terhelése általában
lényegesen alacsonyabb, mint a szerveré. Mindezen jótékony hatásokat tovább erősíti,
hogy az Ajax segítségével sokszor jól megvalósítható, hogy mindig csak az éppen
szükséges minimális mennyiségű adat töltődjön le a szerverről. Ennek köszönhetően
mindig csak a feltétlen szükséges minimális mennyiségű adattal kell dolgozni.
Összefoglalva az Ajax és az itt leírt módszerek együttes használatával szignifikáns
oldal letöltési sebesség növekedés és szerverterhelés csökkentés érhető el. A gyorsulás
általában fordított arányban áll a webes alkalmazás funkcionális összetettségével
és alkalmazáslogikájának bonyolultságával.

Egy másik előnye az Ajax használatának, hogy lehetővé teszi az adatokat szolgáltató
és a megjelenítésért felelős programkód elkülönítését.

### 6.2 Az AJAX technikái, a jQuery fontosabb AJAX metódusai ($.ajax, $.get, $.getJSON, $.post, $.load)

A **jQuery** egy JavaScript függvénykönyvtár, amelyet John Resig kezdett fejleszteni.
Első kiadása 2006-ban volt, jelenleg a 3.6 verzió van forgalomban. Licencét tekintve
nyílt forráskódú, kettős licenccel: GPL/MIT. A jQuery célja, hogy segítsen minél
inkább leválasztani a JavaScript kódot a HTML-ről, és kényelmes kommunikációt
biztosítson a weblap elemeivel. Használata megkönnyíti HTML dokumentumok bejárását,
manipulálását, animálását, stílusok módosítását, események kezelését és az AJAX-os
kommunikációt. A benne írt kód böngészőfüggetlen lesz, azaz bármelyik böngésző
bármelyik verziójában ugyanazt az eredményt kapjuk. A jQuery-t az utóbbi időben
több projektre bontották, a **jQueryUI** különböző felületi komponenseket definiál,
míg a **jQuery Mobile** mobilalkalmazások készítését könnyíti meg jQuery alapokon
különböző felületi elemeket definiálva.

Minden művelet előtt szükséges kiválasztanunk azokat az elemeket, amelyekkel dolgozni
szeretnénk. A jQuery filozófiájának középpontjában éppen ezért a ```jQuery()``` vagy
```$()``` függvény áll. Ez paraméterül egy szövegként megadott CSS3 kompatibilis
szelektorkifejezést vár. Ha paraméterként HTML kifejezést tartalmazó szöveget kap,
akkor megpróbálja a kifejezésnek megfelelő elemeket létrehozni a memóriában, és e
struktúrának a legkülső elemét teszi a jQuery objektumba. Végül a ```jQuery()``` függvény
egy függvénykifejezést is paraméterül kaphat. Az így átadott függvény akkor hívódik
meg, amikor az oldal betöltődött, pontosabban egy kicsit előtte, amikor az oldal
DOM struktúrája felépült.

A kiválasztott elemekkel sokféleképpen lehet dolgozni, általában lekérdezni szeretnénk
valamilyen paraméterüket, vagy módosítani azokat. A jQuery metódusai általában egyszerre
*setter*ek és *getter*ek is. Ha nem kapnak paramétert, akkor általában az adott
tulajdonság értékével térnek vissza, paramétert kapva azonban beállítják azt. A
setterek általában mindegyik elemre érvényesülnek, a getterek általában a tömbben
lévő első elemre vonatkoznak.

Manipulálni az elemek attribútumait, tartalmát, stílustulajdonságait lehet, valamint
elemeket létrehozni, áthelyezni, törölni. A jQuery könyvtár támogatja az AJAX hívásokat,
amik gyakorlatilag aszinkron HTTP kérések. Ez azt jelenti, hogy a háttérben történik
egy HTTP kérés, és amikor ennek eredménye megérkezik, akkor azt felhasználja, mindezt
az oldal újratöltése nélkül.

#### $.ajax

Az ```$.ajax()``` az összes jQuery által küldött AJAX-kérés alapjául szolgál. Sokszor
azonban felesleges ezt a függvényt direktben meghívni, mivel léteznek magasabb szintű,
egyszerűbben használható alternatívái (mint a ```$.get()``` és a ```$.load()```).
Viszont, ha ritkábban használt beállításokra is szükség lenne (a ```settings```
PlainObject típusú paraméterben), akkor az ```$.ajax()``` rugalmasabban használható,
mint a felsorolt többi függvény.

*Leírás*: Végrehajt egy aszinkron HTTP (AJAX) kérést és egy **jqXHR** objektummal tér
vissza, ami a szabványos XMLHttpRequest objektumból származik (annak kibővítése).

*Szintaxis:* ```$.ajax(url[, settings])``` a jQuuery 1.5 verziótól, előtte: ```$.ajax(settings)```
(az url nem volt külön paraméter, hanem a **settings** objektum egyik tulajdonsága,
csak az 1.5 jQuery választotta külön).

*Paraméterei:*

* **url** (kötelező): String típusú érték, amely a kérés célpontját határozza meg
(ez általában a szerveren futó dinamikus weboldal URL-je).
* **settings** (opcionális): [PlainObject](https://api.jquery.com/Types/#PlainObject)
típusú (*tulajdonképpen egy kulcs/érték párokat tartalmazó mezei JavaScript objektum,
amit azért becéznek ```PlainObject```-nek, hogy megkülönböztessék a többi JS objetum-típustól*)
érték, ami az AJAX-kérés felkonfigurálásához szükséges beállításokat tartalmazza,
```kulcs:érték``` párok formájában. Ha a **settings** paramétert mellőzzük, akkor az
alapértelmezett beállítások lesznek felhasználva, melyeket a [$.ajaxSetup](https://api.jquery.com/jQuery.ajaxSetup/)
metódussal lehet módosítani (használata azonban ellenjavallott). Alább a **settings**
objektum néhány fontosabb tulajdonsága (bármelyik szabadon elhagyható, akár az egész
objektum is):
	* **beforeSend** (Function): a HTTP kérés elküldése előtt futtatandó függvény
	* **contentType** (String vagy Boolean): megfelel a 'Content-Type' HTTP fejlécnek,
	illetve a HTML form elem *enctype* tulajdonságának, nem kell birizgálni (alapértelmezett
	érték: ```application/x-www-form-urlencoded; charset=UTF-8```)
	* **complete****** (Function): akkor hívódik meg, ha a lekérés befejeződött,
	és a **success** illetve **error** függvények már lefutottak. 2 paramétere van:
	jqXHR (jqXHR objektum) és a textStatus (String). A jQuery 3.0 változatától nem
	használható, helyette a ```jqXHR.always(function(data|jqXHR, textStatus, jqXHR|errorThrown) { }); ```
	alkalmazadó (az	```$.ajax()``` által visszaadott jqXHR objektumon), a szintaxisban
	feltüntetett kibővített paraméterlistával.
	* **data** (PlainObject vagy String vagy Array):  a kiszolgáló felé küldendő
	adatokat tartalmazza. Ha string-ről van szó, akkor azt a jQuery átalakítja
	lekérdezés (query) string-é. Javascript objektum esetén kulcs érték pároknak
	kell lennie a tartalmának. Tömb esetén szerializálni kell.
	* **dataType** (String): a visszaküldött adatok adattípusát adhatjuk meg itt
	(lehetséges értékei: text, html, xml, json, jsonp, script).
	* **error** (Function): akkor hívódik meg, ha a HTTP kérés sikertelen. 3 paramétere
	van: jqXHR (jqXHR objektum), textStatus (String), errorThrown (String). A jQuery
	3.0 változatától nem használható, helyette a ```jqXHR.fail(function( jqXHR, textStatus, errorThrown ) {});```
	alkalmazadó (az	```$.ajax()``` által visszaadott jqXHR objektumon), ugyanazokkal
	a paraméterekkel.
	* **method** (String): az alkalmazott HTTP metódus (alapértelmezett érték: GET)
	* **success** (Function): akkor hívódik meg, ha a HTTP kérés sikeres. 3 paramétere
	van: data (Object, ami tartalmazza a kiszolgálóról érkezett adatokat), textStatus
	(String), és jqXHR (jqXHR objektum). A jQuery 3.0 változatától nem használható,
	helyette a ```jqXHR.done(function(data, textStatus, jqXHR) {});``` alkalmazadó (az
	```$.ajax()``` által visszaadott jqXHR objektumon), ugyanazokkal a paraméterekkel.
	* **type** (String): az alkalmazott HTTP metódus, a JQuery 1.9.0 előtti változataiban
	a *method* megfelelője (alapértelmezett érték: GET).

A **settings** objektumnak még számos lehetséges tulajdonsága van, ezek megtalálhatók
a [dokumentációban](https://api.jquery.com/jquery.ajax/).

Példakód:

```javascript

var menuId = $( "ul.nav" ).first().attr( "id" );
var request = $.ajax({
  url: "script.php",
  method: "POST",
  data: { id : menuId },
  dataType: "html"
});
 
request.done(function( msg ) {
  $( "#log" ).html( msg );
});
 
request.fail(function( jqXHR, textStatus ) {
  alert( "Request failed: " + textStatus );
});

```

#### $.get

*Leírás*: adatokat tölt le a szerverről HTTP GET metódus használatával és egy
**jqXHR** objektummal tér vissza.

*Szintaxis:* ```$.get(URL[, data] [, function(data, textStatus, jqXHR)] [, dataType])```

*Paraméterei:*

* **URL** (kötelező): String típusú érték, amely a kérés célpontját határozza meg
(ez általában a szerveren futó dinamikus weboldal URL-je).
* **data** (opcionális): : PlainObject vagy String típusú érték, a kiszolgáló felé
küldendő adatokat tartalmazza.
* **function** (opcionális): függvény, amely akkor hívódik meg, ha a HTTP kérés
sikeres. 3 paramétere van: data (Object, ami tartalmazza a kiszolgálóról érkezett
adatokat), textStatus (String), és jqXHR (jqXHR objektum).
* **dataType** (opcionális): String típusú érték, melyben a visszaküldött adatok
adattípusát adhatjuk meg (lehetséges értékei: text, html, xml, json, jsonp, script).

Példakód:

```javascript

$.get("example.php", function() {
  alert("sikeres");
})
  .done(function() {
    alert("sikeres másodszor");
  })
  .fail(function() {
    alert("hiba");
  })
  .always(function() {
    alert("befejezve");
  });

```

#### $.post

*Leírás*: adatokat küld a szervernek HTTP POST metódus segítségével és egy
**jqXHR** objektummal tér vissza.

*Szintaxis:* ```$.post(URL[, data] [, function(data, textStatus, jqXHR)] [, dataType])```

*Paraméterei:*

* **URL** (kötelező): String típusú érték, amely a kérés célpontját határozza meg
(ez általában a szerveren futó dinamikus weboldal URL-je).
* **data** (opcionális): : PlainObject vagy String típusú érték, a kiszolgáló felé
küldendő adatokat tartalmazza.
* **function** (opcionális): függvény, amely akkor hívódik meg, ha a HTTP kérés
sikeres. 3 paramétere van: data (Object, ami tartalmazza a kiszolgálóról érkezett
adatokat), textStatus (String), és jqXHR (jqXHR objektum).
* **dataType** (opcionális): String típusú érték, melyben a visszaküldött adatok
adattípusát adhatjuk meg (lehetséges értékei: text, html, xml, json, jsonp, script).

Példakód:

```javascript

$.post( "test.php", { name: "John", time: "2pm" })
  .done(function( data ) {
    alert( "Data Loaded: " + data );
  });

```


#### $.getJSON

*Leírás*: JSON formátumú adatokat tölt le a szerverről HTTP GET metódus használatával
és egy **jqXHR** objektummal tér vissza.

*Szintaxis:* ```$.getJSON(URL[, data][, function(data, textStatus, jqXHR)])```

*Paraméterei:*

* **URL** (kötelező): String típusú érték, amely a kérés célpontját határozza meg
(ez általában a szerveren futó dinamikus weboldal URL-je).
* **data** (opcionális): : PlainObject vagy String típusú érték, a kiszolgáló felé
küldendő adatokat tartalmazza.
* **function** (opcionális): függvény, amely akkor hívódik meg, ha a HTTP kérés
sikeres. 3 paramétere van: data (Object, ami tartalmazza a kiszolgálóról érkezett
adatokat), textStatus (String), és jqXHR (jqXHR objektum).

Példakód:

```javascript

$.getJSON( "test.js", { name: "John", time: "2pm" } )
  .done(function( json ) {
    console.log( "JSON Data: " + json.users[ 3 ].name );
  })
  .fail(function( jqxhr, textStatus, error ) {
    var err = textStatus + ", " + error;
    console.log( "Request Failed: " + err );
});

```


#### $.load

*Leírás*: adatokat tölt le a szerverről, majd elhelyezi őket a kiválasztóban
megjelölt HTML elemben. Ez a metódus a legegyszerűbb módja az adatletöltésnek.

*Szintaxis:* ```$(kiválasztó).load(url[, data][, function(response, textStatus, jqXHR)])```

*Paraméterei:*

* **URL** (kötelező): String típusú érték, amely a kérés célpontját határozza meg
(ez általában a szerveren futó dinamikus weboldal URL-je).
* **data** (opcionális): : PlainObject vagy String típusú érték, a kiszolgáló felé
küldendő adatokat tartalmazza.
* **function** (opcionális): függvény, amely akkor hívódik meg, ha a HTTP kérés
sikeres. 3 paramétere van: response (String, ami tartalmazza a kiszolgálóról érkezett
adatokat), textStatus (String), és jqXHR (jqXHR objektum).

Példakód:

```html

<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <title>load demo</title>
  <style>
  body {
    font-size: 12px;
    font-family: Arial;
  }
  </style>
  <script src="https://code.jquery.com/jquery-3.5.0.js"></script>
</head>
<body>
 
	<b>Projects:</b>
	<ol id="new-projects"></ol>
	<!-- ide kerülnek a letöltött adatok -->
	<script>
		$( "#new-projects" ).load( "/resources/load.html #projects li" );
	</script>
 
</body>
</html>

```


## 7. A PHP nyelv szerepe a webfejlesztésben

A **PHP (PHP: Hypertext Preprocessor)** erőteljes szerver-oldali szkriptnyelv, jól
alkalmazható dinamikus és interaktív weboldalak elkészítéséhez. Az első szkriptnyelvek
egyike, amely külső fájl használata helyett HTML oldalba ágyazható. A PHP
oldalak elkészítésénél a HTML-t gyakorlatilag csak mint formázást használják.
Ezen lapok teljes funkcionalitása a PHP-re épül. Amikor egy PHP-ben megírt oldalt
akarunk elérni, a kiszolgáló először feldolgozza a PHP utasításokat, és csak a
kész (HTML) kimenetet küldi el a böngészőnek. Így kliensoldalról nem látható a
programkód. A feldolgozáshoz egy ún. interpretert (értelmezőt) használ, amely
általában a webszerver egy külső modulja. A kódot az értelmező futás közben fordítja,
és azonnal végre is hajtja. A kódok végezhetnek adatbázis-lekérdezéseket,
létrehozhatnak képeket, fájlokat olvashatnak és írhatnak, kapcsolatot létesíthetnek
távoli kiszolgálókkal. A PHP-kódok kimenete a megadott HTML elemekkel együtt kerül
az ügyfélhez.

A PHP-t [Rasmus Lerdorf](https://en.wikipedia.org/wiki/Rasmus_Lerdorf) dán programozó agyalta ki valamikor 1994 őszén. Az első
kiadatlan verziókat a saját honlapján használta, hogy figyelemmel kísérje, kik
látogatják az oldalait. Ez a verzió még nem önálló programozási nyelv volt, csupán
a weblapok programozott előállítását megkönnyítő, Perl-szkriptekből álló makrógyűjtemény.
Egy nagyon egyszerű feldolgozó programból állt, ami csak néhány speciális makrót
értett meg, valamint tartalmazott számos eszközt, amiket akkoriban gyakran használtak
a honlapokon (számláló, vendégkönyv és hasonlók).

A PHP-t Lerdorf még 1995-ben kibővítette egy HTML-űrlap-feldolgozóval (*Form Interpreter*) és
*miniSql* adatbázis-kezelő rendszer elérését biztosító függvényekkel. A program
nevét ez után változtatta PHP/FI-re (PHP/FI 2.). Az új, C nyelven megírt változat
képes volt adatbázisokhoz kapcsolódni és segítségével egyszerű dinamikus weboldalakat
is létre lehetett hozni. Lerdorf **1995. június 8-án adta ki a PHP első nyilvános
változatát**, hogy külső segítséggel gyorsabbá tegye a hibák megtalálását és a kód
további fejlesztését. Ez a verzió volt a PHP 2 (Personal Home Page Tools) és már
megtalálhatóak voltak benne a mai PHP alapvető tulajdonságai: a [Perl](https://hu.wikipedia.org/wiki/Perl_(programoz%C3%A1si_nyelv))-éhez hasonló
változók, az űrlapok kezelése és a HTML-kód beszúrásának lehetősége. A szintaktikája
is hasonló volt a Perl-éhez, de annál jóval korlátoltabb, egyszerűbb és kevésbé
egységes volt.

A program bámulatos ütemben fejlődött, és az emberek elkezdték kódokkal segíteni
a fejlesztést. 1997-ben Lerdorf, [Zeev Suraski](https://en.wikipedia.org/wiki/Zeev_Suraski)
és [Andi Gutmans](https://en.wikipedia.org/wiki/Andi_Gutmans) szinte teljesen átírta
a programkódot. A PHP hivatalos neve ezzel egy időben **PHP: Hypertext Preprocessor**-ra
változott. A fejlesztők ezzel is jelezték, hogy a PHP a fejlesztés nyomán önálló,
elsősorban webalkalmazások készítésére alkalmas, szerveroldali programozási nyelvé
alakult.

Az PHP-t azt követően is többször átírták. A nyelv funkciói egyre bővültek, ugyanakkor
hatékonysága is jelentősen nőtt. 1998 júniusában Suraski és Gutmans megint a PHP-mag
újraírása mellett döntött, amiből 1999-ben megszületett a Zend Engine.
A két fejlesztő ekkor alapította meg a [Zend Technologies](https://en.wikipedia.org/wiki/Zend_(company))-t,
ami máig aktívan ellenőrzi a PHP fejlesztését.

A Zend Engine 1.0 által hajtott PHP 4.0 2000. május 4-én jelent meg. Ezt követte 2004.
július 13-án a következő nagy mérföldkőnek számító, az új Zend Engine 2-n alapuló PHP 5.0
Az ötös verzió sok újítást tartalmazott: fejlettebb objektumorientált programozási
lehetőségeket, a *PDO (PHP Data Objects)* adatbázis-absztrakciós kiterjesztést, és
sok teljesítményt növelő javítást is. A nyelv régen várt 6. verziója sohasem készült el,
helyette 2015 december 3-án megérkezett a 7.0, majd 2020. november 26-án a 8.0. Jelenleg
a 8. a főverzió, de még a 7.4 is aktívan támogatott, a 7.3-hoz viszont már csak
biztonsági frissítések várhatók. 

A PHP nyelv szabad, de licence kimondja, hogy a származtatott termékek nem használhatják
nevükben a PHP szót a group@php.net írásos engedélye nélkül. Emiatt a PHP licenc nem
csereszabatos a [GNU General Public License](https://hu.wikipedia.org/wiki/GNU_General_Public_License)-szel.

### 7.1 A PHP nyelvtana, felhasználási területei

Bár a PHP-t alapvetően a webes környezet ihlette, ez egy általános szkriptnyelv,
melyet sokféle környezetben lehet felhasználni. Egyre gyakrabban használják parancssori
feladatok elvégzésére (parancssori interfész, angolul *Command Line Interface – CLI*),
amellyel klasszikus szkriptnyelveket, például [shell szkriptet](http://web.cs.elte.hu/linfo/Shell/script.html)
vagy a [Perlt](https://hu.wikipedia.org/wiki/Perl_(programoz%C3%A1si_nyelv)) váltják ki.
Népszerűsége kapcsán olyan területeken is megjelenik, amely távol áll eredeti céljától.
Ilyen például grafikus asztali alkalmazások programozása, amely egy külön projekt, a
[PHP-GTK](https://gtk.php.net/) segítségével válik lehetővé.

Természetesen leggyakrabban dinamikus weboldalak készítéséhez használják. Ekkor a
```.php``` kiterjesztésű állományt a webszerveren kell elhelyezni. A PHP telepítésétől
függően két lehetséges helyre kerülhet. Ha a PHP CGI módban van telepítve, akkor a
*cgi-bin* könyvtárba szükséges a futtatandó fájlt elhelyezni. Sokkal hatékonyabb
kiszolgálást kapunk azonban akkor, ha a PHP szerver modulként van feltelepítve.
Ekkor ugyanis nem külön folyamat (process), hanem csak külön szálként (thread) indul
el az értelmező, ami az operációs rendszer szempontjából gyorsabban megvalósítható.
Ekkor a PHP állományok bárhol elhelyezkedhetnek a publikus dokumentumaink között. 

#### Nyelvtan

A PHP egy gyengén típusos, értelmezett, általános célú, C-típusú szkriptnyelv, amely
sokat merített a Perlből (pl. változók ```$``` jellel való jelölése), a C++-ból és a
Javából, például az ```if``` feltételes utasítást, a ```for``` és a ```while``` ciklusokat.
Az osztályok megalkotása a C++-t, az absztrakt osztályok és az öröklődés megvalósítása
a Javát idézi.

A PHP állományok tipikus kiterjesztése a ```.php```, de előfordul, hogy más kiterjesztésű
fájlok (pl. ```.inc```) is tartalmaznak PHP kódot. Igazából a kiterjesztés mindegy is,
a PHP értelmező a fájl tartalma alapján végzi el a végrehajtást. Egy PHP állományban
a PHP kódot ```<?php``` és ```?>``` elemek közé kell helyezni. A legegyszerűbb esetben
a fájl egyetlen ilyen elempárt tartalmaz, egy fájlban azonban több ilyen PHP blokk
is elhelyezkedhet. Amikor a PHP értelmező feldolgoz egy fájlt, akkor a nyitó és a
záró tag-eket keresi, amelyek megmondják neki, hogy kezdje el ill. fejezze be a
közöttük lévő kód értelmezését. Ez teszi lehetővé azt, hogy a PHP kódokat HTML
dokumentumba lehessen ágyazni, mivel **a blokkon belüli rész értelmezésre, az a szövegrész
pedig, ami PHP blokkon kívül helyezkedik el, automatikusan kiírásra kerül**. 

A PHP tartalmaz még egy *short echo* néven ismert cimkepárt is (```<?=``` és ```?>```),
amelyet főleg template-fájlokban használnak egy-egy változó értékének a kiíratására.

```php

<?= 'Írd ki ezt a szöveget!' ?>

#egyenértékű ezzel a kifejezéssel:

<?php echo 'Írd ki ezt a szöveget!' ?>

```

A záró tag a fájl végén opcionális, egyes esetekben az elhagyása hasznos (pl. több
fájlból felépülő projekt, ahol ```include()``` vagy ```require()``` segítségével
illesztjük be az egyes - kizárólag php kódot tartalmazó - forrásállományokat). Ahol
viszont a php kód és a html tartalom egy állományban szerepel, mindig ki kell tenni
a záró tag-et is.

A nyelv néhány jellemzője:

* Kis- és nagybetű érzékeny, akárcsak a többi C alapú nyelv.
* Az utasításokat pontosvessző zárja le.
* Klasszikus objektumorientált nyelv, osztályokkal, interfészekkel.
* Nincs főprogram, akárcsak JavaScriptben, a szkript elején kezdődik az értelmezés
és fentről halad lefelé.
* Az egysoros megjegyzéseket ```#``` vagy ```//``` jel után, a többsorosakat pedig
```/*``` és ```*/``` jelek közé kell írni.

```php

<?php

//egysoros megjegyzés
  
# Perl szintaktikájú egysoros megjegyzés
  
/*
többsoros
megjegyzés
*/

?>

```

#### Adattípusok

*Elemi (vagy skaláris) adattípusok:*

* **logikai (bool)**: két értéke van (nem kis- és nagybetű érzékeny), ```true``` és ```false```
* **egész szám (int)**: megadhatók bináris, oktális, decimális és hexadecimális értékek
* **lebegőpontos szám (float, más néven double)**:
* **szöveg (string)**: PHP-ban sokféleképpen lehet szöveget megadni. Legegyszerűbb
esetben a szöveget aposztrófok között adjuk meg. Ekkor a PHP semmiféle további
feldolgozást nem végez. Ha macskakörmök közé rakjuk a szöveget, akkor egyrészt a
szokásos escape szekvenciák értelmeződnek (pl. ```\t```, ```\n```, stb.), másrészt
a szövegben lévő változók értékei is automatikusan behelyettesítésre kerülnek. Mindkét
megadási mód támogatja többsoros szövegek bevitelét. A fenti megadási módok alternatívája
a nowdoc és heredoc formátum. Ezeknél egy tetszőlegesen megadott token nyitó és zárópárja
között adjuk meg a szöveget. A nyitótokent ```<<<``` előzi meg, a zárótokennek a sor
elején kell lennie egyedüli szövegként a sorban. A nowdoc formátum az aposztrófos megadás,
a heredoc a macskakörmös megadás viselkedését örökli.
```php
<?php
$a = 12;
  
'alma\t{$a} alma';          //"alma\t{$a} alma"
'Több
sor is lehet benne';
  
"alma\t{$a} alma";          //"alma   12 alma"
"Ez egy
több soros szöveg";
  
<<<'EOT'                    //"Ez is lehet {$a}
Ez is lehet {$a}            // több soros"
több soros.
EOT;
  
<<<EOT                      //"Több soros 12
Több soros {$a}             // szöveg"
szöveg
EOT;
?>
```

*Összetett adattípusok:*

* **tömb (array)**:  szabadon változtatható méretű dinamikus struktúra, melynek elemei
kulcs-érték párokból állnak. **A kulcs egész szám vagy szöveg, az érték bármilyen
típusú lehet**. A PHP-s tömb ilyen jellegű rugalmassága teszi lehetővé, hogy PHP-ban
a gyűjtemények általános objektuma legyen. Segítségével gyakorlatilag az összes
ismert összetett adatszerkezet leírható, megvalósítható: rekord, indexelt tömb,
asszociatív tömb, többdimenziós tömb, mátrix, fa, sor, verem, stb. Természetesen
ezek az adatszerkezetek tetszőleges mélységben egymásba ágyazhatók a leírandó adatnak
megfelelően.
* **objektum (object)**: objektum létrehozására a ```new``` operátor való, amely
az adott objektumtípus egy példányát hivatott létrehozni.
* **hívható (callable)**: ál-típus, amelyet a PHP 5.4-ben vezettek be. Olyan kód,
amely függvényként hívható és a neve szöveges paraméterként átadható, pl a
```call_user_func()``` beépített függvénynek.
* **bejárható (iterable)**: ál-típus, amelyet a PHP 7.1-ben vezettek be. Minden
olyan tömböt vagy objektumot elfogad, amely implementálja a *Traversable* interfészt
és ```foreach``` ciklus segítségével bejárható.

*Speciális típusok:*

* **erőforrás (resource)**: egy olyan speciális változó, ami referenciát tartalmaz
valamilyen külső erőforrásra, mint például fájl, adatbázis kapcsolat, hálózati
kapcsolat, stb. Az erőforrásokat speciális függvények hozzák létre és használják. 
* **null**: a speciális NULL érték jelzi, hogy egy változó nem tartalmaz értéket.
A NULL a null egyetlen lehetséges értéke. Egy változó NULL-nak tekintendő, ha
	* a NULL állandó értéke lett hozzárendelve.
	* ha még semmilyen érték nem lett hozzárendelve.
	* ha az ```unset()``` függvény törölte.

### 7.2 Változók

A PHP gyengén típusos nyelv, ezért nem követeli meg (és nem is támogatja) az explicit
típusdefiníciót a változók deklalárásakor; egy változó típusát a környezet határozza
meg, amiben a változót használjuk. Ebből kifolyólag a PHP nyelvben a változókat
használatuk előtt nem kell deklarálni, viszont célszerű egy kezdő értékadással
bevezetni használatukat. Az értékadás és paraméterátadás alapesetben érték szerint
történik, de lehetőség van referencia szerinti átadásra is (a változó neve elé írt
```&``` karakterrel). A referencia szerinti értékhozzárendelés azt jelenti, hogy
mindkét változó ugyanarra az adatra fog mutatni, és nem történik meg a változó
értékének lemásolása.

```php

<?php

$foo = 'Bob';              // $foo változó értéke legyen 'Bob'
$bar = &$foo;              // Hivatkozás $foo-ra $bar-ban ($bar értéke $foo lesz)
$bar = "Nevem $bar";       // $bar megváltoztatása...
echo $foo;                 // $foo is megváltozik.
echo $bar;

?>

```

A változók nevét a a Perl nyelvhez hasonlóan a ```$``` karakter vezeti be, például:
```$valtozo```. A változónevek case sensitiv-ek, vagyis kisbetű-nagybetű érzékenyek.
A változónevekre a PHP más jelzőivel azonos szabályok vonatkoznak. Egy érvényes
változónév csak ASCII karaktereket tartalmazhat, betűjvel vagy aláhúzással kezdődik,
amit tetszőleges számú betű, szám vagy aláhúzás követ.

Hatókört illetően a függvényen és osztályon kívül létrehozott változók **globálisak**
lesznek, a függvényen belül létrehozottak **lokálisak**. Más szavakkal: a változó a
függvényen kívülről vagy más függvényekből nem lesz elérhető. Viszont a függvényen
kívül meghatározott változó sem érhető el automatikusan a függvényen belülről. A
PHP-ben a globális változókat ```global``` kulcsszóval deklarálni kell a függvényekben,
ha szeretnénk őket a függvényben is használni. Globális változók elérésének másik
módja a PHP által definiált speciális ```$GLOBALS``` szuperglobális tömb használata.
A ```$GLOBALS``` tömb egy asszociatív tömb, ahol a globális változó neve a kulcs,
és a változó az értéke. *Megjegyzendő, hogy egy függvénynek átadott paraméter általában
valamilyen érték másolata, a paraméter megváltoztatásának a függvény vége után semmilyen
hatása nincs. Ha azonban egy globális változó értékét változtatjuk meg egy függvényen
belül, akkor az eredeti változót változtattuk meg és nem egy másolatot.*

A PHP a ```$GLOBALS``` tömbön kívül definiál még néhány szuperglobális változót,
amelyek mindenhonnan elérhetőek. A felhasználható előre definiált változók listája
függ a szkript környezetétől (pl. webszerveren fut-e a PHP vagy esetleg különálló
programként), a PHP verziószámától és a webszerver típusától.

### 7.3 Konstansok

Az állandó a PHP-ben egy előre meghatározott érték azonosítója. Olyan, mint a változó,
azt a két dolgot kivéve, hogy konstans a ```define()``` függvénnyel hozható létre
és később nem módosítható. Az állandók nevei is kis/nagybetű érzékenyek, bár nem
előírás, de a programozói gyakorlat szerint csupa nagybetűvel írjuk őket. Az állandók
nevei az angol abc betűit, valamit az ASCII kódtábla 128-255. elemeit tartalmazhatják
(pl. aláhúzás jelet igen, de kötőjelet nem), mindig betűvel, vagy aláhúzás jellel
kell kezdődniük. Fontosabb különbségek a változókhoz képest:
* Az állandók nevei elé nem tesszük ki a ```$``` dollárjelet.
* Az állandók a scriptben bárhol definiálhatók, és bárhonnan elérhetők, a változók
környezeti korlátozásaitól függetlenül (szuperglobálisak).
* Az állandók értéke létrehozásuk után nem módosítható és nem törölhető.
* Az állandók skaláris értékeket (boolean, integer, float vagy string) és tömböt
(PHP 7.0 óta) tartalmazhatnak.

Állandót a PHP ```define()``` beépített függvényével lehet létrehozni. A függvény
globális hatókörben és függvényekben használható, osztály meződefinícióban nem.

```php
define (string $nev, mixed $ertek, bool $nem_kisbetu_nagybetu_erzekeny = false) : bool
```

Osztályállandó létrehozására a ```const``` kulcsszó használható.

```php
const ALLANDO_NEVE = "érték, ami lehet boolean, integer, float, string vagy tömb";
```

A PHP nyelv tartalmaz jó-néhány előre meghatározott konstanst. A fontosabbak:

| Állandó | Típus | Leírás | Lehetséges értékek |
|---------|-------|--------|--------------------|
| ```PHP_VERSION``` | string | a szerveren futó PHP verziószáma | pl. ```"8.0.0-extra"``` |
| ```PHP_OS_FAMILY``` | string | Az operációs rendszer, ami alatt a PHP fut | ```'Windows', 'BSD', 'Darwin', 'Solaris', 'Linux', 'Unknown'``` |
| ```PHP_SAPI``` | string | A webszerver és a PHP közötti interfész típusa | ```'apache', 'apache2handler', 'cgi', 'cgi-fcgi', 'cli', 'cli-server', 'embed', 'fpm-fcgi', 'litespeed', 'phpdbg'``` |
| ```true``` | bool | Logikai igaz érték | ```true``` |
| ```false``` | bool | Logikai hamis érték | ```false``` |
| ```null``` | null | Null érték | ```null``` |
| ```DIRECTORY_SEPARATOR``` | string | Operációs rendszer-függő könyvtárelválasztó karakter | ```/``` (Unix) vagy ```\``` (Windows) |
| ```PHP_EOL``` | string | Operációs rendszer-függő 'End Of Line' (sorvég, újsor) karakter | ```\n``` (Unix) vagy ```\r\n``` (Windows) |
| ```E_ERROR``` | int | Az ```error_reporting()``` függvényben használni kívánt hibajelentési szint megadására szolgál (nem feldolgozás során keletkezett helyrehozhatatlan hiba) | ```1``` |
| ```E_WARNING``` | int | Az ```error_reporting()``` függvényben használni kívánt hibajelentési szint megadására szolgál (figyelmeztetés, ami nem akadályozza meg a kód végrehajtását) | ```2``` |
| ```E_PARSE``` | int | Az ```error_reporting()``` függvényben használni kívánt hibajelentési szint megadására szolgál (szintaktikai hiba) | ```4``` |
| ```E_NOTICE``` | int | Az ```error_reporting()``` függvényben használni kívánt hibajelentési szint megadására szolgál (lehet, hogy hiba, de lehet, hogy nem, ami nem akadályozza meg a kód végrehajtását) | ```8``` |
| ```E_ALL``` | int | Az ```error_reporting()``` függvényben használni kívánt hibajelentési szint megadására szolgál (Minden ```E_*``` formátumú hiba) | ```32767``` |

Különleges, úgynevezett [mágikus állandók](https://www.php.net/manual/en/language.constants.magic.php) (a nevük minden esetben dupla aláhúzás karakterrel kezdődik):

* ```__LINE__```: Az aktuális scripten belüli sor száma. Ha includdal, vagy require-ral
behívott file-ra alkalmazzuk, az include-olt file-on belüli pozíciót kapjuk.
* ```__FILE__```: A script file neve. Ha egy olyan file-on belül használjuk, amelyet
include-oltunk, vagy require-ral rakjuk be, akkor az include-olt file nevét kapjuk,
nem a futtatott scriptét.
* ```__DIR__```: A könyvtár neve, ahol a script található. Ha egy olyan file-on belül használjuk,
amelyet include-oltunk, vagy require-ral rakjuk be, akkor az include-olt file-t
tartalmazó könyvtár nevét kapjuk, nem a futtatott scriptét.
* ```__FUNCTION__```: A függvény neve.
* ```__CLASS__```: Az osztály neve.
* ```__TRAIT__```: Aktuális trait neve
* ```__METHOD__```: Az osztály metódusának neve.
* ```__NAMESPACE__```: Az aktuális névtér
* ```ClassName::class```: Teljesen minősített osztálynév


### 7.4 Operátorok

Az [operátorokat](https://www.php.net/manual/en/language.operators.php) csoportosíthatjuk operandusaik (az értékek, melyeken valamilyen
műveletet végzünk) száma (egy vagy több), típusa (aritmetikai, logikai, típus),
illetve az operátor által végeztt művelet jellege (hozzárendelő, összehasonlító,
hibakezelő, értékadó) szerint.

**Aritmetikai operátorok**

Az aritmetikai operátorok a matematikából ismert feladatukat látják el (*összeadás*: ```+```,
*kivonás*: ```-```, *szorzás*: ```*```, *osztás*: ```/```). Az osztás operátor ("/")
mindig lebegőpontos számot ad eredményül, kivéve, ha mindkét operandus egész típusú
vagy egész típusúvá alakított string, illetve abban az esetben, ha a két operandus
maradék nélkül osztható. A maradékos osztás operátora a ```%```, melynek segítségével
az osztási művelet maradékát kapjuk meg (```$result = 5 % 2; #$result értéke: 1```).

A PHP **értékadó operátora**: ```=``` (egyenlőségjel), azt jelenti, hogy a bal oldali
operandus a jobb oldali kifejezést kapja értékül. Annak ellenére, hogy valójában csak
egy hozzárendelő művelet van, a PHP számos további **hozzárendelő operátort** biztosít,
amelyek a bal oldali operandust módosítják. A műveletek az operandusokat általában nem
változtatják meg, ez alól azonban a hozzárendelés kivétel. Az összetett hozzárendelő
operátorok egy hagyományos aritmetikai műveletjelből és az azt követő értékadó operátorból
állnak, az alábbiak szerint:

| Operátor | Példakód | Egyenértékű kifejezés |
|----------|----------|-----------------------|
| ```+=``` | ```$x += 5;``` | ```$x = $x + 5;``` |
| ```-=``` | ```$x -= 5;``` | ```$x = $x - 5;``` |
| ```*=``` | ```$x *= 5;``` | ```$x = $x * 5;``` |
| ```/=``` | ```$x /= 5;``` | ```$x = $x / 5;``` |
| ```%=``` | ```$x %= 5;``` | ```$x = $x % 5;``` |
| ```.=``` | ```$x .= 'valami szöveg';``` | ```$x = $x.'valami szöveg';``` |

**Bitorientált operátorok**

A **bitorientált operátorok** teszik lehetővé, hogy egész típusú számokon belül
bizonyos biteket beállítsunk, vagy lefedjünk (maszkolás). Ha viszont az operátor
mindkét oldalán sztring típusú változó áll, akkor az a sztringek karakterein dolgozik
úgy, hogy a karakterek ASCII kódjain végzi el a műveletet, és az eredményül kapott
számot ASCII kóddal megadott karakternek értelmezi.

| Operátor | Név | Példa | Eredmény | Leírás | 
|----------|-----|-------|----------|--------|
| ```&``` | And | ```0011 & 0101``` | ```0001``` | Az eredményben azon a helyiértéken lesz 1, ahol minkét operandusnál 1 áll, egyébként 0. |
| ```\|``` | Or | ```0011 \| 0101``` | ```0111``` | Az eredményben azon a helyiértéken lesz 1, ahol legalább az egyik operandusnál 1 áll, egyébként 0. |
| ```^``` | Xor | ```0011 ^ 0101``` | ```0110``` | Az eredményben azon a helyiértéken lesz 1, ahol csakis az egyik operandusnál áll 1, egyébként 0. |
| ```~``` | Not | ```~0101``` | ```1010``` | Az összes bitet invertálja |
| ```<<``` | Balra tolás | ```00110101 << 2``` | ```11010100``` | A bal oldali operandus bitjeit a jobb oldali operandusban megadott számú bittel balra tolja (minden bitnyi eltolás 2-vel való szorzást jelent).  |
| ```>>``` | Jobbra tolás | ```00110101 >> 2``` | ```00001101``` | A bal oldali operandus bitjeit a jobb oldali operandusban megadott számú bittel jobbra tolja (minden bitnyi eltolás 2-vel való egész-osztást jelent).  |

**Összehasonlító operátorok**

Az **összehasonlító operátorok** az operandusokon vizsgálatokat végeznek. A PHP 7.0 változatában
bevezetett kombinált összehasonlítás operátor (vagy "űrhajó operátor") kivételével
logikai értékkel térnek vissza, vagyis értékük ```true``` lesz, ha a feltételezett viszony
fennáll, és ```false```, ha nem. Az "űrhajó operátor" (```<=>```) célja, hogy egyszerűsítse
az összehasonlító kódrészleteket.

```php
$x = 10;
```

| Operátor | Név | Igaz, ha | Példa | Eredmény |
|----------|-----|--------|-------|----------|
| ```==``` | Egyenlő | a két érték megegyezik | ```$x == 5;``` | ```false``` |
| ```===``` | Azonos | a két érték és típus megegyezik | ```$x === 10;``` | ```true``` |
| ```!=``` vagy ```<>``` | Nem egyenlő | a két érték különböző | ```$x != 8;``` | ```true``` |
| ```!==``` | Nem azonos | a két érték vagy típus különböző | ```$x !== "tíz";``` | ```true``` |
| ```<``` | Kisebb, mint | a bal oldal kisebb a jobb oldalnál | ```$x < 20;``` | ```true``` |
| ```>``` | Nagyobb, mint | a bal oldal nagyobb a jobb oldalnál | ```$x > 20;``` | ```false``` |
| ```<=``` | Kisebb, vagy egyenlő | a bal oldal kisebb a jobb oldalnál vagy egyenlő vele | ```$x <= 12;``` | ```true``` |
| ```>=``` | Nagyobb, vagy egyenlő | a bal oldal nagyobb a jobb oldalnál vagy egyenlő vele | ```$x >= 12;``` | ```false``` |
| ```<=>``` | Űrhajó | eredménye ```-1```, ha a bal oldali operandus kisebb, mint a jobb oldali, ```0```, ha egyenlőek és ```1```, ha nagyobb | ```$x <=> 12;``` | ```1``` |

Az **összehasonlító operátorok** közé tartozik a három operandusú (ternáris) feltételes
(```?:```, népszerűbb nevén: Elvis) operátor is, amely úgyanúgy működik, mint C-ben és sok
más nyelvben. Két egymástól kettősponttal elválasztott értékből egyet ad vissza
annak a függvényében, hogy teljesül-e a kérdőjel bal oldalán álló feltétel. Amennyiben
a feltétel teljesül (igazzal tér vissza), az operátor a kérdőjel és a kettőspont
közötti, egyébként pedig a kettőspont utáni értékkel tér vissza. Szintaxisa:

```php

feltetel ? "érték, ha feltetel igaz" : "érték, ha feltetel hamis" ;

```

A PHP 7.0 változata óta létezik a feltételes operátornak egy rövidebb változatai is,
a nullával összehasonlító operátor (```??```). Ezt abban az esetben lehet alkalmazni, ha a feltételben
vizsgálnunk kell, hogy egy adott változó létezik-e, mielőtt felhasználnánk az értékét
egy kifejezésben.

```php

/* Megvizsgáljuk, hogy $b létezik-e, ha igen az értékét átadjuk $a-nak, ha nem,
akkor $a értéke a "default" string lesz. */

//Ternáris operátorral:
$a = isset($b) ? $b : "default";

//Ugyan az a kifejezés nullával összehasonlító operátorral:
$a = $b ?? "default";

```

**Hibakezelő operátor**

A PHP egy hibakezelő operátort támogat, az at jelet (```@``` - kukac). PHP kifejezés
elé írva a kifejezés által esetlegesen generált hibaüzenete(ke)t figyelmen kívül
hagyja a rendszer. Használható változók, függvények és ```include()``` hívások, állandók
neve előtt és sok más esetben. Nem használható azonban függvény és osztály definíciók
vagy nyelvi szerkezetek (mint például ```if``` és ```foreach``` utasítások) előtt.
A PHP 8.0.0 előtt a ```@``` hibakezelő operátor kikapcsolja azon kritikus hibák
jelentését is, amelyek megszakítják a szkript futását.

**Végrehajtás-operátor**

A vissza-aposztróf ' ` ' (AltGr+7) operátor használatával ugyanazt érjük el, mintha
a ```shell_exec()``` függvényt használnánk: mindent, amit a két ' ` ' jel közé írunk,
az operációs rendszernek küldi el a php végrehajtásra. Az operációs rendszer válaszát
stringként kapjuk vissza. Ez nem egyszerűen a kimenetre kerül, hanem hozzárendelhető
egy változóhoz.

**Vigyázzunk, nehogy beleessünk abba a hibába, hogy például egy form mezőjén keresztül
várunk egy inputot, amit végrehajtatunk, mivel így a felhasználó azt csinál a
szerverünkkel, amit csak akar.**

**Növelő, csökkentő operátorok**

A PHP támogatja a C-szerű, egy operandusú inkrementáló (```++```) és dekrementáló
(```--```) operátorokat is. Ha az operátor az operandus előtt áll, akkor a PHP
előbb 1-el növeli/csökkenti az operandus értékét, majd visszaadja azt. Ellenben, ha
az operandus után helyzkedik el, akkor előbb megkapjuk az operandus értékét, ezután
történik annak növelése/csökkentése 1-el.

**Logikai operátorok**

| Operátor | Név | Igaz, ha | Példa | Eredmény |
|----------|-----|----------|-------|----------|
| ```and``` | és | mindkét operandus igaz | ```true and false``` | ```false``` | 
| ```or``` | vagy | legalább az egyik operandus igaz | ```true or false``` | ```true``` | 
| ```xor``` | kizáró vagy | kizárólag az egyik operandus igaz | ```true xor true``` | ```false``` | 
| ```!``` | tagadás | az egyetlen operandus hamis | ```!true``` | ```true``` | 
| ```&&``` | és | mindkét operandus igaz | ```true && true``` | ```true``` | 
| ```\|\|``` | vagy | legalább az egyik operandus igaz | ```true \|\| true``` | ```true``` |

Az "és" és a "vagy" operátorok két variációjára a magyarázat az operátorok precedenciájában
keresendő (a betűvel írt változatok később értékelődnek ki).

**String operátorok**

A konkatenáció (összefűzés) jele a pont ```.``` , mindkét operandust karakterláncnak
tekintve, a jobb oldali elemet hozzáfűzi a bal oldalihoz. Az elemek típusuktól függetlenül
karakterláncként értékelődnek ki és az eredmény is mindig karakterlánc lesz. Az
összefűző-hozzárendelő operátor (```.=```) hozzáfűzi a jobb oldalon szereplő szöveges
értéket a bal oldali operandus végéhez.

**Tömb operátorok**

A ```+``` (únió) az egyetlen tömb-operátor PHP-ban. A jobboldali tömböt a baloldalihoz fűzi
úgy, hogy a mindkét tömbben létező kulcsoknál a bal oldali tömb elemeit használják,
és a jobb oldali tömb azonos kulcs által jelölt elemeit figyelmen kívül hagyják.

```php

$a = array("a" => "alma", "b" => "banán");
$b = array("a" =>"körte", "b" => "áfonya", "c" => "cseresznye");

$c = $a + $b;

var_dump($c);
array(3) {
  ["a"]=>
  string(5) "alma"
  ["b"]=>
  string(6) "banán"
  ["c"]=>
  string(6) "cseresznye"
}

```

Tömbökre alkalmazhatók még az egyenlőséget és azonosságot vizsgáló összehasonlító
operátorok is. Az ```==``` operátor pl. azt vizsgálja, hogy a két tömb ugyanazokat
a kulcs-érték párokat tartalmazza-e, míg a ```===``` operátor a kulcs-érték párok
sorrendjét és típusát is ellenőrzi.

**Típus operátor**

A PHP egyetlen típus operátorral rendelkeik, ez az ```instanceof```, amely azt vizsgálja,
hogy a bal oldalán álló változó a jobb oldalon megadott osztály öröklődési fájában
van-e (az öröklési fában lehetnek ős-osztályok és interfészek is).

```php
<?php

$a = 1;
$b = NULL;
$c = imagecreate(5, 5);

var_dump($a instanceof stdClass); // false, mert $a egy egész szám
var_dump($b instanceof stdClass); // false, mert $b értéke NULL
var_dump($c instanceof stdClass); // false, mert $c egy erőforrás

?>
```

Rendelkezik egy beépített függvény változattal is:
```is_a (mixed $object, string $class_name, bool $allow_string = false) : bool```,
amely szintén ```true``` értékkel tér vissza, ha az ```instanceof``` bal oldali
operandusának megfelelő ```$object``` a jobb oldali operandusnak megfelelő ```$class_name```
egy példánya (ha nem, akkor szintén ```false```-t kapunk).


### 7.5 Tömbök

A PHP tömb a Perl-beli megfelelőjéhez hasonlóan működik, ám akadnak komolyabb különbségek.
Míg a Perlben két külön típus volt a *tömb* és a *hasítótábla*, a PHP nyelvben
teljesen ugyanaz a két fogalom, ugyanis az index tetszőleges nem negatív egész szám,
vagy szöveg is lehet, ráadásul ez akár egy tömbön belül is tetszőlegesen változhat.
Ha nem adjuk meg előre a tömb indexeit, akkor 0-tól induló egész sorozat rendelődik
hozzá.

A PHP tömb szabadon változtatható méretű dinamikus struktúra, melynek elemei kulcs-érték
párokból állnak. A PHP tömbjei rendezett leképezéseket valósítanak meg. A leképezés
értékeket rendel kulcsokhoz. A kulcs egész szám vagy szöveg, az érték bármilyen
típusú lehet. Ez a típus sokféleképpen használható, mint egy hagyományos tömb, lista
(vektor), hash tábla, szótár, kollekció, halmaz, sor, és mások. Mivel egy újabb
PHP tömb szerepelhet értékként, könnyen lehet fákat szimulálni.

Egy array (tömb) típusú változót többféleképpen lehet létrehozni:

* ```array()``` nyelvi elemmel, amely egy vagy több vesszővel elválasztott kulcs => érték
párt vár. Ha nem adunk meg kulcsokat, csak a tömb elemeit soroljuk fel, akkor az indexelés
0-ról indul, automatikusan. A vessző az utolsó tömbelem után opcionális, szabadon elhagyható.
```php
//Manuális indexeléssel:
$tomb = array(kulcs1 => érték, kulcs2 => érték2, kulcs3 => érték3,...kulcsN => értékN);
//Automatikus indexeléssel:
$tomb = array(érték, érték2, érték3,...értékN);
```

* ```[]``` (szögletes zárójelben). A JavaScriptből ismerős literálforma a PHP 5.4-es
verziójától kezdve használható. Ha nem adunk meg kulcsokat, csak a tömb elemeit
soroljuk fel, akkor az indexelés itt is 0-ról indul, automatikusan. A vessző az
utolsó tömbelem után opcionális, szabadon elhagyható.
```php
//Manuális indexeléssel:
$tomb = [kulcs1 => érték, kulcs2 => érték2, kulcs3 => érték3,...kulcsN => értékN];
//Automatikus indexeléssel:
$tomb = [érték, érték2, érték3,...értékN];
```

Az egyes elemekre ```[]``` zárójelben megadott kulccsal hivatkozhatunk. A tömb hosszát
a ```count()``` függvénnyel lehet lekérni, de ez nem az utolsó számmal indexelt
elem indexét adja vissza, hanem a tömb számosságát. A tömb végére elemet rakni
legegyszerűbben egy üres ```[]``` operátorral lehet. Ekkor egy számmal indexelt
elem jön létre, méghozzá az eddigi legnagyobb számos index eggyel növelt helyén.
Elem törlésére az ```unset()``` függvény szolgál.

```php

//Üres tömb létrehozása:
$uresTomb = array();
//PHP 5.4-től kezdve:
$uresTomb = [];
  
//Indexelt tömb létrehozása előre megadott elemekkel
$indTomb = array('alma', 12, true, -23.34);

print_r($indTomb); //Tömb kiíratása
/*
Array
(
    [0] => alma
    [1] => 12
    [2] => 1
    [3] => -23.34
)
*/
  
//Hivatkozás az elemekre
$indTomb[0];        //"alma"
$indTomb[1];        //12
$indTomb[2];        //true
$indTomb[3];        //-23.34
  
//A tömb hosszának lekérdezése
count($indTomb);    // Eredmény: 4
  
//Elemek módosítása
$indTomb[1] = 13;   

//Új elem beszúrása a tömb végére
$indTomb[] = 'új';

print_r($indTomb);
/*
Array
(
    [0] => alma
    [1] => 13
    [2] => 1
    [3] => -23.34
    [4] => 'új'
)
*/
  
//Új elem felvétele tetszőleges indexre
$indTomb[100] = 'messze';

print_r($indTomb);
/*
Array
(
    [0] => alma
    [1] => 13
    [2] => 1
    [3] => -23.34
    [4] => 'új'
    [100] => 'messze'
)
*/
  
//Elem törlése
unset($indTomb[1]);

print_r($indTomb);
/*
Array
(
    [0] => alma
    [2] => 1
    [3] => -23.34
    [4] => 'új'
    [100] => 'messze'
)
*/
  
//Asszociatív tömb
$gyumolcsok = array(
    'alma'      => 'piros',
    'korte'     => 'sárga',
    'szilva'    => 'kék',
);

print_r($gyumolcsok);
/*
Array
(
    [alma] => piros
    [korte] => sárga
    [szilva] => kék
)
*/
  
//Hivatkozás elemekre
echo $gyumolcsok['alma']; //piros
  
//Bővítés új elemekkel
$gyumolcsok['barack'] = 'barackszín';
$gyumolcsok[] = 'zöld';

print_r($gyumolcsok);
/*
Array
(
    [alma] => piros
    [korte] => sárga
    [szilva] => kék
    [barack] => barackszín
    [0] => zöld
)
*/
```

Tömbök bejárása legegyszerűbben a ```foreach``` ciklussal lehetséges.

A PHP rengeteg [függvénnyel](https://www.php.net/manual/en/ref.array.php) segíti a
tömbök feldolgozását:

* ```array_merge()```: két vagy több tömb egyesítése
* ```array_push()```: egyszerre több elem hozzáadása egy tömb végéhez
* ```array_shift()```: az első elem eltávolítása
* ```array_slice()```: tömb részének kinyerése
* ```sort()```: számmal indexelt tömb rendezése érték szerint
* ```asort()```: asszociatív tömb rendezése érték szerint
* ```ksort()```: asszociatív tömb rendezése kulcs szerint

### 7.6 Feltételes utasítások

Sok esetben merül fel egy-egy programozási feladat kapcsán annak szükségessége, hogy
különféle lehetőségekhez más-más viselkedést rendeljünk. Ennek megoldására használhatjuk
a feltételes kifejezéseket.

**if, elseif, else**

Az ```if``` kifejezés igazságértéke értékelődik ki. Ha kifejezés ```TRUE```, a PHP
végrehajtja az utasítást; ha ```FALSE``` figyelmen kívül hagyja. A feltételes utasítások
vég nélkül további ```if``` utasításokba ágyazhatók.

Gyakan van rá szükség, hogy ha teljesül egy bizonyos felétel, akkor valamilyen utasítást
kell végrehajtani, de ha nem, akkor egy másikat. Erre való az ```else```. Az ```else```
kibővíti az ```if``` utasítást, hogy akkor hajtson végre valamit, amikor az ```if```
kifejezés nem teljesül, vagyis ```FALSE```. Viszont csak akkor hajtódik végre, ha
az ```if``` és az összes ```elseif``` kifejezés is ```FALSE``` értékű.

Az ```elseif```, amint azt a neve is sugallja, az ```if``` és az ```else``` kombinációja.
Ha több feltételből egy teljesülése esetén szeretnénk más-más kódot futtatni, ezt
szerkezetet használjuk. Az ```else```-hez hasonlóan az ```if``` kifejezést terjeszti
ki, hogy különböző utasításokat hajtson végre abban az esetben, ha az eredeti ```if```
kifejezés értéke ```FALSE``` lenne. Azonban az ```else```-sel ellentétben csak akkor
hajtra végre az alternatív kódrészt, ha az ```elseif``` kifejezés ```TRUE```. Egy
feltételes kifejezésben akárhány ```elseif``` elágazás lehet (a jó ízlés határán belül,
ha nagyon megszaporodik a számuk érdemesebb a ```switch``` szerkezetet használni).

*Szintaxis:*
```php
if (feltétel1) {
 végrehajtandó kód, ha a feltétel1 teljesül;
} elseif (feltéte2l) {
 végrehajtandó kód, ha a feltétel2 teljesül;
} else {
 végrehajtandó kód, ha egyik feltétel sem teljesül;
}
```

Néha előfordul, hogy az ```if-else``` szerkezet helyett egyetlen operátort, a feltételes
(Elvis) operátort használjuk. Ez csak akkor lehet alternatívája az ```if-else``` használatának,
ha mindkét ágon valamilyen értéket akarunk előállítani, és azt a továbbiakban felhasználni.
Például, ha a feltételtől függ, hogy egy változó melyik értéket kapja.

**Switch**

A **switch** utasítást a PHP-ben akkor használjuk, hogyha más-más kódot szeretnénk
végrehajtani egy változó vagy kifejezés lehetséges értékei alapján. A switch használatával
bizonyos esetekben elkerülhetőek a hosszú *if-elseif-else* blokkok. Működése:
* egy egyszerű kifejezés (leggyakrabban egy változó) egyszer kiértékelődik
* a kifejezés értéke összehasonlításra kerül mindegyik case kifejezéssel a blokkon belül
(a case kifejezések működésüket tekintve nagyjából az ```elseif``` ágnak felelnek
meg)
* ha egyezést talál, akkor az adott case-ben található kód végrehajtódik
* miután ez megtörtént, a break utasítás leállítja az utasítások végrehajtását és
a vezérlés átkerül a switch blokk utáni programrészre
* a default utasítás arra használható, hogy le tudjuk kezelni azokat a kifejezéseket,
értékeket is, amelyek egy case utasításban sem voltak kezelve (nagyjából az ```else```
ágnak felel meg).

*Szintaxis:*

```php
switch (<kifejezés>) {
	case <cimke1>:
		 <a végrehajtandó kód, ha a kifejezés = cimke1>;
		 break;
	case <cimke2>:
		 <a végrehajtandó kód, ha a kifejezés = cimke2>;
		 break;
	default:
		 <a végrehajtandó kód ha a kifejezés különbözik
		 cimke1 és cimke2-től>;
		 break;
}

```

Egy switch szerkezetben tetszőleges számú case blokk elhelyzehető. Figyelni kell arra,
hogy minden egyes case ágat zárjunk le egy break-kel, különben a következő case
ág is lefut. Más nyelvektől eltérően a case értékei nem kell, hogy konstansok legyenek.
Tetszőleges kifejezés alkalmazható.

### 7.7 Ciklusok

A *ciklus*, vagy *iteráció* a számítógép-programozás és az algoritmusok egyik alapvető
eszköze, amely az ismétlődő tevékenységek megvalósítására szolgál. A ciklus beépítését
a programba ciklusszervezésnek is nevezik. A PHP nyelvben ciklusszervezésre több
lehetőség is van, más C-típusú nyelvekhez hasonlóan léteznek **feltételes**, **számláló**
és **iteráló** (bejáró) cilkusok.

#### Feltételes ciklusok

A feltételes ciklus olyankor használatos, amikor nem ismert előre, hogy hányszor
kell a ciklusnak lefutnia, az viszont igen, hogy milyen feltétel teljesülése
esetén kell futnia. A feltétel teljesülését vizsgálhatjuk a *ciklusfejben* vagy
a *ciklusvégben* is; a különbség abban fog állni, hogy legalább egyszer lefut-e
a ciklus. Ez alapján vannak elől-, és hátultesztelő ciklusok.

Az **előltesztelő** ```while``` ciklusok a PHP legegyszerűbb ciklusai. Éppen úgy viselkednek,
mint C nyelvbeli megfelelőik. A ```while``` ciklus tehát először megvizsgálja, hogy
a feltétel fennáll-e. Ha igen, akkor lefuttatja a ciklusmagot, és újból kezdődik;
ha nem, akkor a program a ciklus utáni ponton folytatódik, azaz a ciklusmag kimarad.
Lehetséges tehát, hogy a ciklus egyszer sem fog lefutni. A ```while``` ciklus tipikus
alkalmazása az adatállományok beolvasása; előfordulhat ugyanis, hogy az állomány üres,
és ilyenkor nincs mit beolvasni. Hasonló a helyzet a könyvtárak listázásakor is,
hiszen a könyvtárban nem biztos, hogy van állomány.

*Szintaxisa:*

```php
while (<feltétel>) {
  <ciklusmag>;
}
```

A **hátultesztelő** ```do..while``` ciklusnál a feltételvizsgálat a ciklusmag után
áll, ezért legalább egyszer mindenképpen lefut. Jellemző példa a hátultesztelő
ciklusra az adatbevitel ellenőrzése.

*Szintaxisa:*

```php
do {
 <ciklusmag>;
} while (<feltétel>);
```

A ```do..while``` ciklus feltételét tartalmazó zárójel után mindig ki kell tenni
a pontosvesszőt.

#### Számláló ciklusok

A számláló ciklus általánosságban olyan elöltesztelő ciklust jelent, amely egy
felsorolható típus adott intervallumán léptet végig, speciálisan egész számokon.
Üres intervallumra nem fut le.

A ```for``` cilus a legbonyolultabb ciklus a PHP-ben. Éppen úgy viselkedik, mint
a C nyelvbeli párja. Akkor használjuk, amikor előre tudjuk, hányszor kell futtatni
egy adott utasítást vagy utasítás listát. A ```for``` ciklusfejének három eleme van.
Az első ad kezdőértéket a ciklusváltozóknak (vagy számlálónak), a második tartalmazza
a feltételt és a harmadikban pedig az inkrementáló (növelő) utasítás van, ami a
ciklust vezérli. Ha több mint egy változó is szerepel az értékadásban vagy az
inkrementáló részben, vesszővel válasszuk el őket. Megjegyzendő, hogy bármilyen
```while``` ciklus átírható ```for``` ciklussá (mivel a ```for``` is elől tesztel).

*Szintaxisa:*

```php
for (<inicializálás>; <feltétel>; <növelés>) {
 <ciklusmag>;
}
```

Az ```<inicializálás>``` egyszer hajtódik végre, mégpedig a ciklus elején (kezdőértéket kap
a ciklusváltozó). Minden iteráció elején kiértékelődik a ```<feltétel>```. Ha értéke
```TRUE```, a ciklus folytatódik, és az ciklusmag végrehajtódik, ha ```FALSE```, a
ciklus véget ér. A ```<növelés>``` minden iteráció végén végrehajtódik (növeljük a
számlálóként funkcionáló ciklusváltozót eggyel). A ```for``` ciklus fejéből bármelyik
kifejezés elhagyható, de figyelnünk kell arra, hogy a pontosvesszőket mindig kiírjuk.
Ha például a ```<feltétel>``` marad ki, végtelen ciklust kapunk.

#### Bejáró ciklusok

A bejáró (iteráló) ciklusok arra valók, hogy egy egy tároló (PHP-ben iterable típusú elem,
amely implementálja a *Traversable* interfészt, kizárólag tömb vagy objektum) elemeit
bejárják és minden egyes elemre végrehajtsák a ciklus törzsében található utasítást
illetve utasításokat. A PHP 4-től a Perlhez és más nyelvekhez hasonlóan rendelkezésre
áll a ```forech``` szerkezet is.


*Szintaxisa:*

```php
foreach (<bejarhato_elem> as $ertek) {
	<ciklusmag>;
}

//Vagy:

foreach (<bejarhato_elem> as $kulcs => $ertek) {
	<ciklusmag>;
}
```

Két szintaxis létezik, a második egy apró, de hasznos plusz szolgáltatást nyújt az
elsőhöz képest. Mindkét forma végigmegy a ```<bejarhato_elem>``` által adott tömbön,
vagy objektumon. Minden alkalommal az aktuális elem értéke a ```$ertek``` változóba kerül,
és a belső tömb mutató növekszik eggyel (tehát a következő alkalommal a soron következő
elemen fog dolgozni). A második forma ezt kiegészíti annyival, hogy az aktuális elem
kulcsa a ```$key``` változóba kerül, így a ciklusmagban erre is lehet közvetlenül
hivatkozni, nem csak az ```$ertek``` változóra.

A ```forech``` nem az eredeti adatszerkezeten dolgozik, hanem egy másolaton. Ha
az eredeti adatszerkezetet szeretnénk módosítani, akkor a ciklusfejben az ```$ertek```
változót referencia szerint kell átadnunk, a ```&``` operátor hasznákatával:
```php
foreach (<bejarhato_elem> as &$ertek) {
	<ciklusmag>;
}
```


### 7.8 Függvények

### 7.9 Sütik és munkamentek kezelése

## 8. Objektum orientált programozás PHP-ben

### 8.1 Osztályok, tagváltozók, tagfüggvények, a konstruktor és a destruktor

### 8.2 Objektumok létrehozása

### 8.3 Osztályok kiterjesztése, öröklés, absztrakt osztályok

### 8.4 A static és a final kulcsszavak

## 9. A PHP, mint sablonrendszer

### 9.1 Keretrendszerek alapjai

### 9.2 MVC modell

### 9.3 Tartalomkezelő rendszerek (CMS)

## 10. Webszolgáltatások

### 10.1 A webszolgáltatások jellemzői

### 10.2 Alapvető szabványok: SOAP, WSDL, UDDI


### Jegyzetek:
* <span id="note1">[[1]](#1)</span> Kvaszingerné Prantner Csilla – Nagy Dénes: Weblapfejlesztés, 36-37. oldal
* <span id="note2">[[2]](#2)</span> Wikipedia: [Fogd és vidd](https://hu.wikipedia.org/wiki/Fogd_%C3%A9s_vidd) szócikk


### Felhasznált (ajánlott) irodalom

#### HTML:
* Wikipedia: [HTML](https://hu.wikipedia.org/wiki/HTML)
* Nagy Gusztáv: [Web-programozás, 2.1 fejezet](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Nagy Gusztáv: [Webes szabványok, 2-6. fejezet](https://nagygusztav.hu/sites/default/files/csatol/webes_szabvanyok_jegyzet_0.1.pdf)
* Kvaszingerné Prantner Csilla – Nagy Dénes: [Weblapfejlesztés, 3, 4. és 5. fejezet](https://mek.oszk.hu/14100/14137/pdf/14137.pdf)
* Abonyi-Tóth Andor: A weblapkészítés technikája (HTML5, CSS3) és ergonómiája
	* [HTML-bevezető](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke2_lap1.html)
	* [Oldalszerkezet elemek](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke7_lap1.html)
	* [Űrlapok](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke9_lap1.html)
	* [Videó állományok beillesztésére](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke6_lap4.html#hiv2)
	* [Hangállomány beillesztése](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke6_lap3.html#hiv2)
* Horváth Győző: Bevezetés a kliens- és szerveroldali webalkalmazások készítésébe
	* [Űrlapok és űrlapelemek](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke9_lap1.html#hiv2)
* Gál Tamás: [HTML5 weboldalak készítése](https://webfejlesztes.gtportal.eu/index.php?f0=HTML5)
* Tamás Ferenc: [Weblapkészítés HTMl alapokon](https://tferi.hu/weblapkeszites-html-alapokon-1)
* Sallai András: [A HTML 5 nyelv](https://szit.hu/doku.php?id=oktatas:web:html:html5_nyelv)
* Cservenák Bence: [Webtervezés jegyzet](https://okt.sed.hu/webtervezes/)
* Mark Pilgrim: [HTML5 - az új szabvány](https://people.inf.elte.hu/zirtaai/html_ebooks/HTML5.az.uj.szabvany.2011.eBOOk-AnAhTaR.pdf)
* Aurora: [Szabványkövető statikus honlapok készítése, 2. fejezet](https://www.tutorial.hu/webszerkesztes/html5-css3-osszefoglalo/html5-css3-osszefoglalo-v12.pdf)
* W3schools: [HTML5 útmutató](https://www.w3schools.com/html/default.asp)
* [Web forms 2.0 szabvány](https://www.w3.org/Submission/web-forms2/)
* A HTML 5 szabvány [webes űrlapokról szóló fejezete](https://html.spec.whatwg.org/multipage/forms.html#forms)
* W3schools: [HTML Audio](https://www.w3schools.com/html/html5_audio.asp)
* W3schools: [HTML Video](https://www.w3schools.com/html/html5_video.asp)
* W3schools: [HTML Geolocation API](https://www.w3schools.com/html/html5_geolocation.asp)
* MDN: [Geolocation API](https://developer.mozilla.org/en-US/docs/Web/API/Geolocation_API)
* W3C: [Geolocation API Specification 2nd Edition](https://www.w3.org/TR/geolocation-API/)
* A HTML 5 szabvány [Drag and drop fejezete](https://html.spec.whatwg.org/multipage/dnd.html#dnd)
* W3schools: [HTML Drag and Drop API](https://www.w3schools.com/html/html5_draganddrop.asp)
* Tutorialspoint: [HTML5 - Drag & drop](https://www.tutorialspoint.com/html5/html5_drag_drop.htm)
* MDN: [HTML Drag and Drop API](https://developer.mozilla.org/en-US/docs/Web/API/HTML_Drag_and_Drop_API)
* Wikipedia: [Canvas](https://hu.wikipedia.org/wiki/Canvas)
* W3schools: [HTML Canvas Graphics](https://www.w3schools.com/html/html5_canvas.asp)
* W3schools: [HTML Canvas Reference](https://www.w3schools.com/tags/ref_canvas.asp)
* W3C: [The canvas element](https://html.spec.whatwg.org/multipage/canvas.html#the-canvas-element)
* Java T Point: [HTML Tutorial](https://www.javatpoint.com/html-tutorial)

#### CSS:
* Wikipedia: [CSS](https://hu.wikipedia.org/wiki/Cascading_Style_Sheets)
* Abonyi-Tóth Andor: A weblapkészítés technikája (HTML5, CSS3) és ergonómiája
	* [Kitekintés a stíluslapok használatába, tipikus szövegformázások](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke4_lap1.html)
	* [Bevezetés a stíluslapok használatába](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke11_lap1.html)
	* [CSS kiértékelési sorrend (rangsorolás)](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke12_lap1.html)
	* [Ismerkedés a CSS dobozmodelljével](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke13_lap1.html)
	* [Vizuális formázásmodell](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke15_lap1.html)
	* [Médiatípusok használata](http://tamop412.elte.hu/tananyagok/weblapkeszites/lecke17_lap1.html)
* Gál Tamás: [CSS3 stíluslapok készítése](https://webfejlesztes.gtportal.eu/index.php?f0=CSS3)
* Nagy Gusztáv: [Web-programozás, 2.2 fejezet](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Nagy Gusztáv: [Webes szabványok, 6. fejezet](https://nagygusztav.hu/sites/default/files/csatol/webes_szabvanyok_jegyzet_0.1.pdf)
* Bártházi András: [A CSS alapjai I-VII.](http://weblabor.hu/cikkek/cssalapjai1)
* Kvaszingerné Prantner Csilla – Nagy Dénes: [Weblapfejlesztés, 7-9. fejezet](https://mek.oszk.hu/14100/14137/pdf/14137.pdf)
* Sallai András: [CSS](http://szit.hu/doku.php?id=oktatas:web:css)
* Aurora: [Szabványkövető statikus honlapok készítése, 3. fejezet](https://www.tutorial.hu/webszerkesztes/html5-css3-osszefoglalo/html5-css3-osszefoglalo-v12.pdf)
* Gremmedia: [A CSS3 alapjai-példákkal bemutatva](https://gremmedia.hu/edukacio/bejegyzes/css-alapjai-peldakkal-bemutatva)
* Dynamicart: [CSS3 újdonságok, amiket használni kell](http://dynamicart.hu/blog/css3-ujdonsagok-amiket-hasznalni-kell)
* Dynamicart: [CSS3 szelektorok: szerkezeti pszeudo-osztályok](http://dynamicart.hu/blog/css3-szelektorok-szerkezeti-pszeudo-osztalyok)
* Laki Ádám: [Bevezetés a reszponzív tervezésbe](https://adamlaki.com/hu/bevezetes-responsive-tervezesbe-viewport/)
* W3schools: [CSS Tutorial](https://www.w3schools.com/css/default.asp)

#### Javascript, DOM:
* Wikipedia: [Javascript](https://hu.wikipedia.org/wiki/JavaScript)
* Wikipedia: [Document Object Model](https://hu.wikipedia.org/wiki/Document_Object_Model)
* Több szerző: [DOM és HTML](http://nyelvek.inf.elte.hu/leirasok/JavaScript/index.php?chapter=21)
* Filep Levente: [JavaScript alapok helyesen, I.](http://epa.oszk.hu/00200/00220/00146/pdf/EPA00220_firka_2017-2018_4_022-028.pdf)
* Filep Levente: [JavaScript alapok helyesen, II.](http://epa.hu/00200/00220/00147/pdf/EPA00220_firka_2018-2019_01_16-20.pdf)
* Több szerző: [A Javascript programozási nyelv](http://nyelvek.inf.elte.hu/leirasok/JavaScript/index.php?chapter=1)
* Nagy Gusztáv: [Web-programozás, 4. fejezet](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Nagy Gusztáv: [Webes szabványok, 7. fejezet](https://nagygusztav.hu/sites/default/files/csatol/webes_szabvanyok_jegyzet_0.1.pdf)
* Sallai András: [Javascript](http://szit.hu/doku.php?id=oktatas:web:javascript)
* Kvaszingerné Prantner Csilla – Nagy Dénes: [Weblapfejlesztés, 10. fejezet](https://mek.oszk.hu/14100/14137/pdf/14137.pdf)
* Tari Balázs: [JavaScript](http://www.inf.u-szeged.hu/~tarib/javascript/)
* Horváth Győző: Bevezetés a kliens- és szerveroldali webalkalmazások készítésébe
	* [Alapvető ismeretek a JavaScripthez](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke2_lap1.html)
	* [A JavaScript nyelvi alapjai](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke3_lap1.html)
	* [A JavaScript további nyelvi elemei](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke4_lap1.html)
	* [A HTML dokumentum programozásának alapjai](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke5_lap1.html)
	* [A Dokumentum Objektum Modell](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke7_lap1.html)
* MDN: [JavaScript](https://developer.mozilla.org/hu/docs/Web/JavaScript)
* Szabó Viktor: [HTML5 Web Storage – Tároljuk okosan](https://html5.ugyesen.com/2012/04/html5-web-storage-taroljuk-okosan/)
* W3schools: [HTML Web Storage API](https://www.w3schools.com/html/html5_webstorage.asp)
* Laki Ádám: [HTML5 Web Storage](https://adamlaki.com/hu/html5-web-storage/)
* Sallai András: [Adattárolás](https://szit.hu/doku.php?id=oktatas:web:javascript:javascript_adattarolas)
* Tari Balázs: [Programozás és algoritmizálás JavaScript nyelven](http://eta.bibl.u-szeged.hu/3093/6/dist/javascript/lokalistarolok.html)
* Wikipedia: [Websocket](https://hu.wikipedia.org/wiki/WebSocket)
* Fejlesztő lány: [Websocket, websocket mindenhol...](https://fejlesztolany.hu/2019/03/26/websocket-websocket-mindenhol/)
* BME AUT: [Mi is a Websocket](http://bmeaut.github.io/snippets/snippets/AlkFejlHfTanulsagok/51/)
* websocket.org: [About HTML5 WebSocket](http://websocket.org/aboutwebsocket.html)
* W3C: a HTML 5 szabvány [Websocket](https://html.spec.whatwg.org/multipage/web-sockets.html#network) fejezete
* Papp Krisztián: [Web workerek](https://app.letscode.hu/videos/js-workerek/web-workerek)
* MDN: [Web Workers API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Workers_API)
* W3C: a HTML 5 szabvány [Web workers](https://html.spec.whatwg.org/multipage/workers.html#workers) fejezete
* Farkas Máté: [Web Worker – Számolni? Böngészőben?!](http://weblabor.hu/cikkek/web-worker)
* Molnár Gábor, Schnell Henrik, Szarvas Attila, Szeberényi Imre: [Munkában a böngészők](https://nws.niif.hu/ncd2011/docs/ehu/063.pdf)
* Wikipedia: [Server-sent events](https://en.wikipedia.org/wiki/Server-sent_events)
* W3C: a HTML 5 szabvány [Server-sent Events](https://html.spec.whatwg.org/multipage/server-sent-events.html) fejezete
* MDN: [Server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events)
* W3Schools: [HTML SSE API](https://www.w3schools.com/html/html5_serversentevents.asp)
* JavaScript.info: [Server Sent Events](https://javascript.info/server-sent-events)
* MDN: [Canvas API](https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API)
* Ivo Wetzel, Zhang Yi Jiang: [JavaScript Garden](https://bonsaiden.github.io/JavaScript-Garden/hu/)
* W3Schools: [JavaScript Tutorial](https://www.w3schools.com/js/DEFAULT.asp)

#### JSON:
* [ISO/IEC 21778:2017](https://www.iso.org/standard/71616.html)
* [JSON bevezető](https://www.json.org/json-hu.html)
* Wikipedia: [JSON](https://hu.wikipedia.org/wiki/JSON)
* Több szerző: [JSON](http://nyelvek.inf.elte.hu/leirasok/JavaScript/index.php?chapter=19)
* BME Wiki: [JSON](http://static.hlt.bme.hu/semantics/external/pages/JSON-objektum/hu.wikipedia.org/wiki/JSON.html)
* W3Schools: [JSON](https://www.w3schools.com/js/js_json_intro.asp)

#### AJAX:
* Wikipedia: [AJAX](https://hu.wikipedia.org/wiki/Ajax_(programoz%C3%A1s))
* jQuery [API Documantation](https://api.jquery.com/jquery.ajax/)
* H-Well SEO Studio: [Mi az az Ajax?](https://hwellkft.hu/marketing-szotar/ajax)
* Több szerző: [AJAX](http://nyelvek.inf.elte.hu/leirasok/JavaScript/index.php?chapter=18)
* MDN: [XMLHttpRequest](https://developer.mozilla.org/hu/docs/Web/API/XMLHttpRequest)
* Horváth Győző: Bevezetés a kliens- és szerveroldali webalkalmazások készítésébe
	* [AJAX – weboldalak részleges frissítése](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke19_lap1.html)
* Zsolt jegyzetei: [jQuery.ajax() alapozó](https://anon117blog.wordpress.com/2013/12/11/jquery-ajax-alapozo/)
* Sallai András: [jQuery AJAX](http://szit.hu/doku.php?id=oktatas:web:jquery:ajax)
* W3Schools: [AJAX Tutorial](https://www.w3schools.com/js/js_ajax_intro.asp)
* W3Schools: [AJAX - The XMLHttpRequest Object](https://www.w3schools.com/js/js_ajax_http.asp)
* W3Schools: [jQuery AJAX Methods](https://www.w3schools.com/jquery/jquery_ref_ajax.asp)

#### PHP alapok:
* Wikipedia: [PHP](https://hu.wikipedia.org/wiki/PHP)
* [PHP Kézikönyv](https://www.php.net/manual/en/index.php)
* Horváth Győző: Bevezetés a kliens- és szerveroldali webalkalmazások készítésébe
	* [A PHP mint programozási nyelv](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke13_lap1.html)
	* [Weboldalak dinamikus generálása PHP-val](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke14_lap1.html)
	* [Munkamenet-kezelés](http://webprogramozas.inf.elte.hu/tananyag/wf2/lecke17_lap1.html)
* Stig Sćther Bakken, Alexander Aulbach, Egon Schmid, Jim Winstead, Lars Torben Wilson, Rasmus Lerdorf
Zeev Suraski, Andrei Zmievski: [PHP Kézikönyv (2000-es kiadás fordítása)](https://www.nejanet.hu/~ksanyi/php3/manual.html)
* Nagy Gusztáv: [Web-programozás, 3. fejezet](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Több szerző: [A PHP programozási nyelv](http://nyelvek.inf.elte.hu/leirasok/PHP/index.php?chapter=1)
* Sallai András: [A PHP nyelv](https://szit.hu/doku.php?id=oktatas:programozas:php:php_nyelv)
* Bundi: [Készülj fel a PHP 7-re](http://webmestertanfolyam.hu/webmester-blog/keszulj-fel-a-php-7-re)
* Botond: [A PHP 8 újdonságai és változásai](https://www.linuxportal.info/cikkek/egyeb-szoftverek/a-php-8-ujdonsagai-es-valtozasai)
* W3Schools: [PHP Tutorial](https://www.w3schools.com/php/)

#### PHP OOP, MVC, CMS:
* Wikipedia: [Objektumorientált programozás](https://hu.wikipedia.org/wiki/Objektumorient%C3%A1lt_programoz%C3%A1s)
* Wikipedia: [Tartalomkezelő rendszerek](https://hu.wikipedia.org/wiki/Tartalomkezel%C5%91_rendszerek)
* Nagy Gusztáv: [Web-programozás, 3.8, 3.10, 3.11 fejezet](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Gremmedia: [Minden, amit az objektumorientált PHP programozásról tudni érdemes](https://gremmedia.hu/edukacio/bejegyzes/minden-amit-az-objektumorientalt-php-programozasrol-tudni-erdemes)
* Több szerző: [PHP keretrendszerek](http://nyelvek.inf.elte.hu/leirasok/PHP/index.php?chapter=19)
* Nagy Gusztáv: [Web-programozás, 3.11 fejezet: Sablonrendszerek](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Webshark: [Mi az a cms?](https://webshark.hu/gyik/cms-tartalomkezelo-rendszer-wordpress/)
* Horváth Győző, Tarcsi Ádám: [Webadatbázis-programozás](http://ade.web.elte.hu/wabp/index.html)
* W3Schools: [PHP OOP](https://www.w3schools.com/php/php_oop_what_is.asp)

#### Webszolgáltatások:
* Wikipedia: [Webszolgáltatás](https://hu.wikipedia.org/wiki/Webszolg%C3%A1ltat%C3%A1s)
* Wikipedia: [SOAP](https://hu.wikipedia.org/wiki/SOAP)
* Wikipedia: [WSDL - Webszolgáltatás-leíró nyelv](https://hu.wikipedia.org/wiki/Webszolg%C3%A1ltat%C3%A1s-le%C3%ADr%C3%B3_nyelv)
* Wikipedia: [UDDI](https://hu.wikipedia.org/wiki/UDDI)
* IBM Knowledge Center: [Webszolgáltatások](https://www.ibm.com/support/knowledgecenter/hu/SS4JE2_7.5.5/org.eclipse.jst.ws.doc.user/concepts/cws.html)
* Wikipedia: [REST](https://hu.wikipedia.org/wiki/REST)
* Peter Smith: [REST alapú kommunikáció](https://psprog.hu/article/rest-alapu-kommunikacio)
* Szerző nélkül: [A REST szabályai: Hogyan lehet RESTful a HTTP / JSON API-kban](https://hun.small-business-tracker.com/rules-rest-how-be-restful-httpjson-apis-527492)


[Kezdőlap](../README.md)
