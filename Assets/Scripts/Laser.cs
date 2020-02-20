using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public static float rightx = 35;
    void Update()
    {
        if(transform.position.x > rightx)
        {
            Destroy(this.gameObject);
        }

    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if( collidedWith.tag == "Object")
        {
            Destroy (collidedWith);
            Destroy(this.gameObject);
        }
    }
}
