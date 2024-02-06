using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_28_Class_02 : MonoBehaviour
{
    public class DongVat
    {
        string loai;
        int CanNang;
        double ChieuCao;
        bool GioiTinh;
        public void HienThi()
        {
            string gioitinh1;
            if(GioiTinh == true)
            {
                gioitinh1 = "giong duc";
            }
            else
            {
                gioitinh1 = "giong cai";
            }
            Debug.Log("Hien thi doi tuong: " + ":" + loai + ":" + CanNang + ":" + ChieuCao + ":" + gioitinh1);
        }
        public DongVat()
        {

        }
        public DongVat(string l,int n,int c)
        {
            loai = l;
            CanNang = n;
            ChieuCao = c;   

        }
        public DongVat(string l, int a, double c, bool d)
        {
            loai = l;
            CanNang = a;
            ChieuCao = c;
            GioiTinh = d;
        }
    }
    void Start()
    {
        DongVat khongbien = new DongVat();
        khongbien.HienThi();
        DongVat Cat = new DongVat("Meo", 20, 12);
        Cat.HienThi();
        DongVat Dog = new DongVat("Cho", 30, 40);
        Dog.HienThi();
        DongVat maleCat = new DongVat("Meo Duc", 12, 14,true);
        maleCat.HienThi();
        DongVat femaleDog = new DongVat("Cho Cai", 23, 40, false);
        femaleDog.HienThi();
    }

}
