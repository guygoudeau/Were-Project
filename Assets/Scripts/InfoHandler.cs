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

    private GameObject pas;     //Paused canvas
    public bool paused = false;
    public bool win = false;
    private static InfoHandler _instance;
    public static InfoHandler instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<InfoHandler>();
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    void Start()
    {
        print("Info Handler Start");
        timerText = GameObject.Find("TimeText").GetComponent<Text>();
        //pas = GameObject.Find("Paused Canvas");
        //pas.SetActive(false);
    }


    void FixedUpdate()
    {
        ///Actual Code
        /// 
        if(win == false)
        {
            timerText = GameObject.Find("TimeText").GetComponent<Text>();
            timer += Time.deltaTime;
            currentTime = maxTime - timer;

            int minutes = Mathf.FloorToInt(currentTime / 60F);
            int seconds = Mathf.FloorToInt(currentTime - minutes * 60);
            string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

            timerText.text = niceTime;

            if (currentTime <= 0f)
            {
                SceneManager.LoadScene("Menu");
            }
        }

        //Test Code. trying to find out how long it takes to complete.        
        //if(win == false)
        //{
        //    timer += Time.deltaTime;

        //    int minutes = Mathf.FloorToInt(timer / 60F);
        //    int seconds = Mathf.FloorToInt(timer - minutes * 60);
        //    string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        //    timerText.text = niceTime;
        //}
    }

    //bool togglePause()
    //{
    //    if (Time.timeScale == 0f)
    //    {
    //        Time.timeScale = 1f;
    //        return false;
    //    }

    //    else
    //    {
    //        Time.timeScale = 0f;
    //        return true;
    //    }
    //}
}