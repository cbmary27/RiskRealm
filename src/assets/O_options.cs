using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class O_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr12 = { "a", "b", "c", "d" };
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "1000000";
            z = "100000";
        }
        if (val == 1)
        {
            output.text = "Calgary";
            x = "Calgary";
            y = "1000000";
            z = "100000";
        }
        if (val == 2)
        {
            output.text = "Texas";
            x = "Texas";
            y = "1000000";
            z = "100000";
        }
        arr12[0] = "Oil Refineries";
        arr12[1] = x;
        arr12[2] = y;
        arr12[3] = z;

    }
}
