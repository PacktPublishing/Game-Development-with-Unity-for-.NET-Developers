using Unity.Entities;

[GenerateAuthoringComponent]
public struct SampleComponent : IComponentData
{
    public int Value;
}