using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    private Systems _system;

	// Use this for initialization
	void Start () {
        var context = Contexts.sharedInstance;
        _system = new Feature("Systems").Add(new AddGameSystems(context));
        _system.Initialize();
	}
	
	// Update is called once per frame
	void Update () {
        _system.Execute();
        _system.Cleanup();
	}
}
