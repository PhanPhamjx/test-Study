using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bai_28_Class : MonoBehaviour
{
    public class ThoiGian  // tao mot lop theo dinh nghia (thuoc tinh) class<dinh danh>,
    {
        int Nam;
        int Thang;
        int Ngay;
        int Gio;
        int Phut;
        int Giay;
        public void ThoiGianHienHanh()// 
        {
            Debug.Log("Hien thi thoi gian hien hanh: " + Nam + Thang + Ngay + Gio + Phut + Giay);
        }
        public ThoiGian(System.DateTime dt) // Tao phuong thuc khoi tao trung voi ten class.
                                            // Co tham so truyen vao hoac khong co tham so truyen vao
                                            // Tham so truyen vao co data type la DateTime + ten bien = dt                                   
        {
            Nam = dt.Year;
            Thang = dt.Month;
            Ngay = dt.Day;
            Gio = dt.Hour;
            Phut = dt.Minute;
            Giay = dt.Second;
        }
        public ThoiGian()// ham khoi tao khong chua tham so
        {
            // Voi cac tham so khong duoc khai bao nhu trong nay. Chuong trinh C# mac dinh la 0
            // int , long, byte, ... = 0, bool = false, char ='0'(null), enum = 0, reference = null
        } 
    }
    void Start()
    {
        // new + <Data types> = khoi tao moi
        ThoiGian t = new ThoiGian(); // khoi tao moi mot bien co kieu du lieu la thoi gian
        t.ThoiGianHienHanh(); // truy xuat vao phuong thuc 
        System.DateTime thoigianhientai = System.DateTime.Now;
        ThoiGian d = new ThoiGian(thoigianhientai); // Khoi tao moi mot Bien d voi tham so la thoigianhientai
        d.ThoiGianHienHanh();
    }


}
