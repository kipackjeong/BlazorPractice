using BlazorPracticeServer.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorPracticeServer.Components
{
    public partial class IndividualMovie : ComponentBase
    {
        [Parameter]
        public Movie Movie { get; set; }
        [Parameter]
        public bool DisplayDeleteButtons { get; set; }
        // event callback, bring the method from parent component, and on certain condition, invoke it.
        [Parameter] public EventCallback<Movie> DeleteMoviePrompt { get; set; }
        [Parameter] public EventCallback<Movie> EditMoviePrompt { get; set; }

    }
}
