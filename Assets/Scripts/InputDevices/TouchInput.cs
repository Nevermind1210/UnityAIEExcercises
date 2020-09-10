using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace xavier_game
{
    public class TouchInput : MonoBehaviour
    {
        private CharacterControl characterControl;
        private void Awake()
        {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }
        public Joystick joystick;
        public JoyButton JoyButton;

        protected bool jump;

        // Update is called once per frame
        void Update()
        {
            if (VirtualInputManager.Instance.moveRight)
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
            if (VirtualInputManager.Instance.jump)
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
