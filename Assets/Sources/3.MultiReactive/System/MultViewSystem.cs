using Entitas;
using Entitas.Unity;
using MultiReactive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    public class MultViewSystem : MultiReactiveSystem<IViewSystem, Contexts>
    {
        private Dictionary<string, Transform> _parentDic;
        private Dictionary<string, IContext> _parentContext = new Dictionary<string, IContext>();

        public MultViewSystem(Contexts contexts) : base(contexts){
            _parentDic = new Dictionary<string, Transform>();
            foreach(var context in contexts.allContexts)
            {
                string name = context.contextInfo.name;
                _parentDic[name] = new GameObject(name + "ViewParent").transform;
                _parentContext[name] = context;
            }
        }

        protected override void Execute(List<IViewSystem> entities)
        {
            foreach (IViewSystem entity in entities)
            {
                string name = entity.contextInfo.name;
                var go = new GameObject(name + "View");
                go.transform.SetParent(_parentDic[name]);
                entity.AddMultiReactiveView(go.transform);
                go.Link(entity, _parentContext[name]);
            }
        }

        protected override bool Filter(IViewSystem entity)
        {
            return !entity.hasMultiReactiveView;
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[]{
                contexts.game.CreateCollector(GameMatcher.MultiReactiveView),
                contexts.input.CreateCollector(InputMatcher.MultiReactiveView),
                contexts.ui.CreateCollector(UiMatcher.MultiReactiveView)
            };
        }
    }

    public interface IViewSystem : IEntity, IMultiReactiveViewEntity{ }
}

public partial class GameEntity : IViewSystem { }
public partial class InputEntity : IViewSystem { }
public partial class UiEntity : IViewSystem { }

