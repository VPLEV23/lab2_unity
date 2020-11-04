using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralMovement : MonoBehaviour
{
    public GameObject Target;
    public Vector3 direction;
    public float speed;
    void Start()
    {
        
    }

 
    void Update()
    {
        transform.RotateAround(Target.transform.position, new Vector3(0, 1, 0), speed * Time.deltaTime);
        transform.Translate(direction * 2 * Time.deltaTime);
        if (transform.position.y <= 2)
        {
            direction *= -1;
        }
        if (transform.position.y >= 16)
        {
            direction *= -1;
        }
    }
}
