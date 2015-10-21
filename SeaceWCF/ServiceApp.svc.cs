using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SeaceWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceApp" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceApp.svc o ServiceApp.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceApp : IServiceApp
    {
        public void DoWork()
        {
        }
    }
}
