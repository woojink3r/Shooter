using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
public float speed = 10f; // The speed in m/s
public float fireRate = 0.3f; // Seconds/shot (Unused)
public float health = 10;
public int score = 100; // Points earned for destroying this
public bool ________________;
public Bounds bounds; // The Bounds of this and its children
public Vector3 boundsCenterOffset; // Dist of bounds.center from position
public static float LeftEdgeX = -50f;
void Awake() {
    
}

// Update is called once per frame
void Update() {
Move();
if ( transform.position.x < LeftEdgeX ) {
Destroy( this.gameObject );
}

}

public virtual void Move() {
Vector3 tempPos = pos;
tempPos.x -= speed * Time.deltaTime;
pos = tempPos;
}
// This is a Property: A method that acts like a field
public Vector3 pos {
get {
return( this.transform.position );
}
set {
this.transform.position = value;
}

}
}
