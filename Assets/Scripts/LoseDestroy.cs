using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameObject.Find("uiroot") != null)
        {
            Destroy(GameObject.Find("uiroot"));
        }

        if (GameObject.Find("InformationHolder(Clone)") != null)
        {
            Destroy(GameObject.Find("InformationHolder(Clone)"));
        }

        if (GameObject.Find("InputHandler") != null)
        {
            Destroy(GameObject.Find("InputHandler"));
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
