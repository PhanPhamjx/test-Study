using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_03 : MonoBehaviour
{
    // TryGetValue = la phuong phap tra cuu hieu qua nhat, kiem tra co key neu tim thay tra ve gia tri
    // Quan tr?ng: C� th? t?i ?u h�a nhi?u ch??ng tr�nh b?ng TryGetValue. Ch�ng ta c� th? s? d?ng gi� tr? m�
    // ch�ng ta truy c?p m� kh�ng nh?n ???c l?n th? hai.
    void Start()
    {
        Dictionary<string, string> values= new Dictionary<string, string>();
        values.Add("cat", "feline");
        values.Add("dog", "canine");
        // su dung TryGetValue
        string test;
        if(values.TryGetValue("cat", out test)) // return true
        {
            Debug.Log(test);
        }
        Debug.Log(test);
        if(values.TryGetValue("bird", out test)) // return false
        {
            Debug.Log(false);
        }
        Debug.Log(test);
    }

    
}
