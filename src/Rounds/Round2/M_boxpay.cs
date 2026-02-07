using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class M_boxpay : MonoBehaviour
{
    public TextMeshProUGUI w;
    public TextMeshProUGUI x;
    public static int s = 0;
    public static int r = 0;
    int index;
    public void Score_up()
    {
            if (Mbox.b == 1)
            {
                score.amt += 10000;
            }
            if (Mbox.b == 2)
            {
                score.amt += 15000;
            }
    }
    public void CorrectAnswer()
    {
        if (s == 0)
        {
            w.text = "";
            x.text = "";
            w.text = "Correct Answer! Here's a bonus of $500!";
            score.amt += 500;
            s++;
            r++;
        }
    }
    public void WrongAnswer()
    {
        if (r == 0)
        {
            w.text = "";
            x.text = "";
            x.text = "Wrong Answer! Better Luck next time!";
            s++;
        }
    }
}

