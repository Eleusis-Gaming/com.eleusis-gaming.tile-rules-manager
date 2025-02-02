using System;
using Editor.Enums;
using UnityEngine;

namespace Editor.Scripts
{
    public class TileRuleConfiguration
    {
        public string Name;
        public ETileType Type;
        public GameObject Prefab;
        public ETileType[] AllowedNeighborTypes;
        
        public bool IsExpanded = true;
        
        private static readonly ETileSideSocket[] DefaultSideSockets = new ETileSideSocket[4];
        private static readonly ETileCornerSocket[] DefaultCornerSockets = new ETileCornerSocket[4];
        public readonly TileSockets Sockets = new(DefaultSideSockets, DefaultCornerSockets);
        
        public int Variants;
        public string[] Ids = Array.Empty<string>();
        public ETileRotation[] Rotations = Array.Empty<ETileRotation>();
    }
}