using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class M_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string[] arr6 = { "a", "b", "c", "d" };
    public string x;
    public string y;
    public string z;
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "200000";
            z = "20000";


        }
        if (val == 1)
        {
            output.text = "Germany";
            x = "Germany";
            y = "300000";
            z = "30000";
        }
        arr6[0] = "Heavy Machinery";
        arr6[1] = x;
        arr6[2] = y;
        arr6[3] = z;
    }
}
