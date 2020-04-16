using DG.Tweening;
using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionSystem : ReactiveSystem<GameEntity>
{
    private GameContext _gameContext;
    private IGroup<GameEntity> _moveGroup;

    public DirectionSystem(Contexts contexts) : base(contexts.game)
    {
        _gameContext = contexts.game;
        _moveGroup = contexts.game.GetGroup(GameMatcher.InterActionView);
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity entity in entities)
        {
            Transform view = entity.interActionView.viewTrans;
            Vector3 targetPos = entity.interActionMove.targetPos;
            Vector3 direct = (targetPos - view.position).normalized;

            //Quaternion angleOffset = Quaternion.FromToRotation(view.up, direct);
            //view.rotation *= angleOffset;

            float angle = Mathf.Atan2(direct.y, direct.x) * Mathf.Rad2Deg;
            entity.ReplaceInterActionDirection(angle);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasInterActionMove
            && entity.hasInterActionView
            && entity.isInterActionMoveComplete;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.InterActionMove);
    }
}
