using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeature : Feature {

	public GameFeature(Contexts contexts)
    {
        Add(new AddViewSystem(contexts));
        Add(new RenderSpriteSystem(contexts));
    }
}
