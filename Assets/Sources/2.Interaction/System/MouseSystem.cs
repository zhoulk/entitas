using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSystem : IExecuteSystem, IInitializeSystem
{
    private InputContext _contexts;

    public MouseSystem(Contexts contexts)
    {
        _contexts = contexts.input;
    }

    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _contexts.ReplaceInterActionMouse(MouseButton.LEFT, MouseButtonEvent.DOWN);
        }
        if (Input.GetMouseButtonDown(1))
        {
            _contexts.ReplaceInterActionMouse(MouseButton.RIGHT, MouseButtonEvent.DOWN);
        }
    }

    public void Initialize()
    {
        //_inputEntity = _contexts.interActionMouseEntity;
    }
}
