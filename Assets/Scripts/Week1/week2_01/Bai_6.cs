using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_6 : MonoBehaviour
{
    int[] Mang = new int[10];

    int tong = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        Mang[0] = 0;
        Mang[1] = 1;
        Mang[2] = 2;
        Mang[3] = 3;
        Mang[4] = 4;    
        Mang[5] = 6;
        Mang[6] = 3;
        Mang[7] = 9;
        Mang[8] = 0;
        Mang[9] = 9;
        int max = Mang[0];
        int sobitrung = Mang[0];
        for (int i = 0; i < Mang.Length; i++)
        {
            if (max < Mang[i])
            {
                max = Mang[i];
            }
        }
       for(int j = 0; j < Mang.Length; j++)
        {
            if(max == Mang[j])
            {
                tong += Mang[j];
            }
        }

        Debug.Log("tong:" + tong);
    }

   
}
