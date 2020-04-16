using UnityEngine;

namespace Game
{
    public class Services
    {
        public Services(Contexts contexts, Transform gameController)
        {
            LoadPrefabService.Instance.Init(contexts, gameController);
            CreaterService.Instance.Init(contexts);
            //GetEmptyItemService.Instance.Init(contexts);
        }
    }
}
