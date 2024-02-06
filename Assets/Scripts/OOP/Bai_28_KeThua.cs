using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_28_KeThua : MonoBehaviour
{
    public class SinhVien // Tao lop cha : SinhVien
    {
        public string HoTen;
        public string Tuoi;
        public bool GioiTinh;
        public static int TongSoHocSinh;
        public SinhVien()// phuong thuc khoi dung mac dinh
        {

        }
        public SinhVien(string HoTen, string Tuoi, bool GioiTinh) // ham khoi tao
        {
            this.HoTen = HoTen; // this = phan biet biet cac bien neu ten trung nhau
            this.Tuoi = Tuoi;
            this.GioiTinh = GioiTinh;
            TongSoHocSinh++;
        }
        public SinhVien(string name)// ham khoi tao
        {
            HoTen = name;
            TongSoHocSinh++;
        }
        
    }
    class SinhVienToan : SinhVien // lop con: SinhVienToan -> ke thua cac thuoc tinh, bien public tu lop cha: SinhVien
                                  // neu co private lop con ko dc ke thua -> phai khoi tao ham get,set
    {
        public SinhVienToan()
        {
            TongSoHocSinh++;
        }
    }
    public void HienThi(int sohinhsinh, string ten, string tuoi, bool gt) // phuong thuc 
    {
        string gioitinh;
        if (gt == true)
        {
            gioitinh = "nam";
        }
        else
        {
            gioitinh = "nu";
        }
        Debug.Log("So hoc sinh: " + " " + sohinhsinh + " " + ten + " " + tuoi + " " + gioitinh);
    }
    void Start()
    {
        SinhVienToan Ryan = new SinhVienToan();
        Ryan.HoTen = "Ryan Gosling";
        Ryan.Tuoi = "13";
        Ryan.GioiTinh = true;
        HienThi(SinhVien.TongSoHocSinh,Ryan.HoTen,Ryan.Tuoi,Ryan.GioiTinh);
    }

}
