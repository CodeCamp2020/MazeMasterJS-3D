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