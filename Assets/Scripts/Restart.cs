using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void TryAgain()
    {
        SceneManager.LoadScene("Menu");
    }
}
