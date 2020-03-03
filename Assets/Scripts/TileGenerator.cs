using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TileGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject tile;

    [SerializeField]
    int spacing;
 
    [SerializeField]
    protected int width = 5;
 
    [SerializeField]
    protected int height = 5;
 
    // Start is called before the first frame update
    void Start()
    {
        /*float offsetX = width / 2f - 0.5f;
        float offsetY = height / 2f - 0.5f;*/
 
        Vector3 offset = new Vector3(
            width / 2f - 0.5f,
            0,
            height / 2f - 0.5f
            );
 
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                PlaceTile(offset, x, z);
            }
        }
    }
 
    protected virtual void PlaceTile(GameObject tile, Vector3 offset, int x, int z)
    {
        GameObject newTile = Instantiate(tile,
            new Vector3(x * spacing, transform.position.y, z * spacing) - offset,
            Quaternion.identity);
 
        newTile.name = "(" + x + "," + z + ")";
 
        newTile.transform.parent = this.transform;
    }
 
    protected virtual void PlaceTile(Vector3 offset, int x, int z)
    {
        PlaceTile(tile, offset, x, z);
    }
 
}