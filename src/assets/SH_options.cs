using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SH_options : MonoBehaviour
{
    public TextMeshProUGUI output;
    public string x;
    public string y;
    public string z;
    public static string[] arr10 = { "a", "b", "c", "d" };
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Mumbai";
            x = "Mumbai";
            y = "300000";
            z = "60000";
        }
        arr10[0] = "Ships and Cargo";
        arr10[1] = x;
        arr10[2] = y;
        arr10[3] = z;
    }
}
