using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    //private static GameObject player1MoveText;
    public static GameObject player1;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    
    public static bool gameOver = false;
    void Start()
    {
        //player1MoveText = GameObject.Find("Player1MoveText");
        player1 = GameObject.Find("dollar");
        player1.GetComponent<Waypoints>().moveAllowed = false;
        player1StartWaypoint = 0;
    //player1MoveText.gameObject.SetActive(true);
}

    void Update()
    {
        if (player1.GetComponent<Waypoints>().waypointIndex > player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<Waypoints>().moveAllowed = false;
            //player1MoveText.gameObject.SetActive(false);
            player1StartWaypoint = player1.GetComponent<Waypoints>().waypointIndex - 1;
        }
        if (player1.GetComponent<Waypoints>().waypointIndex == player1.GetComponent<Waypoints>().waypoints.Length)
        {
            //player1MoveText.gameObject.SetActive(true);
            gameOver = true;
        }
    }
    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<Waypoints>().moveAllowed = true;
                break;
        }
    }
}

