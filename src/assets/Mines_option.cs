using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Mines_option : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string[] arr5 = { "a", "b", "c", "d" };
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
            z = "30000";
        }
        if (val == 1)
        {
            output.text = "San Francisco";
            x = "San Francisco";
            y = "300000";
            z = "30000";
        }
        if (val == 2)
        {
            output.text = "Calgary";
            x = "Calgary";
            y = "300000";
            z = "30000";
        }
        if (val == 3)
        {
            output.text = "Tokyo";
            x = "Tokyo";
            y = "300000";
            z = "30000";
        }
        arr5[0] = "Mines";
        arr5[1] = x;
        arr5[2] = y;
        arr5[3] = z;
    }
}
