using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;




namespace DataAccess.SqlServer
{
   public class UserData:ConnectionToSql
    {

        public bool Login(string email, string clave)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from usuario where email = @email and clave = @clave";
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLogin.IdUsuario = reader.GetInt32(0);
                            UserLogin.IdRol = reader.GetInt32(1);
                            UserLogin.IdArea = reader.GetInt32(2);
                            UserLogin.Nombre_Usuario = reader.GetString(3);
                            UserLogin.Email = reader.GetString(5);
                            UserLogin.Estado = reader.GetInt32(6);

                            
                        }
                        return true;

                    }
                    else
                    {
                        return false;

                    }
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from usuario where nombre_usuario=@user or email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    //Ejecutamos el lector
                    SqlDataReader reader = command.ExecuteReader();
                    //Si detecta registros...
                    if (reader.Read() == true)
                    {
                        //El nombre y apellido de acuerdo a las columnas de la base de datos.
                        string userName = reader.GetString(3);
                        //Obtenemos el correo del usuario y la contraseña.
                        string userMail = reader.GetString(4);
                        string accountPassword = reader.GetString(5);
                        //Intanciamos a la clase correo, soporte de sistema.
                        var mailService = new MailServices.SystemSupportMail();

                        mailService.sendMail(

                            subject: "Sistema: solicitud de recuperación de contraseña.",
                            body: "Hola, " + userName + "\nTu solicitud ha sido procesada correctamente.\n" +
                            "Tu contraseña es: " + accountPassword +
                            "\nSe recomienda cambiar su contraseña después de iniciar sesión.",
                            recipientMail: new List<string> { userMail });
                        //Puedes  enviar el correo a muchos y se instasnciaria arriba el List.
                        return "Hola, " + userName + "\nHas solicitado recordar tu contraseña.\n" +
                            "Por favor revisa tu correo: " + userMail +
                            "\nSe recomienda cambiar su contraseña después de iniciar sesión.";
                    }
                    else
                    {
                        
                        return "Lo sentimos, no existe una cuenta con ese correo o nombre de usuario.";
                    }


                }
            }


        }

        public string sendMailApplicant(string email,string nombreSolicitante, string estatusSolicitud, string NombreAutorizador, string folio)
        {
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "Sistema: Estatus de solicitud.",
                            body: "Hola, " + nombreSolicitante + "\nTu solicitud con folio No. "+folio+ " ha sido " +estatusSolicitud+" por, "+NombreAutorizador +".\n" +
                           "\nPara más detalles, por favor ingresa al Sistema de Salidas.",
                            recipientMail: new List<string> { email });
                        return "OK";
        }
        public string sendMailApplicantForFinance(string email, string nombreSolicitante, string estatusSolicitud, string NombreFinanzas, string folio)
        {
            var mailService = new MailServices.SystemSupportMail();
            mailService.sendMail(
                subject: "Sistema: Estatus de solicitud.",
                body: "Hola, " + nombreSolicitante + "\nTu solicitud  con folio No. " + folio + " ha recibido el " + estatusSolicitud + " de, " + NombreFinanzas + ". Ya puedes salir con tu material y/o equipo.\n" +
               "\nPara más detalles, por favor ingresa al Sistema de Salidas.",
                recipientMail: new List<string> { email });
            return "OK";
        }


        public string sendMailAuthorizer(string email, string nombreFinanzas, string nombreSolicitante, string NombreAutorizador, string folio)
        {
            var mailService = new MailServices.SystemSupportMail();
            mailService.sendMail(
                subject: "Sistema: Nueva solicitud.",
                body: "Hola, " + nombreFinanzas + "\nTienes una nueva solicitud con folio No. "+folio+ " de " + nombreSolicitante + " autorizada por " + NombreAutorizador + ".\n" +
               "\nPara más detalles, por favor ingresa al Sistema de Salidas.",
                recipientMail: new List<string> { email });
            return "OK";
        }

        public string sendMailAuthorizerForApplicant(string email, string nombreSolicitante, string NombreAutorizador)
        {
            var mailService = new MailServices.SystemSupportMail();
            mailService.sendMail(
                subject: "Sistema: Nueva solicitud.",
                body: "Hola, " + NombreAutorizador + "\nTienes una nueva solicitud de " + nombreSolicitante + "." +
               "\nPara más detalles, por favor ingresa al Sistema de Salidas.",
                recipientMail: new List<string> { email });
            return "OK";
        }

    }
}
