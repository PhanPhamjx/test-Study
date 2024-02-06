using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_02 : MonoBehaviour
{
    // 2, Su dung Ham ContainsKey = tim kiem key ton tai trong dictionary
    void Start()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("apple", 1);
        dictionary.Add("windows", 5);

        if (dictionary.ContainsKey("apple"))
        {
            int value = dictionary["apple"];
            Debug.Log(value);
            // neu ton tai in ra 1
        }
        if (!dictionary.ContainsKey("arcorn"))
        {
            // neu khong ton tai in ra false
            Debug.Log(false);
        }

    }


}
