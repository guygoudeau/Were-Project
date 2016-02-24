using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {

    private GameObject info;

	void Start () {
        info = GameObject.Find("InformationHolder(Clone)");
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (info.GetComponent<InfoHandler>().req[0] == true)
        {
            if (info.GetComponent<InfoHandler>().req[1] == true)
            {
                if (info.GetComponent<InfoHandler>().req[2] == true)
                {
                    info.GetComponent<InfoHandler>().win = true;
                    SceneManager.LoadScene("PreWin");
                }
            }
        }
    }

}
