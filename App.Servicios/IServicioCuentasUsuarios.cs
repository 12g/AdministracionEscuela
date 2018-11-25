using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using App.Negocio;

namespace App.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCuentasUsuarios
    {

        [OperationContract]
        bool ValidarCredenciales(string usuario, string contraseña);

        [OperationContract]
        bool RegistrarUsuarioNuevo(string usuario, string contraseña);

        [OperationContract]
        List<CuentaUsuario> ListarUsuarios();


    }
}
