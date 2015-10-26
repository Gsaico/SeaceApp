using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DroidSeace
{
    [Activity(Label = "DroidSeace", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        TextView lblMensaje;
        EditText txtUsuario;
        EditText txtPassword;
        Button btnLogin;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            lblMensaje = FindViewById<TextView>(Resource.Id.lblMensaje);
            txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuario);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);



            btnLogin.Click += BtnLogin_Click;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

