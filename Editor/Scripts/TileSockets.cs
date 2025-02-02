using Editor.Enums;

namespace Editor.Scripts
{
    [System.Serializable]
    public class TileSockets
    {
        // Top four side sockets on the tile
        public ETileSideSocket topNSocket;
        public ETileSideSocket topESocket;
        public ETileSideSocket topSSocket;
        public ETileSideSocket topWSocket;
        
        // Top four corner sockets on the tile
        public ETileCornerSocket topNwSocket;
        public ETileCornerSocket topNeSocket;
        public ETileCornerSocket topSeSocket;
        public ETileCornerSocket topSwSocket;

        // Top four corner sockets on the tile
        public ETileCornerSocket bottomNwSocket;
        public ETileCornerSocket bottomNeSocket;
        public ETileCornerSocket bottomSeSocket;
        public ETileCornerSocket bottomSwSocket;
        
        public TileSockets(ETileSideSocket[] sideSockets, ETileCornerSocket[] cornerSockets)
        {
            topNSocket = sideSockets[0];
            topESocket = sideSockets[1];
            topSSocket = sideSockets[2];
            topWSocket = sideSockets[3];
            
            topNwSocket = cornerSockets[0];
            topNeSocket = cornerSockets[1];
            topSeSocket = cornerSockets[2];
            topSwSocket = cornerSockets[3];
            
            bottomNwSocket = ETileCornerSocket.Inner;
            bottomNeSocket = ETileCornerSocket.Inner;
            bottomSeSocket = ETileCornerSocket.Inner;
            bottomSwSocket = ETileCornerSocket.Inner;
        }
    }
}