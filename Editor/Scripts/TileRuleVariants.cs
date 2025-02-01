using Editor.Enums;
using UnityEditor;
using UnityEngine;
using static Editor.Scripts.Labels;

namespace Editor.Scripts
{
    public static class TileRuleVariants
    {
        public static void TileRuleVariantsSection(TileRuleConfiguration tileRuleConfig)
        {
            AddLabel("Variants:");
            tileRuleConfig.Variants = Mathf.Max(0,EditorGUILayout.IntField("Variants", tileRuleConfig.Variants));
            if (tileRuleConfig.Variants <= 0) return;
            
            if(tileRuleConfig.Variants != tileRuleConfig.Ids.Length) tileRuleConfig.Ids = new string[tileRuleConfig.Variants];
            if(tileRuleConfig.Variants != tileRuleConfig.Rotations.Length) tileRuleConfig.Rotations = new ETileRotation[tileRuleConfig.Variants];
            EditorGUILayout.Space(10);
            for (var i = 0; i < tileRuleConfig.Variants; i++)
            {
                EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                AddLabel($"Variant {i + 1}");
                tileRuleConfig.Ids[i] = EditorGUILayout.TextField("ID", tileRuleConfig.Ids[i]);
                tileRuleConfig.Rotations[i] = (ETileRotation) EditorGUILayout.EnumPopup("Rotation", tileRuleConfig.Rotations[i]);
                EditorGUILayout.Space(10);
            }
        }
    }
}