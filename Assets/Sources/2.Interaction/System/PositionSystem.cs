using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSystem : ReactiveSystem<GameEntity>
{
    public PositionSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity entity in entities)
        {
            entity.interActionView.viewTrans.position = entity.interActionPosition.postion;
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasInterActionPosition && entity.hasInterActionView;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.InterActionPosition);
    }
}
