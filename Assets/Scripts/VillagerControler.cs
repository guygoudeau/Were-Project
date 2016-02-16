using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VillagerControler : MonoBehaviour {

    public float sayRate;
    public Text villagerText;
    public string villSay;
    private float nextSay;

    // Use this for initialization
    void Start () {
        villagerText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSay)
        {
            villagerText.text = "";
        }
    }

    public void Speach()
    {
        nextSay = Time.time + sayRate;
        villagerText.text = villSay;
    }
}
