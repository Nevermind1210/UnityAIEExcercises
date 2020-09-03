using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xavier_game
{
    public class ManualInput : MonoBehaviour
    {
        private CharacterControl characterControl;

        private void Awake()
        {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }
      
        void Update()
        {
            if(VirtualInputManager.Instance.moveRight)
            {
                characterControl.moveRight = true;
            }
            else
            {
                characterControl.moveRight = false;
            }

            if (VirtualInputManager.Instance.moveLeft)
            {
                characterControl.moveLeft = true;
            }
            else
            {
                characterControl.moveLeft = false;
            }
            if(VirtualInputManager.Instance.jump)
            {
                characterControl.jump = true;
            }
            else
            {
                characterControl.jump = false;
            }
        }
    }

}
