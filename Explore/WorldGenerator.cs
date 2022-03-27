using System;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneratorChunk
    {
        public int X;
        public int Y;
    }

public class WorldGenerator
    {
        public int Width = 500;
        public int Height = 500;

        public WorldGeneratorChunk[,] GenerateWorld()
            {
                WorldGeneratorChunk[,] world = new WorldGeneratorChunk[Width, Height];
                
                for (int x = 0; x < world.GetLength(0); x++)
                    {
                        for (int y = 0; y < world.GetLength(1); y++)
                            {
                                world[x, y] = new WorldGeneratorChunk {X = x, Y = y};
                            }
                    }

                return world;
            }
    }
