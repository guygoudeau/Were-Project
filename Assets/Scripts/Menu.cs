using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    public Canvas howToPlay;
    public string level;

    List<GameObject> _menus = new List<GameObject>();
    void Awake()
    {
        _menus.Add(MainCanvas.gameObject);
        _menus.Add(OptionsCanvas.gameObject);
        _menus.Add(howToPlay.gameObject);
        DisableMenus();
    }

    public void EnableMenu(GameObject go)
    {
        if (go.name == "Play Button")
            DisableMenus(); 
    }
   
    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
        howToPlay.enabled = false;
    }

    public void HowtoPlay()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
        howToPlay.enabled = true;
    }

    public void ReturnOn()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
        howToPlay.enabled = false;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(level);
        if (GameObject.Find("InformationHolder(Clone)") != null)
        {
            GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().timer = 0;
            GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().win = false;
            for (int i = 0; i < 3; i++)
            {
                GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().req[i] = false;
            }
        }    
    }

    private void DisableMenus()
    {
        foreach(GameObject go in _menus)
        {
            go.SetActive(false);
        }
    }

    public void EnableMenus()
    {
        foreach (GameObject go in _menus)
            go.SetActive(true);
    }
}
