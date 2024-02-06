using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BaiTap_01 : MonoBehaviour
{
    public class SinhVien
    {
        public string HoTen;
        public int Tuoi;
    }
    List<SinhVien> lstSinhVien = new List<SinhVien>();
    void Start()
    {
        SinhVien sinhvien;
        sinhvien = new SinhVien();
        sinhvien.HoTen = "Hoang Thi Thuy";
        sinhvien.Tuoi = 23;
        lstSinhVien.Add(sinhvien);

        sinhvien = new SinhVien();
        sinhvien.HoTen = "Le Thi Thuy";
        sinhvien.Tuoi = 21;
        lstSinhVien.Add(sinhvien);

        sinhvien = new SinhVien();
        sinhvien.HoTen = "Hoang Van Cuong";
        sinhvien.Tuoi = 79;
        lstSinhVien.Add(sinhvien);

        sinhvien = new SinhVien();
        sinhvien.HoTen = "Tran Anh Hung";
        sinhvien.Tuoi = 21;
        lstSinhVien.Add(sinhvien);

        List<SinhVien> truyvanmoi = lstSinhVien.Where(Hoang => Hoang.HoTen.Contains("Hoang") || Hoang.HoTen.Contains("Le")).OrderBy(o => o.Tuoi).ToList();
        List<SinhVien> truyvanmoi1 = lstSinhVien.Where(H => H.HoTen.Contains("abcxyz") ||  H.HoTen.Contains("LHT")).OrderByDescending(c => c.Tuoi).Take(2).ToList();
        Debug.Log(truyvanmoi1.Count);
        // tim Hoang va Le
        foreach (SinhVien sv in truyvanmoi)
        {
            Debug.Log("+++: " + sv.HoTen + sv.Tuoi);
        }
        // lay danh sach first
        if (truyvanmoi1.Count != 0)
        {
            string Ten = truyvanmoi1.First().HoTen;
            string Tuoi = truyvanmoi.First().Tuoi.ToString();
           //Debug.Log("Ten: " + Ten + "Tuoi: " + Tuoi);
        }

    }

}
