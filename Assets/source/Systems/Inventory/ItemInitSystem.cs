using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class ItemInitSystem : IInitializeSystem
{
    readonly GameContext _context;

    public ItemInitSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        var entity = _context.CreateEntity();
        entity.AddItem("sword3");
        entity.AddSprite("sword3");
        entity.AddItemIndex(3);
        entity.AddisDropped(true);  // 初始化为false，测试时暂设为true且有position；实际需要从数据库中读取信息，并添加所有的物品
        entity.AddPosition(-6, -3);

        // Item In Bag
        var IiBentity = _context.CreateEntity();
        List<int> AmountList = new List<int>();
        List<Vector2> ItemInBagList = new List<Vector2>();
        IiBentity.AddItemInBag(ItemInBagList, AmountList);
    }

}
