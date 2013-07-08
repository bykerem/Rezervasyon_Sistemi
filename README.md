#### Staj �al��mas�

Farkl� platformlar aras�nda ileti�im kurarak rezervasyon arama listeleme gibi i�lemleri yapan bir �al��ma.

Web Servis ile farkl� platformlar aras�nda ileti�im sa�lanacak.

Web servisi java ile Web Servis �stemcisi C# ile kodlanmas� planlan�yor.

#### Kullan�lan diller ve teknolojiler ve geli�tirme ortamlar�
* java(web servis yaz�ld�)
* C # ( web servis istemcisi yaz�ld�)
* Mysql
* Hibernate
* Netbeans - Visual Studio
* Tomcat
* WampServer

Farkl� platformlar aras�nda web servis �al��malar�

https://github.com/cehars/Rezervasyon_Sistemi/tree/master/Web%20Servisler

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
