using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // public AudioClip diePlayerAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        // AudioSource.PlayClipAtPoint(diePlayerAudio, transform.position);
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
