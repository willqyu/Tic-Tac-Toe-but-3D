using UnityEngine;
using System.Collections;

public class UnitController : MonoBehaviour {

    public float speed;
    public int identification;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime));
	}
}
