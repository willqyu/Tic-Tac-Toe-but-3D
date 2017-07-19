using UnityEngine;
using System.Collections;

public class PlaceableController : MonoBehaviour {

    public Material active;
    public Material unactive;
    public int identification;
    public int stack;

    private Vector3[] directions = new Vector3[26];
    public bool isClicked;

	// Use this for initialization
	void Start () {
        
    }
    

    // Update is called once per frame
    void OnMouseExit () {
        GetComponent<Renderer>().material = unactive;
	}

    void OnMouseOver()
    {
        GetComponent<Renderer>().material = active;
        
    }
    
    
    
}
