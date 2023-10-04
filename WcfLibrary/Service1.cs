using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfLibrary.Model;

namespace WcfLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public UserModel GetUsuario(string name, string surname)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
                throw new Exception("Valores incompletos");

            return new UserModel { Name = name, SurName = surname };
        }
    }
}