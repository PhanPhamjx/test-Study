using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_03 : MonoBehaviour
{
    // TryGetValue = la phuong phap tra cuu hieu qua nhat, kiem tra co key neu tim thay tra ve gia tri
    // Quan tr?ng: Có th? t?i ?u hóa nhi?u ch??ng trình b?ng TryGetValue. Chúng ta có th? s? d?ng giá tr? mà
    // chúng ta truy c?p mà không nh?n ???c l?n th? hai.
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
