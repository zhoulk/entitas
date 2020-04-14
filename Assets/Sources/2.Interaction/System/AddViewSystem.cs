using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddViewSystem : ReactiveSystem<GameEntity>
{
    private Transform _parent;
    private Contexts _context;

    public AddViewSystem(Contexts contexts) : base(contexts.game)
    {
        _parent = new GameObject("ViewParent").transform;
        _context = contexts;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity entity in entities)
        {
            GameObject go = new GameObject("View");
            go.transform.SetParent(_parent);
            go.Link(entity, _context.game);
            entity.AddInterActionView(go.transform);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return !entity.hasInterActionView && entity.hasInterActionSprite;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.InterActionSprite);
    }
}
