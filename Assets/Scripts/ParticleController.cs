using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

    public GameObject fireWork;

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(fireWork, gameObject.transform.position, new Quaternion());
    }
}
