using DG.Tweening;
using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMoveSystem : ReactiveSystem<InputEntity>
{
    private GameContext _gameContext;
    private IGroup<GameEntity> _moveGroup;

    public StartMoveSystem(Contexts contexts) : base(contexts.input)
    {
        _gameContext = contexts.game;
        _moveGroup = contexts.game.GetGroup(GameMatcher.InterActionView);
    }

    protected override void Execute(List<InputEntity> entities)
    {
        foreach(InputEntity entity in entities)
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            foreach (GameEntity gameEntity in _moveGroup)
            {
                gameEntity.ReplaceInterActionMove(worldPos);
            }
        }
    }

    protected override bool Filter(InputEntity entity)
    {
        return entity.hasInterActionMouse
            && entity.interActionMouse.mouse == MouseButton.RIGHT
            && entity.interActionMouse.MouseEvent == MouseButtonEvent.DOWN;
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.InterActionMouse);
    }
}
