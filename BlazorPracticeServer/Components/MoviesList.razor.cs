using BlazorPracticeServer.Components.Enums;
using BlazorPracticeServer.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Components
{
    public partial class MoviesList : ComponentBase
    {
        [Inject] private IJSRuntime Js { get; set; }


        #region Parameters
        [Parameter] public List<Movie> Movies { get; set; }
        #endregion

        public Confirmation Confirmation { get; set; }

        public bool _displayDeleteButton = true;

        public Movie MovieToChange { get; set; }

        private async Task DeleteMoviePrompt(Movie movie)
        {
            MovieToChange = movie;
            Confirmation.ConfirmType = ConfirmType.Delete;
            Confirmation.Show(movie);
        }

        private async Task DeleteMovie()
        {
            Confirmation.Hide();
            Movies.Remove(MovieToChange);
            MovieToChange = null;
        }

        private async Task EditMoviePrompt(Movie movie)
        {
            MovieToChange = movie;
            Confirmation.ConfirmType = ConfirmType.Edit;
            Confirmation.Show(movie);
        }

        private async Task EditMovie()
        {
            Confirmation.Hide();
        }

        protected async override Task OnInitializedAsync()
        {
            MovieToChange = new Movie();
        }
    }
}
