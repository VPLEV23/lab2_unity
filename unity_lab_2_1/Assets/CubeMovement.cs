using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float Speed = 15f;
    public Vector3 Axe;
    
    void Start()
    {
       Axe = transform.right;
    }

    void Update()
    {
        transform.Rotate(Axe, Speed * Time.deltaTime);
    
    }

   
}
