using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject follow;//Player or object the camera is following.

    public bool cameraRestraint;

    public float maxX;//Max X point
    public float minX;//Min X point

    public float maxY;//Max Y point
    public float minY;//Min Y Point

    Vector3 offset;//Distace from player  

	void Update () {

        offset = new Vector3(follow.transform.position.x, follow.transform.position.y, gameObject.transform.position.z);

        if(cameraRestraint == true)
        {
            if (follow.transform.position.x <= minX)//X min. If true, Keeps x = minX
            {
                offset = new Vector3(minX, offset.y, gameObject.transform.position.z);
            }

            else if (follow.transform.position.x >= maxX)//X max. If true, Keeps x = maxX
            {
                offset = new Vector3(maxX, offset.y, gameObject.transform.position.z);
            }

            if (follow.transform.position.y <= minY)//Y min. If true, Keeps y = minY
            {
                offset = new Vector3(offset.x, minY, gameObject.transform.position.z);
            }

            else if (follow.transform.position.y >= maxY)//Y max. If true, Keeps y = maxY
            {
                offset = new Vector3(offset.x, maxY, gameObject.transform.position.z);
            }  
        }
       
        
        gameObject.transform.position = offset; //Sets camera position to offset.
	}
}
