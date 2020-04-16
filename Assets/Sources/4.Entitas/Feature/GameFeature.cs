using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class GameFeature : Feature
    {
        public GameFeature(Contexts contexts)
        {
            Add(new GameBoardSystem(contexts));
        }
    }
}

