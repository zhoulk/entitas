using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Contexts.sharedInstance.game.CreateEntity().isMultiReactiveDestroy = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Contexts.sharedInstance.input.CreateEntity().isMultiReactiveDestroy = true;
        }
    }
}
