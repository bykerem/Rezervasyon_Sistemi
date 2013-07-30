/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package cehars.service;

import cehars.Rezervasyon;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;
import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import org.hibernate.Session;
import org.hibernate.Transaction;

/**
 *
 * @author cehars
 */
@Stateless
@Path("cehars.rezervasyon")
public class RezervasyonFacadeREST extends AbstractFacade<Rezervasyon> {
    @PersistenceContext(unitName = "5PU")
    private EntityManager em;
    private String ucret3;
    private String bos_sayisi3;

    public RezervasyonFacadeREST() {
        super(Rezervasyon.class);
    }

    @POST
    @Override
    @Consumes({"application/xml", "application/json"})
    public void create(Rezervasyon entity) {
        super.create(entity);
    }

    @PUT
    @Override
    @Consumes({"application/xml", "application/json"})
    public void edit(Rezervasyon entity) {
        super.edit(entity);
    }

    @DELETE
    @Path("{id}")
    public void remove(@PathParam("id") Integer id) {
        super.remove(super.find(id));
    }

    @GET
    @Path("{id}")
    @Produces({"application/xml", "application/json"})
    public Rezervasyon find(@PathParam("id") Integer id) {
        return super.find(id);
    }

    @GET
    @Override
    @Produces({"application/xml", "application/json"})
    public List<Rezervasyon> findAll() {
        return super.findAll();
    }

    @GET
    @Path("{from}/{to}")
    @Produces({"application/xml", "application/json"})
    public List<Rezervasyon> findRange(@PathParam("from") Integer from, @PathParam("to") Integer to) {
        return super.findRange(new int[]{from, to});
    }

    @GET
    @Path("count")
    @Produces("text/plain")
    public String countREST() {
        return String.valueOf(super.count());
    }

    @Override
    protected EntityManager getEntityManager() {
        return em;
    }
    
    
    @GET
    @Path("ekle/{isim}/{fiyat}/{bos}")
    //@Produces({"application/xml", "application/json"})
    public String ekle(@PathParam("isim") String isim, @PathParam("fiyat") Integer fiyat, @PathParam("bos") Integer bos) {
        
        
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        cehars.service.Rezervasyon emp = new cehars.service.Rezervasyon();
        emp.setIsim(isim);
        emp.setFiyat(fiyat);
        emp.setBos(bos);
        sess.save(emp);
        tr.commit();
        
        return "Kayit Basariyla Eklendi";
    }
    
    
    
    @GET
    @Path("sil/{isim}")
    //@Produces({"application/xml", "application/json"})
    public String sil(@PathParam("isim") String isim) {
        int id = 0;
        try {
            
            Session sess = NewHibernateUtil.getSessionFactory().openSession();
            Transaction tr = sess.beginTransaction();

            org.hibernate.Query query = sess.createQuery("from Rezervasyon");

            List result = query.list();
            Iterator it = result.iterator();
           
             while (it.hasNext()) {
                
                cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) it.next();
                 if ( emp.getIsim().equals(isim) ) {
                     id = emp.getId();
                     
                     // fiyat3 = Integer.toString(fiyat);
                 }
                 
             }

            cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) sess.load(cehars.service.Rezervasyon.class, id);
            sess.delete(emp);
            
            tr.commit();
            sess.close(); 
            
            return "Silme islemi Basariyla Gerceklestirildi";


        } catch (Exception e) {
            return "Otel Bulunamadi!!!";
        }
    }
    
    
    
    @GET
    @Path("fiyat/{isim}")
    //@Produces({"application/xml", "application/json"})
    public String fiyat(@PathParam("isim") String isim) {
        
     Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        org.hibernate.Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) it.next();
             if ( emp.getIsim().equals(isim) ) {
                 
                 int ucret = emp.getFiyat();
                 ucret3 = Integer.toString(ucret);
        
                 return ucret3+" TL";
             }   
         }
         
        return "Otel Bulunamadı";    
    
    }
    
    
    @GET
    @Path("bos/{isim}")
    //@Produces({"application/xml", "application/json"})
    public String bos(@PathParam("isim") String isim) {
        
     Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        org.hibernate.Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) it.next();
             if ( emp.getIsim().equals(isim) ) {
                 
                 int bos_sayisi = emp.getBos();
                 bos_sayisi3 = Integer.toString(bos_sayisi);
        
                 return bos_sayisi3+" kisilik bos yer var";
             }   
         }
         
        return "Otel Bulunamadı";    
    
    }
    
    
     @GET
    @Path("guncelle/{isim}/{fiyat}/{bos}")
    //@Produces({"application/xml", "application/json"})
    public String guncelle(@PathParam("isim") String isim, @PathParam("fiyat") int fiyat, @PathParam("bos") int bos) {
        
     Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        org.hibernate.Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
            cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) it.next();
             if ( emp.getIsim().equals(isim) ) {
                 int id_guncelle = emp.getId();
                 
                 cehars.service.Rezervasyon st = (cehars.service.Rezervasyon) sess.load(cehars.service.Rezervasyon.class, id_guncelle);
                 // int fiyat_guncelle = Integer.parseInt(fiyat);
                 // int bos_guncelle = Integer.parseInt(bos);
                 
                 st.setFiyat(fiyat);
                 st.setBos(bos);
                 
                 tr.commit();
                 sess.close();
     
                 return "Bilgiler Basariyla Guncellendi";
             }  
         }
         
     return "Otel Bulunamadı";  
    }
    
     
     
     @GET
    @Path("listele_isim")
    //@Produces({"application/xml", "application/json"})
    public List<String> listele_isim() {
        
     List<String> liste = new ArrayList<>();
      
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        org.hibernate.Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
             
            cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) it.next();
            liste.add(emp.getIsim());
        }
            
    return liste;  
    
    }
    
     
     @GET
    @Path("listele_fiyat")
    //@Produces({"application/xml", "application/json"})
    public List<String> listele_fiyat() {
        
     List<String> liste2 = new ArrayList<>();
      
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        org.hibernate.Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
             
             cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) it.next();
             String fiyat_str = Integer.toString(emp.getFiyat());
             liste2.add(fiyat_str);
        }
            
    return liste2;  
    
    }
    
     
     @GET
    @Path("listele_bos")
    //@Produces({"application/xml", "application/json"})
    public List<String> listele_bos(){
        
     List<String> liste3 = new ArrayList<>();
      
        Session sess = NewHibernateUtil.getSessionFactory().openSession();
        Transaction tr = sess.beginTransaction();
        
        org.hibernate.Query query = sess.createQuery("from Rezervasyon");
        
        List result = query.list();
        Iterator it = result.iterator();
        
         while (it.hasNext()) {
             
             
             cehars.service.Rezervasyon emp = (cehars.service.Rezervasyon) it.next();
             String bos_str = Integer.toString(emp.getBos());
             liste3.add(bos_str); 
        }
            
    return liste3;  
    
    }
    
     
}
