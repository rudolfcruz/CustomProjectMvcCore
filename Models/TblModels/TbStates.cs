using System;
using System.Collections.Generic;
using System.Text;

namespace Seccion.Model.TblModels
{
    public class TbStates
    {
        public TbStates()
        {
            //this.Municipios = new HashSet<Municipios>();
            //this.Empleado = new HashSet<Empleado>();
        }

        public Guid StateID { get; set; }
        public string NameSate { get; set; }

        //public virtual ICollection<TbMunicipalities> unicipalities { get; set; }
        //public virtual ICollection<TbEmployee> Employee { get; set; }
    }
}
