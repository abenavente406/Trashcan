using UnityEngine;
using System.Collections;

public class MoveSquare : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position.Set(this.transform.position.x + 10, 
			this.transform.position.y, this.transform.position.z);
	}
}
