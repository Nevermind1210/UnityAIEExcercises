using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace xavier_game
{
    public class KeyboardInputThirdPerson : MonoBehaviour
    { 
        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                VirtualInputManagerThirdPerson.Instance.moveUp = true;
            }
            else
            {
                VirtualInputManagerThirdPerson.Instance.moveUp = false;
            }
            if(Input.GetKey(KeyCode.S))
            {
                VirtualInputManagerThirdPerson.Instance.moveDown = true;
            }
            else
            {
                VirtualInputManagerThirdPerson.Instance.moveDown = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                VirtualInputManagerThirdPerson.Instance.moveRight = true;
            }
            else
            {
                VirtualInputManagerThirdPerson.Instance.moveRight = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                VirtualInputManagerThirdPerson.Instance.moveLeft = true;
            }
            else
            {
                VirtualInputManagerThirdPerson.Instance.moveLeft = false;
            }
        }
    }

}
