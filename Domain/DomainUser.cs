using System.Data;
using DataAccess.Data;
using Common.Entities;

namespace Domain
{
    public class DomainUser
    {
        public static DataTable ListUsers()
        {
            DataUser data = new DataUser();
            return data.ListUsers();
        }

        public static DataTable Search(string valor)
        {
            DataUser data = new DataUser();
            return data.Search(valor);
        }

        public static string Desactivate (int id)
        {
            DataUser data = new DataUser();
            return data.Desactivate(id);
        }

        public static string Activate(int id)
        {
            DataUser data = new DataUser();
            return data.Activate(id);
        }
        public static string Insert(int idRol, int idArea, string nombre, string email, string clave, int estado)
        {
            DataUser data = new DataUser();
            string existe = data.Exists(email);
            if (existe.Equals("1"))
            {
                return "Éste correo ya está ocupado.";
            }
            else
            {
                User obj = new User();
                obj.IdRol = idRol;
                obj.IdArea = idArea;
                obj.Nombre = nombre;
                obj.Email = email;
                obj.Clave = clave;
                obj.Estado = estado;
                return data.Insert(obj);

            }
        }

        public static string Update(int id, int idRol, int idArea, string nombre, string email, string clave)
        {
            DataUser data = new DataUser();
            User obj = new User();

                obj.IdUsuario = id;
                obj.IdRol = idRol;
                obj.IdArea = idArea;
                obj.Nombre = nombre;
                obj.Email = email;
                obj.Clave = clave;
            
            return data.Update(obj);
        }

        public static string UpdateEmail(int id, int idRol, int idArea, string nombre, string email, string clave)
        {
            DataUser data = new DataUser();
            User obj = new User();

                string exists = data.Exists(email);
                if (exists.Equals("1"))
                {
                    return "Este email ya está ocupado.";
                }
                else
                {
                    obj.IdUsuario = id;
                    obj.IdRol = idRol;
                    obj.IdArea = idArea;
                    obj.Nombre = nombre;
                    obj.Email = email;
                    obj.Clave = clave;

                }

            
            return data.Update(obj);
        }



    }
}
