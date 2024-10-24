namespace DictionaryIssueMinimalExample.Models.Base;

/// <summary>
/// Base class for entity
/// </summary>
/// <typeparam name="TKey">The type of the key</typeparam>
[Serializable]
public abstract class EntityModel<TKey>
{
    public TKey Id { get; set; }
}
