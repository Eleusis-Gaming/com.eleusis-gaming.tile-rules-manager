using System;
using Editor.Enums;
using UnityEditor;
using UnityEngine;
using static Editor.Scripts.Labels;

namespace Editor.Scripts
{
    public static class TileRuleSockets
    {
        public static void TileRuleSocketsSection(TileSockets sockets)
        {
            AddLabel("Tile Rule Grid:");
            DrawGrid(sockets);
        }
        
        private static void DrawGrid(TileSockets sockets)
        {
            const int gridSize = 3;
            const float buttonSize = 65f;
            
            for (var y = 0; y < gridSize; y++)
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                for (var x = 0; x < gridSize; x++)
                {
                    Color currentColor;
                    var currentCornerSocket = ETileCornerSocket.None;
                    var currentSideSocket = ETileSideSocket.None;
                    
                    var index = y * gridSize + x;
                    var isCornerSocket = (index % 2).Equals(0);
                    if (isCornerSocket)
                    {
                        currentCornerSocket = GetCornerSocket(sockets, index);
                        currentColor = SocketCornerColors(currentCornerSocket);
                    }
                    else
                    {
                        currentSideSocket = GetSideSocket(sockets, index);
                        currentColor = SocketSideColors(currentSideSocket);
                    }
                    GUI.backgroundColor = currentColor;

                    if (isCornerSocket)
                    {
                        if (GUILayout.Button(Enum.GetName(typeof(ETileCornerSocket), currentCornerSocket), GUILayout.Width(buttonSize), GUILayout.Height(buttonSize)))
                        {
                            var currentCornerSocketValue = (ETileCornerSocket)(((int)currentCornerSocket + 1) % (System.Enum.GetValues(typeof(ETileCornerSocket)).Length - 1));
                            SetSocket(sockets, index, ETileSideSocket.None, currentCornerSocketValue);
                        }
                    }
                    else
                    {
                        if (GUILayout.Button(Enum.GetName(typeof(ETileSideSocket), currentSideSocket), GUILayout.Width(buttonSize), GUILayout.Height(buttonSize)))
                        {

                            var currentSideSocketValue = (ETileSideSocket)(((int)currentSideSocket + 1) % (System.Enum.GetValues(typeof(ETileSideSocket)).Length -1));
                            SetSocket(sockets, index, currentSideSocketValue, ETileCornerSocket.None);
                        }
                    }
                    GUI.backgroundColor = Color.white;
                }
                GUILayout.FlexibleSpace(); 
                EditorGUILayout.EndHorizontal();
            }
        }
        
        private static Color SocketSideColors(ETileSideSocket socket)
        {
            return socket switch
            {
                ETileSideSocket.Open => Color.green,
                ETileSideSocket.Closed => Color.red,
                _ => Color.black
            };
        }
        
        private static Color SocketCornerColors(ETileCornerSocket socket)
        {
            return socket switch
            {
                ETileCornerSocket.Inner => Color.green,
                ETileCornerSocket.Outer => Color.yellow,
                ETileCornerSocket.Closed => Color.red,
                _ => Color.black
            };
        }

        private static ETileSideSocket GetSideSocket(TileSockets sockets, int index)
        {
            return index switch
            {
                1 => sockets.topNSocket,
                3 => sockets.topWSocket,
                5 => sockets.topESocket,
                7 => sockets.topSSocket,
                _ => ETileSideSocket.None
            };
        }
        
        private static ETileCornerSocket GetCornerSocket(TileSockets sockets, int index)
        {
            return index switch
            {
                0 => sockets.topNwSocket,
                2 => sockets.topNeSocket,
                6 => sockets.topSwSocket,
                8 => sockets.topSeSocket,
                _ => ETileCornerSocket.None
            };
        }

        private static void SetSocket(TileSockets sockets, int index, ETileSideSocket sideSocket, ETileCornerSocket cornerSocket)
        {
            switch (index)
            {
                case 0:
                    sockets.topNwSocket = cornerSocket;
                    break;
                case 1:
                    sockets.topNSocket = sideSocket;
                    break;
                case 2:
                    sockets.topNeSocket = cornerSocket;
                    break;
                case 3:
                    sockets.topWSocket = sideSocket;
                    break;
                case 4:
                    break;
                case 5:
                    sockets.topESocket = sideSocket;
                    break;
                case 6:
                    sockets.topSwSocket = cornerSocket;
                    break;
                case 7:
                    sockets.topSSocket = sideSocket;
                    break;
                case 8:
                    sockets.topSeSocket = cornerSocket;
                    break;
            }
        }
    }
}