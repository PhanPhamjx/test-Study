using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_25 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TinhTong(6, 2);
        int Tong = TinhTong(0, 9);
        Debug.Log("tong la : " + Tong);

        TinhTichSo(3,4,8);
        float tich = TinhTichSo(6, 45, 6);
        Debug.Log(": " + tich);

        TinhTich3so(1, 0, "6");
    }
    int TinhTong(int a, int b)
    {
        int Tong2so = 0;
        Tong2so = a + b;
        int Hieu2so = 0;
        Hieu2so = a - b;
        return Tong2so;
    }
    float TinhTichSo(float v1, float v2, float v3)
    {
        float Tichso = 0;
        Tichso = v1 * v2 * v3;
        return Tichso;
    }
    void TinhTich3so(int a,float b, string c)
    {
        float tich3so = 0;
        tich3so = a * b * float.Parse(c);
        Debug.Log("Tich 3 so la : " + tich3so);
    }
}
