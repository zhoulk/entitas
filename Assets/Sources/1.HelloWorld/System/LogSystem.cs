using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class LogSystem : ReactiveSystem<GameEntity> {

    public LogSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasLog;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Log);
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            Debug.Log(entity.log.message);
        }
    }
}
