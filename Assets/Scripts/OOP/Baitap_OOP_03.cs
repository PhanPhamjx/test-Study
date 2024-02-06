using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HocSinh
{
     string HoTen;
     int Tuoi;
     bool GioiTinh;
     public static int TongSoHocSinh;
    public HocSinh()
    {

    }
    public HocSinh(string HoTen, int Tuoi, bool GioiTinh)
    {
        this.HoTen = HoTen;
        this.Tuoi = Tuoi;
        this.GioiTinh = GioiTinh;
        TongSoHocSinh++;
    }
    public HocSinh(string Hoten, int Tuoi)
    {
        this.HoTen = Hoten;
        this.Tuoi = Tuoi;
        TongSoHocSinh++;
    }
    public void GanThongtin(string ten, int tuoi, bool gioitinh)
    {
        this.HoTen = ten;
        this.Tuoi = tuoi;
        this.GioiTinh = gioitinh;
    }
    public void LayThongTin()
    {

        string giatri ="";
        if (GioiTinh)
        {
            giatri = "Nam";
        }
        else
        {
            giatri = "Nu";
        }
        Debug.Log("Hoc sinh: " + TongSoHocSinh + "--->" + HoTen + "--->" + Tuoi + "--->" + giatri);
    }
}
class HocSinhNam: HocSinh
{
    public HocSinhNam()
    {
        TongSoHocSinh++;
    }
    
}
public class Baitap_OOP_03 : MonoBehaviour
{

    void Start()
    {
        HocSinhNam Ryan = new HocSinhNam();
        Ryan.GanThongtin("Tung", 23, true);
        Ryan.LayThongTin();

        HocSinhNam Ryan1 = new HocSinhNam();
        Ryan1.GanThongtin("Tung", 23, true);
        Ryan1.LayThongTin();

        HocSinhNam Ryan2 = new HocSinhNam();
        Ryan2.GanThongtin("Tung", 23, true);
        Ryan2.LayThongTin();

        HocSinhNam Ryan3 = new HocSinhNam();
        Ryan2.GanThongtin("Tung", 23, true);
        Ryan2.LayThongTin();

        Debug.Log("Tong hoc sinh:" + HocSinh.TongSoHocSinh);
    }

}
