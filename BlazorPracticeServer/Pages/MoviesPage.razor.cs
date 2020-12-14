using BlazorPracticeServer.Data;
using BlazorPracticeServer.Model;
using BlazorPracticeServer.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Pages
{
    public partial class MoviesPage : ComponentBase
    {
        #region Field/Prop
        [Inject] public IRepository Repository { get; set; }
        [Inject] public SingletonService SingletonService { get; set; }

        private List<Movie> _movies;


        private readonly List<string> _messages = new List<string>();

        #endregion

        #region PageLifeCycle
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            _movies = Repository.GetMovies();

            _messages.Add("OnInitializedAsync");
        }

        protected override async Task OnParametersSetAsync()
        {
            _messages.Add("OnParameterAsync");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            _messages.Add(firstRender ? "OnAfterRenderAsync : first" : "OnAfterRenderAsync : not first");
        }

        protected override bool ShouldRender()
        {
            return true;
        }
        #endregion
    }
}
