using SharpDX;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace cengine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a <see cref="Frame">.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Device device;
        Camera cam = new Camera();
        Mesh mesh = new Mesh("Cube",8,12);
        Mesh[] meshes;

        DateTime previousDate;
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            WriteableBitmap bmp = new WriteableBitmap(640, 480);

            device = new Device(bmp);

            frontBuffer.Source = bmp;

            meshes = await device.LoadJSONFileAsync("monkey.babylon");

            cam.Position = new Vector3(0, 0, 10);
            cam.Target = new Vector3(0, 0, 0);

            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        void CompositionTarget_Rendering(object sender, object e)
        {
            var now = DateTime.Now;
            var currentFPS = 1000.0 / (now - previousDate).TotalMilliseconds;
            previousDate = now;

            fps.Text = string.Format("{0:0.00} fps", currentFPS);


            device.Clear(0, 0, 0, 255);

            foreach (var mesh in meshes)
            {
                mesh.Rotation = new Vector3(mesh.Rotation.X + 0.01f, mesh.Rotation.Y + 0.01f, mesh.Rotation.Z);

                device.Render(cam, mesh);

                device.Present();
            }
            
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
