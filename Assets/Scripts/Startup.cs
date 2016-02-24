using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour
{
    public enum GameState
    {
        MENU,
        TOWN,
    }
    public GameState startupState;
    void Start()
    {
        switch(startupState)
        {
            case GameState.MENU:
                UIRoot.instance.EnableMenu("Main Canvas");                
                break;
            case GameState.TOWN:
                break;
        }
        
    }
}
