using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_04 : MonoBehaviour
{
    // su dung Foreach trong Dictionary
    void Start()
    {
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            { "cat", 2},
            { "dog", 1},
            { "llama", 0},
            { "iguana", -1}
        };
        // Foreach voi KayValuePair<>
        foreach (KeyValuePair<string, int> pair in data)
        {
            Debug.Log("FOREACH KEYVALUEPAIR: {0}, {1} " + pair.Key +" "+ pair.Value);
        }
        // Foreach voi Var
        foreach (var pair in data)
        {
            Debug.Log("FOREACH VAR: {0}, {1} " + pair.Key + " " + pair.Value);
        }
    }


}
