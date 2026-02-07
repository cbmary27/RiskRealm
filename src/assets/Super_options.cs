using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Super_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string[] arr = { "a", "b", "c", "d" };
    public string x;
    public string y;
    public string z;
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "300000";
            z = "60000";
        }
        if (val == 1)
        {
            output.text = "San Francisco";
            x = "San Francisco";
            y = "500000";
            z = "100000";
        }
        if (val == 2)
        {
            output.text = "Calgary";
            x = "Calgary";
            y = "300000";
            z = "60000";
        }
        if (val == 3)
        {
            output.text = "Gulf of Mexico";
            x = "Gulf of Mexico";
            y = "300000";
            z = "60000";
        }
        if (val == 4)
        {
            output.text = "Tokyo";
            x = "Tokyo";
            y = "300000";
            z = "60000";
        }
        if (val == 5)
        {
            output.text = "Texas";
            x = "Texas";
            y = "300000";
            z = "60000";
        }
        if (val == 6)
        {
            output.text = "Manila";
            x = "Manila";
            y = "500000";
            z = "100000";
        }
        if (val == 7)
        {
            output.text = "Carribean Island";
            x = "Carribean Island";
            y = "600000";
            z = "120000";
        }
        if (val == 8)
        {
            output.text = "Germany";
            x = "Germany";
            y = "300000";
            z = "60000";
        }
        arr[0] = "Supermarkets";
        arr[1] = x;
        arr[2] = y;
        arr[3] = z;
    }
}
