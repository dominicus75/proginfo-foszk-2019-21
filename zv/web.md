[Kezdőlap](../README.md)

# Web-fejlesztés

## 1. HTML nyelv alapjai

A HTML (Hypertext MarkUp Language) egy szöveges jelölőnyelv, más néven leírónyelv, amelyet weboldalak készítéséhez fejlesztettek ki, mára egyes
változatai internetes szabvánnyá váltak a W3C (World Wide Web Consorcium)
jóvoltából. A HTML leírónyelv egy általános leírónyelvből, az [SGML (Standard Generalized MarkUp Language)](https://hu.wikipedia.org/wiki/Standard_Generalized_Markup_Language)
dokumentumszabványból jött létre. Az SGML 1986-ban lett ISO szabvány, dokumentumok
általános leírására szolgált, ennek elődje volt a GML (Generalized MarkUp Language),
amelyet az 1960-as években fejlesztettek ki az IBM-nél.

A HTML nem programozási nyelv, azaz nem valósíthatunk meg vele szelekciót (feltételektől
függő elágazást), sem iterációt (ismétlődést, ciklusokat). A három vezérlési szerkezet
közül csakis a szekvencia (parancsok egymásutáni végrehajtása) valósítható meg vele.

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
(a HTML 5. szabvány összesen [21 lehetséges értéket sorol fel](https://html.spec.whatwg.org/multipage/input.html#states-of-the-type-attribute)
a type attribútumhoz) egészítette ki:

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

### 4.1 Nyelvtani sajátosságok

### 4.2 Eseményvezérelt programozás

### 4.3 DOM

## 5. JSON.

### 5.1 Az JSON adattípusai, szintaxisa.

### 5.2 JSON-formázott szöveg értelmezése JavaScript-ben (eval(), JSON.parse()).

### 5.3 JSON objektumok kódolása és dekódolása PHP-ben (json_encode(), json_decode())

## 6. Az AJAX.

### 6.1 Az AJAX céljai és előnyei

### 6.2 Az AJAX technikái, a jQuery fontosabb AJAX metódusai ($.ajax, $.get, $.getJSON, $.post, $.fn.load)

## 7. A PHP nyelv szerepe a webfejlesztésben

### 7.1 A PHP nyelvtana, felhasználási területei

### 7.2 Változók, konstansok, operátorok, tömbök

### 7.3 Feltételes utasítások, ciklusok, függvények

### 7.4 Sütik és munkamentek kezelése

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
* Abonyi-Tóth Andor: [A weblapkészítés technikája (HTML5, CSS3) és ergonómiája](http://tamop412.elte.hu/tananyagok/weblapkeszites/index.html)
* Horváth Győző: [Bevezetés a kliens- és szerveroldali webalkalmazások készítésébe](http://webprogramozas.inf.elte.hu/tananyag/wf2/index.html)
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
* Több szerző: [A Javascript programozási nyelv](http://nyelvek.inf.elte.hu/leirasok/JavaScript/index.php?chapter=1)
* Nagy Gusztáv: [Web-programozás, 4. fejezet](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Nagy Gusztáv: [Webes szabványok, 7. fejezet](https://nagygusztav.hu/sites/default/files/csatol/webes_szabvanyok_jegyzet_0.1.pdf)
* Sallai András: [Javascript](http://szit.hu/doku.php?id=oktatas:web:javascript)
* Kvaszingerné Prantner Csilla – Nagy Dénes: [Weblapfejlesztés, 10. fejezet](https://mek.oszk.hu/14100/14137/pdf/14137.pdf)
* Tari Balázs: [JavaScript](http://www.inf.u-szeged.hu/~tarib/javascript/)
* Horváth Győző: [Bevezetés a kliens- és szerveroldali webalkalmazások készítésébe](http://webprogramozas.inf.elte.hu/tananyag/wf2/index.html)
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
* W3Schools: [JavaScript Tutorial](https://www.w3schools.com/js/DEFAULT.asp)

#### JSON:
* Wikipedia: [JSON](https://hu.wikipedia.org/wiki/JSON)
* Több szerző: [JSON](http://nyelvek.inf.elte.hu/leirasok/JavaScript/index.php?chapter=19)
* BME Wiki: [JSON](http://static.hlt.bme.hu/semantics/external/pages/JSON-objektum/hu.wikipedia.org/wiki/JSON.html)
* W3Schools: [JSON](https://www.w3schools.com/js/js_json_intro.asp)

#### AJAX:
* Wikipedia: [AJAX](https://hu.wikipedia.org/wiki/Ajax_(programoz%C3%A1s))
* H-Well SEO Studio: [Mi az az Ajax?](https://hwellkft.hu/marketing-szotar/ajax)
* Több szerző: [AJAX](http://nyelvek.inf.elte.hu/leirasok/JavaScript/index.php?chapter=18)
* W3Schools: [AJAX Tutorial](https://www.w3schools.com/js/js_ajax_intro.asp)

#### PHP alapok:
* Wikipedia: [PHP](https://hu.wikipedia.org/wiki/PHP)
* Nagy Gusztáv: [Web-programozás, 3. fejezet](https://nagygusztav.hu/sites/default/files/csatol/web_programozas_-_szines.pdf)
* Több szerző: [A PHP programozási nyelv](http://nyelvek.inf.elte.hu/leirasok/PHP/index.php?chapter=1)
* Sallai András: [A PHP nyelv](https://szit.hu/doku.php?id=oktatas:programozas:php:php_nyelv)
* Bundi: [Készülj fel a PHP 7-re](http://webmestertanfolyam.hu/webmester-blog/keszulj-fel-a-php-7-re)
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
