using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_18 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ViDu_1:
        /*
        int[] Mang = new int[5];
        Mang[0] = 3;    
        Mang[1] = 1;
        Mang[2] = 6;
        Mang[3] = 5;
        Mang[4] = 9;
        for(int i = 0; i < Mang.Length; i++)
        {
           for(int j = i+1; j < Mang.Length - 1; j++)
            {
                int trunggian;
                trunggian = Mang[j];
                Mang[j] = Mang[i];                        
            }
        }
        */

        // ViDu_2:
        int[] Mang2 = new int[5];
        Mang2[0] = -5;
        Mang2[1] = 8;
        Mang2[2] = -9;
        Mang2[3] = 4;
        Mang2[4] = -10;
        for (int i = 0; i < Mang2.Length; i++)
        {
            for (int j = i + 1; j < Mang2.Length; j++)
            {
                if (Mang2[i] > Mang2[j])
                {
                    int bientam2;
                    bientam2 = Mang2[j];
                    Mang2[j] = Mang2[i];
                    Mang2[i] = bientam2;
                   
                }
            }
        }

        for (int i = 0; i < Mang2.Length; i++)
        {
            Debug.Log("tu be den lon : " + Mang2[i]);
        }

    }
}
