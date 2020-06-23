using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CameraFollow : MonoBehaviour { 
    
    public Transform birdTransform;
    Vector3 range;

    void Awake()
    {
        //Calculate the range between the Camera's position and the bird position
        range = transform.position - birdTransform.position;
    }


    // Update is called once per frame
    void FixedUpdate() {
        
            //Make the camera follow the bird movement
            //and keep the y position constant
            transform.position = new Vector3(range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);

    }
}