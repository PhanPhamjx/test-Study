using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2 : MonoBehaviour
{
    public class xemay
    {
        public string tenXe;
        public string hangXe;
        public int phanKhoi;
        public bool loaiXe;
        public void HienThi()
        {
            string loaiXeGaSo;
            if (loaiXe == true)
            {
                loaiXeGaSo = "Xe ga";
            }
            else
            {
                loaiXeGaSo = "Xe Số";
            }
            Debug.Log("Hiển thị danh sách : " + hangXe + " " + tenXe + " " + phanKhoi + " " + loaiXeGaSo);
        }
        public int PhanKhoi
        {
            get
            {
                return phanKhoi;
            }
            set
            {
                if (value >= 0 && value < 175)
                {
                    phanKhoi = value;
                }
            }
        }
        public xemay(string hangXe, string tenXe, int phanKhoi, bool loaiXe)
        {
            this.hangXe = hangXe;
            this.tenXe = tenXe;
            this.phanKhoi = phanKhoi;
            this.loaiXe = loaiXe;
        }
    }
    class Suzuki : xemay
    {
        public Suzuki() : base("aa", "bb", 12, true)// goi qua base
        {
        }
    }
    class phuKien : Suzuki // lop con cua Suzuki
    {
        public virtual void thongtinPK() // tao virtual
        {
            Debug.Log("Phụ kiện xe");
        }
    }
    class lopXe : phuKien
    {
        public override void thongtinPK()
        {
            Debug.Log("Đây là phụ kiện lốp");
        }
    }
    class xichXe : phuKien
    {
        public override void thongtinPK()
        {
            Debug.Log("Đây là phụ kiện xích xe");
        }
    }
    phuKien pk1 = new phuKien();
    phuKien pk2 = new lopXe();
    phuKien pk3 = new xichXe();
    void Start()
    {
        pk1.thongtinPK();
        pk2.thongtinPK();
        pk3.thongtinPK();
        xemay wave = new xemay("Honda", "Wave", 110, false);
        wave.HienThi();
        xemay ab = new xemay("Honda", "AB", 125, true);
        ab.HienThi();
        xemay jn = new xemay("Yamaha", "Janus", 110, true);
        jn.HienThi();
        xemay ex = new xemay("Yamaha", "Exciter", 155, false);
        ex.HienThi();
        xemay xe155 = new xemay("Yamaha", "NVX", 200, true);
        xe155.PhanKhoi = 155;
        xe155.HienThi();
        Debug.Log("Phân khối xe NVX = " + xe155.PhanKhoi);
        Suzuki raider = new Suzuki();
        raider.tenXe = "Raider";
        raider.hangXe = "Suzuki";
        raider.phanKhoi = 150;
        raider.loaiXe = false;
        raider.HienThi();
        phuKien poXe = new phuKien();
        poXe.hangXe = "Aka";
        poXe.loaiXe = true;
        poXe.HienThi();
        bool ispoXe = poXe is xemay;
        Debug.Log("Check poXe có trong class xemay ? : " + ispoXe);
        bool ispoXe1 = poXe is Suzuki;
        Debug.Log("Check poXe có trong class Suzuki ? : " + ispoXe1);
    }
}
