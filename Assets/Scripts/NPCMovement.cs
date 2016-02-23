using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPCMovement : MonoBehaviour {

    public Transform[] patrolPoints;//The NPC's Patrol points
    public float speed;             //NPC's speed
    public float moveRate;          //How long the stop before each move
    public Text villagerText;       //The text space the villager will fill
    public string villSay;          //What the villager will fill in in the space

    private int currentPoint;       //Current point the NPC is on
    private bool moving = true;     //Are they moving?
    private float nextMove;         //When the NPC will move next
    public bool speach = false;     //Are they speaking.


    void Start()
    {
        currentPoint = 0;
        villagerText = GameObject.Find("Villager Text").GetComponent<Text>();
        villagerText.text = "";
    }


    void Update()
    {
        if(moving == true && patrolPoints[currentPoint] != null)
        {
            if (gameObject.transform.position == patrolPoints[currentPoint].transform.position)
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
