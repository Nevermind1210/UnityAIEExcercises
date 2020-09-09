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
        public Animator animator;
        public Material material;
        public bool moveRight;
        public bool moveLeft;
        public bool jump;
        public GameObject ColliderEdgePrefab;
        private List<GameObject> bottomSpheres = new List<GameObject>() ;

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

            GameObject bottomFront = CreateEdgeSphere(new Vector3(0f, bottom, front));
            GameObject bottomBack = CreateEdgeSphere(new Vector3(0f, bottom, back));

            bottomFront.transform.parent = this.transform;
            bottomBack.transform.parent = this.transform;

            bottomSpheres.Add(bottomFront);
            bottomSpheres.Add(bottomBack);

            float sec = (bottomFront.transform.position - bottomBack.transform.position).magnitude / 5f;

            for (int i = 0; i < 5; i++)
            {
                Vector3 pos = bottomBack.transform.position + (Vector3.forward * sec * (i + 1));
                GameObject newObj = CreateEdgeSphere(pos);
                newObj.transform.parent = this.transform;
            }

        }

        GameObject CreateEdgeSphere(Vector3 pos)
        {
            GameObject obj = Instantiate(ColliderEdgePrefab, pos, Quaternion.identity);
            return obj;
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

