using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour {
    public Rigidbody rocketRigidbody;
    [SerializeField] public float Forceupward = 2000;
    // Use this for initialization
    void Start () {
		rocketRigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") > 0)
        {
            rocketRigidbody.AddForce(new Vector3(0, Forceupward, 0));
        }
        else if (Input.GetAxis("Jump") < 0)
        {
            rocketRigidbody.AddForce(new Vector3(0, 0, 0));
        }
    }
}
