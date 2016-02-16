using UnityEngine;
using System.Collections;

public class Snap : MonoBehaviour {

    public GameObject follow;//Player or object the camera is following.

    [HideInInspector]
    public bool follower;
    private bool snap;
    [HideInInspector]
    public bool side;

	void Update () {

        if(follower == true)
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().holding = true;
            gameObject.transform.position = GameObject.Find("Player").transform.position; //Sets object's position to player's.
        }        

        if(Input.GetKeyDown(KeyCode.F))
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().holding = false;
            follower = false;
        }

        if (gameObject.transform.position.y <= GameObject.Find("CrossingPoint").transform.position.y)
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
        if(GameObject.Find("Player").GetComponent<PlayerMovement>().holding == false)
        {
            follower = true;
        }   
    }
}
