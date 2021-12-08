using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{   
    public float Speed;
    public Vector3 initialPosition;
        
    private void Start()
    {
        initialPosition = transform.position;
    }
    void Update()
    {
        transform.position -= Vector3.right * Speed;
    }

    public void caRepart()
    {
        transform.position = initialPosition;
    }


}
