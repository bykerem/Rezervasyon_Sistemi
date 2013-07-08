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
    @WebMethod(operationName = "sil")
    public String sil(@WebParam(name = "otel_ismi") String otel_ismi) {
       
        
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
            return "Otel Bulunamadı";
        
        }
        
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "fiyat_bul")
    public String fiyat_bul(@WebParam(name = "otel_ismi") String otel_ismi) {
        
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                 
                 int fiyat_int = emp.getFiyat();
                 
                 String fiyat = Integer.toString(fiyat_int);

                 
                 return fiyat;
             }
         }
         
        return "Otel Bulunamadı";
        
        
        
    }

   /**
     * Web service operation
     */
    @WebMethod(operationName = "bos_bul")
    public String bos_bul(@WebParam(name = "otel_ismi") String otel_ismi) {
        
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                 
                 int bos_int = emp.getBos();
                 
                 String bos = Integer.toString(bos_int);

                 
                 return bos;
             }
         }
         
        return "Otel Bulunamadı";
        
        
        
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "guncelle")
    public String guncelle(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "fiyat") String fiyat, @WebParam(name = "bos") String bos) {
       
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
                 
                 st.setIsim(otel_ismi);
                 st.setFiyat(Integer.parseInt(fiyat));
                 st.setBos(Integer.parseInt(bos));
                 
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
    @WebMethod(operationName = "ekle")
    public String ekle(@WebParam(name = "otel_ismi") String otel_ismi, @WebParam(name = "fiyat") String fiyat, @WebParam(name = "bos") String bos) {
        
        int fiyat2 = Integer.parseInt(fiyat);
        int bos2 = Integer.parseInt(bos);

        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
        int durum = 0;
        
         while (it.hasNext()) {
            Rezervasyon emp = (Rezervasyon) it.next();
             if ( emp.getIsim().equals(otel_ismi) ) {
                   durum = 1;
             }
         }
         
         if (durum == 0) {
             Rezervasyon emp = new Rezervasyon();
        
        emp.setIsim(otel_ismi);
        emp.setFiyat(fiyat2);
        emp.setBos(bos2);
        
        sess.save(emp);
        tr.commit();
        return "Kayıt Başarıyla Eklendi";
        }
        else
            return "Aynı Kayıttan Var";
        
    }

    
}
