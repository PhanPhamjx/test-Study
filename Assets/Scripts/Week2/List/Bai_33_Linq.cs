using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
// Linq dung de truy van va tim kiem doi tuong
public class Bai_33_Linq : MonoBehaviour
{
    // Khai bao 1 mang list co kieu du lieu la SinhVat
    public class SinhVat
    {
        public string TenSinhVat { get; set; }

        public int ChieuCao { get; set; }

    }
    // khai bao 1 mot mang list co co kieu du lieu la : SinhVat
    List<SinhVat> lstDanhSachSinhVat = new List<SinhVat>();
    void Start()
    {
        SinhVat sinhvat;
        sinhvat = new SinhVat();
        sinhvat.TenSinhVat = "Trex";
        sinhvat.ChieuCao = 350;
        lstDanhSachSinhVat.Add(sinhvat);
        sinhvat = new SinhVat();
        sinhvat.TenSinhVat = "Dinaasour";
        sinhvat.ChieuCao = 600;
        lstDanhSachSinhVat.Add(sinhvat);
        sinhvat = new SinhVat();
        sinhvat.TenSinhVat = "Kaiju";
        sinhvat.ChieuCao = 520;
        lstDanhSachSinhVat.Add(sinhvat);
        // tim sinh vat co chieu cao >= 500, in ra man hinh
        // tao mot list truy van moi de chua 
        List<SinhVat> lsttruyvanmoi = lstDanhSachSinhVat.Where(creature => creature.ChieuCao >= 2000 || creature.TenSinhVat.Contains("a")).OrderBy(r => r.ChieuCao).Take(1).ToList();
        // .OrderBy() = Sap xep theo chieu tang dan || .OrderByDescending = Sap xep theo chieu giam dan.
        // .Take(<so thu tu phan  tu >) = Lay phan tu tu so thu tu
        // dung foreach duyet list lstTruyvanmoi
        // first
        Debug.Log("so luong : " + lsttruyvanmoi.Count);
        if (lsttruyvanmoi.Count != 0)
        {
            string ten = lsttruyvanmoi.First().TenSinhVat;
            string chieucao = lsttruyvanmoi.First().ChieuCao.ToString();
            Debug.Log("Ten: " + ten + chieucao);
        }
        foreach (SinhVat creature in lsttruyvanmoi)
        {
            //Debug.Log("Ten sinh vat: " + creature.TenSinhVat + "Chieu cao: " + creature.ChieuCao);
        }
    }




}
