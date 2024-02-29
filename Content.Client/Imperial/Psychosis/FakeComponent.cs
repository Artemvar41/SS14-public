using Robust.Shared.GameStates;

namespace Content.Client.Fake;

/// <summary>
/// psychosis thing
/// </summary>
[RegisterComponent]
[NetworkedComponent]
[Access(typeof(FakeSystem))]
public sealed partial class FakeComponent : Component
{
    public TimeSpan Life = TimeSpan.FromSeconds(60);

    public TimeSpan Delete = TimeSpan.FromSeconds(0);
}
