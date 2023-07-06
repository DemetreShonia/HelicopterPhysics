using UnityEngine;
using UnityEditor;
using System;

namespace Shonia
{
	[CustomEditor(typeof(KeyBoardHeliInput))]
	public class KeyBoardHeliEditor : Editor
	{
		#region Variables
		KeyBoardHeliInput _targetInput;
        #endregion

        #region Builtin Methods
        void OnEnable()
        {
            _targetInput = target as KeyBoardHeliInput;
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            DrawDebugUI();
            Repaint();
        }

        #endregion

        #region Custom methods
        void DrawDebugUI()
        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.Space();
            
            EditorGUI.indentLevel++;
            EditorGUILayout.LabelField("Throttle: " + _targetInput.ThrottleInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Collective: " + _targetInput.CollectiveInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Cyclic: " + _targetInput.CyclicInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Pedal: " + _targetInput.PedalInput.ToString("0.00"), EditorStyles.boldLabel);
            EditorGUI.indentLevel--;

            EditorGUILayout.Space();
            EditorGUILayout.EndVertical();
        }
        #endregion
    }
}
