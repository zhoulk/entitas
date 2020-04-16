using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Game
{
    [Game, Unique]
    public class GameBoardComponent : IComponent
    {
        /// <summary>
        /// 列
        /// </summary>
        public int columns;
        /// <summary>
        /// 行
        /// </summary>
        public int rows;
    }

    /// <summary>
    /// 游戏界面元素
    /// </summary>
    [Game]
    public class GameBoardItemComponent : IComponent
    {

    }

    /// <summary>
    /// 游戏元素消除组件
    /// </summary>
    [Game, Event(EventTarget.Self)]
    public class DestroyComponent : IComponent
    {

    }

    /// <summary>
    /// 游戏元素的坐标
    /// </summary>
    [Game, Event(EventTarget.Self, EventType.Added, 1)]
    public class ItemIndexComponent : IComponent
    {
        [EntityIndex]
        public CustomVector2 index;
    }

    /// <summary>
    /// 加载预制体组件
    /// </summary>
    [Game, Event(EventTarget.Any)]
    public class LoadPrefabComponent : IComponent
    {
        public string path;
    }


    /// <summary>
    /// 元素是否可移动的标签
    /// </summary>
    [Game]
    public class MovableComponent : IComponent
    {

    }
}
