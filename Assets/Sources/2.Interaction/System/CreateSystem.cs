using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSystem : ReactiveSystem<InputEntity>
{
    private GameContext _gameContext;

    public CreateSystem(Contexts contexts) : base(contexts.input)
    {
        _gameContext = contexts.game;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        foreach(InputEntity entity in entities)
        {
            _gameContext.CreateEntity().AddInterActionSprite("Bullet");
        }
    }

    protected override bool Filter(InputEntity entity)
    {
        return entity.hasInterActionMouse 
            && entity.interActionMouse.mouse == MouseButton.LEFT
            && entity.interActionMouse.MouseEvent == MouseButtonEvent.DOWN;
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.InterActionMouse);
    }
}
