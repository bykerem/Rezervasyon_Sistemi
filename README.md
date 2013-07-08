#### Staj �al��mas�

Farkl� platformlar aras�nda ileti�im kurarak arama, listeleme, sorgulama, rezervasyon, kay�t ekleme, kay�t silme, kay�t g�ncelleme gibi i�lemleri yapan bir �al��ma.

Web Servis ile farkl� platformlar aras�nda ileti�im sa�lanacak.

Web servisi java ile Web Servis �stemcisi C# ile kodlanm��t�r.

#### Kullan�lan diller, teknolojiler ve geli�tirme ortamlar�
* java (web servis yaz�ld�)
* C # (web servis istemcisi yaz�ld�)
* Mysql
* Hibernate
* Tomcat
* WampServer
* Netbeans - Visual Studio

---------------------------------------------------------------------------

#### web servis java ile haz�rland�.

File->New Project->java web -> web application

projeye saga t�kla -> new -> java package

projeye saga t�kla -> new -> other -> web service -> web service

Web services klas�r� icindeki web servise saga t�kla -> add operation (istersen parameters)

Proje saga t�kla -> deploy 

Web services klas�r� icindeki web servise saga t�kla -> test web services

WSDL linki bizim kullanacag�m�z link.

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

Uygulama �al��t�r�l�rken wamp server a��k olmal�

-------------------------------------------------------------------

Uygulamay� �al��t�rd���m�zda m��teri ve admin panelini se�ene�i geliyor. A�a��daki b�l�mlerden olu�maktad�r.

##### Admin panelinde 

* Kay�t Ekleme
* Kay�t G�ncelleme
* Kay�t Silme

##### M��teri panelinde 
* Rezervasyon
* Fiyat Sorgulama
* Otelin Doluluk Durumu
* Otelleri Listeleme

-------------------------------------------------------------------

![](http://m1307.hizliresim.com/1c/8/q0hgz.png)

-------------------------------------------------------------------

![](http://m1307.hizliresim.com/1c/8/q0hgr.png)

-------------------------------------------------------------------

![](http://r1307.hizliresim.com/1c/8/q0hgu.png)

-------------------------------------------------------------------

![](http://r1307.hizliresim.com/1c/8/q0hgs.png)

-------------------------------------------------------------------

![](http://u1307.hizliresim.com/1c/8/q0hgt.png)
