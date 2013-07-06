/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package cehars;

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
}
