//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public isDroppedComponent isDropped { get { return (isDroppedComponent)GetComponent(GameComponentsLookup.isDropped); } }
    public bool hasisDropped { get { return HasComponent(GameComponentsLookup.isDropped); } }

    public void AddisDropped(bool newIsdrop) {
        var index = GameComponentsLookup.isDropped;
        var component = (isDroppedComponent)CreateComponent(index, typeof(isDroppedComponent));
        component.isdrop = newIsdrop;
        AddComponent(index, component);
    }

    public void ReplaceisDropped(bool newIsdrop) {
        var index = GameComponentsLookup.isDropped;
        var component = (isDroppedComponent)CreateComponent(index, typeof(isDroppedComponent));
        component.isdrop = newIsdrop;
        ReplaceComponent(index, component);
    }

    public void RemoveisDropped() {
        RemoveComponent(GameComponentsLookup.isDropped);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherisDropped;

    public static Entitas.IMatcher<GameEntity> isDropped {
        get {
            if (_matcherisDropped == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.isDropped);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherisDropped = matcher;
            }

            return _matcherisDropped;
        }
    }
}