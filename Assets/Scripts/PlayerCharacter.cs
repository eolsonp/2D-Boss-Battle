using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [SerializeField]
    private int lives = 3;

    [SerializeField]
    private string name = "Mario";

    [SerializeField]
    private float jumpHeight = 5, speed = 5;

    
    private bool isOnGround;
    
    private float horizontalInput;


	// Use this for initialization
	void Start () {
        Debug.Log("Hello");
	}
	
	// Update is called once per frame
	void Update () {

        GetInput();
        Move();
		
	}
    private void GetInput()
    {
       horizontalInput = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        rigidbody2dInstance.velocity = new Vector2(horizontalInput, 0);
    }
}
