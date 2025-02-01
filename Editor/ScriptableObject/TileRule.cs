using Editor.Enums;
using Editor.Scripts;
using UnityEngine;

namespace Editor.ScriptableObject
{
    [CreateAssetMenu(fileName = "TileRule", menuName = "ScriptableObjects/TileRule", order = 1)]
    public class TileRule: UnityEngine.ScriptableObject
    {
        [Header("Tile ID")]
        public string id;
        
        [Header("Tile Type")]
        public ETileType type;
        
        [Header("Allowed Neighbor Tile Types")]
        public ETileType[] allowedNeighborTypes;
        
        [Header("Tile Prefab")]
        public GameObject prefab;
        
        [Header("Tile Sockets")]
        public TileSockets sockets;
        
        [Header("Tile Rotation")]
        public ETileRotation rotation;
    }
}