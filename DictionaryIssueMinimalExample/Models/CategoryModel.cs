using DictionaryIssueMinimalExample.Models.Base;

namespace DictionaryIssueMinimalExample.Models;

public class CategoryModel : LocalizedEntityModel<int, CategoryLocalizationModel>
{
    public decimal Fee { get; set; }
}
