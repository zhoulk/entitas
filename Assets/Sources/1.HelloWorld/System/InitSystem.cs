using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSystem : IInitializeSystem {

    private GameContext _gameContext;

    public InitSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
        _gameContext.CreateEntity().AddLog("Hello World");
    }
}
