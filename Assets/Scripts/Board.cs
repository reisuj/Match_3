using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private int m_width;
    [SerializeField]
    private int m_height;

    [SerializeField]
    private GameObject tilePrefab = null;

    Tile[,] m_allTiles;
    // Start is called before the first frame update
    void Start()
    {
        m_allTiles = new Tile[m_width, m_height];
        SetupTiles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupTiles()
    {
        for (int i = 0; i < m_width; i++)
        {
            for (int j = 0; j < m_height; j++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(i, j, 0), Quaternion.identity) as GameObject;

                tile.name = "Tile (" + i + "," + j + ")";

                m_allTiles[i, j] = tile.GetComponent<Tile>();

                tile.transform.parent = transform;
            }
        }
    }
}
