using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MP
{
    public partial class MainPage : ContentPage
    {
        int winDoor;
        Random rnd = new Random();
        bool secondClick = false;

        public MainPage()
        {
            InitializeComponent();
            T1.IsVisible = false;
            T2.IsVisible = false;
            winDoor = rnd.Next(1, 3);
        }

        public void B1_Click(object sender, EventArgs e)
        {
            if (secondClick == false)
            {
                if (winDoor != 2)
                {
                    B2.IsVisible = false;
                }
                else
                {
                    B3.IsVisible = false;
                }
                secondClick = true;
            }
            else
            {
                if(winDoor == 1)
                {
                    T1.IsVisible = true;
                }
                else
                {
                    T2.IsVisible = true;
                }
            }
        }

        public void B2_Click(object sender, EventArgs e)
        {
            if (secondClick == false)
            {
                if (winDoor != 1)
                {
                    B1.IsVisible = false;
                }
                else
                {
                    B3.IsVisible = false;
                }
                secondClick = true;
            }
            else
            {
                if (winDoor == 2)
                {
                    T1.IsVisible = true;
                }
                else
                {
                    T2.IsVisible = true;
                }
            }
        }

        public void B3_Click(object sender, EventArgs e)
        {
            if (secondClick == false)
            {
                if (winDoor != 1)
                {
                    B1.IsVisible = false;
                }
                else
                {
                    B2.IsVisible = false;
                }
                secondClick = true;
            }
            else
            {
                if (winDoor == 3)
                {
                    T1.IsVisible = true;
                }
                else
                {
                    T2.IsVisible = true;
                }
            }
        }
    }
}
