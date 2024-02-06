using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Animal // khai bao lop cha voi tu khoa abstract => cac lop con can nhung tu khoa nhu override
{   // Khai báo l?p: <quy?n truy c?p> abstract class <tên l?p>{}
    /* khai báo ph??ng th?c: <Quy?n truy c?p> abstract <ki?utr?v?><Tên ph??ng th?c>(Danh sách tham s?)
       Trong abstract class ph?i ch?a ít nh?t 1 Abstract method
       Trong m?t Abstract  class có 3 lo?i ph??ng th?c: abstract method, virtual method, virtual method va notmal method.
    */
    // Normal method
    public void Bird()
    {
        Debug.Log("day la Normal Method cua Chim");
    }
    // Virtual method
    public virtual void Dog()
    {
        //thuc hien khoi lenh
        Debug.Log("Dong vat noi");
    }
    // abstract method
    public abstract void Cat();

}
// khai bao lop ke thua
public class DongVat : Animal
{
    // khi khai báo ph??ng th?c abstract Method thì b?t bu?c ph?i override và ph?m vi truy c?p ph?i giong lop cha
    public override void Cat()
    {
        Debug.Log("Day la con Meo");
    }
    // Khi khai báo ph??ng th?c Virtual Method  thì không b?t bu?c ph?i override và ph?m vi truy c?p ph?i gi?ng l?p cha
    public override void Dog()
    {
        Debug.Log("Day la con Cho");
    }
    //Normal Method dùng luôn l?p cha không c?n khai báo.
}
public class DongVat2 : Animal
{
    public override void Cat()
    {
        Debug.Log("Meo");
    }

}
public class Bai_30_Abstract : MonoBehaviour
{
   
    void Start()
    {
        // Abstract không the tao ra ?c ??i t??ng mà ph?i thông qua k? th?a c?a l?p con
        // <Tên l?p> <Tên bi?n> = new <Tên L?p> ==> Sai
        // <Tên l?p> <Tên bi?n> = new <Tên l?p k? th?a > && <Tên l?p k? th?a ><Tên ph??ng th?c> = new <Tên l?p k? th?a> ==> ?úng
        Animal ketqua = new DongVat();
        //DongVat ketqua1 = new DongVat(); 
        //DongVat2 ketqua2 = new DongVat2();
        //Animal.Bird();
        ketqua.Dog();
        //ketqua.Cat();
        //ketqua.Bird();
        //ketqua1.Cat();
        //ketqua2.Cat();  
    }
}
