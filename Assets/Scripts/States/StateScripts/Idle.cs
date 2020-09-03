using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xavier_game
{
    [CreateAssetMenu(fileName = "New State", menuName = "Xavier's Game/AbilityData/Idle")]
    public class Idle : StateData
    {
        public float Speed;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);

            if(control.jump)
            {
                animator.SetBool(TransitionParameter.Jump.ToString(), true);
            }

            if (VirtualInputManager.Instance.moveRight)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }

            if (VirtualInputManager.Instance.moveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
          
        }
    }

}
