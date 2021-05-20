﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Entitas;

public class BagManager : MonoBehaviour
{
    static BagManager instance;

    public GameObject slotGrid;
    public Slot slotPrefab;
    public Text itemInformation;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    public static void AddItem2Entity(GameEntity bag, int character_id, int item_id)
    {
        Vector2 temp = new Vector2(character_id, item_id);

        //已经在背包中，改变数量
        if (bag.itemInBag.ItemInBagList.Exists(t => t == temp))
        {
            var location = bag.itemInBag.ItemInBagList.FindIndex(t => t == temp);
            bag.itemInBag.AmountList[location] += 1;
        }
        // 不在，添加
        else
        {
            bag.itemInBag.ItemInBagList.Add(temp);
            bag.itemInBag.AmountList.Add(1);
        }
    }

    // 获得所有Item的信息，传给Slot
    public static void CreateNewItem(GameEntity item, int num)
    {
        Slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);   // Object, Position, Quaternion
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);    // 父节点
        //newItem.slotItem = item;    // 信息赋值
        newItem.slotImage.sprite = Resources.Load<Sprite>(item.sprite.name); ;      // 图片
        newItem.slotNum.text = num.ToString();   // 个数
    }

    public static void RefreshItem(GameEntity bagdata, IGroup<GameEntity> _items)
    {
        // 目前只做玩家装备的刷新与显示
        int character_id = 0;
        var playeritem = bagdata.itemInBag.ItemInBagList.FindAll(t => t[0] == character_id);
        var total_num = playeritem.Count;

        // 先清零再重载
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < total_num; i++)
        {
            // 找到每个item id对应的entity，并找到其关联的数量，输入到函数中
            int now_iid = (int)playeritem[i][1]; // item id
            int now_cid = character_id;

            Vector2 temp = new Vector2(now_cid, now_iid);
            var location = bagdata.itemInBag.ItemInBagList.FindIndex(t => t == temp);
            int num = bagdata.itemInBag.AmountList[location];

            foreach (GameEntity e in _items)
            {
                if (e.itemIndex.id == now_iid)
                {
                    GameEntity now_item = e;
                    CreateNewItem(now_item, num);
                    break;
                } 
            }
        }

    }

}
