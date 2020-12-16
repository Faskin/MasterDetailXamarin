using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailXamarin
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("mipmap-hdpi/icon.png");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "About",
                Detail = "Info",
                ImagePath = "about.jpg",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Get started",
                Detail = "First steps",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.AchievemnetsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "StackLayout",
                Detail = "StackLayout Tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Label",
                Detail = "Label Tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.ExperiencePage)
            });

            list.Add(new MasterMenuItems()
            {
                Text = "Grid Layout",
                Detail = "Grid layout tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.Gridlay)
            });

            list.Add(new MasterMenuItems()
            {
                Text = "Button",
                Detail = "Button Tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.Btnxml)
            });

            list.Add(new MasterMenuItems()
            {
                Text = "Image",
                Detail = "Image Tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.Imagexml)
            });

            list.Add(new MasterMenuItems()
            {
                Text = "List",
                Detail = "List Tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.Listsxml)
            });

            list.Add(new MasterMenuItems()
            {
                Text = "Pop-ups",
                Detail = "Pop-ups Tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.Popupsxml)


            });

            list.Add(new MasterMenuItems()
            {
                Text = "Text Editor",
                Detail = "Text Editor Tutorial",
                ImagePath = "icon.png",
                TargetPage = typeof(Views.texteditorxml)
            });

            return list;
        }


        void aboutList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
