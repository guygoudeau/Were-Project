using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour {

    private GameObject info;
    public float moveRate;          //How long the stop before each move
    private Text villagerText;       //The text space the villager will fill
    public string villSay;          //What the villager will fill in in the space

    private float nextMove;         //When the NPC will move next
    public bool speach = false;     //Are they speaking.

    void Start () {
        info = GameObject.Find("InformationHolder(Clone)");
	}

    void Update()
    {
        if (Time.time > nextMove)
        {
            if (speach == true)
            {
                UIRoot.instance.NPCText("");
                speach = false;
            }
        }
    }

    int OnCollisionEnter2D(Collision2D other)
    {
        if (info.GetComponent<InfoHandler>().req[0] == true)
        {
            if (info.GetComponent<InfoHandler>().req[1] == true)
            {
                if (info.GetComponent<InfoHandler>().req[2] == true)
                {
                    info.GetComponent<InfoHandler>().win = true;
                    SceneManager.LoadScene("PreWin");
                    return 0;
                }
            }
        }

        
    
        if (other.gameObject.tag == "Player")
        {
            speach = true;
            UIRoot.instance.EnableMenu("NPC Canvas");
            UIRoot.instance.NPCText(villSay);
            nextMove = Time.time + moveRate;
        }
        return 0;
    }

}
