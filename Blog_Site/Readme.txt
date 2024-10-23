Blog Sitesi Projesi Ba�lang��
--Admin olacak
--Kullan�c� Kay�t olacak
--Kullan�c� Post Payla�abilecek
--Post begenisi olacak
--Postlar payl�a�lmadan �nce admin onay�na tabi tutulacak
--Admin post silme i�lemini yapabilecek
--postu �ikayet edilebilecek.

Classlar
--User (name-surname-birtdate-Isadm�n-mail-pass-passwordagais--list<post>)
--Post(title-description-photo-user-like-complain)


DAL- katman� veritaban�un�n tutuldu�u ana veritabanu� i�lmlerini yap�ld��� katmand�r. bu katmanda i�lemler direk entity yani class �zerinden ger�ekle�ir
BLL- i� katman� veritaban� i�lemlerinin yap�ld��� ytere referans verir ve oradaki i�lemleri kullanarak as�l i�i yapt�rmak i�in kullan�l�r. i�lemler direk entitiy yani class �zerinden de�i� DTO!lar �zerinden ge�kel�ir
DTO- Data transfer object anlam�na gelir �zellikle katmanl� mimari yap�lar�nda direk entity �zerinden �al��mak �ok do�ru ve g�venli olmayaca�� i�in entitylerin maplenece�i yani i�le�tirilip kullan�laca�� yerdir.
MVC(UI-Prentation Layer) - Controllerlar �zerinden BLL!de olu�turdu�umuz yap�lar kullan�l�arak kullan�lmak istedi�i i�lem yapt�r�l�r. ��lemler Entity ya da Class de�il viewmodel �zerinden ger�ekle�ir.
ViewModel Nedir: View mvc'nin v harfiyle e�le�ir yani biz asl�nda mvc'deki frontende verileri sadece viewModel olarak g�ndermek zorunday�z. viewmodellerde DTO ile e�le�ir bu sayede entity kullanmadan araya hem dto hem de view model sokarak hem kullan��l��� hem de g�venli�i artt�r�r�z.

COOK�E ve SESS�ON KAVRAMLARI
1-�erezler(COOK�ES) istemcinin (Chorome,edge,mozilla v.s) saklanan k���k veri par�alar�n�. Genellikle kullan�c� tercihlerini,kimlik do�rulama jetonl�ar�n� veya birden fazla istek ve oturum boyunca kal�c� olmas� gereken verileri hat�rlamak i�in kullan�l�r.
2-Sesions(Oturumlar): oturumlar, kullan�c�ya �zel verilerin sunucu taraf�nda saklad��� mekan�zmad�r.Oturum verileri bir kullan�c�n�n taray�c�s�na SessionId(Oturum kimlii�i) atanarak y�netilir. Cookie g�re daha g�venilirdir ve daha b�y�k veri saklayabilir.


                                     PROJEYE BA�LA

1- DAL(Data aplication Layer)(Veri Katman�) ve BLL(businies Logic Layer)(�� Katmanu) katmanlar� i�in ClassLibrary Ekle. Bu ��lem i�in Solutiona sa� t�kla new proj ect de ve classlibrary se�.
2-BLL'e DAL projesine referans veriri.
3-MVC projesi hem BLL projesine hemde DAL projesine referans verir.
4-DAL projesi hi�bir�eye referans vermez
5-DAL projesine Entity Paketlerini ekle.
6-DAL Projesine data klas�r� ekle ve i�in AppDbContext ekle 
7-DaL Projesine Entities kals�r� ekle ve t�m veri taban� s�n�flar�n� olu�tur.
8-AppContext / Dbset tan�mla 
    ** OnModelCreating ovveride edilerek seed data tan�mlan�r.
9-DAL projesinin i�erisine AbstractRepository klas�r� ekle vw i�weisine repository interfacen� ekle.
    ** T �zel harftir ve Jenerik anlam�na gelir T yerine istedi�imiz class� verebiliriz.
10-BaseEntity class� olu�tur ve tum entitileri bu classtan miras al
11- DAL alt�nda ConcreteRepositories klas�r�n� a� ve i�erisinde Repository ekle ve Irepositor�den miras al ve i�erini�i enjecte et.
12- Migration atarken Start-up proje de mvc katman� olmal� ve package manager console da default proje DAL se�ilmeli ve migration atmadna once MVC katman�na Manager NuGet Packetten Entitiy.core.desing paketini kur.
13-MVC katman�nda Appsetting.Json connectingstring tan�mlamas� yap.
14- MVC katman�nda Program.cs clas�nda database ba�lant�s�n� tan�ma
15- Migration at
16-Program.cs de Ireapository ve repository ba�lant�lar�n� yap.
17-BLL projesinde git Dtos kals�r�n� ekle ve i�erisine data Entites de ne varsa aynan clas olarak tan�ma e�er classlar�n i�erisinde navigation properties var ise ayn� isimli olmamal�d�r onun yan�na dto eklenir.
18- Dto ile Entitylerin aras�nda AutoMapper ile ba�lant� kurulur bunun i�in BLL katman�na Automapper paketi y�klenir Nuget Packetten.
19-mappering klasor� a� entityleri mapperla 
20- program.cs mapprleri yol g�ster.
21-MVC katman�nda Model klas�r�nde V�ewModelleri Haz�rla 
22- MVC Katman�nda Mapping klas�r�n� olu�tur ve DTO ile View modeller aras�nda ki mapplemeyi yap
23- DTO ile View Model aras�ndaki maplemeyi Program.cs de yap
24- Controllerda Action yaz 
25- View Olu�tur.
26-Post service olu�tur
27- IMapper ve Irepository enjecte et
28- ctor tan�mla
29- Program cs. service ba�lant�s� yap.
30- Post service i�ini doldur.
31-Model olu�tur.
32- User view modele gidip list post ba�lant�s�n�  ekle
33- Resimler string olarak atn�mlar because foto�raf�n yolunu kaydediyoruz.
34-Mapping posttdo ile postview modelin yolunu ekle
35-PostController ekle
36-


