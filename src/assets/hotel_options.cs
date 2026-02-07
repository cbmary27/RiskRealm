using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hotel_options: MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr13 = { "a", "b", "c", "d" };
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "800000";
            z = "80000";
        }
        if (val == 1)
        {
            output.text = "Germany";
            x = "Germany";
            y = "1000000";
            z = "100000";
        }
        if (val == 2)
        {
            output.text = "Calgary";
            x = "Calgary";
            y = "1100000";
            z = "110000";
        }
        if (val == 3)
        {
            output.text = "Texas";
            x = "Texas";
            y = "1000000";
            z = "100000";
        }
        arr13[0] = "Hotels & Resorts";
        arr13[1] = x;
        arr13[2] = y;
        arr13[3] = z;
    }
}
