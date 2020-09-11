using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xavier_game
{
    [CreateAssetMenu(fileName = "New State", menuName = "Xavier's Game/AbilityData/Jump")]
    public class Jump : StateData
    {
        public float jumpForce;
        public AnimationCurve Gravity;
        public AnimationCurve Pull;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            characterState.GetCharacterControl(animator).rb.AddForce(Vector3.up * jumpForce);
            animator.SetBool(TransitionParameter.Grounded.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);

            control.GravityMultiplier = Gravity.Evaluate(stateInfo.normalizedTime);
            control.PullMultipiler = Pull.Evaluate(stateInfo.normalizedTime);
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }

}
