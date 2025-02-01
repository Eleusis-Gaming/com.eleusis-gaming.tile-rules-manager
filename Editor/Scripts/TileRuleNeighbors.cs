using System;
using UnityEngine;
using UnityEditor;
using Editor.Enums;
using static Editor.Scripts.Labels;

namespace Editor.Scripts
{
    public static class TileRuleNeighbors
    {
        public static void TileRuleNeighborsSection(TileRuleConfiguration tileRuleConfig)
        {
            AddLabel("Allowed Neighbors:");
            tileRuleConfig.AllowedNeighborTypes ??= Array.Empty<ETileType>();
            var typeCount = Mathf.Max(0, EditorGUILayout.IntField("Count", tileRuleConfig.AllowedNeighborTypes.Length));
            if (typeCount != tileRuleConfig.AllowedNeighborTypes.Length)
            {
                Array.Resize(ref tileRuleConfig.AllowedNeighborTypes, typeCount);
            }
            for (var i = 0; i < tileRuleConfig.AllowedNeighborTypes.Length; i++)
            {
                tileRuleConfig.AllowedNeighborTypes[i] = (ETileType)EditorGUILayout.EnumPopup($"Neighbor {i + 1}", tileRuleConfig.AllowedNeighborTypes[i]);
            }
        }
    }
}