using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_06 : MonoBehaviour
{
    // Su dung Remove, Count
    void Start()
    {
        var data = new Dictionary<string, int>();
        data.Add("cat", 1);
        data.Add("dog", 2);
        Debug.Log("Count: " + data.Count);

        // Remove cat   
        data.Remove("cat"); // remove key "cat"
        Debug.Log("Count after remove: " + data.Count);

        // Remove nothing, not remove anything
        data.Remove("nothing");
        Debug.Log("Count after remove nothing: " + data.Count); 
    }
}
