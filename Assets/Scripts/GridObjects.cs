using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObjects : MonoBehaviour
{
    public GameObject prefab;
    public int gridSizeX = 5;
    public int gridSizeY = 5;
    public int amount = 1;
    public float spacing = 1f;
    public List<GameObject> allGrids;

    void Start()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Vector3 position = new Vector3(x * spacing, 0, y * spacing);
                GameObject grid = Instantiate(prefab, position, Quaternion.identity);
                grid.transform.parent = transform;
                allGrids.Add(grid);
            }
        }
    }
}
