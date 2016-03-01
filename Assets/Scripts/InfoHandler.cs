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
        timerText = GameObject.Find("TimeText").GetComponent<Text>();
    }


    void FixedUpdate()
    {
        if(win == false)    //If the game is being played
        {
            timer += Time.deltaTime;
            currentTime = maxTime - timer;

            int minutes = Mathf.FloorToInt(currentTime / 60F);
            int seconds = Mathf.FloorToInt(currentTime - minutes * 60);
            string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

            timerText.text = niceTime;

            if (currentTime <= 0f)
            {
                SceneManager.LoadScene("PreLose");
            }
        }
    }
}