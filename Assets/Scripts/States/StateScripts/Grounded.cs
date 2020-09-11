﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xavier_game
{
    [CreateAssetMenu(fileName = "New State", menuName = "Xavier's Game/AbilityData/Grounded")]
    public class Grounded : StateData
    {
        [Range(0.01f,1f)]
        public float CheckTime;
        public float Distance;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
           
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);

            if(stateInfo.normalizedTime >= CheckTime)
            {
               if(IsGrounded(control))
                {
                    animator.SetBool(TransitionParameter.Grounded.ToString(), true);
                }
                else
                {
                    animator.SetBool(TransitionParameter.Grounded.ToString(), false);
                }
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        bool IsGrounded(CharacterControl control)
        {
            if(control.rb.velocity.y > -0.001f && control.rb.velocity.y <= 0f)
            {
                return true;
            }

            if(control.rb.velocity.y < 0f)
            {
                foreach (GameObject o in control.BottomSpheres)
                {
                    Debug.DrawRay(o.transform.position, -Vector3.up * 0.7f, Color.yellow);
                    RaycastHit hit;
                    if (Physics.Raycast(o.transform.position, -Vector3.up, out hit, Distance))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
