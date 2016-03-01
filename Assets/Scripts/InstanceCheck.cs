using UnityEngine;
using System.Collections;

public class InstanceCheck : MonoBehaviour {

    private static InstanceCheck _instance;
    public static InstanceCheck instance;
    void Awake()
    {
        if (_instance == null)
        {
            /*
                checks to see if there is another object of this type and if there isn't
                it will not destroy the object when a scene is loaded
            */
            _instance = this.gameObject.GetComponent<InstanceCheck>();
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
}
