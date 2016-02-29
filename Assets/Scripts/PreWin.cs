using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PreWin : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
