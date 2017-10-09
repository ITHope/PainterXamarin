using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace VectPaint.Droid
{
	[Activity (Label = "VectPaint.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		XDataAndroid data = new XDataAndroid();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Draw);
            FindViewById<PDraw>(Resource.Id.pDraw).data = data;
            SetSpinnersListeners();
        }
        private void SetSpinnersListeners()
        {
            Spinner spType = FindViewById<Spinner>(Resource.Id.spType);
         
            var adapterT = ArrayAdapter.CreateFromResource(this, Resource.Array.type_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapterT.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spType.Adapter = adapterT;

            spType.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
        }
		 private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            
			if (spinner.Id == Resource.Id.spType)
            {
                switch (spinner.SelectedItem.ToString())
                {
					case "Line":
                        data.Type = Figure.FigureType.Line; 
					    break;
					case "Ellipse":
                        data.Type = Figure.FigureType.Ellipse; 
					    break;
                    case "Rectangle":
                        data.Type = Figure.FigureType.Rect; 
					    break;
                }
            }
        }
	}
}


