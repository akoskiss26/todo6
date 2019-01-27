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

-fenti a GET metódust használja (input alapértelmezett tulajdonsága) NEM SZABVÁNYOS
