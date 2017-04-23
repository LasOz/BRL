using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    public string destination;
	// Use this for initialization
	
	// Update is called once per frame
	public void LoadLevel () {
        Application.LoadLevel(destination);
    }
}
