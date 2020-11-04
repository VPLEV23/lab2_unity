using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject Target;
    public Vector3 direction;
    public float Speed;

    void Start()
    {
        Debug.Log(Vector3.up);    
    }

    void Update()
    {
        transform.RotateAround(Target.transform.position, direction, Speed *
        Time.deltaTime);
        //RotatePointAroundPivot(Target.transform.position, direction, Quaternion.Euler(0, 2 * Time.deltaTime, 0));
     
    }

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }
}
