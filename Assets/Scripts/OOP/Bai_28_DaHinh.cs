using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_28_DaHinh : MonoBehaviour
{
    // Da Hinh : la cac phuong thuc giong nhau phai phan biet duoc thong qua virtual va override
   public class DongVat
    {
        public virtual void HienThi() // su dung tu khoa virtual de khai bao phuong thuc ao(phai co tu khoa virtual moi dung duoc override)
        {
            Debug.Log("ohohohoho");
        }
    }
    public class Meo : DongVat
    {
        public override void HienThi() // ovverride danh dau day la phuong thuc ghi de len phuong thuc cha
        {
            Debug.Log("Meo keu");
        }
    }
    public class Cho: DongVat
    {
        public override void HienThi() // ovverride danh dau day la phuong thuc ghi de len phuong thuc cha
        {
            Debug.Log("Cho keu");
        }
    }
    void Start()
    {
        DongVat dv = new Meo();
        dv.HienThi();
        DongVat dv1 = new Cho();
        dv1.HienThi();  
    }

}
