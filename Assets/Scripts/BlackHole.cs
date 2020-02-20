using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject[] Obj;
    public float speed=10f;
    public float topAndBotEdge=50f;
    public float chanceToChangeDirections = 0.05f ;
    public float secondsBetweenObject = 1f ;
    // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("ObjectAppear", 2f, secondsBetweenObject) ;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position ;
        pos.y += speed * Time.deltaTime ;
        transform.position = pos ;

        if (pos.y < -topAndBotEdge) {

            speed = Mathf.Abs(speed) ;

        } else if (pos.y > topAndBotEdge) {

            speed = -Mathf.Abs(speed) ;

        }
        
    }

    void FixedUpdate() {

        if (Random.value < chanceToChangeDirections) {

            speed *= -1 ;

        }

    }

    void ObjectAppear() {
        int ndx = Random.Range(0, Obj.Length);
            
        GameObject Objects = Instantiate(Obj[ndx])as GameObject ;
        Objects.transform.position = transform.position ;
        Vector3 pos = Vector3.zero;

            }
       
}
