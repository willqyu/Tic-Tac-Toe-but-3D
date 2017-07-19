using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    
    
    public GameObject board;
    public GameObject cross;
    public GameObject ring;
    public GameObject generic;

    private GameObject toPlace;
    public GameObject[,] positions = new GameObject[4, 16];
    private float playerTurn = 1;
    private bool running = true;

	// Use this for initialization
	void Start () {
        makeBoard();
        
	}
	
	// Update is called once per frame
	void Update () {
	    if (running)
        {
            gamerun();
        }
	}

    void gamerun()
    {
        if (playerTurn == 1)
        {
            toPlace = cross;
        }
        else
        {
            toPlace = ring;
        }
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            if (hit.collider.tag == "Clickable position") {
                GameObject placed = Instantiate(toPlace);
                placed.transform.position = hit.collider.gameObject.transform.position;
                placed.GetComponent<UnitController>().identification = hit.collider.GetComponent<PlaceableController>().identification;
                positions[hit.collider.GetComponent<PlaceableController>().stack, placed.GetComponent<UnitController>().identification-1] = placed;
                Debug.Log("Quack");

                hit.collider.gameObject.SetActive(false);

                checkConnection();

                playerTurn *= -1;
            }

        }
        
    }

    void checkConnection()
    {
        //check for horizontal rows:
        for (int i = 0; i < 9; i++)
        {
            
        }

    }



    

    // Use this for initialization
    public void makeBoard()
    {
        Instantiate(board);
        board.transform.position = new Vector3(0, 0, 0);
        
    }

}
