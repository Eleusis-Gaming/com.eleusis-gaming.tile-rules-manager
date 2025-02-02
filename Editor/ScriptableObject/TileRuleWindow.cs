using Editor.Scripts;
using UnityEditor;

namespace Editor.ScriptableObject
{
    [CustomEditor(typeof(TileRule))]
    public class TileRuleWindow : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var tileRule = (TileRule) target;
            TileRuleSockets.TileRuleSocketsSection(tileRule.sockets);
        }
    }
}