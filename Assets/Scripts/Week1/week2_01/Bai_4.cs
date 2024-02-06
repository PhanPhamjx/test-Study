using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_4 : MonoBehaviour
{
    
    int giatri = 10;
    // Start is called before the first frame update
    void Start()
    {
        //ToString()
        string bienvanban = giatri.ToString();
        Debug.Log(bienvanban);
        string c = "12";

        //Parse()
        int tong = int.Parse(c);
        int f = tong + 1;
        Debug.Log(f); // 13
        string k = c + 2;
        Debug.Log(k); // 122
        string x = "100";
        string t = (int.Parse(x) + 3).ToString();
        Debug.Log(t);
        //float.Parse()
        string o = "100.5";
        float j = float.Parse(o);
        Debug.Log(j);
        // Cac cach chuyen du lieu trong c#
        string ten = "Ryan Gosling";
        string[] mangtach = ten.Split(' ');
        Debug.Log(mangtach[1]);
        // lastindexOf(),indexof()
        string newname = "&Timothe &Chala &Mett";
        int cuoimuctimthay = newname.LastIndexOf('&');
        string chuoicuoicantimla = newname.Substring(cuoimuctimthay + 1);
        Debug.Log(chuoicuoicantimla);   
    }
         
    
}
