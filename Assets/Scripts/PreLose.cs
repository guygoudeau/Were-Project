using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PreLose : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Lose");
        }
    }
}