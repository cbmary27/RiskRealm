using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEditor.Experimental.GraphView;
using UnityEditor;
using System.Threading;

public class Risks : MonoBehaviour
{
    private static GameObject popup1;
    public TextMeshProUGUI t;
    public static int rt;
    int i = 0;
    int[] arr = { 3, 7, 10, 13, 16, 19, 22, 25, 28, 31 };
    [SerializeField]
    int j = 2;
    void Start()
    {
        popup1.gameObject.SetActive(false);
    }

    void Awake()
    {
        popup1 = GameObject.Find("popup");
    }
    private void Update()
    {
        if (GameControl.player1.GetComponent<Waypoints>().waypointIndex == arr[i] && GameControl.player1.GetComponent<Waypoints>().moveAllowed == false && j == 2)
        {
            switch (arr[i])
            {
                case 3:
                    popup1.gameObject.SetActive(true);
                    t.text = "Uh oh! Looks like there is a flood in...";
                    rt = 1;
                    break;
                case 7:
                    popup1.gameObject.SetActive(true);
                    t.text = "There's a fire blazing through...";
                    rt = 2;
                    break;
                case 10:
                    popup1.gameObject.SetActive(true);
                    t.text = "A tsunami crashes through...";
                    rt = 3;
                    break;
                case 13:
                    popup1.gameObject.SetActive(true);
                    t.text = "Oh no! A typhoon has hit...";
                    rt = 4;
                    break;
                case 16:
                    popup1.gameObject.SetActive(true);
                    t.text = "An earthquake of magnitude 5.0 has hit...";
                    rt = 5;
                    break;
                case 19:
                    popup1.gameObject.SetActive(true);
                    t.text = "Yikes! A thunderstorm has rolled in...";
                    rt = 6;
                    break;
                case 22:
                    popup1.gameObject.SetActive(true);
                    t.text = "Oh no! A huge hurricane is headed towards...";
                    rt = 7;
                    break;
                case 25:
                    popup1.gameObject.SetActive(true);
                    t.text = "Uh oh! Looks like there is a flood in...";
                    rt = 1;
                    break;
                case 28:
                    popup1.gameObject.SetActive(true);
                    t.text = "There's a fire blazing through...";
                    rt = 2;
                    break;
                case 31:
                    popup1.gameObject.SetActive(true);
                    t.text = "A tsunami crashes through...";
                    rt = 3;
                    break;
            }
            j = 3;
        }
        if (GameControl.player1.GetComponent<Waypoints>().waypointIndex > arr[i])
        {
            if (i != arr.Length - 1)
            { i++; }
            popup1.gameObject.SetActive(false);
            j = 2;
        }
    }
}
