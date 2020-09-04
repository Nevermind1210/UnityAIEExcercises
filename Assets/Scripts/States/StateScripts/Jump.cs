using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xavier_game
{
    [CreateAssetMenu(fileName = "New State", menuName = "Xavier's Game/AbilityData/Jump")]
    public class Jump : StateData
    {
        public float jumpForce;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            characterState.GetCharacterControl(animator).rb.AddForce(Vector3.up * jumpForce);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }

}
