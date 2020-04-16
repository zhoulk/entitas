using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class GameController : MonoBehaviour
    {
        private Systems _systems;

        private void Awake()
        {
            var contexts = Contexts.sharedInstance;
            _systems = GetSystems(contexts);
            new Services(contexts, transform);
        }

        // Use this for initialization
        void Start()
        {
            _systems.Initialize();
        }

        // Update is called once per frame
        void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private Systems GetSystems(Contexts contexts)
        {
            return new GameFeature(contexts)
                .Add(new GameEventSystems(contexts));
        }
    }
}

