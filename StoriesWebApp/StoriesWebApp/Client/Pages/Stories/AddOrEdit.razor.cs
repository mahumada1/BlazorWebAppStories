using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using StoriesWebApp.Client.Componentes;
using System.Timers;
using Timer = System.Timers.Timer;

namespace StoriesWebApp.Client.Pages.Stories
{
    public partial class AddOrEdit
    {

        public enum FormMode
        {
            Add, Edit
        }

        private string storyText;
        private Timer timer;


        [Inject]
        private ILocalStorageService localStorageService { get; set; }

        [Parameter]
        public FormMode Mode { get; set; }

        private int percentage;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {
                var storedText = await localStorageService.ContainKeyAsync("storyText") ? await localStorageService.GetItemAsync<string>("storyText") : null;
                if(!string.IsNullOrWhiteSpace(storedText))
                {
                    storyText = storedText;
                    StateHasChanged();
                }
                timer = new Timer { Interval = 1000 };
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
        }

        private async void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            await this.InvokeAsync(SaveStoryTextInStorage); 
            // METODO EXTRA PARA SER COMPATIBLE CON BLAZOR SERVER
            // NO ES NECESARIO SI SOLO SE CONSIDERA WEBASSEMBLY COMO PROYECTO BLAZOR
        }

        private async Task SaveStoryTextInStorage()
        {
            await localStorageService.SetItemAsync("storyText", storyText);
        }

        private void FillingPercentageChanged(FillingPercentageChangedEventArgs e)
        {
            percentage = e.FillingPercentage;
        }

    }
}
