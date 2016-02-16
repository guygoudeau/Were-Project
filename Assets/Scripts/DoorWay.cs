using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorWay : MonoBehaviour {

    public string level;
    public int item;
    public bool needItem;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(needItem == true)
        {
            if(other.gameObject.tag == "Player" && GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().req[item] == false)
             {
                NextLevel(level);
            }
        }

        else
        {
            if (other.gameObject.tag == "Player")
            {
                NextLevel(level);
            }
        }         
    }   
    
    public void NextLevel(string level)
    {
        GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().lastLevel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(level);
    }   
}
