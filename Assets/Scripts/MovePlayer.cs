using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	private float speed = 2.5f; // player speed
	public GameObject kunai;
	public GameObject kunaiPoint;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // loop that keeps reading events
        // it reads the keyboard inputs
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0)); // move to the right
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0)); // move left
        } else if (Input.GetKeyDown(KeyCode.Space)) {
        	// instantiate kunais at the kunaiPoint coords
        	// rotation is to follow the point coords anyway
        	Instantiate(
	            kunai,
	            new Vector3(
	                kunaiPoint.transform.position.x,
	                kunaiPoint.transform.position.y,
	                kunaiPoint.transform.position.y
	            ),
	            kunaiPoint.transform.rotation
            );
        }
        
        
    }
}
