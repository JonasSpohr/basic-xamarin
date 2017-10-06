using PCLStorage;
using Plugin.Media;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POCPrism.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TookPicture.Clicked += TookPicture_ClickedAsync;
            BrowsePicture.Clicked += BrowsePicture_Clicked;

            if (Application.Current.Properties.ContainsKey("profilepic"))
            {
                this.PhotoImage.Source = ImageSource.FromFile(Application.Current.Properties["profilepic"] as string);
            }
        }

        private async void BrowsePicture_Clicked(object sender, EventArgs e)
        {
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                     CompressionQuality = 80
                });

                if (file == null)
                    return;

                Application.Current.Properties["profilepic"] = file.Path;

                this.PhotoImage.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            }
            catch (Exception eee)
            {
                Debug.WriteLine(eee.ToString());
                await DisplayAlert("Error", eee.ToString(), "Sorry");
            }
        }

        private async void TookPicture_ClickedAsync(object sender, EventArgs e)
        {
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "Profile.jpg",
                    SaveToAlbum = true
                });

                if (file == null)
                    return;

                Application.Current.Properties["profilepic"] = file.Path;

                this.PhotoImage.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            }
            catch(Exception eee)
            {
                Debug.WriteLine(eee.ToString());
                await DisplayAlert("Error", eee.ToString(), "Sorry");
            }                        
        }      
    }
}
