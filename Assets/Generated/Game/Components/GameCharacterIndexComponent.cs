//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CharacterIndexComponent characterIndex { get { return (CharacterIndexComponent)GetComponent(GameComponentsLookup.CharacterIndex); } }
    public bool hasCharacterIndex { get { return HasComponent(GameComponentsLookup.CharacterIndex); } }

    public void AddCharacterIndex(int newId) {
        var index = GameComponentsLookup.CharacterIndex;
        var component = (CharacterIndexComponent)CreateComponent(index, typeof(CharacterIndexComponent));
        component.id = newId;
        AddComponent(index, component);
    }

    public void ReplaceCharacterIndex(int newId) {
        var index = GameComponentsLookup.CharacterIndex;
        var component = (CharacterIndexComponent)CreateComponent(index, typeof(CharacterIndexComponent));
        component.id = newId;
        ReplaceComponent(index, component);
    }

    public void RemoveCharacterIndex() {
        RemoveComponent(GameComponentsLookup.CharacterIndex);
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

    static Entitas.IMatcher<GameEntity> _matcherCharacterIndex;

    public static Entitas.IMatcher<GameEntity> CharacterIndex {
        get {
            if (_matcherCharacterIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CharacterIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCharacterIndex = matcher;
            }

            return _matcherCharacterIndex;
        }
    }
}