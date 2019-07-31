using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XFGMapsStyling
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //var assembly = this.GetType().Assembly;
            //Stream stream = assembly.GetManifestResourceStream("XFGMapsStyling.Resources.MapStylLes.Dark.json");
            //string json;
            //using (var reader = new StreamReader(stream))
            //{
            //    json = reader.ReadToEnd();
            //}

            //GMap.MapStyle = MapStyle.FromJson(json);
        }
    }
}
