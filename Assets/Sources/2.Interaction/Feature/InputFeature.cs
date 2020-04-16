using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFeature : Feature {

	public InputFeature(Contexts contexts)
    {
        Add(new CreateSystem(contexts));
        Add(new MouseSystem(contexts));
        Add(new StartMoveSystem(contexts));
    }
}

