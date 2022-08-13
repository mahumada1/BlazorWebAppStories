using Microsoft.AspNetCore.Components;
using StoriesWebApp.Client.Configuracion;
using StoriesWebApp.Shared;

namespace StoriesWebApp.Client.Componentes
{
    public partial class StoriesTable
    {

        [Inject]
        private PaginationConfig paginationConfig { get; set; }

        [Parameter]
        public string Caption { get; set; }

        [Parameter]
        public List<Story> Stories { get; set; }


        private List<string> recentSearches = new List<string> { "terror", "dientes", "gato" };
        private string searchField;
        private string textToFilter;
        private List<Story> filteredResults;
        private string captionWithFilter => this.Caption + (!string.IsNullOrEmpty(textToFilter) ? $". Filtrado por : {textToFilter}" : ". Todo el contenido");

        protected override void OnParametersSet()
        {
            filteredResults = Stories;
        }

        private void PerformSearch()
        {
            textToFilter = searchField;
            if (string.IsNullOrEmpty(textToFilter))
            {
                filteredResults = Stories;
            }
            else
            {
                filteredResults = Stories.Where(s => s.Title.Contains(textToFilter, StringComparison.InvariantCultureIgnoreCase)
                || s.Author.Contains(textToFilter, StringComparison.InvariantCultureIgnoreCase)
                || s.Category.Contains(textToFilter, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(textToFilter) && recentSearches.Count(s => s == textToFilter) == 0)
            {
                recentSearches.Add(textToFilter);
            }
        }

        private void RemoveRecentSearch(string item)
        {
            if (recentSearches.Any(s => s == item))
            {
                recentSearches.Remove(item);
            }
        }

        private void SetRecentSearch(string text)
        {
            searchField = text;
        }


    }

}

//namespace StoriesWebApp.Client.Componentes
//{
//	public partial class StoriesTable
//	{
//		[Parameter]
//		public string Caption { get; set; }

//		[Parameter]
//		public List<Story> Stories { get; set; }
//	}
//}

//ESTE ARCHIVO SE CREA A MANO UTILIZANDO EL MISMO NOMBRE DEL COMPONENETE Y LA EXTENSIÓN CS
//AL CREAR EL ARCHIVO SE TIENE QUE AGREGAR PARTIAL A LA DEFINICIÓN DE LA CLASE PARA QUE LO TOME COMO CODEBEHIND
