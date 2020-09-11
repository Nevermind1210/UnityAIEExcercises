using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace xavier_game
{
    public class TouchInput : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (VirtualInputManager.Instance.moveRight)
            {
                VirtualInputManager.Instance.moveRight = true;
            }
            else
            {
                VirtualInputManager.Instance.moveRight = false;
            }

            if (VirtualInputManager.Instance.moveLeft)
            {
                VirtualInputManager.Instance.moveLeft = true;
            }
            else
            {
                VirtualInputManager.Instance.moveLeft = false;
            }
            if (VirtualInputManager.Instance.jump)
            {
                VirtualInputManager.Instance.jump = true;
            }
            else
            {
                VirtualInputManager.Instance.jump = false;
            }
        }
    }

}
