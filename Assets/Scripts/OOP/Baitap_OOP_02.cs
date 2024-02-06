using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinhVien 
{
    public static int Dem = 0; // dung duoc duoc truc tiep khi class truy xuat
    public string HoTen;
    public int Tuoi;
    public float DiemToan;
    private float DiemVan;

    public float diemVan
    {
        get
        {
            return DiemVan;
        }
        set
        {
            if (value >= 0 && value <= 10 )
            {
                DiemVan = value;
            }
        }
    }
    public SinhVien()
    {
        Dem++;
    }
    public SinhVien(string HoTen, int Tuoi, float DiemToan, float DiemVan)
    {
        this.HoTen = HoTen;
        this.Tuoi = Tuoi;
        this.DiemToan = DiemToan;
        this.DiemVan = DiemVan;
        Dem++;
    }
    public SinhVien(string HoTen, int Tuoi)
    {
        this.HoTen = HoTen;
        this.Tuoi = Tuoi;
        Dem++;
    }
}
public class Baitap_OOP_02 : MonoBehaviour
{
    void Start()
    {
        SinhVien a = new SinhVien();
        a.diemVan = 7;
        SinhVien b = new SinhVien();    
        b.diemVan = 5;
        Debug.Log("diem van 2 em a b la: " + a.diemVan +"va"+ b.diemVan);    
        Debug.Log("tong so hoc sinh: " + SinhVien.Dem);
    }
}
