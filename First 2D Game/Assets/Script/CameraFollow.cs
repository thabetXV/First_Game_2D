using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (followTransform)
        {
            this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);
        }
    }
    // public Transform player;
    // public Vector3 offset;
    //
    // void Update () 
    // {
    //     transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    // }
}
