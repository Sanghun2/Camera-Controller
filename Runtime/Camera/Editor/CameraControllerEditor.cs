using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace BilliotGames
{
    [CustomEditor(typeof(CameraController))]
    public class CameraControllerEditor : Editor
    {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();

            var _script = (CameraController)target;
            if (GUILayout.Button("Calculate Offset")) {
                _script.CalculateOffset();
            }
        }
    }
}
