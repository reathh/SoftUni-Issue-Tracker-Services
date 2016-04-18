using System.Collections.Generic;
using SIT.Web.ViewModels.Label;

namespace SIT.Web.Services
{
    public interface ILabelsService
    {
        IEnumerable<LabelViewModel> GetLabels(string filter);
    }
}