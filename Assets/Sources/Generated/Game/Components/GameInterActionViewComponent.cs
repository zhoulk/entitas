//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public InterAction.ViewComponent interActionView { get { return (InterAction.ViewComponent)GetComponent(GameComponentsLookup.InterActionView); } }
    public bool hasInterActionView { get { return HasComponent(GameComponentsLookup.InterActionView); } }

    public void AddInterActionView(UnityEngine.Transform newViewTrans) {
        var index = GameComponentsLookup.InterActionView;
        var component = (InterAction.ViewComponent)CreateComponent(index, typeof(InterAction.ViewComponent));
        component.viewTrans = newViewTrans;
        AddComponent(index, component);
    }

    public void ReplaceInterActionView(UnityEngine.Transform newViewTrans) {
        var index = GameComponentsLookup.InterActionView;
        var component = (InterAction.ViewComponent)CreateComponent(index, typeof(InterAction.ViewComponent));
        component.viewTrans = newViewTrans;
        ReplaceComponent(index, component);
    }

    public void RemoveInterActionView() {
        RemoveComponent(GameComponentsLookup.InterActionView);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherInterActionView;

    public static Entitas.IMatcher<GameEntity> InterActionView {
        get {
            if (_matcherInterActionView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InterActionView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInterActionView = matcher;
            }

            return _matcherInterActionView;
        }
    }
}