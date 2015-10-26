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
            SeaceWCF.ServiceApp service = new SeaceWCF.ServiceApp();

            SeaceWCF.personDTO persona = new SeaceWCF.personDTO();
            persona.username = txtUsuario.Text;
            persona.password = txtPassword.Text;

            service.VerificarPasswordCompleted += Service_VerificarPasswordCompleted;
            service.VerificarPasswordAsync(persona);
            lblMensaje.Text = "Validando, por favor espere...";
    

           
            btnLogin.Enabled = false;
             
        }

        private void Service_VerificarPasswordCompleted(object sender, SeaceWCF.VerificarPasswordCompletedEventArgs e)
        {
            btnLogin.Enabled = true;
            // lblMensaje.Text = "Concretado...";
            //e.VerificarPasswordResult;

            //  lblMensaje.Text = e.VerificarPasswordResult.ToString();

                if (!e.VerificarPasswordResult)
               {
                   lblMensaje.Text = "Usuario con acceso denegado";
            btnLogin.Enabled = true;
                    return;
               }
               lblMensaje.Text = "Usuario con acceso permitido";

            //llamo a nueva ventana
            var intent = new Intent(this, typeof(MenuActivity));
            //intent.PutStringArrayListExtra("phone_numbers", _phoneNumbers);
            StartActivity(intent);
        }
    }
}

