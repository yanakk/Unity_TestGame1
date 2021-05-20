//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ItemIndexComponent itemIndex { get { return (ItemIndexComponent)GetComponent(GameComponentsLookup.ItemIndex); } }
    public bool hasItemIndex { get { return HasComponent(GameComponentsLookup.ItemIndex); } }

    public void AddItemIndex(int newId) {
        var index = GameComponentsLookup.ItemIndex;
        var component = (ItemIndexComponent)CreateComponent(index, typeof(ItemIndexComponent));
        component.id = newId;
        AddComponent(index, component);
    }

    public void ReplaceItemIndex(int newId) {
        var index = GameComponentsLookup.ItemIndex;
        var component = (ItemIndexComponent)CreateComponent(index, typeof(ItemIndexComponent));
        component.id = newId;
        ReplaceComponent(index, component);
    }

    public void RemoveItemIndex() {
        RemoveComponent(GameComponentsLookup.ItemIndex);
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

    static Entitas.IMatcher<GameEntity> _matcherItemIndex;

    public static Entitas.IMatcher<GameEntity> ItemIndex {
        get {
            if (_matcherItemIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ItemIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherItemIndex = matcher;
            }

            return _matcherItemIndex;
        }
    }
}