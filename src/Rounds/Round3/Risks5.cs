using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEditor.Experimental.GraphView;
using UnityEditor;
using System.Threading;

public class Risks5 : MonoBehaviour
{
    private static GameObject popup2;
    public TextMeshProUGUI t;
    public static int rt;
    int i = 0;
    int[] arr = { 3, 6, 9, 12, 15, 19, 22, 25, 28, 31 };
    [SerializeField]
    int j = 2;
    void Start()
    {
        popup2.gameObject.SetActive(false);
    }

    void Awake()
    {
        popup2 = GameObject.Find("popup");
    }
    private void Update()
    {
        if (GameControl.player1.GetComponent<Waypoints>().waypointIndex == arr[i] && GameControl.player1.GetComponent<Waypoints>().moveAllowed == false && j == 2)
        {
            switch (arr[i])
            {
                case 3:
                    popup2.gameObject.SetActive(true);
                    t.text = "Uh oh! Looks like there is a flood in...";  
                    rt = 1; 
                    break;
                case 6:
                    popup2.gameObject.SetActive(true);
                    t.text = "There's a fire blazing through...";
                    rt = 2;
                    break;
                case 9:
                    popup2.gameObject.SetActive(true);
                    t.text = "A tsunami crashes through...";
                    rt = 3;
                    break;
                case 12:
                    popup2.gameObject.SetActive(true);
                    t.text = "Oh no! A typhoon has hit...";
                    rt = 4;
                    break;
                case 15:
                    popup2.gameObject.SetActive(true);
                    t.text = "Uh oh! Looks like there is an earthquake in...";
                    rt = 5;
                    break;
                case 19:
                    popup2.gameObject.SetActive(true);
                    t.text = "Heavy rains! A thunderstorm has hit...";
                    rt = 6;
                    break;
                case 22:
                    popup2.gameObject.SetActive(true);
                    t.text = "A hurricane swirls through...";
                    rt = 7;
                    break;
                case 25:
                    popup2.gameObject.SetActive(true);
                    t.text = "Oops! A tropical storm is spinning through...";
                    rt = 8;
                    break;
                case 28:
                    popup2.gameObject.SetActive(true);
                    t.text = "No way! A terror attack broke out in...";
                    rt = 9;
                    break;
                case 31:
                    popup2.gameObject.SetActive(true);
                    t.text = " Uh oh! Looks like there is a flood in ...";
                    rt = 1;
                    break;
            }
            j = 3;
        }
        if (GameControl.player1.GetComponent<Waypoints>().waypointIndex > arr[i])
        {
            if (i != arr.Length - 1)
            { i++; }
            popup2.gameObject.SetActive(false);
            j = 2;
        }
    }
}
