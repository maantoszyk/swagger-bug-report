namespace DictionaryIssueMinimalExample.Models.Base;

/// <summary>
/// Defines members for localized entity
/// </summary>
/// <typeparam name="TLocalization"></typeparam>
public interface ILocalizedEntityModel<TLocalization>
{
    /// <summary>
    /// The localization
    /// </summary>
    LocalizationModel<TLocalization> Localization { get; set; }
}
