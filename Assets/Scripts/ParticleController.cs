using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ParticleController : MonoBehaviour {

    public GameObject fireWork;
    private int counter;

    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        if(counter >= 4)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        counter++;
        Instantiate(fireWork, gameObject.transform.position, new Quaternion());
    }
}
