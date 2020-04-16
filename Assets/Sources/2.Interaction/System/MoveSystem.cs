using DG.Tweening;
using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : ReactiveSystem<GameEntity>
{
    public MoveSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity entity in entities)
        {
            entity.interActionView.viewTrans.DOMove(entity.interActionMove.targetPos, 3);
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
