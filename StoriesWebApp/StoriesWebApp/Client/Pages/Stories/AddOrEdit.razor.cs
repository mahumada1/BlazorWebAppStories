using Microsoft.AspNetCore.Components;
using StoriesWebApp.Client.Componentes;

namespace StoriesWebApp.Client.Pages.Stories
{
    public partial class AddOrEdit
    {

        public enum FormMode
        {
            Add, Edit
        }

        [Parameter]
        public FormMode Mode { get; set; }

        private int percentage;

        private void FillingPercentageChanged(FillingPercentageChangedEventArgs e)
        {
            percentage = e.FillingPercentage;
        }

    }
}
