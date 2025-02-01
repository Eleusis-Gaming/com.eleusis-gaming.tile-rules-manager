using UnityEngine;
using UnityEditor;
using Editor.Scripts;
using System.Collections.Generic;
using static UnityEngine.GUILayout;
using static Editor.Scripts.Labels;
using static Editor.Scripts.TileRuleBase;
using static Editor.Scripts.TileRuleGenerator;
using static Editor.Scripts.TileRuleNeighbors;
using static Editor.Scripts.TileRuleSockets;
using static Editor.Scripts.TileRuleVariants;

namespace Editor
{
    public class TileRulesManagerWindow : EditorWindow
    {
        [MenuItem("Tools/Tile Rules Manager")]
        public static void ShowWindow() { GetWindow<TileRulesManagerWindow>("Tile Rules Manager"); }
        
        private string _outputPath = "Assets/Resources/TileRules/";
        private Vector2 _scrollPosition;
        private readonly List<TileRuleConfiguration> _tileRuleConfigurations = new();

        private void OnGUI()
        {
            Space(10);
            _outputPath = EditorGUILayout.TextField("Output Path:", _outputPath);
            Space(10);
            if (Button("Add Tile Config")) _tileRuleConfigurations.Add(new TileRuleConfiguration());
            _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);
            Space(10);
            TileRulesConfigurationsDisplay();
            EditorGUILayout.EndScrollView();
            if (Button("Generate Tile Rules")) GenerateTileRules(_outputPath, _tileRuleConfigurations);
        }

        private void TileRulesConfigurationsDisplay()
        {
            AddHorizontalLine();
            EditorGUI.indentLevel++;
            foreach (var tileConfig in _tileRuleConfigurations)
            {
                BeginHorizontal();
                tileConfig.IsExpanded = EditorGUILayout.Foldout(tileConfig.IsExpanded, tileConfig.Name ?? "Tile Config");
                if (Button("Remove"))
                {
                    _tileRuleConfigurations.Remove(tileConfig);
                    EndHorizontal();
                    break;
                }
                EndHorizontal();
                if (!tileConfig.IsExpanded) continue;
                Space(10);
                TileRuleBaseSection(tileConfig);
                TileRuleNeighborsSection(tileConfig);
                TileRuleSocketsSection(tileConfig);
                TileRuleVariantsSection(tileConfig);
                AddHorizontalLine();
            }
            EditorGUI.indentLevel--;
        }
    }
}