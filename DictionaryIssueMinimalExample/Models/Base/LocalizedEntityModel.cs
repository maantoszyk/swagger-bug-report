namespace DictionaryIssueMinimalExample.Models.Base;

/// <summary>
/// Base class for entity with key and localization
/// </summary>
/// <typeparam name="TKey">The type of the key.</typeparam>
/// <typeparam name="TLocalization">The type of the localization.</typeparam>
[Serializable]
public abstract class LocalizedEntityModel<TKey, TLocalization> : EntityModel<TKey>, ILocalizedEntityModel<TLocalization>
{
    public LocalizationModel<TLocalization> Localization { get; set; }
}
