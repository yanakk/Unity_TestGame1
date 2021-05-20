using Entitas;
using UnityEngine;
using System.Collections.Generic;

[Game]
public sealed class ViewComponent : IComponent
{
    public GameObject gameObject;
}


[Game]
public sealed class VelocityComponent : IComponent
{
    public float x;
    public float y;
}

[Game]
public sealed class SpriteComponent : IComponent
{
    public string name;
}

[Game]
public sealed class SpeedComponent : IComponent
{
    public float speed;
}

[Game]
public sealed class PositionComponent : IComponent
{
    public float x;
    public float y;
}


[Game]
public sealed class HeroComponent : IComponent
{
    public string name;
}

[Game]
public sealed class DataComponent : IComponent
{
    public Dictionary<string,string> values;
}

[Game]
public sealed class ItemComponent : IComponent
{
    public string name;
}

[Game]
public sealed class isDroppedComponent : IComponent
{
    public bool isdrop; //  װ���Ƿ�Ϊ��¶�ڵ�ͼ�еĿ�ʰȡ״̬
}

[Game]
public sealed class ItemInBagComponent : IComponent
{
    public List<Vector2> ItemInBagList; // c_id, i_id
    public List<int> AmountList; // amount
}

[Game]
public sealed class ItemIndexComponent : IComponent
{
    public int id;
}

[Game]
public sealed class SkillIndexComponent : IComponent
{
    public int id;
}

[Game]
public sealed class SkillComponent : IComponent
{
    public string name;
}

[Game]
public sealed class CharacterIndexComponent : IComponent
{
    public int id;  // 0-player
}

[Game]
public sealed class CharacterNameComponent : IComponent
{
    public string fname;    // family name
    public string gname;    // given name
}

[Game]
public sealed class CharacterGenderComponent : IComponent
{
    public int gender;  // 0-male  1-female
}

[Game]
public sealed class DebugLogComponent : IComponent
{
    public string message;
}