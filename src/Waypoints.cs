using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField]
    private float speed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;
    public bool moveAllowed = false;


    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    
    void Update()
    {
        if (moveAllowed)
            Move();
    }

    private void Move()
    {
       if(waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, speed * Time.deltaTime);
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
