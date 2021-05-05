//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DebugLogComponent debugLog { get { return (DebugLogComponent)GetComponent(GameComponentsLookup.DebugLog); } }
    public bool hasDebugLog { get { return HasComponent(GameComponentsLookup.DebugLog); } }

    public void AddDebugLog(string newMessage) {
        var index = GameComponentsLookup.DebugLog;
        var component = (DebugLogComponent)CreateComponent(index, typeof(DebugLogComponent));
        component.message = newMessage;
        AddComponent(index, component);
    }

    public void ReplaceDebugLog(string newMessage) {
        var index = GameComponentsLookup.DebugLog;
        var component = (DebugLogComponent)CreateComponent(index, typeof(DebugLogComponent));
        component.message = newMessage;
        ReplaceComponent(index, component);
    }

    public void RemoveDebugLog() {
        RemoveComponent(GameComponentsLookup.DebugLog);
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

    static Entitas.IMatcher<GameEntity> _matcherDebugLog;

    public static Entitas.IMatcher<GameEntity> DebugLog {
        get {
            if (_matcherDebugLog == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DebugLog);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDebugLog = matcher;
            }

            return _matcherDebugLog;
        }
    }
}
