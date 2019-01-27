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

-fenti a GET met�dust haszn�lja (input alap�rtelmezett tulajdons�ga) NEM SZABV�NYOS
