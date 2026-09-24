using System;
using UnityEngine;

public class RS_BombScript : MonoBehaviour
{

    Vector3 velocity, acceleration;
    float rotationRate = 360;
    internal void SetInitialVelocity(Vector3 StartingVelocity)
    {
        velocity = StartingVelocity;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = new Vector3(0, -9.81f, 0);

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        transform.Rotate(Vector3.forward, rotationRate * Time.deltaTime);

    }
}
