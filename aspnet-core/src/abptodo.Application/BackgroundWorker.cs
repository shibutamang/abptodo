using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Threading;

namespace abptodo
{
    public class BackgroundWorker : AsyncPeriodicBackgroundWorkerBase
    {
        public BackgroundWorker(
              AbpAsyncTimer timer,
            IServiceScopeFactory serviceScopeFactory): base(timer, serviceScopeFactory)  
        {
            Timer.Period = 2000;
        }

        protected override Task DoWorkAsync(PeriodicBackgroundWorkerContext workerContext)
        {
            Logger.LogInformation("Background worker running");
            return Task.FromResult(0);
        }
    }
}
