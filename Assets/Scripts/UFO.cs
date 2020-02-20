using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UFO : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject prefabLaser;
    public float projectileSpeed;

    [Header("Set in Inspector")]
    public GameObject projectile;
    public GameObject firepoint;
    public Vector3 firepos;
    
    

    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.y = mousePos3D.y;
        this.transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            FireLaser();
        }

        void FireLaser()
        {
            projectile = Instantiate(prefabLaser) as GameObject;
            projectile.transform.position = transform.position;
            Rigidbody LaserRigid = projectile.GetComponent<Rigidbody>();
            LaserRigid.velocity = Vector3.right * projectileSpeed;

        }
    }
    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Object")
        {
            ObjectDestroyed();
        }
            
    }

    public void ObjectDestroyed()
    {
        GameObject[] tObjectArray = GameObject.FindGameObjectsWithTag("Object");
        foreach (GameObject tGO in tObjectArray)
        {
            Destroy(tGO);
        }
    }
}
