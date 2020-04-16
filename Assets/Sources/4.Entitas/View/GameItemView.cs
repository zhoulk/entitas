using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Entitas;
using UnityEngine;

namespace Game
{
    public class GameItemView : View, IGameItemIndexListener
    {
        public override void Link(IEntity entity, IContext context)
        {
            base.Link(entity, context);
            _gameEntity.AddGameItemIndexListener(this);
            //_gameEntity.AddGameLoadSpriteListener(this);
            transform.position = new Vector3(_gameEntity.gameItemIndex.index.x, Contexts.sharedInstance.game.gameGameBoard.rows);
        }

        public void OnGameItemIndex(GameEntity entity, CustomVector2 index)
        {
            transform.DOMove(new Vector3(index.x, index.y, 0), 0.3f); //.OnComplete(() => _gameEntity.isGameMoveComplete = true);
        }
    }
}

