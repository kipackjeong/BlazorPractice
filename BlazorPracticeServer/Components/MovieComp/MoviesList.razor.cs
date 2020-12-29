using BlazorPracticeServer.Entity;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Components.MovieComp
{
    public partial class MoviesList : ComponentBase
    {
        #region Parameters
        [Parameter] public List<Movie> Movies { get; set; }
        [Parameter] public string Label { get; set; }
        #endregion
        public bool _displayDeleteButton = true;

        public Movie MovieToChange { get; set; }

        protected async override Task OnInitializedAsync()
        {
            MovieToChange = new Movie();
        }
    }
}
