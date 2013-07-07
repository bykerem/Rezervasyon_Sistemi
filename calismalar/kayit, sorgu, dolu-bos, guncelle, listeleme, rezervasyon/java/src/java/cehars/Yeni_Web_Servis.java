/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package cehars;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.hibernate.Query;
import org.hibernate.Transaction;
import org.hibernate.classic.Session;

/**
 *
 * @author cehars
 */
@WebService(serviceName = "Yeni_Web_Servis")
public class Yeni_Web_Servis {
    private int fiyat2;
    private String fiyat3;

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "deneme")
    public String deneme(@WebParam(name = "parameter") String parameter) {
        //TODO write your implementation code here:
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        Rezervasyon emp = new Rezervasyon();
        emp.setIsim("deneme_otel3");
        emp.setFiyat(33);
        sess.save(emp);
        tr.commit();
        // System.out.println("Başarıyla eklendi"); 
        
        
        return "cehars";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "ekle")
    public String ekle(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "fiyat") String fiyat) {
        
        fiyat2 = Integer.parseInt(fiyat);
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        Rezervasyon emp = new Rezervasyon();
        emp.setIsim(otel_ismi);
        emp.setFiyat(fiyat2);
        sess.save(emp);
        tr.commit();
        
        return "Kayit Başarıyla Eklendi";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "sorgu")
    public String sorgu(@WebParam(name = "otel_ismi") String otel_ismi) {
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                 int fiyat = emp.getFiyat();
                 fiyat3 = Integer.toString(fiyat);
                 return fiyat3;
             }
                    
         }
         
        return "sorgu bulunamadı";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "doluluk_durumu")
    public String doluluk_durumu(@WebParam(name = "otel_ismi") String otel_ismi) {
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                 int bos = emp.getBos();
                 // fiyat3 = Integer.toString(fiyat);
                 if (bos == 5) {
                     return "otel dolu";
                      
                 } else if(bos < 5) {
                     return "otel boş";
                 }
             }
                    
         }
         
        return "sorgu bulunamadı";
        
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "guncelle")
    public String guncelle(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "fiyat") String fiyat) {
     
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                 int id_guncelle = emp.getId();
                 
                 Rezervasyon st = (Rezervasyon) sess.load(Rezervasyon.class, id_guncelle);
                 int fiyat_guncelle = Integer.parseInt(fiyat);
                 
                 st.setFiyat(fiyat_guncelle);
                 
                 tr.commit();
                 sess.close();
                 return "başarıyla güncellendi";
                 
             }  
         }
     return "otel bulunamadı";    
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "Yer_Ayirt")
    public String Yer_Ayirt(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "kisi") String kisi) {
       
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                 int id_yer = emp.getId();
                 
                 int bos = emp.getBos();
                 if (bos == 5) {
                     return "otel dolu";
                 } else if(bos < 5) {
                     int kisi2 = Integer.parseInt(kisi);
                     int bos2 = bos + kisi2;
                     if (bos2 > 5) {
                         return "en fazla " +(5 - bos)+" yer ayırabilirsiniz";
                         
                     } else {
                         Rezervasyon st = (Rezervasyon) sess.load(Rezervasyon.class, id_yer);
                
                        st.setBos(bos2);

                        tr.commit();
                        sess.close();
                 
                     return "yer ayırtıldı";
                     }
                     
                 
                 }
                 }
                 
                 
    }
         return "otel bulunamadı";
}

    /**
     * Web service operation
     */
    @WebMethod(operationName = "onay")
    public String onay(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "kac_kisi") String kac_kisi) {
    Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                 int id_yer = emp.getId();
                 int fiyat = emp.getFiyat();
                 int bos = emp.getBos();
                 if (bos == 5) {
                     return "otel dolu";
                 } else if(bos < 5) {
                     int kisi2 = Integer.parseInt(kac_kisi);
                     int bos2 = bos + kisi2;
                     if (bos2 > 5) {
                         return "en fazla " +(5 - bos)+" yer ayırabilirsiniz";
                         
                     } else {
                 
                     return kisi2*fiyat+""  ;
                     }
                     
                 
                 }
                 }
                 
                 
    }
         return "otel bulunamadı";

    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "listele_isim")
    public List<String> listele_isim() {
      
        List<String> liste = new ArrayList<String>();
      
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
            liste.add(emp.getIsim());
            
        }
            
       return liste;  
         
    }
    
    /**
     * Web service operation
     */
    @WebMethod(operationName = "listele_fiyat")
    public List<String> listele_fiyat() {
      
        List<String> liste = new ArrayList<String>();
      
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
            
            liste.add(Integer.toString(emp.getFiyat()));
            
        }
         
       return liste;
         
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "listele_bos")
    public List<String> listele_bos() {
      
         List<String> liste = new ArrayList<String>();
      
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
            
            liste.add(Integer.toString(emp.getBos()));
            
        }
         
       return liste;
       
    }
    
}
