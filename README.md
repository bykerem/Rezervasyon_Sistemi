#### Staj Çalýþmasý

Farklý platformlar arasýnda iletiþim kurarak rezervasyon arama listeleme gibi iþlemleri yapan bir çalýþma.

Web Servis ile farklý platformlar arasýnda iletiþim saðlanacak.

Web servisi java ile Web Servis Ýstemcisi C# ile kodlanmasý planlanýyor.

#### Kullanýlan diller ve teknolojiler ve geliþtirme ortamlarý
* java(web servis yazýldý)
* C # ( web servis istemcisi yazýldý)
* Mysql
* Hibernate
* Netbeans - Visual Studio
* Tomcat
* WampServer

Farklý platformlar arasýnda web servis çalýþmalarý

https://github.com/cehars/Rezervasyon_Sistemi/tree/master/Web%20Servisler

---------------------------------------------------------------------------

#### web servis java ile hazýrlandý.

File->New Project->java web -> web application

projeye saga týkla -> new -> java package

projeye saga týkla -> new -> other -> web service -> web service

Web services klasörü icindeki web servise saga týkla -> add operation (istersen parameters)

Proje saga týkla -> deploy 

Web services klasörü icindeki web servise saga týkla -> test web services

WSDL linki bizim kullanacagýmýz link.

---------------------------------------------------------------------------

#### web servis istemcisi c# ile hazýrlandý.

File -> new -> project -> windows forms application

Projeye saða týkla -> add service reference

Gelen pencereye yukarýda web servisinden hazýrladýðýmýz linki yapýþtýr.

--------------------------------------------------------------------------

#### Veritabaný için mysql veritabaný iþlemleri için hibernate kullanýldý.

1. Hibernate ->  Hibernate Cofiguration Wizard

2. Hibernate -> Hibernate Reverse Engineering (Paket gözükmezse kendimiz seçiyoruz. Bir sonraki adýmda bu iki adýmda oluþturduðumzu dosya lazým olacak.)

3. Hibernate -> Hibernate Mappings Files and POJOs from Databases

4. Hibernate -> HibernateUtil

-------------------------------------------------------------------

Uygulama çalýþtýrýlýrken wamp server açýk olmalý

-------------------------------------------------------------------
