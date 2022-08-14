using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using StoriesWebApp.Client.Servicios;
using StoriesWebApp.Shared;

namespace StoriesWebApp.Client.Pages.Admin
{
	public partial class Index
	{
        [Inject]
        public IStoriesService storiesService { get; set; }

        private List<Story> stories;

        protected override async Task OnInitializedAsync()
        {
            stories = storiesService.GetNovelties(StoriesService.NoveltiesScope.today);
        }

        private Story storySelected = null;
        private void OnStorySelected(Story item)
        {
            storySelected = item;
        }
    }
}
