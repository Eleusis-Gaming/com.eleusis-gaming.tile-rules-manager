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
                    sockets.topSwSocket, sockets.topNwSocket, sockets.topNeSocket, sockets.topSeSocket,
                    sockets.bottomSwSocket, sockets.bottomNwSocket, sockets.bottomNeSocket, sockets.bottomSeSocket
                }),
                ETileRotation.Degree180 => new TileSockets(new[]
                {
                    sockets.topSeSocket, sockets.topSwSocket, sockets.topNwSocket, sockets.topNeSocket,
                    sockets.bottomSeSocket, sockets.bottomSwSocket, sockets.bottomNwSocket, sockets.bottomNeSocket
                }),
                ETileRotation.Degree270 => new TileSockets(new[]
                {
                    sockets.topNeSocket, sockets.topSeSocket, sockets.topSwSocket, sockets.topNwSocket,
                    sockets.bottomNeSocket, sockets.bottomSeSocket, sockets.bottomSwSocket, sockets.bottomNwSocket
                }),
                _ => throw new ArgumentOutOfRangeException(nameof(rotation), rotation, null)
            };
        }
    }
}