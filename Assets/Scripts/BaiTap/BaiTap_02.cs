using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BaiTap_02 : MonoBehaviour
{
    // Start is called before the first frame update
    public class DiemTB
    {
        public string HoTen;
        public float Toan;
        public float Ly;
        public float Hoa;
        public float DiemTrungBinh;
        public DiemTB(string hoten, float toan, float ly, float hoa)
        {
            this.HoTen = hoten;
            this.Toan = toan;
            this.Ly = ly;
            this.Hoa = hoa;
        }
    }
    List<DiemTB> lstdiemtb = new List<DiemTB>();
    void Start()
    {
        lstdiemtb.Add(new DiemTB("Hoang anh c", 5, 5, 6));
        lstdiemtb.Add(new DiemTB("Hoang anh a", 9, 8, 10));
        lstdiemtb.Add(new DiemTB("Hoang anh b", 4, 10, 6));
        lstdiemtb.Add(new DiemTB("Hoang anh l", 1, 5, 6));
        // DiemTB diemtb;
        // diemtb = new DiemTB();
        // diemtb.HoTen = " Tran Van A";
        // diemtb.Toan = 9;
        // diemtb.Ly = 7.5f;
        // diemtb.Hoa = 8.5f;
        // //diemtb.DiemTrungBinh = (diemtb.Toan + diemtb.Ly + diemtb.Hoa) / 3;
        // lstdiemtb.Add(diemtb);

        // diemtb = new DiemTB();
        // diemtb.HoTen = " Le Thi B";
        // diemtb.Toan = 10;
        // diemtb.Ly = 6.5f;
        // diemtb.Hoa = 9.5f;
        // //diemtb.DiemTrungBinh = (diemtb.Toan + diemtb.Ly + diemtb.Hoa) / 3;
        // lstdiemtb.Add(diemtb);

        // diemtb = new DiemTB();
        // diemtb.HoTen = " Nguyen Van G";
        // diemtb.Toan = 4.5f;
        // diemtb.Ly = 4.5f;
        // diemtb.Hoa = 5.5f;
        //// diemtb.DiemTrungBinh = (diemtb.Toan + diemtb.Ly + diemtb.Hoa) / 3;
        // lstdiemtb.Add(diemtb);

        foreach (var item in lstdiemtb)
        {
            float value = (item.Toan + item.Ly + item.Hoa) / 3;
            item.DiemTrungBinh = value;
            if (value < 5)
            {
                Debug.Log("Hoc luc yeu: " + item.HoTen + item.DiemTrungBinh);
            }
            else if (value < 7)
            {
                Debug.Log("Hoc luc trung binh: " + item.HoTen + item.DiemTrungBinh);
            }
            else if (value < 8)
            {

                Debug.Log("Hoc luc  kha : " + item.HoTen + item.DiemTrungBinh);
            }
            else
            {
                Debug.Log("Hoc luc gioi: " + item.HoTen + item.DiemTrungBinh);
            }
        }
        //in ra

    }


}
