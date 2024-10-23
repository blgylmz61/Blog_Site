Blog Sitesi Projesi Baþlangýç
--Admin olacak
--Kullanýcý Kayýt olacak
--Kullanýcý Post Paylaþabilecek
--Post begenisi olacak
--Postlar paylþaýlmadan önce admin onayýna tabi tutulacak
--Admin post silme iþlemini yapabilecek
--postu þikayet edilebilecek.

Classlar
--User (name-surname-birtdate-Isadmýn-mail-pass-passwordagais--list<post>)
--Post(title-description-photo-user-like-complain)


DAL- katmaný veritabanýunýn tutulduðu ana veritabanuý iþlmlerini yapýldýðý katmandýr. bu katmanda iþlemler direk entity yani class üzerinden gerçekleþir
BLL- iþ katmaný veritabaný iþlemlerinin yapýldýðý ytere referans verir ve oradaki iþlemleri kullanarak asýl iþi yaptýrmak için kullanýlýr. iþlemler direk entitiy yani class üzerinden deðiþ DTO!lar üzerinden geçkelþir
DTO- Data transfer object anlamýna gelir özellikle katmanlý mimari yapýlarýnda direk entity üzerinden çalýþmak çok doðru ve güvenli olmayacaðý için entitylerin mapleneceði yani iþleþtirilip kullanýlacaðý yerdir.
MVC(UI-Prentation Layer) - Controllerlar üzerinden BLL!de oluþturduðumuz yapýlar kullanýlþarak kullanýlmak istediði iþlem yaptýrýlýr. Ýþlemler Entity ya da Class deðil viewmodel üzerinden gerçekleþir.
ViewModel Nedir: View mvc'nin v harfiyle eþleþir yani biz aslýnda mvc'deki frontende verileri sadece viewModel olarak göndermek zorundayýz. viewmodellerde DTO ile eþleþir bu sayede entity kullanmadan araya hem dto hem de view model sokarak hem kullanýþlýðý hem de güvenliði arttýrýrýz.

COOKÝE ve SESSÝON KAVRAMLARI
1-Çerezler(COOKÝES) istemcinin (Chorome,edge,mozilla v.s) saklanan küçük veri parçalarýný. Genellikle kullanýcý tercihlerini,kimlik doðrulama jetonlþarýný veya birden fazla istek ve oturum boyunca kalýcý olmasý gereken verileri hatýrlamak için kullanýlýr.
2-Sesions(Oturumlar): oturumlar, kullanýcýya özel verilerin sunucu tarafýnda sakladýðý mekanýzmadýr.Oturum verileri bir kullanýcýnýn tarayýcýsýna SessionId(Oturum kimliiði) atanarak yönetilir. Cookie göre daha güvenilirdir ve daha büyük veri saklayabilir.


                                     PROJEYE BAÞLA

1- DAL(Data aplication Layer)(Veri Katmaný) ve BLL(businies Logic Layer)(Ýþ Katmanu) katmanlarý için ClassLibrary Ekle. Bu Ýþlem için Solutiona sað týkla new proj ect de ve classlibrary seç.
2-BLL'e DAL projesine referans veriri.
3-MVC projesi hem BLL projesine hemde DAL projesine referans verir.
4-DAL projesi hiçbirþeye referans vermez
5-DAL projesine Entity Paketlerini ekle.
6-DAL Projesine data klasörü ekle ve için AppDbContext ekle 
7-DaL Projesine Entities kalsörü ekle ve tüm veri tabaný sýnýflarýný oluþtur.
8-AppContext / Dbset tanýmla 
    ** OnModelCreating ovveride edilerek seed data tanýmlanýr.
9-DAL projesinin içerisine AbstractRepository klasörü ekle vw içweisine repository interfacený ekle.
    ** T özel harftir ve Jenerik anlamýna gelir T yerine istediðimiz classý verebiliriz.
10-BaseEntity classý oluþtur ve tum entitileri bu classtan miras al
11- DAL altýnda ConcreteRepositories klasörünü aç ve içerisinde Repository ekle ve Irepositorýden miras al ve içeriniði enjecte et.
12- Migration atarken Start-up proje de mvc katmaný olmalý ve package manager console da default proje DAL seçilmeli ve migration atmadna once MVC katmanýna Manager NuGet Packetten Entitiy.core.desing paketini kur.
13-MVC katmanýnda Appsetting.Json connectingstring tanýmlamasý yap.
14- MVC katmanýnda Program.cs clasýnda database baðlantýsýný tanýma
15- Migration at
16-Program.cs de Ireapository ve repository baðlantýlarýný yap.
17-BLL projesinde git Dtos kalsörünü ekle ve içerisine data Entites de ne varsa aynan clas olarak tanýma eðer classlarýn içerisinde navigation properties var ise ayný isimli olmamalýdýr onun yanýna dto eklenir.
18- Dto ile Entitylerin arasýnda AutoMapper ile baðlantý kurulur bunun için BLL katmanýna Automapper paketi yüklenir Nuget Packetten.
19-mappering klasorü aç entityleri mapperla 
20- program.cs mapprleri yol göster.
21-MVC katmanýnda Model klasöründe VÝewModelleri Hazýrla 
22- MVC Katmanýnda Mapping klasörünü oluþtur ve DTO ile View modeller arasýnda ki mapplemeyi yap
23- DTO ile View Model arasýndaki maplemeyi Program.cs de yap
24- Controllerda Action yaz 
25- View Oluþtur.
26-Post service oluþtur
27- IMapper ve Irepository enjecte et
28- ctor tanýmla
29- Program cs. service baðlantýsý yap.
30- Post service içini doldur.
31-Model oluþtur.
32- User view modele gidip list post baðlantýsýný  ekle
33- Resimler string olarak atnýmlar because fotoðrafýn yolunu kaydediyoruz.
34-Mapping posttdo ile postview modelin yolunu ekle
35-PostController ekle
36-


