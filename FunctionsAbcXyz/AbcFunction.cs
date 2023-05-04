using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionsAbcXyz;

public static class AbcFunction
{
    [FunctionName("AbcFunction")]
    public static Task RunAsync([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation("C# Timer trigger function executed at: {UtcNow}", DateTime.UtcNow);
        return Task.CompletedTask;
    }
}
