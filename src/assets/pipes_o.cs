using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.ParticleSystemJobs;


public class pipes_o: MonoBehaviour
{
    public TextMeshProUGUI output;
    public string[] arr3 = { "a", "b", "c", "d" };
    public string x;
    public string y;
    public string z;
    public void HandleInput(int val)
    {
        if (val == 0)
        {
            output.text = "Manila";
            x = "Manila";
            y = "400000";
            z = "40000";
        }
        if (val == 1)
        {
            output.text = "Gulf of Mexico";
            x = "Gulf of Mexico";
            y = "400000";
            z = "40000";
        }
        if (val == 2)
        {
            output.text = "Tokyo";
            x = "Tokyo";
            y = "400000";
            z = "40000";
        }
        arr3[0] = "Pipelines";
        arr3[1] = x;
        arr3[2] = y;
        arr3[3] = z;
    }
   
}
