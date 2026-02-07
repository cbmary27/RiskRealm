using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dropdown_input : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string[] arr2 = { "a", "b", "c", "d" };
    public string x;
    public string y;
    public string z;
    public void HandleInput(int val)
    {
        if (val==0)
        {
            output.text = "Germany";
            x = "Germany";
            y = "500000";
            z = "50000";
        }
        if (val==1)
        {
            output.text = "Texas";
            x = "Texas";
            y = "300000";
            z = "30000";
        }
        arr2[0] = "Manufacturing Plants";
        arr2[1] = x;
        arr2[2] = y;
        arr2[3] = z;
    }
}
