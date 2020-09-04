using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xavier_game
{
    [CreateAssetMenu(fileName = "New State", menuName = "Xavier's Game/AbilityData/Land")]
    public class Land : StateData
    {
        public float Speed;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionParameter.Jump.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
          
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }

}
