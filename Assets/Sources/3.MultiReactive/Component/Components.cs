using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    [Game, Input, Ui]
    public class DestroyComponent : IComponent
    {

    }

    [Game, Input, Ui]
    public class ViewComponent : IComponent
    {
        public Transform viewTrans;
    }

}

