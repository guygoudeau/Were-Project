using UnityEngine;
using System.Collections;

public class PlaySide : MonoBehaviour {

    [HideInInspector]
    public bool side;

    void Update () {

        if (gameObject.transform.position.y <= GameObject.Find("CrossingPoint").transform.position.y)
        {
            side = true;
        }

        else
        {
            side = false;
        }

    }
}
