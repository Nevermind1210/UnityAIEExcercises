using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float MovementSpeed = 0f;

    private Vector3 right = new Vector3(0, 90, 0),
        left = new Vector3(0, 270, 0),
        currentDirection = Vector3.zero;
    private Vector3 intialPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
