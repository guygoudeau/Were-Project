using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    public string level;

    void Awake()
    {
        OptionsCanvas.enabled = false;
    }
   
    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(level);
        GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().timer = 0;
    }

    public void QuitOn()
    {
        Application.Quit();
    }
}
