using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public Vector3[] points; // This is where we can carry X amount of points that is called "Size" in Unity!
    public int point_number = 0; 
    private Vector3 currentTarget;

    public float tolerance;
    public float speed;
    public float delayTime;

    private float delayStart;
    public bool automatic;

    void Start()
    {
        if (points.Length > 0)
        {
            currentTarget = points[0];
        }
        tolerance = speed * Time.deltaTime;
    }

    void FixedUpdate() //Change this to Update for RigidBody, or FixedUpdate for playercontroller to attach to platform totally up to you.
    {
        if (transform.position != currentTarget)
        {
            MovePlatform();
        }
        else
        {
            UpdateTarget();
        }
    }

    void MovePlatform()
    {
        Vector3 heading = currentTarget - transform.position;
        transform.position += (heading / heading.magnitude) * speed * Time.deltaTime;
        if (heading.magnitude < tolerance)
        {
            transform.position = currentTarget;
            delayStart = Time.time;
        }
    }

    void UpdateTarget()
    {
        if (automatic)
        {
            if (Time.time - delayStart > delayTime)
            {
                NextPlatform();
            }
        }
    }

    public void NextPlatform()
    {
        point_number++;
        if (point_number >= points.Length)
        {
            point_number = 0;
        }
        currentTarget = points[point_number];
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
