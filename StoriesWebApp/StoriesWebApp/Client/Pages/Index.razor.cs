using Microsoft.AspNetCore.Components;

namespace StoriesWebApp.Client.Pages
{
    public partial class Index
    {
        //QUEDA LA DUDA DE COMO ASIGNAR EN CASCADA MAS DE UNA VARIABLE
        [CascadingParameter (Name = "numeroSuscriptores")]
        private int numSubs { get; set; }


    }
} 
