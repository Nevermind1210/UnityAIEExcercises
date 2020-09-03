using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace xavier_game
{
    [CustomEditor(typeof(CharacterControl))]
    public class Material : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            CharacterControl control = (CharacterControl)target;

            if (GUILayout.Button("Change Material"))
            {
                control.ChangeMaterial();
            }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

