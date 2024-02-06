using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_07 : MonoBehaviour
{
    // Copy Dictionary
    void Start()
    {
        var test = new Dictionary<string, int>();
        test["cat"] = 30;

        var copy = new Dictionary<string, int>(test); // copy 1 dic khac cua (test)
        copy["dog"] = 50;
        Debug.Log("test count : " + test.Count);
        Debug.Log(" copy count: " + copy.Count);
    }

    
}
