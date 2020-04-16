using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeature : Feature {

	public GameFeature(Contexts contexts)
    {
        Add(new AddViewSystem(contexts));
        Add(new RenderSpriteSystem(contexts));
        Add(new PositionSystem(contexts));
        Add(new MoveSystem(contexts));
        Add(new DirectionSystem(contexts));
        Add(new RotateSystem(contexts));
    }
}
