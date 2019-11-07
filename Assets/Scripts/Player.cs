using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float walkSpeed = .1f;
    public float runSpeed = .2f;

    public Quaternion facing = new Quaternion(0f, 0f, 0f, 0f);
    public Vector3 location = new Vector3(0f, 0.5f, 7f);

    // Start is called before the first frame update
    void Start()
    {
        transform.SetPositionAndRotation(new Vector3(0f, 0.5f, 7f), facing);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(new Vector3(0f, 0f, walkSpeed), Space.Self);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(new Vector3(0f, 0f, 0 - walkSpeed), Space.Self);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(new Vector3(walkSpeed, 0f, 0f), Space.Self);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(new Vector3(0 - walkSpeed, 0f, 0f), Space.Self);
        }

    }
}

/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public Vector3 speed = new Vector3(0f, 0f, 0f);
    public Vector3 rotDir = new Vector3(0f, 0f, 0f);
    public Vector3 rotSpeed = new Vector3(0f, 0f, 0f);s

    public float engineThrust = 0.25f;
    public float monoThrust = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)) {
            speed.z = speed.z + engineThrust;
        }

        if (Input.GetKey(KeyCode.S)) {
            speed.z = speed.z - engineThrust;
        }

        if (Input.GetKey(KeyCode.A)) {
            speed.x = speed.x - monoThrust;
        }

        if (Input.GetKey(KeyCode.D)) {
            speed.x = speed.x + monoThrust;
        }

        if (Input.GetKey(KeyCode.Q)) {
            rotDir.z = rotDir.z + monoThrust;
        }

        if (Input.GetKey(KeyCode.E)) {
            rotDir.z = rotDir.z - monoThrust;
        }

        if (Input.GetKey(KeyCode.Space)) {
            speed = new Vector3(0f, 0f, 0f);
            rotDir = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.R)) {
            transform.SetPositionAndRotation(new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f));
            transform.Translate(0f, 0f, 0f);
        }

        moveShip();
	}

    private void moveShip() {
        if (speed.x != 0 || speed.y != 0 || speed.z != 0) { 
            transform.Translate(speed, Space.World);
        }

        if (rotDir.z != 0) {
            transform.Rotate(rotDir, Space.World);
        }
    }
   
}

*/