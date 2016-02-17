using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InfoHandler : MonoBehaviour {

    public bool[] req = { false, false, false };
    public float timer;
    public float currentTime;
    public float maxTime;
    public string lastLevel;
    public Text timerText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        timerText = GameObject.Find("TimeText").GetComponent<Text>();       
    }

    void FixedUpdate()
    {
        ///Actual Code
        /// 
        //timerText = GameObject.Find("TimeText").GetComponent<Text>();
        //timer += Time.deltaTime;
        //currentTime = maxTime - timer;

        //int minutes = Mathf.FloorToInt(currentTime / 60F);
        //int seconds = Mathf.FloorToInt(currentTime - minutes * 60);
        //string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        //timerText.text = niceTime;

        //if(currentTime <= 0f)
        //{
        //    SceneManager.LoadScene("Menu");
        //}

        //Test Code. trying to find out how long it takes to complete.
        timerText = GameObject.Find("TimeText").GetComponent<Text>();
        timer += Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        timerText.text = niceTime;
    }
}