using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace XamProj
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RadioButton radioBtn1;
        RadioButton radioBtn2;
        RadioButton radioBtn3;
        Button btnSelection;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            radioBtn1 = FindViewById<RadioButton>(Resource.Id.radioButton1);
            radioBtn2 = FindViewById<RadioButton>(Resource.Id.radioButton2);
            radioBtn3 = FindViewById<RadioButton>(Resource.Id.radioButton3);
            btnSelection = FindViewById<Button>(Resource.Id.btnSubmit);

            btnSelection.Click += OnButtonSubmit;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        void OnButtonSubmit(object sender, EventArgs e)
        {
            if (radioBtn1.Checked)
            {
                Toast.MakeText(this, "Radio Button 1 Selected", ToastLength.Long).Show();
            }
            else if (radioBtn2.Checked)
            {
                Toast.MakeText(this, "Radio Button 2 Selected", ToastLength.Long).Show();
            }
            else if (radioBtn3.Checked)
            {
                Toast.MakeText(this, "Radio Button 3 Selected", ToastLength.Long).Show();
            }
        }
    }
}