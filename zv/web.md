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

### 2.1 Új szemantikus elemek

A szemantikus HTML nem más, mint a HTML tagok jelentésének betartása, rendeltetésszerű
használata. Például, egy bekezdést nem használunk fel menü kialakításához.

### 2.2 Forms 2.0

### 2.3 Perzisztens helyi tárolás

### 2.4 Web workers, websocket

### 2.5 Szerver által küldött események (Server-Sent Events, SSE)

### 2.6 Hang és video, geolokáció

### 2.7 Fogd és vidd (drag and dropp)

### 2.8 Canvas

## 3. Weboldalak információtartalmának és kinézetének szétválasztása

A HTML leírónyelvvel határozzuk meg a weboldalak tartalmát és struktúráját. A weboldalak
megjelenítéséért a CSS állományok felelnek. Az a helyes, ha a tartalom és a forma
egymástól élesen elkülönül, a HTML (strukturált tartalom) és a CSS (formázás, megjelenés, elrendezés)
állományokkal ez professzionálisan megvalósítható, ez azért fontos, mert így a tartalom és
a megjelenés egymástól függetlenül is változtatható.


### 3.1 CSS nyelvtan, kiválasztók és tulajdonságok, mértékegységek.

### 3.2 Doboz modell, pozicionálás, megjelenítés

### 3.3 Fontosabb média típusok

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
* Mark Pilgrim: [HTML5 - az új szabvány](https://people.inf.elte.hu/zirtaai/html_ebooks/HTML5.az.uj.szabvany.2011.eBOOk-AnAhTaR.pdf)
* Aurora: [Szabványkövető statikus honlapok készítése, 2. fejezet](https://www.tutorial.hu/webszerkesztes/html5-css3-osszefoglalo/html5-css3-osszefoglalo-v12.pdf)
* W3schools: [HTML5 útmutató](https://www.w3schools.com/html/default.asp)
* [Web forms 2.0](https://html.spec.whatwg.org/multipage/forms.html#forms)
* Wikipedia: [Websocket](https://hu.wikipedia.org/wiki/WebSocket)
* Fejlesztő lány: [Websocket, websocket mindenhol...](https://fejlesztolany.hu/2019/03/26/websocket-websocket-mindenhol/)
* Papp Krisztián: [Web workerek](https://app.letscode.hu/videos/js-workerek/web-workerek)
* MDN: [Web Workers API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Workers_API)
* Molnár Gábor, Schnell Henrik, Szarvas Attila, Szeberényi Imre: [Munkában a böngészők](https://nws.niif.hu/ncd2011/docs/ehu/063.pdf)
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
