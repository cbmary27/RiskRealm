using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class Mbox1_pay : MonoBehaviour
{
    public TextMeshProUGUI w;
    public TextMeshProUGUI x;
    public static int h = 0;
    public static int g = 0;
    public void Score_up()
    {
        if (M_box1.b == 1)
        {
            score.amt += 10000;
            //u++;
        }
        if (M_box1.b == 2)
        {
            score.amt += 15000;
            //u++;
        }
        if (M_box1.b == 3)
        {
            CorrectAnswer();
        }
    }
    public void CorrectAnswer()
    {
        if (h == 0)
        {
            w.text = "";
            x.text = "";
            w.text = "Correct Answer! Here's a bonus of $500!";
            score.amt += 500;
            h++;
            g++;
        }
    }
    public void WrongAnswer()
    {
        if (g == 0)
        {
            w.text = "";
            x.text = "";
            x.text = "Wrong Answer! Better Luck next time!";
            h++;
        }
    }
}
