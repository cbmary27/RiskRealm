using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class P_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr15 = { "a", "b", "c", "d"};
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "400000";
            z = "80000";
        }
        if (val == 1)
        {
            output.text = "Germany";
            x = "Germany";
            y = "300000";
            z = "60000";
        }
        if (val == 2)
        {
            output.text = "Manila";
            x = "Manila";
            y = "300000";
            z = "60000";
        }
        if (val == 3)
        {
            output.text = "San Francisco";
            x = "San Francisco";
            y = "500000";
            z = "100000";
        }
        arr15[0] = "Power Plant";
        arr15[1] = x;
        arr15[2] = y;
        arr15[3] = z;
    }
}
