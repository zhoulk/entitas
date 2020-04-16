using Entitas;
using MultiReactive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    public class MultDestroySystem : MultiReactiveSystem<IDestroySystem, Contexts>
    {
        public MultDestroySystem(Contexts contexts) : base(contexts){

        }

        protected override void Execute(List<IDestroySystem> entities)
        {
            foreach(IDestroySystem entity in entities)
            {
                if (entity.hasMultiReactiveView)
                {
                    GameObject.Destroy(entity.multiReactiveView.viewTrans.gameObject);
                }
                Debug.Log("destroy at " + entity.contextInfo.name);
            }
        }

        protected override bool Filter(IDestroySystem entity)
        {
            return entity.isMultiReactiveDestroy;
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[]{
                contexts.game.CreateCollector(GameMatcher.MultiReactiveDestroy),
                contexts.input.CreateCollector(InputMatcher.MultiReactiveDestroy),
                contexts.ui.CreateCollector(UiMatcher.MultiReactiveDestroy)
            };
        }
    }

    public interface IDestroySystem : IEntity, IMultiReactiveDestroyEntity, IMultiReactiveViewEntity{ }
}

public partial class GameEntity : IDestroySystem{ }
public partial class InputEntity : IDestroySystem { }
public partial class UiEntity : IDestroySystem { }

