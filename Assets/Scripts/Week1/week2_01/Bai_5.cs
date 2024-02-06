using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_5 : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        string VanBanGoc = "https://docs.google.com/spreadsheets/d/1-PFsC9ZPGLi7TNDTEuIwBOmQwZT0WMNeFv4L7-hb77M/edit#gid=0";
        //Cách 1: lastindexof, substring
        //Cách 2: indexof, substring
        //Cách 3: split, xác ??nh ph?n t? c?n c?t và substring(<vi tri>, so luong)
        // cach1
        int chiso_1 = VanBanGoc.LastIndexOf('1');
        string vb_1 = VanBanGoc.Substring(chiso_1+2,36);
        Debug.Log("Cach 1:" + vb_1);
        //Cach 2
        int chiso_2 = VanBanGoc.IndexOf('1');
        string vb_2 = VanBanGoc.Substring(chiso_2 + 2, 36);
        Debug.Log("Cach 2:" + vb_2);
        //Cach 3:
        string[] arrMang = VanBanGoc.Split('/');
        //for(int i = 0; i < arrMang.Length; i++)
        //{
        //    Debug.Log(i+ "--->" + arrMang[i]);
        //}
        string vb_3 = arrMang[5].Substring( 2, 36);
        Debug.Log("Cach 3:" + vb_3);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
