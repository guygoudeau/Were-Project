using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{ 
    public void LoadOn(GameObject go)
    {
        GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().paused = false;
        GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().win = true;
        Time.timeScale = 1f;
        go.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
