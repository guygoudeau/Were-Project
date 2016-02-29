using UnityEngine;
using System.Collections;

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
                print("found another instance of ID: " + gameObject.GetInstanceID() + ". Destroying.");
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
    }

}
