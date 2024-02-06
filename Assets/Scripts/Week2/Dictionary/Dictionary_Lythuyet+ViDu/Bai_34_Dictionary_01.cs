using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_34_Dictionary_01 : MonoBehaviour
{
    //dictionary la mot dang colection bao gom (Key + Value)
    void Start()
    {
        // 1: Dictionary,Add,Initializer, and Count
        //Ver1: tao dictionary khi them
        var dictionary = new Dictionary<string, int>();
        dictionary.Add("cat", 2);
        dictionary.Add("Dog", 1);
        dictionary.Add("Llama", 0);
        dictionary.Add("iguna", -1);
        Debug.Log("dictionary: " + dictionary.Count);
        //Ver2: tao Dictionary bang khoi tao
        var dictionary2 = new Dictionary<string, int>()
        {
            {"Cat", 2},
            {"Dog", 1},
            {"llama", 0},
            { "iguana", -1}
        };
        Debug.Log("DICTIONARY 2: " + dictionary2.Count);
    }


}
