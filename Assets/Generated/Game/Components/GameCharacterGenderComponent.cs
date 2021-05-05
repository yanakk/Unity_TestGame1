//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CharacterGenderComponent characterGender { get { return (CharacterGenderComponent)GetComponent(GameComponentsLookup.CharacterGender); } }
    public bool hasCharacterGender { get { return HasComponent(GameComponentsLookup.CharacterGender); } }

    public void AddCharacterGender(int newGender) {
        var index = GameComponentsLookup.CharacterGender;
        var component = (CharacterGenderComponent)CreateComponent(index, typeof(CharacterGenderComponent));
        component.gender = newGender;
        AddComponent(index, component);
    }

    public void ReplaceCharacterGender(int newGender) {
        var index = GameComponentsLookup.CharacterGender;
        var component = (CharacterGenderComponent)CreateComponent(index, typeof(CharacterGenderComponent));
        component.gender = newGender;
        ReplaceComponent(index, component);
    }

    public void RemoveCharacterGender() {
        RemoveComponent(GameComponentsLookup.CharacterGender);
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

    static Entitas.IMatcher<GameEntity> _matcherCharacterGender;

    public static Entitas.IMatcher<GameEntity> CharacterGender {
        get {
            if (_matcherCharacterGender == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CharacterGender);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCharacterGender = matcher;
            }

            return _matcherCharacterGender;
        }
    }
}