//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity gameGameBoardEntity { get { return GetGroup(GameMatcher.GameGameBoard).GetSingleEntity(); } }
    public Game.GameBoardComponent gameGameBoard { get { return gameGameBoardEntity.gameGameBoard; } }
    public bool hasGameGameBoard { get { return gameGameBoardEntity != null; } }

    public GameEntity SetGameGameBoard(int newColumns, int newRows) {
        if (hasGameGameBoard) {
            throw new Entitas.EntitasException("Could not set GameGameBoard!\n" + this + " already has an entity with Game.GameBoardComponent!",
                "You should check if the context already has a gameGameBoardEntity before setting it or use context.ReplaceGameGameBoard().");
        }
        var entity = CreateEntity();
        entity.AddGameGameBoard(newColumns, newRows);
        return entity;
    }

    public void ReplaceGameGameBoard(int newColumns, int newRows) {
        var entity = gameGameBoardEntity;
        if (entity == null) {
            entity = SetGameGameBoard(newColumns, newRows);
        } else {
            entity.ReplaceGameGameBoard(newColumns, newRows);
        }
    }

    public void RemoveGameGameBoard() {
        gameGameBoardEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.GameBoardComponent gameGameBoard { get { return (Game.GameBoardComponent)GetComponent(GameComponentsLookup.GameGameBoard); } }
    public bool hasGameGameBoard { get { return HasComponent(GameComponentsLookup.GameGameBoard); } }

    public void AddGameGameBoard(int newColumns, int newRows) {
        var index = GameComponentsLookup.GameGameBoard;
        var component = (Game.GameBoardComponent)CreateComponent(index, typeof(Game.GameBoardComponent));
        component.columns = newColumns;
        component.rows = newRows;
        AddComponent(index, component);
    }

    public void ReplaceGameGameBoard(int newColumns, int newRows) {
        var index = GameComponentsLookup.GameGameBoard;
        var component = (Game.GameBoardComponent)CreateComponent(index, typeof(Game.GameBoardComponent));
        component.columns = newColumns;
        component.rows = newRows;
        ReplaceComponent(index, component);
    }

    public void RemoveGameGameBoard() {
        RemoveComponent(GameComponentsLookup.GameGameBoard);
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

    static Entitas.IMatcher<GameEntity> _matcherGameGameBoard;

    public static Entitas.IMatcher<GameEntity> GameGameBoard {
        get {
            if (_matcherGameGameBoard == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameGameBoard);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameGameBoard = matcher;
            }

            return _matcherGameGameBoard;
        }
    }
}
