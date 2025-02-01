using Editor.Enums;

namespace Editor.Scripts
{
    [System.Serializable]
    public class TileSockets
    {
        // Top four sockets on the tile
        public ETileSocket topNwSocket;
        public ETileSocket topNeSocket;
        public ETileSocket topSeSocket;
        public ETileSocket topSwSocket;
        
        // Bottom four sockets on the tile
        public ETileSocket bottomNwSocket;
        public ETileSocket bottomNeSocket;
        public ETileSocket bottomSeSocket;
        public ETileSocket bottomSwSocket;

        public TileSockets(ETileSocket[] sockets)
        {
            topNwSocket = sockets[0];
            topNeSocket = sockets[1];
            topSeSocket = sockets[2];
            topSwSocket = sockets[3];
            bottomNwSocket = sockets[4];
            bottomNeSocket = sockets[5];
            bottomSeSocket = sockets[6];
            bottomSwSocket = sockets[7];
        }
    }
}