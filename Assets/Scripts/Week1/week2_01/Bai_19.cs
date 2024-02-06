using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_19 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        int[,] Mang2chieu = new int[4, 4];
        Mang2chieu[0, 0] = 5;
        Mang2chieu[0, 1] = 7;
        Mang2chieu[0, 2] = 6;
        Mang2chieu[0, 3] = 5;

        Mang2chieu[1, 0] = 0;
        Mang2chieu[1, 1] =-6;
        Mang2chieu[1, 2] =-3;
        Mang2chieu[1, 3] = 4;

        Mang2chieu[2, 0] = 12;
        Mang2chieu[2, 1] = 3;
        Mang2chieu[2, 2] = 4;
        Mang2chieu[2, 3] = 5;

        Mang2chieu[3, 0] = 8;
        Mang2chieu[3, 1] = 7;
        Mang2chieu[3, 2] = 20;
        Mang2chieu[3, 3] =-12;
        int tong = 0;
        for (int i = 0; i < Mang2chieu.Length; i++)
        {
            for (int j = 0; j < Mang2chieu.Length; j++)
            {
                if (i == j)
                {
                    tong += Mang2chieu[i,j];
                }
            }
        }
        Debug.Log(tong);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
