using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGameSystems : Feature {

	public AddGameSystems(Contexts contexts) : base("AddGameSystems")
    {
        Add(new LogSystem(contexts));
        Add(new InitSystem(contexts));
    }
}
