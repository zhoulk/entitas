using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class GameBoardSystem : IInitializeSystem
    {
        public GameBoardSystem(Contexts context)
        {
            //_itemsGroup = context.game.GetGroup(GameMatcher.GameGameBoardItem);
        }

        public void Initialize()
        {
            var gameBoard = CreaterService.Instance.CreateGameBoard().gameGameBoard;

            for (int row = 0; row < gameBoard.rows; row++)
            {
                for (int index = 0; index < gameBoard.columns; index++)
                {
                    CreaterService.Instance.CreateBall(1, index, row);
                }
            }
        }
    }
}

