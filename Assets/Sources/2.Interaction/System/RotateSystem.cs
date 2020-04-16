using DG.Tweening;
using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSystem : ReactiveSystem<GameEntity>
{
    public RotateSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity entity in entities)
        {
            float angle = entity.interActionDirection.direction;
            Debug.Log(angle);
            entity.interActionView.viewTrans.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasInterActionDirection 
            && entity.hasInterActionView
            && entity.isInterActionMoveComplete;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.InterActionDirection);
    }
}
