using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Baitap_Dic_01 : MonoBehaviour
{
    public class LopHoc
    {
        public int ID;
        public string HoTen;
        public string Ngay;
        public int Tuoi;
        public string GioiTinh;
        public LopHoc(int iD, string hoten, string ngay, int tuoi, string gioitinh)
        {
            this.ID = iD;
            this.HoTen = hoten;
            this.Ngay = ngay;
            this.Tuoi = tuoi;
            this.GioiTinh = gioitinh;
        }
    }
    void Start()
    {
        var DicTruongHoc = new Dictionary<string, List<LopHoc>>();
        List<LopHoc> lopB = new List<LopHoc>();

        lopB.Add(new LopHoc(123, "Tran Anh C", "23/4", 17, "nam"));
        lopB.Add(new LopHoc(237, "Bui Anh T", "11/4", 13, "nam"));
        DicTruongHoc.Add("Lop B1", lopB);

        lopB = new List<LopHoc>();
        lopB.Add(new LopHoc(434, "Le thi C ", "2/4", 19, "nu"));
        lopB.Add(new LopHoc(034, "Tran van Q ", "9/4", 11, "nam"));
        DicTruongHoc.Add("Lop B2", lopB);

        lopB = new List<LopHoc>();
        lopB.Add(new LopHoc(673, "Nguyen Van A", "3/4", 27, "nam"));
        lopB.Add(new LopHoc(673, "Nguyen Mai A", "1/4", 37, "nu"));
        DicTruongHoc.Add("Lop B3", lopB);


        int max = 0;
        bool status = false;
        foreach (var data2 in DicTruongHoc)
        {
            foreach (var item in data2.Value)
            {
                if (status == false)
                {
                    max = item.Tuoi;
                    status = true;
                    Debug.Log("max bool la : " + max);
                }
                if (max < item.Tuoi)
                {
                    max = item.Tuoi;
                    Debug.Log("max loop la : " + max);
                }
                    
            }
        }
        Debug.Log("Max:" + max);
    }
}
