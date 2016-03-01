using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class UIRoot : MonoBehaviour
{
    public GameObject infoHolder;
    public List<GameObject> _menus = new List<GameObject>();
    public bool paused;
    private static UIRoot _instance;
    public static UIRoot instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIRoot>();
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }
    void Awake()
    {
        if (_instance == null)
        {
            /*
                checks to see if there is another object of this type and if there isn't
                it will not destroy the object when a scene is loaded
            */
            _instance = this.gameObject.GetComponent<UIRoot>();
            DontDestroyOnLoad(_instance);

        }

        else
        {
            if (this != _instance)
            {
                /*
                    If the same object does exist it will destroy the current instance of that object
                */

                Destroy(this.gameObject);
            }
        }
        DisableMenus();
    }

    public void NPCText(string txt)
    {
        GameObject npcMenu = _menus.Find(x => x.name == "NPC Canvas");
        npcMenu.GetComponentInChildren<Text>().text = txt;
        
    }
    public void EnableMenu(string name)
    {
        GameObject menu = _menus.Find(x => x.name == name);
        menu.SetActive(true);
    }

    public void DisableMenu(string name)
    {
        GameObject menu = _menus.Find(x => x.name == name);
        menu.SetActive(false);
    }

    public void LoadOn(string level)
    {
        SceneManager.LoadScene(level);
        DisableMenus();
        UnPause();
        EnableMenu("HUD Canvas");
        if (GameObject.Find("InformationHolder(Clone)") != null)
        {
            GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().timer = 0;
            GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().currentTime = GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().maxTime;
            GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().win = false;
            for (int i = 0; i < 3; i++)
            {
                GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().req[i] = false;
            }
        }

        else
        {
            Instantiate(infoHolder);
        }

        GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().lastLevel = "";
    }

    private void DisableMenus()
    {
        foreach (GameObject go in _menus)
        {
            go.SetActive(false);
        }
    }

    public void EnableMenus()
    {
        foreach (GameObject go in _menus)
            go.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        paused = true;
        EnableMenu("Main Canvas");
    }

    public void UnPause()
    {
        paused = false;
        Time.timeScale = 1;
        DisableMenu("NPC Canvas");
        DisableMenu("Main Canvas");
        DisableMenu("Options Canvas");
        DisableMenu("Instructions Canvas");
        EnableMenu("HUD Canvas");
    }
}
