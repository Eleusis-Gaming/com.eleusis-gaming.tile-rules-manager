using UnityEngine;
using UnityEditor;
using Editor.Enums;

namespace Editor.Scripts
{
    public static class TileRuleBase
    {
        public static void TileRuleBaseSection(TileRuleConfiguration tileRuleConfig)
        {
            tileRuleConfig.Name = EditorGUILayout.TextField("Config Prefix", tileRuleConfig.Name);
            tileRuleConfig.Type = (ETileType) EditorGUILayout.EnumPopup("Tile Type", tileRuleConfig.Type);
            tileRuleConfig.Prefab = (GameObject) EditorGUILayout.ObjectField("Prefab", tileRuleConfig.Prefab, typeof(GameObject), false);
        }
    }
}