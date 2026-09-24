using UnityEngine;

public class RD_bombScript : MonoBehaviour
{
    private Vector3 velocity;
    private Vector3 acceleration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

    }
}
