using Entitas;
using Entitas.CodeGeneration.Attributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterAction
{
    [Input, Unique]
    public class MouseComponent : IComponent
    {
        /// <summary>
        /// 点击的鼠标类型
        /// </summary>
        public MouseButton mouse;

        /// <summary>
        /// 鼠标事件
        /// </summary>
        public MouseButtonEvent MouseEvent;
    }
}

