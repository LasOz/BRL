using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour {
    public float RotationSpeed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //RotationSpeed = RotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, RotationSpeed);
	}
}
