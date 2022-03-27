using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpawner : MonoBehaviour
{
    public GameObject[] Chunk1Prefab;

    public Vector3 ChunkSize = new Vector3(1,1,0);

    private void Start()
    {
        WorldGenerator generator = new WorldGenerator();
        WorldGeneratorChunk[,] world = generator.GenerateWorld();

        for (int x = -250; x < world.GetLength(0); x++)
            {
                for (int y = -250; y < world.GetLength(1); y++)
                    {
                        Instantiate(Chunk1Prefab[UnityEngine.Random.Range(0, 4)], new Vector3(x * ChunkSize.x, y * ChunkSize.y, y * ChunkSize.z), Quaternion.identity);
                    }
            }
    }
}
