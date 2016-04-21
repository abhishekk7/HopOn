using UnityEngine;
using System.Collections;

public class Bot : MonoBehaviour {

    public float speed;
    private Vector3 dir;

	// Use this for initialization
	void Start () {
        dir = Vector3.zero;//To maintain bot stationary during start of game
	}
	
	// Update is called once per frame
	void Update () {

        //To change bot direction based on keypress
        if (Input.GetKey(KeyCode.LeftArrow))
            dir = Vector3.back;
        else if (Input.GetKey(KeyCode.RightArrow))
            dir = Vector3.forward;

        //To actually move bot
        //Delta time is used to make the bot move identical in all devices. Frequency of update method call varies across devices
        //Update call rate based on fps of device
        float amountToMove = speed * Time.deltaTime;
        transform.Translate(dir * amountToMove);

        //dir = Vector3.up;
        //transform.Translate(dir * amountToMove);

        dir = Vector3.left;
        transform.Translate(dir * amountToMove);
        
        //dir = Vector3.down;
        //transform.Translate(dir * amountToMove);
	}
}
