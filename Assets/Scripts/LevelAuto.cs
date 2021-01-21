using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class LevelAuto : MonoBehaviour
{
    public int width = 10;
    public int  height = 10;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject wall;

    public bool playerSpawn = false;

    private void Start()
    {
        generateWall();
    }
    void generateWall()
    {
        for(int x = 0; x<width;x++)
        {
            for(int y =0;y<height;y++)
            {
                if (Random.value > .7f)
                {
                    // Spawn a wall
                    Vector3 pos = new Vector3(x - width / 3f, 1f, y - height / 2f);
                    Instantiate(wall, pos, Quaternion.identity, transform);
                }
                else if (!playerSpawn) // Should we spawn a player?
                {
                    // Spawn the player
                    Vector3 pos = new Vector3(x - width / 3f, 1.25f, y - height / 3f);
                    Instantiate(player, pos, Quaternion.identity);
                    playerSpawn = true;
                }

            }
        }
    }
}
