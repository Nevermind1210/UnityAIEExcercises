using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorController : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;

    public bool isOpen = false;
    private float scale = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen == true) scale -= Time.deltaTime;
        else scale += Time.deltaTime;
        scale = Mathf.Clamp(scale, 0, 1);


        var topScale = top.transform.localScale;
        var bottomScale = bottom.transform.localScale;

        topScale.y = scale;
        bottomScale.y = scale;

        top.transform.localScale = topScale;
        bottom.transform.localScale = bottomScale;
    }

    public void Open()
    {
        isOpen = true;
    }

    public void Close()
    {
        isOpen = false;
    }
}
