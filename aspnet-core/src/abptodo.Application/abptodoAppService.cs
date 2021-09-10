using System;
using System.Collections.Generic;
using System.Text;
using abptodo.Localization;
using Volo.Abp.Application.Services;

namespace abptodo
{
    /* Inherit your application services from this class.
     */
    public abstract class abptodoAppService : ApplicationService
    {
        protected abptodoAppService()
        {
            LocalizationResource = typeof(abptodoResource);
        }
    }
}
