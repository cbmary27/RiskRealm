using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class T_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr9 = { "a", "b", "c", "d" };
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "500000";
            z = "125000";
        }
        if (val == 1)
        {
            output.text = "Calgary";
            x = "Calgary";
            y = "500000";
            z = "125000";
        }
        if (val == 2)
        {
            output.text = "Texas";
            x = "Texas";
            y = "500000";
            z = "125000";
        }
        arr9[0] = "Telecom Towers";
        arr9[1] = x;
        arr9[2] = y;
        arr9[3] = z;
    }
}
