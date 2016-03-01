using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour
{  
    private static InputHandler _instance;
    public static InputHandler instance;
    void Awake()
    {
        if (_instance == null)
        {
            /*
                checks to see if there is another object of this type and if there isn't
                it will not destroy the object when a scene is loaded
            */
            _instance = this.gameObject.GetComponent<InputHandler>();
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
    }
    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!UIRoot.instance.paused)
            {
                UIRoot.instance.Pause();
                
            }
            else if (UIRoot.instance.paused)
            {
                UIRoot.instance.UnPause();
                
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Statues");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Farmer");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("HedgeMaze");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject.Find("InformationHolder(Clone)").GetComponent<InfoHandler>().req[i] = true;
            }
        }
    }

}
