/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package cehars;

import java.util.ArrayList;
import java.util.Enumeration;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Set;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.servlet.http.HttpSession;
import javax.xml.ws.handler.MessageContext;
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
    
    Hashtable hash_tablosu33 = new Hashtable();
    private Object ekle;
    
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
        
                 return fiyat3+" TL";
             }   
         }
         
        return "Otel Bulunamadı";
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
                 if (bos == 5) {
                     return otel_ismi+"inde boş yer bulunmamaktadır!";
                 } else if(bos < 5) {
                     return otel_ismi+"inde " +(5-bos) +" kişilik boş yer var";
                 }
             }
         }
         
        return "Otel Bulunamadı";
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
     
                 return "Bilgiler Başarıyla Güncellendi.";
             }  
         }
         
     return "Otel Bulunamadı";    
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
                     return otel_ismi+"inde boş yer bulunmamaktadır!";
                 } else if(bos < 5) {
                     int kisi2 = Integer.parseInt(kisi);
                     int bos2 = bos + kisi2;
         
                     if (bos2 > 5) {
                         return otel_ismi+"inde boş yer bulunmamaktadır!";    
                     } else {
                         Rezervasyon st = (Rezervasyon) sess.load(Rezervasyon.class, id_yer);
                
                        st.setBos(bos2);

                        tr.commit();
                        sess.close();
                        
                     return otel_ismi+"inde "+ kisi2 +" Kişilik Rezervasyon Yapıldı";
                     }
                 }
            }    
        }
         
    return "Otel Bulunamadı";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "onay")
    public String onay(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "kac_kisi") String kac_kisi) {
        
        int bos2; 
        
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
                     return otel_ismi+"inde boş yer bulunmamaktadır!";
                 } else if(bos < 5) {
                     int kisi2 = Integer.parseInt(kac_kisi);
                     bos2 = bos + kisi2;
                 
                     if (bos2 > 5) {
                         return "en fazla " +(5 - bos)+" yer ayırabilirsiniz";
                     } else {
                     return kisi2*fiyat+" TL"  ;
                     }
                 }
             }
        }
    return "Otel Bulunamadı";
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

    /**
     * Web service operation
     */
    @WebMethod(operationName = "kayit_sil")
    public String kayit_sil(@WebParam(name = "otel_ismi") String otel_ismi) {
              
       try {
             
            
            Session sess = NewHibernateUtil.getSessionFactory().openSession();
            Transaction tr = sess.beginTransaction();

            Query query = sess.createQuery("from Rezervasyon");

            List result = query.list();
            Iterator it = result.iterator();
           
            int id = 0;

             while (it.hasNext()) {
                Rezervasyon emp = (Rezervasyon) it.next();
                 if ( emp.getIsim().equals(otel_ismi) ) {
                     id = emp.getId();
                     // fiyat3 = Integer.toString(fiyat);

                 }
             }

            Rezervasyon emp = (Rezervasyon) sess.load(Rezervasyon.class, id);
            sess.delete(emp);
            
            tr.commit();
            sess.close(); 
            
            return "Silme İşlemi Başarıyla Gerçekleştirildi";


        } catch (Exception e) {
            return "Silme İşlemi Sırasında Hata Oluştu";
        
        }
    }

    
    
    
    /**
     * Web service operation
     */
    @WebMethod(operationName = "onay3")
    public String onay3(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "kac_kisi") String kac_kisi) {
      
        int kisi2 = Integer.parseInt(kac_kisi);
        
          int bos2 = 0; 
          int i = 0;
          String key; 
         Object value;
         
          //  hash_tablosu33.put("deneme_otel", 2);
     
          Enumeration deneme19 = hash_tablosu33.keys(); 
         
         
          while (deneme19.hasMoreElements()) { 
              
            key = (String) deneme19.nextElement(); 
            
            if (otel_ismi.equals(key)) {
                  value = hash_tablosu33.get(key); 
                  i = (Integer) value;
                  bos2 = bos2 + i;
            }
            
          } 

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
                     return otel_ismi+"inde boş yer bulunmamaktadır!";
                 } else if(bos < 5) {
                     kisi2 = Integer.parseInt(kac_kisi);
                     bos2 = bos2 + bos + kisi2;
                     
                 
                     if (bos2 > 5) {
                         return otel_ismi+"inde boş yer bulunmamaktadır!";
                     } else {
                     
                       if(hash_tablosu33.containsKey(otel_ismi)) {
         
                        ekle = hash_tablosu33.get(otel_ismi);
                        int ekle2 = (Integer) ekle;
                        
                        ekle2 = ekle2 + kisi2;
                        
                        hash_tablosu33.put(otel_ismi, ekle2);
         
                    }
                       else {
                   hash_tablosu33.put(otel_ismi, kisi2);
                       }
                       
                     return kisi2*fiyat+" TL"  ;
                     
                     }
                 }
             }
        }
         
    return "Otel "+ i;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "onay_red")
    public String onay_red(@WebParam(name = "otel_ismi") String otel_ismi) {
        
        hash_tablosu33.remove(otel_ismi);
        
        return "onay reddedildi";
    }

    
    
    
    
    }