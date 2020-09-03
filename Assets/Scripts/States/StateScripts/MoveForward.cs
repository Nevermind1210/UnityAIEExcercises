using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xavier_game
{
    [CreateAssetMenu(fileName = "New State", menuName = "Xavier's Game/AbilityData/MoveForward")]
    public class MoveForward : StateData
    {
        public float Speed;

        public override void UpdateAbility(CharacterState characterState, Animator animator)
        {
            CharacterControl c = characterState.GetCharacterControl(animator);

            if (VirtualInputManager.Instance.moveRight && VirtualInputManager.Instance.moveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }

            if (!VirtualInputManager.Instance.moveRight && !VirtualInputManager.Instance.moveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }

            if (VirtualInputManager.Instance.moveRight)
            {
                c.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                c.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }

            if (VirtualInputManager.Instance.moveLeft)
            {
                c.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                c.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        }
    }

}
