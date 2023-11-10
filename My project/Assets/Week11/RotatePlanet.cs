using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public Transform tr;
    public Transform target_tr;
    public float rot_speed = 15.0f;

    void Start()
    {
        tr = GetComponent<Transform>();   
        // tr은 스크립트가 붙은 물체의 position이니까, 
    }
    void Update()
    {
        tr.RotateAround(target_tr.position, Vector3.up, Time.deltaTime * rot_speed);
    }
}
