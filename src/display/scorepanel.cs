using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorepanel : MonoBehaviour
{
    private static GameObject s;
    void Start()
    {
        s.gameObject.SetActive(true);
    }
    private void Awake()
    {
        s = GameObject.Find("score");
    }
}
