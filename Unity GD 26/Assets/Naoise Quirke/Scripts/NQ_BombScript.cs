using System;
using UnityEngine;

public class NQ_BombScript : MonoBehaviour
{
    private Vector3 velocity;
    private Vector3 acceleration;
    float rotationRate = 360;
    internal void SetInitalVelocity(Vector3 StartingVelocity)
    {
        throw new NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        acceleration = new Vector3(0, -9.18f, 0);
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        transform.Rotate(transform.forward, rotationRate * Time.deltaTime);
    }
}
