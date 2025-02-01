using UnityEngine;
using UnityEditor;

namespace Editor.Scripts
{
    public static class Labels
    {
        public static void AddLabel(string label)
        {
            GUILayout.Space(10);
            GUILayout.BeginHorizontal();
            GUILayout.Space(10);
            GUILayout.Label(label, EditorStyles.boldLabel);
            GUILayout.EndHorizontal();
        }
        
        public static void AddHorizontalLine()
        {
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space(10);
        }
    }
}