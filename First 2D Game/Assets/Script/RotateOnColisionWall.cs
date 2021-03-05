using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnColisionWall : MonoBehaviour
{
    public Transform anEnime, anObject;
    private bool Collision = false;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        Collision = Physics2D.Linecast(anEnime.position,anObject.position, 1 << LayerMask.NameToLayer("Grass"));

        if (Collision)
            transform.localScale =
                new Vector3(transform.localScale.x * (-1), transform.localScale.y, transform.localScale.z);
    }
}
