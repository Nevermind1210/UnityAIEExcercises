using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{

    //Public Variables\\

    public float Speed;

    //Private Variables\\

    private Rigidbody rb;

    //Initiate at first frame of game\\

    void Start()
    {
        //Calling Components\\

        rb = GetComponent<Rigidbody>();
    }

    //Initiate at a set time\\

    void FixedUpdate()
    {
        //Movement Controls\\

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(Movement * Speed);
    }

    //Pick-up Collision\\

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}