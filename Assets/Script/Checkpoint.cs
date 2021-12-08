using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>() != null)
        {
           
            FindObjectOfType<Score>().addScore();
        }
    }

    
    public void caRepart()
    {
        transform.position = initialPosition;
    }

}
