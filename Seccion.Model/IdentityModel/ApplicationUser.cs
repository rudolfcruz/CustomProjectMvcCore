using Microsoft.AspNetCore.Identity;
using System;

namespace Seccion.Model.IdentityModel
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        //Apellido Paterno
        public string FirstName { get; set; }
        //Apellido Materno
        public string LastName { get; set; }
        //Fecha de Ingreso
        public DateTime JoinDate { get; set; }
    }
}
