using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TaoDialogue : MonoBehaviour
{
    [SerializeField] GameObject Join;
    [SerializeField] Text txtDialuge;
    [SerializeField] Button BtnYes;
    [SerializeField] Button BtnNo;

    public bool isStatus = true;
    void Start()
    {

        GetText1();
        isStatus = true;

        BtnYes.onClick.AddListener(delegate
        {
            txtDialuge.text = "Ban da dong y";
            if(isStatus == false)
            {
                SceneManager.LoadScene("SampleScene");
                Debug.Log("chuyen scene");
            }

        });
        BtnNo.onClick.AddListener(delegate
        {

            GetText2();
            isStatus = false;   
            //if(isStatus == false)
            //{
            //    txtDialuge.text = "ending";
            //}
        });

    }
    public void GetText1()
    {
        ChuaDialog.Instance.SetText();
        txtDialuge.text = ChuaDialog.Instance.Dialog1;
        Debug.Log(txtDialuge.text);
    }
    public void GetText2()
    {
        ChuaDialog.Instance.SetText();
       txtDialuge.text = ChuaDialog.Instance.Dialog2;
        Debug.Log(txtDialuge.text);
    }

    void Update()
    {

    }

}
