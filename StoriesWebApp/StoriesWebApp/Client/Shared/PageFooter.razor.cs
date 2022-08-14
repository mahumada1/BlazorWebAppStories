using Microsoft.AspNetCore.Components;

namespace StoriesWebApp.Client.Shared
{
    public partial class PageFooter
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
