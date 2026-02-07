using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class W_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr8 = { "a", "b", "c", "d" };
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
            output.text = "Manila";
            x = "Manila";
            y = "300000";
            z = "60000";
        }
        if (val == 2)
        {
            output.text = "Gulf of Mexico";
            x = "Gulf of Mexico";
            y = "200000";
            z = "40000";
        }
        arr8[0] = "Warehouses";
        arr8[1] = x;
        arr8[2] = y;
        arr8[3] = z;

    }
}
