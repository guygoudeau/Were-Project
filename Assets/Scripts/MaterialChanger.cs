using UnityEngine;
using System.Collections;

public class MaterialChanger : MonoBehaviour {

    public int ch;
    private GameObject handler;

	void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {           
            gameObject.SetActive(false);
            handler = GameObject.Find("InformationHolder(Clone)");
            handler.GetComponent<InfoHandler>().req[ch] = true;
        }
    }
}
