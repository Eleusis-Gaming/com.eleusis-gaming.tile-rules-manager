using System;
using Editor.Enums;

namespace Editor.Scripts
{
    public static class TileRuleSocketRotator
    {
        public static TileSockets SetSocketsBasedOnRotation(ETileRotation rotation, TileSockets sockets)
        {
            return rotation switch
            {
                ETileRotation.Degree0 => sockets,
                ETileRotation.Degree90 => new TileSockets(new[]
                {
                    sockets.topWSocket, 
                    sockets.topNSocket, 
                    sockets.topESocket, 
                    sockets.topSSocket
                }, new[]
                {
                    sockets.topSwSocket, 
                    sockets.topNwSocket, 
                    sockets.topNeSocket, 
                    sockets.topSeSocket
                }),
                ETileRotation.Degree180 => new TileSockets(new[]
                {
                    sockets.topSSocket,
                    sockets.topWSocket,
                    sockets.topNSocket,
                    sockets.topESocket,

                }, new[]
                {
                    sockets.topSeSocket, 
                    sockets.topSwSocket, 
                    sockets.topNwSocket, 
                    sockets.topNeSocket,
                }),
                ETileRotation.Degree270 => new TileSockets(new[]
                {
                    sockets.topESocket,
                    sockets.topSSocket,
                    sockets.topWSocket,
                    sockets.topNSocket,

                }, new[]
                {
                    sockets.topNeSocket, 
                    sockets.topSeSocket, 
                    sockets.topSwSocket, 
                    sockets.topNwSocket,
                }),
                _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
            };
        }
    }
}