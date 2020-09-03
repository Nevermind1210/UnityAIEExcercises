using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class PressurePlateEvent : UnityEvent { };

public class PressurePlate : MonoBehaviour
{
    public PressurePlateEvent onActivate;
    public PressurePlateEvent onDeactivate;

    private bool ifPressed;

    public bool PressurePlatePressed()
    {
        return ifPressed;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("HELLO WORLD");
        if(other.transform.tag == "Player")
        {
            onActivate.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("HELLO WORLD");
        if (other.transform.tag == "Player")
        {
            onDeactivate.Invoke();
        }
    }
}
