# todo6
hatodik
létrehoztuk az alkalamazást és a repository-t

megtaláltuk, hol van a solution és hogy kell innen megnyitni a VS-t

#lista kiírása
	-[] külön controllert csináltunk (Todo) , és annak az Index AR-jébe tettük a listát
	-[] az index.cshtml-ben definiáltuk a Model-t: @Model List<string>
	-[] az index.cshtml-ben foreach ciklussal kiírtuk a Model elemeit egy ordered list-be 

## többtípusú változós lista létrehozása a Model könyvtárban
a lista elemeinek típusa legyen: TodoItem - ebben egy string és egy boolean érték van (Name és Done)
létrehozunk a Model mappában egy TodoList osztályt
a todoController-ben:

var lista = new List<TodoItem>();
            lista.Add(new TodoItem() { Name = "só", Done = true });

itt using kell a TodoItem-nek, és definiálni a Name és Done property-ket

a kiíráshoz az index.cshtml-ben módosítani kell a model definíciót
a foreach -ben az item-et változtattuk, mert egy record több elemet tartalmaz, így meg kell határozni, melyiket akarjuk kiírni

## CRUD alkalamazás készítése

### Indexre beviteli mezõ készítése és adatbevitel
**adatbevitel GET-tel** 

 -készítünk egy új AR fgv-t: Create()
	ide irányítjuk az index oldalról egy linkkel ha új tételt akarunk felírni

- a Create -hez megcsináljuk a View() fgv-t, és belerakjuk a form, input, button tag-eket
- az input-hoz kell name="" tulajdonságot is megadni
- eredmény: a name és a  beviteli mezõbe írt adat megjelenik a cimsorban

-a @Html.ActionLink("szöveg", "AR fgv ahova menni akarunk")  - ezt használjuk most pl. a Cancel-re 

- ha az AR fgv-nek input paramétert adunk: Create(string Name) akkor a model binding a beviteli mezõbe írt szöveget átadja a Create fgv-nek, feltéve hogy:
az input mezõ elnevezése és a Create fgv input paraméterének neve egyezik
így a Create fgv-ben egy if elágazással figyelhetjük h a beviteli mezõben van-e adat, és ha van elmenthetjük, és visszatérünk pl. az index oldalra

- fenti a GET metódust használja (input alapértelmezett tulajdonsága) NEM SZABVÁNYOS

- az új adat ekmentéséhez a Create AR-nek is kell látnia a lista-t, ezért a lista létrehozását az index AR-bõl áttesszük a TodoController osztályba, így a Todo minden fgv-e látni fogja

private List<TodoItem> lista = new List<TodoItem>
            {
                new TodoItem() { Name = "só", Done = true },
                new TodoItem() { Name = "bors", Done = true },
                new TodoItem() { Name = "liszt", Done = false },
                new TodoItem() { Name = "kapor", Done = true }
            };

- persze még ez sem jó, mert a TodoController minden meghívásra újraindul, így az adattárolás nem perzisztens

## A publikus változókat nagy kezdõbetûvel írjuk

## Az adatbáis áthelyezése
 - A Model könyvtárban készítünk egy új osztályt MyDb néven, és ide hozzuk át az adatbázis készitését,
 ami eredetileg a Todo controllerben volt.
 - a Todo controller index fgv-ében az eddigi lista nevet lecseréljük MyDb.Lista névre 
 - így az adattárolás a futási idõ alatt perzisztens, de ha leállítjuk az alkalamazást, az adatok elvesznek


## POST metódus használata
a <form> -nak a method alapértelmezése GET. Állítsuk át POST-ra       <form method="post"> </form>

Az adatok form data-n jönnek be, és a model binding fogja a create fgv paraméterébe betenni  



