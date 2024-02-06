using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;
using UnityEngine.Events;
using System;

public class ChuaDialog : MonoBehaviour
{
    public static ChuaDialog Instance;
    public string Dialog1;
    public string Dialog2;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
    public void SetText()
    {
        Dialog1 = "Ban co muon gia nhap bang hoi ko";
        Dialog2 = "Bạn có muốn chuyển sang level khác không?";
    }
}
