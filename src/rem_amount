using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using static System.Net.Mime.MediaTypeNames;
public class rem_amount : MonoBehaviour
{
    public int amount = 500000;

    public TextMeshProUGUI text_holder1;

    public void change_amount(int a)
    {
        amount = amount + a;
        show_amount();
    }
    public void show_amount()
    {
        text_holder1.text = "Remaining Amount : " + amount.ToString();
    }
}
