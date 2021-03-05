using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private float timer = 0.0f;
    private float visualTime = 0.0f;
    private float scrollBar = 1.0f;
    public float waitTime = 2.0f;
    public bool Cond = true;
    public Vector3 pos;
    void Update()   
    {               
        timer += Time.deltaTime;

        pos = transform.position;
        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        if (timer > waitTime && Cond)
        {
            visualTime = timer;
            Instantiate(Enemy, pos, Quaternion.identity);

            // Remove the recorded 2 seconds.
            timer = timer - waitTime;
            Time.timeScale = scrollBar;
        }
        
    }
}

