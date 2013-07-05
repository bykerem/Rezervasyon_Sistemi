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

    /**
     * Web service operation
     */
    @WebMethod(operationName = "operasyon1")
    public String operasyon1() {
        //TODO write your implementation code here:
        return "cehars";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "operasyon2")
    public int operasyon2(@WebParam(name = "parameter") String parameter) {
        //TODO write your implementation code here:
      // Session sess = NewHibernateUtil.getSessionFactory().openSession();
      //  Rezervasyon deneme = (Rezervasyon)sess.get(Rezervasyon.class, 1);
      //  System.out.print(deneme.getIsim()); 
        
         org.hibernate.Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        Rezervasyon emp = (Rezervasyon) it.next();
         
         while (it.hasNext()) {
           
            // System.out.print(emp.getIsim());
            // System.out.print("   " + emp.getFiyat());
            // System.out.println();
            return emp.getFiyat();
         }
         
        return emp.getFiyat();
        
    }

    
}
