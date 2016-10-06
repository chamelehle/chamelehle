using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var horiz = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var vert = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, horiz, 0);
        transform.Translate(0, 0, vert);

	}
}
