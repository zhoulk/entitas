using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderSpriteSystem : ReactiveSystem<GameEntity>
{
    public RenderSpriteSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(GameEntity entity in entities)
        {
            Transform trans = entity.interActionView.viewTrans;
            SpriteRenderer sr = trans.GetComponent<SpriteRenderer>();
            if (sr == null) sr = trans.gameObject.AddComponent<SpriteRenderer>();
            sr.sprite = Resources.Load<Sprite>(entity.interActionSprite.spriteName);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasInterActionSprite && entity.hasInterActionView;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.InterActionSprite);
    }
}
