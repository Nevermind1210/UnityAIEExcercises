using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace xavier_game
{
    public enum TransitionParameter
    {
        Move,
        Jump,
        ForceTransition,
    }

    public class CharacterControl : MonoBehaviour
    {
        public float Speed;
        public Animator animator;
        public Material material;
        public bool moveRight;
        public bool moveLeft;
        public bool jump;

        private Rigidbody rigid;
        public Rigidbody rb
        {
            get
            {
               if(rigid == null)
                {
                    rigid = GetComponent<Rigidbody>();
                }
                return rigid;
            }
        }

        private void Awake()
        {
            CapsuleCollider cap = GetComponent<CapsuleCollider>();

            float bottom = cap.bounds.center.y - cap.bounds.extents.y;
            float top = cap.bounds.center.y + cap.bounds.extents.y;
            float front = cap.bounds.center.z + cap.bounds.extents.z;
            float back = cap.bounds.center.z - cap.bounds.extents.z;
        }

        public void ChangeMaterial()
        {
            if (material == null)
            {
                Debug.LogError("No Material Selected");
            }

            Renderer[] arrMaterials = this.gameObject.GetComponentsInChildren<Renderer>();

            foreach (Renderer r in arrMaterials)
            {
                if (r.gameObject != this.gameObject)
                {
                    r.material = material;
                }
            }
        }
    }
}

