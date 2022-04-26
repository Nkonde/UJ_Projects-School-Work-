using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit.UI.Views;
using TYPMobileApp.Helpers;

namespace TYPMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class RatingView : Popup
    {
        public RatingView()
        {
            InitializeComponent();

            MyStar1.Text = IconFont.StarOutline;
            MyStar2.Text = IconFont.StarOutline;
            MyStar3.Text = IconFont.StarOutline;
            MyStar4.Text = IconFont.StarOutline;
            MyStar5.Text = IconFont.StarOutline;
        }

        int ratingPoint = 0;

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.StarOutline;
            MyStar3.Text = IconFont.StarOutline;
            MyStar4.Text = IconFont.StarOutline;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 1;
        }

        void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.StarOutline;
            MyStar4.Text = IconFont.StarOutline;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 2;

        }

        void TapGestureRecognizer_Tapped_3(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.Star;
            MyStar4.Text = IconFont.StarOutline;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 3;
        }

        void TapGestureRecognizer_Tapped_4(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.Star;
            MyStar4.Text = IconFont.Star;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 4;
        }

        void TapGestureRecognizer_Tapped_5(System.Object sender, System.EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.Star;
            MyStar4.Text = IconFont.Star;
            MyStar5.Text = IconFont.Star;
            ratingPoint = 5;
        }



        //Dynamic Way to change Rating Point

        //pass integer value in this method

        void ChangeRating(int ratingPoint)
        {

            switch (ratingPoint)
            {

                case 0:
                    {
                        MyStar1.Text = IconFont.StarOutline;
                        MyStar2.Text = IconFont.StarOutline;
                        MyStar3.Text = IconFont.StarOutline;
                        MyStar4.Text = IconFont.StarOutline;
                        MyStar5.Text = IconFont.StarOutline;
                        break;
                    }
                //When Rating point is 1 then it satisfies this case
                case 1:
                    {
                        MyStar1.Text = IconFont.Star;
                        MyStar2.Text = IconFont.StarOutline;
                        MyStar3.Text = IconFont.StarOutline;
                        MyStar4.Text = IconFont.StarOutline;
                        MyStar5.Text = IconFont.StarOutline;
                        break;
                    }
                case 2:
                    {
                        MyStar1.Text = IconFont.Star;
                        MyStar2.Text = IconFont.Star;
                        MyStar3.Text = IconFont.StarOutline;
                        MyStar4.Text = IconFont.StarOutline;
                        MyStar5.Text = IconFont.StarOutline;
                        break;
                    }
                case 3:
                    {
                        MyStar1.Text = IconFont.Star;
                        MyStar2.Text = IconFont.Star;
                        MyStar3.Text = IconFont.Star;
                        MyStar4.Text = IconFont.StarOutline;
                        MyStar5.Text = IconFont.StarOutline;
                        break;
                    }
                case 4:
                    {
                        MyStar1.Text = IconFont.Star;
                        MyStar2.Text = IconFont.Star;
                        MyStar3.Text = IconFont.Star;
                        MyStar4.Text = IconFont.Star;
                        MyStar5.Text = IconFont.StarOutline;
                        break;
                    }
                case 5:
                    {
                        MyStar1.Text = IconFont.Star;
                        MyStar2.Text = IconFont.Star;
                        MyStar3.Text = IconFont.Star;
                        MyStar4.Text = IconFont.Star;
                        MyStar5.Text = IconFont.Star;
                        break;
                    }

                default:
                    {
                        MyStar1.Text = IconFont.StarOutline;
                        MyStar2.Text = IconFont.StarOutline;
                        MyStar3.Text = IconFont.StarOutline;
                        MyStar4.Text = IconFont.StarOutline;
                        MyStar5.Text = IconFont.StarOutline;
                        break;
                    }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}