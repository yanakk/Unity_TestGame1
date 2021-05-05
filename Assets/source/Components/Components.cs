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