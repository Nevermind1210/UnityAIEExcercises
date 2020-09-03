using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace xavier_game
{
    public enum TransitionParameter
    {
        Move,
    }

    public class CharacterControl : MonoBehaviour
    {
        public float Speed;
        public Animator animator;
        public Material material;

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

