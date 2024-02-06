using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_27 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int ketqua = TinhGiaiThua(4);
        Debug.Log("ket qua la :" + ketqua);

    }
    int TinhGiaiThua( int i)
    {
        if(i <= 1)
        {
            return 1;
        }
        int tinh = i * TinhGiaiThua(i - 1);
        Debug.Log("i : " + i + "** tinh" + tinh);
        return tinh;
    }
    // Update is called once per frame
    
}
