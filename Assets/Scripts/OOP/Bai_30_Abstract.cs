using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Animal // khai bao lop cha voi tu khoa abstract => cac lop con can nhung tu khoa nhu override
{   // Khai b�o l?p: <quy?n truy c?p> abstract class <t�n l?p>{}
    /* khai b�o ph??ng th?c: <Quy?n truy c?p> abstract <ki?utr?v?><T�n ph??ng th?c>(Danh s�ch tham s?)
       Trong abstract class ph?i ch?a �t nh?t 1 Abstract method
       Trong m?t Abstract  class c� 3 lo?i ph??ng th?c: abstract method, virtual method, virtual method va notmal method.
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
    // khi khai b�o ph??ng th?c abstract Method th� b?t bu?c ph?i override v� ph?m vi truy c?p ph?i giong lop cha
    public override void Cat()
    {
        Debug.Log("Day la con Meo");
    }
    // Khi khai b�o ph??ng th?c Virtual Method  th� kh�ng b?t bu?c ph?i override v� ph?m vi truy c?p ph?i gi?ng l?p cha
    public override void Dog()
    {
        Debug.Log("Day la con Cho");
    }
    //Normal Method d�ng lu�n l?p cha kh�ng c?n khai b�o.
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
        // Abstract kh�ng the tao ra ?c ??i t??ng m� ph?i th�ng qua k? th?a c?a l?p con
        // <T�n l?p> <T�n bi?n> = new <T�n L?p> ==> Sai
        // <T�n l?p> <T�n bi?n> = new <T�n l?p k? th?a > && <T�n l?p k? th?a ><T�n ph??ng th?c> = new <T�n l?p k? th?a> ==> ?�ng
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
