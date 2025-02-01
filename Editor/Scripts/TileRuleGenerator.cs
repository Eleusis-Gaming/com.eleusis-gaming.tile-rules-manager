using UnityEditor;
using Editor.ScriptableObject;
using System.Collections.Generic;
using static UnityEngine.ScriptableObject;
using static Editor.Scripts.TileRuleSocketRotator;

namespace Editor.Scripts
{
    public static class TileRuleGenerator
    {
        public static void GenerateTileRules(string path, List<TileRuleConfiguration> tileRuleConfigs)
        {
            foreach (var tileRuleConfig in tileRuleConfigs)
            {
                for (var index = 0; index < tileRuleConfig.Ids.Length; index++)
                {
                    var tileRuleScriptableObject = CreateInstance<TileRule>();
                    tileRuleScriptableObject.id = tileRuleConfig.Name + "-" + tileRuleConfig.Ids[index];
                    tileRuleScriptableObject.type = tileRuleConfig.Type;
                    tileRuleScriptableObject.allowedNeighborTypes = tileRuleConfig.AllowedNeighborTypes;
                    tileRuleScriptableObject.prefab = tileRuleConfig.Prefab;
                    tileRuleScriptableObject.rotation = tileRuleConfig.Rotations[index];
                    tileRuleScriptableObject.sockets = SetSocketsBasedOnRotation(tileRuleConfig.Rotations[index], tileRuleConfig.Sockets);
                    SaveTileRule(path, tileRuleScriptableObject);
                }
            }
            
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
        
        private static void SaveTileRule(string path, TileRule tileRule)
        {
            var directory = System.IO.Path.GetDirectoryName($"{path}{tileRule.id}.asset");
            if (!System.IO.Directory.Exists(directory)) {
                if (directory != null) System.IO.Directory.CreateDirectory(directory);
            }
            AssetDatabase.CreateAsset(tileRule, $"{path}{tileRule.id}.asset");
        }
    }
}