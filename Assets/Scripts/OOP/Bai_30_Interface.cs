using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_30_Interface : MonoBehaviour
{
    // Cu phap:   InterFace <Ten interface>{}
    interface Animal // Khai bao truoc cac phuong thuc    
    {
        // Khai bao cac thanh phan ben trong Interface 
        // Cac phuong thuc ben trong duoc khai bao nhung khong co dinh nghia noi dung (Khong co gi ben trong => Rong/empty)
        // Mac dinh trong Interface la phuong thuc truy cap public va khong the khai bao pham vi truy cap khac ngoai public.
        void Cat();
        void Dog();
        void TinhToan(int a, float b, string c);

    }
    class SucVat : Animal // lop duoc thuc thi chuyen doi giong nhu lop ke thua
    {
        public void Cat() // Dinh nghia noi dung cho phuong thuc trong interface.
                          //Phuong thuc  < Ten phuong thuc ()> phai co pham vi truy cap la public
        {
            Debug.Log("Con Meo");
        }
        public void Dog()
        {
            Debug.Log("Con Cho");
        }
        public void TinhToan(int a, float b, string c)
        {
            float tong;
            tong = a + b + float.Parse(c);
            Debug.Log("tong la :" + tong);
        }
    }
    // trien khai nhieu Interface
    interface Animal1
    {
        void Bird();
        void Trex(int a);
    }
    class SucVat1 : Animal1
    {
        public void Bird()
        {
            Debug.Log("Con Chim");
        }
        public void Trex(int a)
        {
            a = 20;
            Debug.Log("So Trex la :" + a);
        }
            
    }

    void Start()
    {
        Animal ketqua = new SucVat();
        Animal1 ketqua1 = new SucVat1();
        ketqua.TinhToan(1,2,"4");
        ketqua1.Bird(); 

    }


}
