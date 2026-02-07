using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OF_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr11 = { "a", "b", "c", "d" };
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "700000";
            z = "70000";
        }
        if (val == 1)
        {
            output.text = "Germany";
            x = "Germany";
            y = "500000";
            z = "50000";
        }
        if (val == 2)
        {
            output.text = "Calgary";
            x = "Calgary";
            y = "1000000";
            z = "100000";
        }
        if (val == 3)
        {
            output.text = "San Francisco";
            x = "San Francisco";
            y = "800000";
            z = "80000";
        }
        if (val == 4)
        {
            output.text = "Gulf of Mexico";
            x = "Gulf of Mexico";
            y = "500000";
            z = "50000";
        }
        if (val == 5)
        {
            output.text = "Caribbean Island";
            x = "Carribean Island";
            y = "400000";
            z = "40000";
        }
        if (val == 6)
        {
            output.text = "Texas";
            x = "Texas";
            y = "1200000";
            z = "120000";
        }
        if (val == 7)
        {
            output.text = "Tokyo";
            x = "Tokyo";
            y = "300000";
            z = "30000";
        }
        if (val == 8)
        {
            output.text = "Manila";
            x = "Manila";
            y = "700000";
            z = "40000";
        }
        arr11[0] = "Offices";
        arr11[1] = x;
        arr11[2] = y;
        arr11[3] = z;
    }
}
