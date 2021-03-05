using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MovEnemy : MonoBehaviour
{
    private Rigidbody2D rg;
    public float speed = 0.1f;
    public float rotateSpeed = 10f;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        rg = GetComponent<Rigidbody2D>();
        gameObject.transform.position += new Vector3(-speed, 0, 0);
        rg.rotation += rotateSpeed;
        
    }
}
