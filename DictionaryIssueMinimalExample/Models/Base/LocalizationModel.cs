namespace DictionaryIssueMinimalExample.Models.Base;

/// <summary>
/// Localization model
/// </summary>
public class LocalizationModel<TLocalization> : Dictionary<string, TLocalization>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocalizationModel{TLocalization}"/> class.
    /// </summary>
    public LocalizationModel()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LocalizationModel{TLocalization}"/> class that
    /// contains values copied from the specified <paramref name="dictionary"/>.
    /// </summary>
    /// <param name="dictionary">The dictionary whose values are copied to the new dictionary.</param>
    public LocalizationModel(IDictionary<string, TLocalization> dictionary)
        : base(dictionary)
    {
    }
}
