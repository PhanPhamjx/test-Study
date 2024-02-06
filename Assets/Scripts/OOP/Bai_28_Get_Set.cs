using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_28_Get_Set : MonoBehaviour
{
    public class SinhVien
    {
        public static int dem = 0;     // static: bien tinh hang so = khong bi thay doi
        private float DiemLy;          // private chi dung trong class noi bo, muc dich la bao mat
        // De lay gia tri cua bien sau private phai thong qua thuoc tinh diemLy


        public SinhVien() // 
        {
            dem++;
        }
        public float diemLy // Thuoc tinh   
        {
            get               // lay gia tri + phai co return
            {
                return DiemLy;
            }
            set               // gan gia tri
            {
                if (value >= 0)
                {
                    DiemLy = value;
                }
            }
        }
    }
    void Start()
    {
        SinhVien SV1 = new SinhVien();
        SV1.diemLy = 7;
        SinhVien SV2 = new SinhVien();
        SinhVien SV3 = new SinhVien();
        SinhVien SV4 = new SinhVien();
        Debug.Log("Diem Ly la: " + SV1.diemLy);
        //Debug.Log("Bien Static Dem" + SinhVien.dem);
    }


}
