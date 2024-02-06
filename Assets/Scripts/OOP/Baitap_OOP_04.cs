using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinhVat
{
    public virtual void sinhVat()
    {
        Debug.Log("Creature");
    }
}
public class KhungLong : SinhVat
{
    public override void sinhVat()
    {
        Debug.Log("Khung Long");
    }
}
public class ViKhuan : SinhVat
{
    public override void sinhVat()
    {
        Debug.Log("Vi khuan");
    }
}
public class Baitap_OOP_04 : MonoBehaviour
{


    void Start()
    {
        SinhVat sv = new SinhVat(); 
        sv.sinhVat();   
        KhungLong kl = new KhungLong(); 
        kl.sinhVat();
        ViKhuan vk = new ViKhuan();
        vk.sinhVat();
    }


}
