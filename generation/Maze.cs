using UnityEngine;

public class Maze
{
    public MazeGeneratorCell[,] cells;
    public Vector2Int finishPosition;
}

public class MazeGeneratorCell
{
    public int X;
    public int Y;

    public bool WallLeft = true;
    public bool WallBottom = true;
    public bool floor = true;
    public bool cubeExitB = true;
    public bool cubeExitL = true;
    public bool Coin = true;

    public bool Visited = false;
    public int DistanceFromStart;
}
