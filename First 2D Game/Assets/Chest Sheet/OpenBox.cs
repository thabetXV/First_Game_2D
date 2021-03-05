using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{

    private bool destroedEvnt = false;
    public Animator animat;
    // Start is called before the first frame update
    void Start() {    
        animat = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() { }
  
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.E) && !destroedEvnt)
        {
            animat.SetBool("open", true);
        }
    }
}