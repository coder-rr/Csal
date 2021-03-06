using ProjectTracker.Ui.Xamarin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsUi
{
  public partial class Dashboard : ContentPage
  {
    public Dashboard()
    {
      InitializeComponent();
    }

    public Task InitAsync()
    {
      BindingContext = new ViewModels.DashboardViewModel();
      return Task.CompletedTask;
    }

    private async void ShowProjectList(object sender, EventArgs e)
    {
      await App.NavigateTo(typeof(Views.ProjectList));
    }

    private async void ShowResourceList(object sender, EventArgs e)
    {
      await App.NavigateTo(typeof(Views.ResourceList));
    }

    private async void ViewRoles(object sender, EventArgs e)
    {
      await App.NavigateTo(typeof(Views.RoleList));
    }
  }
}
