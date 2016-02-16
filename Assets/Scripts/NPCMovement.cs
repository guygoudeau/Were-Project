using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPCMovement : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    public float moveRate;
    public Text villagerText;
    public string villSay;

    private int currentPoint;
    private bool moving = true;
    private float nextMove;
    public bool speach = false;

    // Use this for initialization
    void Start()
    {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;
        villagerText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(moving == true)
        {
            if (transform.position == patrolPoints[currentPoint].position)
             {
                currentPoint++;
                moving = false;
                nextMove = Time.time + moveRate;
             }

              if (currentPoint >= patrolPoints.Length)
             {
                 currentPoint = 0;
             }

             transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, speed * Time.deltaTime);
        }

        if (Time.time > nextMove)
        {
            moving = true;

            if(speach == true)
            {
                villagerText.text = "";
                speach = false;
            }          
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            moving = false;
            speach = true;
            villagerText.text = villSay;
            nextMove = Time.time + moveRate;
        }
    }
}
