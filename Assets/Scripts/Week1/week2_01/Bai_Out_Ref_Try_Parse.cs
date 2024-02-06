using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_Out_Ref_Try_Parse : MonoBehaviour
{
    // Start is called before the first frame update
    int value = 12;
    int value2 = 24;
    void Start()
    {
      // TryParse()
       // ViDu1:
        string canchuyen = "10";
        int chua =0;
        int.TryParse(canchuyen, out chua);
        Debug.Log(chua + 1);

        // ViDu2:
        string canchuyen2 = "20.3";
        float c = 10.2f;
        float.TryParse(canchuyen2, out c);
        Debug.Log(c);
    
        ViduVeout(out value2);

        ViduVeref(ref value);
        Debug.Log("ref value:" +value);
        ViduVeref(ref value);
        Debug.Log("ref value:" + value);
        ViduVeref(ref value);
        Debug.Log("ref value:" + value);

    }
       // ref
     public void ViduVeref(  ref int value)
    {    
        value ++;     
    }
    // out
    
    public void ViduVeout( out int value2)
    {
        value2 = 10;
        value2++;  
        Debug.Log(value2);
    }
      

}
