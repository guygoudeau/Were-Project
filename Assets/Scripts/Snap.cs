using UnityEngine;
using System.Collections;

public class Snap : MonoBehaviour {

    public GameObject follow;//Player or object the camera is following.

    GameObject player; 
    GameObject crossingPoint; 

    [HideInInspector]
    public bool follower;
    [HideInInspector]
    public bool side;

    void Start()
    {
       player = GameObject.Find("Player").gameObject;
       crossingPoint = GameObject.Find("CrossingPoint").gameObject;
    }

	void Update () {

        if(follower == true)
        {
            player.GetComponent<PlayerMovement>().holding = true;
            gameObject.transform.position = player.transform.position; //Sets object's position to player's.
        }        

        if(Input.GetKeyDown(KeyCode.F))
        {
            player.GetComponent<PlayerMovement>().holding = false;
            follower = false;
        }

        if (gameObject.transform.position.y <= crossingPoint.transform.position.y)
        {
            side = true;
        }

        else
        {
            side = false;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(player.GetComponent<PlayerMovement>().holding == false && player.GetComponent<PlaySide>().side == side)
        {
            follower = true;
        }   
    }
}
