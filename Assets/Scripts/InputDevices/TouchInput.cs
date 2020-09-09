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
        protected Joystick joystick;
        protected JoyButton JoyButton;

        protected bool jump;

        // Start is called before the first frame update
        void Start()
        {
            joystick = FindObjectOfType<Joystick>();
            JoyButton = FindObjectOfType<JoyButton>();
        }

        // Update is called once per frame
        void Update()
        {
            var rb = GetComponent<Rigidbody>();

            rb.velocity = new Vector3(joystick.Horizontal * 100f,
                                      rb.velocity.y,
                                      joystick.Vertical * 100f);

            if (!jump && JoyButton.Pressed)
            {
                jump = true;
                rb.velocity += Vector3.up * 100f;
            }

            if(jump && !JoyButton.Pressed)
            {
                jump = false;
            }
        }
    }

}
