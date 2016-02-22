using UnityEngine;
using System.Collections.Generic;
public class StatueDetection : MonoBehaviour {

    [HideInInspector] public string current;

    public GameObject[] statues;
    private int counter = 0;
    public GameObject[] wall;

    void Start()
    {
        Reset();
    }

    public void Check()
    {
        if (current == statues[counter].name)
        {
            statues[counter].transform.FindChild("Gem").gameObject.SetActive(true);
            counter++;
        }

        else
        {
            Reset();
            counter = 0;
        }

        if (counter >= 8)
        {
            for (int g = 0; g < 3; g++)
            {
                wall[g].gameObject.SetActive(false);
            }
        }
    }

    void Reset()
    {
        for (int g = 0; g < 8; g++)
        {
            statues[g].transform.FindChild("Gem").gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Statue")
        { 
            current = other.gameObject.name;
            Check();
        }
    }
}
