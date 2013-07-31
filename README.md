#### Staj Çalýþmasý

Farklý platformlar arasýnda iletiþim kurarak arama, listeleme, sorgulama, rezervasyon, kayýt ekleme, kayýt silme, kayýt güncelleme gibi iþlemleri yapan bir çalýþma.

Web Servis ile farklý platformlar arasýnda iletiþim saðlanacak.

Web servisi java ile Web Servis Ýstemcisi C# ile kodlanmýþtýr.

#### Kullanýlan diller, teknolojiler ve geliþtirme ortamlarý
* java (web servis yazýldý)
* C # (web servis istemcisi yazýldý)
* Restful
* Mysql
* Hibernate
* GlassFish
* WampServer
* Netbeans - Visual Studio

---------------------------------------------------------------------------

#### web servis java ile hazýrlandý.

Services -> Databases -> saga týkla -> New Connection -> MYSQL -> ...

File->New Project->java web -> web application

projeye saga týkla -> new -> java package

projeye saga týkla -> new -> other -> web service -> restful web services from database

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

Uygulama çalýþtýrýlýrken wamp server açýk olmalý.

-------------------------------------------------------------------

Uygulamayý çalýþtýrdýðýmýzda müþteri ve admin paneli seçeneði geliyor. Aþaðýdaki bölümlerden oluþmaktadýr.

##### Admin panelinde 

* Kayýt Ekleme
* Kayýt Silme
* Kayýt Güncelleme


##### Müþteri panelinde 

* Fiyat Sorgulama
* Bos Yer Sorgulama
* Otelleri Listeleme
* Rezervasyon

-------------------------------------------------------------------

##### Giriþ Ekraný

![](http://j1307.hizliresim.com/1c/z/qyxbx.png)

-------------------------------------------------------------------

##### Admin paneli

![](http://k1307.hizliresim.com/1c/z/qyxcd.png)

-------------------------------------------------------------------

##### Kayýt Ekleme

![](http://l1307.hizliresim.com/1c/z/qyxcf.png)
-------------------------------------------------------------------

##### Divan Oteli Eklendi

![](http://j1307.hizliresim.com/1c/z/qyxc5.png)

-------------------------------------------------------------------

##### Kayýt Silme

![](http://j1307.hizliresim.com/1c/z/qyxcc.png)

-------------------------------------------------------------------

##### Kayýt Güncelleme

![](http://j1307.hizliresim.com/1c/z/qyxfq.png)

-------------------------------------------------------------------

##### Divan Oteli boþ yer sayýsý 9 yapýldý.

![](http://j1307.hizliresim.com/1c/z/qyxc1.png)

-------------------------------------------------------------------

##### Müþteri Paneli

![](http://k1307.hizliresim.com/1c/z/qyxch.png)

-------------------------------------------------------------------

##### Fiyat Sorgulama

![](http://l1307.hizliresim.com/1c/z/qyxcn.png)

-------------------------------------------------------------------

##### Boþ Yer Sorgulama

![](http://k1307.hizliresim.com/1c/z/qyxcu.png)

-------------------------------------------------------------------

##### Yer Ayýrtma

![](http://k1307.hizliresim.com/1c/z/qyxcq.png)

-------------------------------------------------------------------

##### Onay Penceresi

![](http://j1307.hizliresim.com/1c/z/qyxcv.png)

-------------------------------------------------------------------

##### Divan otelinden 3 kiþilik yer ayrýldý.

![](http://k1307.hizliresim.com/1c/z/qyxct.png)
