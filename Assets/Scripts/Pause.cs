using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public void LoadOn()
    {
        SceneManager.LoadScene("Menu");
    }
}
