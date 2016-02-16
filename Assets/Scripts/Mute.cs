using UnityEngine;
using System.Collections;

public class Mute : MonoBehaviour {

    bool isMute;

    public void Muted()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }
}
