package cehars.service;
// Generated 23.Tem.2013 23:33:36 by Hibernate Tools 3.2.1.GA



/**
 * Rezervasyon generated by hbm2java
 */
public class Rezervasyon  implements java.io.Serializable {


     private int id;
     private String isim;
     private int fiyat;
     private int bos;

    public Rezervasyon() {
    }

    public Rezervasyon(int id, String isim, int fiyat, int bos) {
       this.id = id;
       this.isim = isim;
       this.fiyat = fiyat;
       this.bos = bos;
    }
   
    public int getId() {
        return this.id;
    }
    
    public void setId(int id) {
        this.id = id;
    }
    public String getIsim() {
        return this.isim;
    }
    
    public void setIsim(String isim) {
        this.isim = isim;
    }
    public int getFiyat() {
        return this.fiyat;
    }
    
    public void setFiyat(int fiyat) {
        this.fiyat = fiyat;
    }
    public int getBos() {
        return this.bos;
    }
    
    public void setBos(int bos) {
        this.bos = bos;
    }




}


