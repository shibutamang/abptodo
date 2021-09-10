using abptodo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abptodo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class abptodoController : AbpController
    {
        protected abptodoController()
        {
            LocalizationResource = typeof(abptodoResource);
        }
    }
}