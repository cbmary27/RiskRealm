using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;
using Unity.Burst.Intrinsics;

public class M_box1 : MonoBehaviour
{
    private static GameObject m;
    private static GameObject p1;
    private static GameObject p2;
    private static GameObject p3;
    private static GameObject p4;
    private static GameObject p5;
    public Mbox1_pay m1;
    public TextMeshProUGUI t1;
    public static int b;
    public int[] marr = { 4, 7, 10, 14, 18, 22, 26};
    int i = 0;
    void Start()
    {
        m.gameObject.SetActive(false);
        p1.gameObject.SetActive(false);
        p2.gameObject.SetActive(false);
        p3.gameObject.SetActive(false);
        p4.gameObject.SetActive(false);
        p5.gameObject.SetActive(false);

    }

    private void Awake()
    {
        m = GameObject.Find("Mysterybox1");
        p1 = GameObject.Find("Image1");
        p2 = GameObject.Find("Image2");
        p3 = GameObject.Find("Riddle1");
        p4 = GameObject.Find("Riddle2");
        p5 = GameObject.Find("Riddle3");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.player1.GetComponent<Waypoints>().waypointIndex == marr[i] && GameControl.player1.GetComponent<Waypoints>().moveAllowed == false)
        {
            switch (marr[i])
            {
                case 4:
                    m.gameObject.SetActive(true);
                    p1.gameObject.SetActive(true);
                    b = 1;
                    t1.text = "Mystery Box!";
                    break;
                case 7:
                    p3.gameObject.SetActive(true);
                    //t = GameObject.Find("text").GetComponent<Text>();
                    b = 3;
                    break;
                case 10:
                    m.gameObject.SetActive(true);
                    p2.gameObject.SetActive(true);
                    b = 2;
                    //t = GameObject.Find("text2").GetComponent<Text>();
                    t1.text = "MysteryBox!";
                    break;
                case 14:
                    p4.gameObject.SetActive(true);
                    //t = GameObject.Find("text2").GetComponent<Text>();
                    b = 3;
                    break;
                case 18:
                    m.gameObject.SetActive(true);
                    p1.gameObject.SetActive(true);
                    b = 1;
                    //t = GameObject.Find("text2").GetComponent<Text>();
                    t1.text = "MysteryBox!";
                    break;
                case 22:
                    p5.gameObject.SetActive(true);
                    //t = GameObject.Find("text2").GetComponent<Text>();
                    b = 3;
                    break;
                case 26:
                    m.gameObject.SetActive(true);
                    p1.gameObject.SetActive(true);
                    b = 1;
                    //t = GameObject.Find("text2").GetComponent<Text>();
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
            Mbox1_pay.g = 0;
            Mbox1_pay.h = 0;

        }
    }
}
