using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

    public GameObject placeable;
    public float dist;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;
    private List<Transform> stacks = new List<Transform>();

    // Use this for initialization
    void Start () {
        foreach (Transform child in transform) {
            stacks.Add(child);
        }

        loadBoard();
	}
	
	// Update is called once per frame
	void Update () {
        move();
	}
    
    void loadBoard()
    {
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                for (int z = 0; z < 4; z++)
                {
                    GameObject tile = Instantiate(placeable);
                    tile.transform.SetParent(stacks[x]);
                    tile.transform.position = new Vector3(x * 5 - 2.5f, y * 5 - 2.5f, z * 5 - 7.5f);
                }
            }
        }
    }

    void move()
    {
        int counter = 0;
        for (int i = -3; i <= 3; i += 2)
        {
            stacks[counter].transform.position = new Vector3(i * dist, 0, 0) + stacks[counter].transform.position;
        }
    }
}
