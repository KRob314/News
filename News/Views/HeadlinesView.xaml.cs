using System.Threading.Tasks;
using News.Services;
using News.ViewModels;

namespace News.Views;

public partial class HeadlinesView : ContentPage
{
	readonly HeadlinesViewModel viewModel;

	public HeadlinesView(HeadlinesViewModel headlinesViewModel)
	{
		this.viewModel = headlinesViewModel;
		InitializeComponent();
		Task.Run(async () => await Initialize(GetScopeFromRoute()));
	}

	private async Task Initialize(string scope)
	{
		BindingContext = viewModel;
		await viewModel.Initialize(scope);
	}

	private string GetScopeFromRoute()
	{
		var route = Shell.Current.CurrentState.Location.OriginalString.Split('/').LastOrDefault();
		return route;
	}
}