using System;
using Editor.Enums;
using UnityEngine;

namespace Editor.Scripts
{
    public class TileRuleConfiguration
    {
        private static readonly ETileSocket[] DefaultSockets = new ETileSocket[8];
        public bool IsExpanded = true;
        public string Name;
        public ETileType Type;
        public ETileType[] AllowedNeighborTypes;
        public GameObject Prefab;
        public readonly TileSockets Sockets = new(DefaultSockets);
        public int Variants;
        public string[] Ids = Array.Empty<string>();
        public ETileRotation[] Rotations = Array.Empty<ETileRotation>();
    }
}