# todo6
hatodik
l�trehoztuk az alkalamaz�st �s a repository-t

megtal�ltuk, hol van a solution �s hogy kell innen megnyitni a VS-t

#lista ki�r�sa
	-[] k�l�n controllert csin�ltunk (Todo) , �s annak az Index AR-j�be tett�k a list�t
	-[] az index.cshtml-ben defini�ltuk a Model-t: @Model List<string>
	-[] az index.cshtml-ben foreach ciklussal ki�rtuk a Model elemeit egy ordered list-be 

## t�bbt�pus� v�ltoz�s lista l�trehoz�sa a Model k�nyvt�rban
a lista elemeinek t�pusa legyen: TodoItem - ebben egy string �s egy boolean �rt�k van (Name �s Done)
l�trehozunk a Model mapp�ban egy TodoList oszt�lyt
a todoController-ben:

var lista = new List<TodoItem>();
            lista.Add(new TodoItem() { Name = "s�", Done = true });

itt using kell a TodoItem-nek, �s defini�lni a Name �s Done property-ket

a ki�r�shoz az index.cshtml-ben m�dos�tani kell a model defin�ci�t
a foreach -ben az item-et v�ltoztattuk, mert egy record t�bb elemet tartalmaz, �gy meg kell hat�rozni, melyiket akarjuk ki�rni

## CRUD alkalamaz�s k�sz�t�se

### Indexre beviteli mez� k�sz�t�se �s adatbevitel
**adatbevitel GET-tel** 

 -k�sz�t�nk egy �j AR fgv-t: Create()
	ide ir�ny�tjuk az index oldalr�l egy linkkel ha �j t�telt akarunk fel�rni

- a Create -hez megcsin�ljuk a View() fgv-t, �s belerakjuk a form, input, button tag-eket
- az input-hoz kell name="" tulajdons�got is megadni
- eredm�ny: a name �s a  beviteli mez�be �rt adat megjelenik a cimsorban

-a @Html.ActionLink("sz�veg", "AR fgv ahova menni akarunk")  - ezt haszn�ljuk most pl. a Cancel-re 

- ha az AR fgv-nek input param�tert adunk: Create(string Name) akkor a model binding a beviteli mez�be �rt sz�veget �tadja a Create fgv-nek, felt�ve hogy:
az input mez� elnevez�se �s a Create fgv input param�ter�nek neve egyezik
�gy a Create fgv-ben egy if el�gaz�ssal figyelhetj�k h a beviteli mez�ben van-e adat, �s ha van elmenthetj�k, �s visszat�r�nk pl. az index oldalra

- fenti a GET met�dust haszn�lja (input alap�rtelmezett tulajdons�ga) NEM SZABV�NYOS

- az �j adat ekment�s�hez a Create AR-nek is kell l�tnia a lista-t, ez�rt a lista l�trehoz�s�t az index AR-b�l �ttessz�k a TodoController oszt�lyba, �gy a Todo minden fgv-e l�tni fogja

private List<TodoItem> lista = new List<TodoItem>
            {
                new TodoItem() { Name = "s�", Done = true },
                new TodoItem() { Name = "bors", Done = true },
                new TodoItem() { Name = "liszt", Done = false },
                new TodoItem() { Name = "kapor", Done = true }
            };

- persze m�g ez sem j�, mert a TodoController minden megh�v�sra �jraindul, �gy az adatt�rol�s nem perzisztens

## A publikus v�ltoz�kat nagy kezd�bet�vel �rjuk

## Az adatb�is �thelyez�se
 - A Model k�nyvt�rban k�sz�t�nk egy �j oszt�lyt MyDb n�ven, �s ide hozzuk �t az adatb�zis k�szit�s�t,
 ami eredetileg a Todo controllerben volt.
 - a Todo controller index fgv-�ben az eddigi lista nevet lecser�lj�k MyDb.Lista n�vre 
 - �gy az adatt�rol�s a fut�si id� alatt perzisztens, de ha le�ll�tjuk az alkalamaz�st, az adatok elvesznek


## POST met�dus haszn�lata
a <form> -nak a method alap�rtelmez�se GET. �ll�tsuk �t POST-ra       <form method="post"> </form>

Az adatok form data-n j�nnek be, �s a model binding fogja a create fgv param�ter�be betenni  



