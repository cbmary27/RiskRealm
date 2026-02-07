using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public TextMeshProUGUI sc;
    public static int amt;
    void Start()
    {
        amt = Show_Assets2.keep;
        sc = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        sc.text = amt.ToString();
        Show_Assets2.keep = amt;
        
    }
}

