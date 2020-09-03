using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrollerCameraFollower : MonoBehaviour
{
    [Header("Camera Settings")]
    [SerializeField] private Transform target;
    [SerializeField] private float smoothSpeed;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Vector3 movedOffset;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        Vector3 desiredPostion = target.position + offset;
        Vector3 smoothedPosition = Vector3.Slerp(transform.position, desiredPostion, smoothSpeed);

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position = smoothedPosition - movedOffset;
            Debug.Log("Left");
        }
        else if (Input.GetAxis("Horizontal") == 0)
        {
            transform.position = smoothedPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
