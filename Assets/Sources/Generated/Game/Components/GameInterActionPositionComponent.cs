//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public InterAction.PositionComponent interActionPosition { get { return (InterAction.PositionComponent)GetComponent(GameComponentsLookup.InterActionPosition); } }
    public bool hasInterActionPosition { get { return HasComponent(GameComponentsLookup.InterActionPosition); } }

    public void AddInterActionPosition(UnityEngine.Vector2 newPostion) {
        var index = GameComponentsLookup.InterActionPosition;
        var component = (InterAction.PositionComponent)CreateComponent(index, typeof(InterAction.PositionComponent));
        component.postion = newPostion;
        AddComponent(index, component);
    }

    public void ReplaceInterActionPosition(UnityEngine.Vector2 newPostion) {
        var index = GameComponentsLookup.InterActionPosition;
        var component = (InterAction.PositionComponent)CreateComponent(index, typeof(InterAction.PositionComponent));
        component.postion = newPostion;
        ReplaceComponent(index, component);
    }

    public void RemoveInterActionPosition() {
        RemoveComponent(GameComponentsLookup.InterActionPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherInterActionPosition;

    public static Entitas.IMatcher<GameEntity> InterActionPosition {
        get {
            if (_matcherInterActionPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InterActionPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInterActionPosition = matcher;
            }

            return _matcherInterActionPosition;
        }
    }
}
