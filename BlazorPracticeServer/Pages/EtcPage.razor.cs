using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using BlazorPracticeServer.Services;
using BlazorPracticeServer.Shared;

namespace BlazorPracticeServer.Pages
{
    public partial class EtcPage
    {

        #region Component Attribute Parameter
        public Dictionary<string, object> DummyTextBoxParameters
        = new Dictionary<string, object>()
        {
                {"placeholder", "new movie name" },
                {"disabled", "true" }
        }; 
        #endregion

        [Inject] public IJSRuntime Js { get; set; }

        #region Cascading Param
        [CascadingParameter(Name = "Color")] public string Color { get; set; }
        [CascadingParameter(Name = "Size")] public string Size { get; set; } 
        [CascadingParameter] public MainLayout.AppState AppState { get; set; }
        #endregion

        private int _currentCount = 0;
        private static int _currentCountStatic = 0;
        private IJSObjectReference _jsModule;

        [JSInvokable]
        public async Task IncrementCount()
        {

            #region JavaScript Isolation
            // using jsmodule, which downloads certain js file only when it is needed
            _jsModule = await Js.InvokeAsync<IJSObjectReference>("import", "./js/counterjs.js");
            await _jsModule.InvokeVoidAsync("displayAlert", "hello world");
            #endregion

            _currentCount++;
            _currentCountStatic++;
            SingletonService.Value++;
            TransientService.Value++;

            #region Calling JS from C#
            await Js.InvokeVoidAsync("functionName", "Parameter");
            #endregion


            #region Calling JS that calls C# static method
            // [IJSRuntime].InvokeVoidAsync("javascript function name")
            // [IJSRuntime].InvokeAsync("javascript function name")
            await Js.InvokeVoidAsync("dotnetStaticInvocation");
            #endregion
        }

        private async Task IncrementCountJavaScript()
        {
            #region Calling JS that calls C# instance method
            await Js.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this)); // this indicates the non-static class, which here is DIPage class. 
            #endregion
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(_currentCountStatic);
        }
    }
}
