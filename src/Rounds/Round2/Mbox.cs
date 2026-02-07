using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;
using Unity.Burst.Intrinsics;
using System.Net.NetworkInformation;

public class Mbox : MonoBehaviour
{
    private static GameObject m;
    private static GameObject p1;
    private static GameObject p2;
    private static GameObject p3;
    private static GameObject p4;
    private static GameObject p5;
    private static GameObject p6;
    public TextMeshProUGUI t1;
    public static int b;
    public int[] marr = { 5, 9, 11, 15, 17, 21, 23, 27, 29 };
    int i = 0;
    void Start()
    {
        m.gameObject.SetActive(false);
        p1.gameObject.SetActive(false);
        p2.gameObject.SetActive(false);
        p3.gameObject.SetActive(false);
        p4.gameObject.SetActive(false);
        p5.gameObject.SetActive(false);
        p6.gameObject.SetActive(false);
    }

    private void Awake()
    {
        m = GameObject.Find("Mysterybox1");
        p1 = GameObject.Find("Image1");
        p2 = GameObject.Find("Image2");
        p3 = GameObject.Find("Riddle1");
        p4 = GameObject.Find("Riddle2");
        p5 = GameObject.Find("Riddle3");
        p6 = GameObject.Find("Riddle4");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.player1.GetComponent<Waypoints>().waypointIndex == marr[i] && GameControl.player1.GetComponent<Waypoints>().moveAllowed == false)
        {
            switch (marr[i])
            {
                case 5:
                    p3.gameObject.SetActive(true);
                    t1.text = "Mystery Box!";
                    break;
                case 9:
                    m.gameObject.SetActive(true);
                    p1.gameObject.SetActive(true);
                    b = 1;
                    t1.text = "Mystery Box!";
                    break;
                case 11:
                    p4.gameObject.SetActive(true);
                    t1.text = "MysteryBox!";
                    break;
                case 15:
                    m.gameObject.SetActive(true);
                    p2.gameObject.SetActive(true);
                    b = 2;
                    t1.text = "MysteryBox!";
                    break;
                case 17:
                    p5.gameObject.SetActive(true);
                    t1.text = "MysteryBox!";
                    break;
                case 21:
                    m.gameObject.SetActive(true);
                    p1.gameObject.SetActive(true);
                    b = 1;
                    t1.text = "MysteryBox!";
                    break;
                case 23:
                    p6.gameObject.SetActive(true);
                    t1.text = "MysteryBox!";
                    break;
                case 27:
                    m.gameObject.SetActive(true);
                    p2.gameObject.SetActive(true);
                    b = 2;
                    t1.text = "MysteryBox!";
                    break;
                case 29:
                    m.gameObject.SetActive(true);
                    t1.text = "MysteryBox!";
                    break;
            }
        }

        if (GameControl.player1.GetComponent<Waypoints>().waypointIndex > marr[i])
        {
            if (i != marr.Length - 1)
            { i++; }
            m.gameObject.SetActive(false);
            p1.gameObject.SetActive(false);
            p2.gameObject.SetActive(false);
            p3.gameObject.SetActive(false);
            p4.gameObject.SetActive(false);
            p5.gameObject.SetActive(false);
            p6.gameObject.SetActive(false);
            M_boxpay.r = 0;
            M_boxpay.s = 0;
        }
    }
}
