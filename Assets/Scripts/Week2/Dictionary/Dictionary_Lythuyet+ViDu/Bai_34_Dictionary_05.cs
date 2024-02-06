using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_05 : MonoBehaviour
{
    // Get Keys
    void Start()
    {
        var data = new Dictionary<string, int>()
        {
            { "cat", 2 },
            { "dog", 3 },
            { "llama", 0 },
            { "iguana", -1 }
        };
        // Store keys in a List
        var list = new List<string>(data.Keys);  // ep sang kieu list
        // foreach
        foreach (string key in list)
        {
            Debug.Log("Keys in list : " + key);
        }
        // Su dung ConstainKey tim Key int
        var data2 = new Dictionary<int, string>();
        data2.Add(100, "color");
        data2.Add(200, "fabric");
        if (data2.ContainsKey(200))
        {
            Debug.Log("ContainsKey 200");
        }

        // Su dung ConstainsValue de tim Value co ton tai ko
        var  data3 = new Dictionary<string, int>();
        data3.Add("cat", 1);
        data3.Add("dog", 2);
        if (data3.ContainsValue(2))
        {
            Debug.Log("ton tai 2");
        }

    }
}
