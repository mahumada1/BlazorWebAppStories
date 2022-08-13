using StoriesWebApp.Shared;

namespace StoriesWebApp.Client.Servicios
{
	public interface IStoriesService
	{
		List<Story> GetNovelties(StoriesService.NoveltiesScope scope);
	}
}