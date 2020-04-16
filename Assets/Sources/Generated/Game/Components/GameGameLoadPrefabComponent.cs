//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.LoadPrefabComponent gameLoadPrefab { get { return (Game.LoadPrefabComponent)GetComponent(GameComponentsLookup.GameLoadPrefab); } }
    public bool hasGameLoadPrefab { get { return HasComponent(GameComponentsLookup.GameLoadPrefab); } }

    public void AddGameLoadPrefab(string newPath) {
        var index = GameComponentsLookup.GameLoadPrefab;
        var component = (Game.LoadPrefabComponent)CreateComponent(index, typeof(Game.LoadPrefabComponent));
        component.path = newPath;
        AddComponent(index, component);
    }

    public void ReplaceGameLoadPrefab(string newPath) {
        var index = GameComponentsLookup.GameLoadPrefab;
        var component = (Game.LoadPrefabComponent)CreateComponent(index, typeof(Game.LoadPrefabComponent));
        component.path = newPath;
        ReplaceComponent(index, component);
    }

    public void RemoveGameLoadPrefab() {
        RemoveComponent(GameComponentsLookup.GameLoadPrefab);
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

    static Entitas.IMatcher<GameEntity> _matcherGameLoadPrefab;

    public static Entitas.IMatcher<GameEntity> GameLoadPrefab {
        get {
            if (_matcherGameLoadPrefab == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameLoadPrefab);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameLoadPrefab = matcher;
            }

            return _matcherGameLoadPrefab;
        }
    }
}