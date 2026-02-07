using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class F_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr14 = { "a", "b", "c", "d" };
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "200000";
            z = "50000";
        }
        if (val == 1)
        {
            output.text = "Germany";
            x = "Germany";
            y = "200000";
            z = "50000";
        }
        if (val == 2)
        {
            output.text = "Calgary";
            x = "Calgary";
            y = "200000";
            z = "50000";
        }
        if (val == 3)
        {
            output.text = "San Francisco";
            x = "San Francisco";
            y = "400000";
            z = "100000";
        }
        if (val == 4)
        {
            output.text = "Gulf of Mexico";
            x = "Gulf of Mexico";
            y = "600000";
            z = "150000";
        }
        if (val == 5)
        {
            output.text = "Caribbean Island";
            x = "Carribean Island";
            y = "200000";
            z = "50000";
        }
        if (val == 6)
        {
            output.text = "Texas";
            x = "Texas";
            y = "200000";
            z = "50000";
        }
        if (val == 7)
        {
            output.text = "Tokyo";
            x = "Tokyo";
            y = "400000";
            z = "100000";
        }
        if (val == 8)
        {
            output.text = "Manila";
            x = "Manila";
            y = "300000";
            z = "75000";
        }
        arr14[0] = "Fleets and Cars";
        arr14[1] = x;
        arr14[2] = y;
        arr14[3] = z;

    }
}
