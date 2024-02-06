using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_31_List : MonoBehaviour
{
    // Cach 1: gan luon gia tri cho mang List khi khai bao
    List<int> IsMang = new List<int>() { 1, 2, 3, 4 };
    // Cach 2: khai bao khong gan gia tri cho list
    List<string> IsMang_1 = new List<string>();

    void Start()
    {
        IsMang_1.Add("Ryan");
        IsMang_1.Add("Gosling");
        IsMang_1.Add("Da Vang");

        for (int i = 0; i < IsMang_1.Count; i++)
        {
            Debug.Log("Gia tri la : " + IsMang_1[i]);
        }
        foreach (var giatri in IsMang_1) // foreach = <kieu du lieu> <ten bien> in <mang list>
        {
            Debug.Log("gia tri foreach la: " + giatri);
        }

    }
}
