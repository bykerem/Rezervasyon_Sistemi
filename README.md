#### Staj �al��mas�

Farkl� platformlar aras�nda ileti�im kurarak arama, listeleme, sorgulama, rezervasyon, kay�t ekleme, kay�t silme, kay�t g�ncelleme gibi i�lemleri yapan bir �al��ma.

Web Servis ile farkl� platformlar aras�nda ileti�im sa�lanacak.

Web servisi java ile Web Servis �stemcisi C# ile kodlanm��t�r.

#### Kullan�lan diller, teknolojiler ve geli�tirme ortamlar�
* java (web servis yaz�ld�)
* C # (web servis istemcisi yaz�ld�)
* Restful
* Mysql
* Hibernate
* GlassFish
* WampServer
* Netbeans - Visual Studio

---------------------------------------------------------------------------

#### web servis java ile haz�rland�.

Services -> Databases -> saga t�kla -> New Connection -> MYSQL -> ...

File->New Project->java web -> web application

projeye saga t�kla -> new -> java package

projeye saga t�kla -> new -> other -> web service -> restful web services from database

---------------------------------------------------------------------------

#### web servis istemcisi c# ile haz�rland�.

File -> new -> project -> windows forms application

Projeye sa�a t�kla -> add service reference

Gelen pencereye yukar�da web servisinden haz�rlad���m�z linki yap��t�r.

--------------------------------------------------------------------------

#### Veritaban� i�in mysql veritaban� i�lemleri i�in hibernate kullan�ld�.

1. Hibernate ->  Hibernate Cofiguration Wizard

2. Hibernate -> Hibernate Reverse Engineering (Paket g�z�kmezse kendimiz se�iyoruz. Bir sonraki ad�mda bu iki ad�mda olu�turdu�umzu dosya laz�m olacak.)

3. Hibernate -> Hibernate Mappings Files and POJOs from Databases

4. Hibernate -> HibernateUtil

-------------------------------------------------------------------

Uygulama �al��t�r�l�rken wamp server a��k olmal�.

-------------------------------------------------------------------

Uygulamay� �al��t�rd���m�zda m��teri ve admin paneli se�ene�i geliyor. A�a��daki b�l�mlerden olu�maktad�r.

##### Admin panelinde 

* Kay�t Ekleme
* Kay�t Silme
* Kay�t G�ncelleme


##### M��teri panelinde 

* Fiyat Sorgulama
* Bos Yer Sorgulama
* Otelleri Listeleme
* Rezervasyon

-------------------------------------------------------------------

##### Giri� Ekran�

![](http://k1307.hizliresim.com/1c/z/qz23f.png)

-------------------------------------------------------------------

##### Admin paneli

![](http://j1307.hizliresim.com/1c/z/qz2ct.png)

-------------------------------------------------------------------

##### Kay�t Ekleme
![](http://j1307.hizliresim.com/1c/z/qz2d2.png)

-------------------------------------------------------------------

##### Divan Oteli Eklendi.

![](http://j1307.hizliresim.com/1c/z/qz23k.png)

------------------------------------------------------------------

##### Kay�t Silme

![](http://j1307.hizliresim.com/1c/z/qz2hv.png)

------------------------------------------------------------------

##### Divan Oteli Silindi.

![](http://j1307.hizliresim.com/1c/z/qz2gq.png)

-------------------------------------------------------------------

##### Kay�t G�ncelleme

![](http://j1307.hizliresim.com/1c/z/qz27j.png)

-------------------------------------------------------------------

##### Ankara Plaza Hotel'in bo� yer say�s� 5 idi 9 yap�ld�.

![](http://j1307.hizliresim.com/1c/z/qz27t.png)

-------------------------------------------------------------------

##### M��teri Paneli

![](http://k1307.hizliresim.com/1c/z/qz27y.png)

-------------------------------------------------------------------

##### Fiyat Sorgulama

![](http://j1307.hizliresim.com/1c/z/qz292.png)

-------------------------------------------------------------------

##### Bo� Yer Sorgulama

![](http://j1307.hizliresim.com/1c/z/qz2b7.png)

-------------------------------------------------------------------

##### Yer Ay�rtma

![](http://l1307.hizliresim.com/1c/z/qz35p.png)

-------------------------------------------------------------------

##### Onay Penceresi

![](http://l1307.hizliresim.com/1c/z/qz2b5.png)

-------------------------------------------------------------------

##### Ankara Plaza Hotel'inden 3 ki�ilik yer ayr�ld�. Bo� Yer say�s� 6'ya d��t�.

![](http://l1307.hizliresim.com/1c/z/qz2bg.png)
