using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class FarmerPuzzleController : MonoBehaviour {

    public GameObject[] items;
    public bool fox;
    public bool bag;
    public bool goose;
    public bool playerSide = false;
    public GameObject garlic;

	void Update () {

        fox = items[0].gameObject.GetComponent<Snap>().side;
        bag = items[1].gameObject.GetComponent<Snap>().side;
        goose = items[2].gameObject.GetComponent<Snap>().side;
        playerSide = items[3].gameObject.GetComponent<PlaySide>().side;  
        
        if(bag == true && goose == true && fox == true)
        {
            garlic.SetActive(true);
        }    

        if (fox == goose && bag != fox && playerSide != fox)
        {
            if(items[0].gameObject.GetComponent<Snap>().follower == false && items[1].gameObject.GetComponent<Snap>().follower == false && items[2].gameObject.GetComponent<Snap>().follower == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
                      
        }

        if (bag == goose && goose != fox && playerSide != bag)
        {
            if (items[0].gameObject.GetComponent<Snap>().follower == false && items[1].gameObject.GetComponent<Snap>().follower == false && items[2].gameObject.GetComponent<Snap>().follower == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            } 
        }
       
    }
}
