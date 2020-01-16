using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UI_CSHARP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Button btnsign;
        Button btnloggi;
        Entry entr1;
        Entry entr2;
        public MainPage()
        {
            InitializeComponent();

            entr1 = new Entry();
            entr1.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entr1.Placeholder = "Email";
            entr1.TextColor = Color.Black;
            entr1.WidthRequest = 200;
            entr1.HeightRequest = 40;
            entr1.FontAttributes = FontAttributes.Bold;

            entr2 = new Entry();
            entr2.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entr2.Placeholder = "Password";
            entr2.TextColor = Color.Black;
            entr2.WidthRequest = 200;
            entr2.HeightRequest = 40;
            entr2.FontAttributes = FontAttributes.Bold;

            btnloggi = new Button();
            btnloggi.WidthRequest = 150;
            btnloggi.HeightRequest = 50;
            btnloggi.Text = "Login";
            btnloggi.CornerRadius = 20;
            btnloggi.BorderColor = Color.White;
            btnloggi.BackgroundColor = Color.Black;
            btnloggi.TextColor = Color.White;



            //Add column
            var col1 = new ColumnDefinition();
            col1.Width = 100;

            var col2 = new ColumnDefinition();
            col2.Width = 100;

            var col3 = new ColumnDefinition();
            col3.Width = 100;


            //add row

            var row1 = new RowDefinition();
            row1.Height = 200;

            var row2 = new RowDefinition();
            row2.Height = 200;

            var row3 = new RowDefinition();
            row3.Height = 200;



            //button1 
            // var btn1 = new Button();
            // btn1.BackgroundColor = Color.Red;
            // btn1.Text = "BUTTON1";
            ////button2
            // var btn2 = new Button();
            // btn2.BackgroundColor = Color.Pink;
            // btn2.Text = "BUTTON2";

            // //button3
            // var btn3 = new Button();
            // btn3.BackgroundColor = Color.Red;
            // btn3.Text = "BUTTON3";
            // //button4
            // var btn4 = new Button();
            // btn4.BackgroundColor = Color.Black;
            // btn4.TextColor = Color.White;
            // btn4.Text = "BUTTON4";

            // //column
            // var col1 = new ColumnDefinition();
            // col1.Width = 100;


            // var col2 = new ColumnDefinition();
            // col2.Width = 100;

            // var col3 = new ColumnDefinition();
            // col3.Width = 100;

            // //row
            // var row1 = new RowDefinition();
            // row1.Height = 100;

            // var row2 = new RowDefinition();
            // row2.Height = 100;

            // var row3 = new RowDefinition();
            // row3.Height = 100;

            // var t = new Grid();

            // //ajouter les column en grid
            // t.ColumnDefinitions.Add(col1);
            // t.ColumnDefinitions.Add(col2);
            // t.ColumnDefinitions.Add(col3);


            // //ajouter les row en grid
            // t.RowDefinitions.Add(row1);
            // t.RowDefinitions.Add(row2);
            // t.RowDefinitions.Add(row3);


            // //ajouter les boutton en grid
            // t.Children.Add(btn1,0,0);
            // t.Children.Add(btn2, 0, 1);
            // t.Children.Add(btn3, 0, 2);
            // t.Children.Add(btn4, 1, 0);


            var main = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                Children ={
                }
            };

            Content = main;
        }
    }
}
