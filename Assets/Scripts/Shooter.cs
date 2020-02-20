using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject prefabUFO;

    void Start()
    {
        GameObject UFO = Instantiate<GameObject>(prefabUFO);
        Vector3 pos = Vector3.zero;
        pos.x = -30;
        UFO.transform.position = pos;
    }
}
