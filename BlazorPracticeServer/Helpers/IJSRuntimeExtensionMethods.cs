using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask ConsoleLog(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", message);
        }

        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("functionName", message);
        }
    }
}
