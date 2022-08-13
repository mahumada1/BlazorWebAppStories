using Microsoft.AspNetCore.Components;
using StoriesWebApp.Client.Servicios;
using StoriesWebApp.Shared;

namespace StoriesWebApp.Client.Pages.Novelties
{
	public partial class Today
	{
        [Parameter]
        public int? PageNumber { get; set; }


        private List<Story> _stories;

        [Inject]
        public ILogger<Today> logger { get; set; }

        [Inject]
        public IStoriesService storiesService { get; set; }


        public override Task SetParametersAsync(ParameterView parameters)
        {
            logger.LogInformation("SetParametersAsync, ajuste de parametros del componente");
            return base.SetParametersAsync(parameters);
        }

        protected override async Task OnInitializedAsync()
        {
            logger.LogInformation("OnInitializedAsync, el componene se acaba de iniciar");
            _stories = storiesService.GetNovelties(StoriesService.NoveltiesScope.today);
        }

        protected override void OnParametersSet()
        {
            logger.LogInformation("OnParametersSet, Se asigna el valor a los parametros");
            this.PageNumber = PageNumber ?? 1;
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            logger.LogInformation($"OnAfterRenderAsync, El componenete se acaba de renderizar, firstRender: {firstRender}");
            return base.OnAfterRenderAsync(firstRender);
        }

        private Story storySelected = null;

        private void OnStorySelected(Story item)
        {
            storySelected = item;
        }

    }
}
