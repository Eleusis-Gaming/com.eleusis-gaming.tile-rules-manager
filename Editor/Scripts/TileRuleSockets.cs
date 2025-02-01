using UnityEditor;
using Editor.Enums;
using static Editor.Scripts.Labels;

namespace Editor.Scripts
{
    public static class TileRuleSockets
    {
        public static void TileRuleSocketsSection(TileRuleConfiguration tileRuleConfig)
        {
            AddLabel("Top Sockets:");
            tileRuleConfig.Sockets.topNwSocket = (ETileSocket) EditorGUILayout.EnumPopup("Top NW", tileRuleConfig.Sockets.topNwSocket);
            tileRuleConfig.Sockets.topNeSocket = (ETileSocket) EditorGUILayout.EnumPopup("Top NE", tileRuleConfig.Sockets.topNeSocket);
            tileRuleConfig.Sockets.topSeSocket = (ETileSocket) EditorGUILayout.EnumPopup("Top SE", tileRuleConfig.Sockets.topSeSocket);
            tileRuleConfig.Sockets.topSwSocket = (ETileSocket) EditorGUILayout.EnumPopup("Top SW", tileRuleConfig.Sockets.topSwSocket);
            
            AddLabel("Bottom Sockets:");
            tileRuleConfig.Sockets.bottomNwSocket = (ETileSocket) EditorGUILayout.EnumPopup("Bottom NW", tileRuleConfig.Sockets.bottomNwSocket);
            tileRuleConfig.Sockets.bottomNeSocket = (ETileSocket) EditorGUILayout.EnumPopup("Bottom NE", tileRuleConfig.Sockets.bottomNeSocket);
            tileRuleConfig.Sockets.bottomSeSocket = (ETileSocket) EditorGUILayout.EnumPopup("Bottom SE", tileRuleConfig.Sockets.bottomSeSocket);
            tileRuleConfig.Sockets.bottomSwSocket = (ETileSocket) EditorGUILayout.EnumPopup("Bottom SW", tileRuleConfig.Sockets.bottomSwSocket);
        }
    }
}