using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using System;

public class display : MonoBehaviour
{
    public TextMeshProUGUI val;
    public TextMeshProUGUI val1;
    public TextMeshProUGUI r;
    public void Display()
    {
        int s = 0;
        val.text = "";
        val1.text = "";
        for (int i = 0; i < Show_Assets2.show1.Count ; i++)
        {
            val.text += Show_Assets2.show1[i][0] + '\n';
            s += int.Parse(Show_Assets2.show1[i][2]);

        }
        if (pay1.asset_removed.Count != 0)
        {
            r.text = "";
            for(int i = 0; i < pay1.asset_removed.Count ; i++)
            {
                r.text += pay1.asset_removed[i] + "\n";
            }
        }
        else
        {
            r.text = "";
        }
        val1.text = s.ToString();

    }
}
