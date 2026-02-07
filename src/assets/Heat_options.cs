using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Heat_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string[] arr4 = { "a", "b", "c", "d" };
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
            z = "40000";
        }
        if (val == 1)
        {
            output.text = "San Francisco";
            x = "San Francisco";
            y = "600000";
            z = "120000";
        }
        arr4[0] = "Heat Exchanger";
        arr4[1] = x;
        arr4[2] = y;
        arr4[3] = z;
    }
}

