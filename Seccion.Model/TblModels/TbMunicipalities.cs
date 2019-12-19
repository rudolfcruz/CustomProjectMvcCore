using System;

namespace Seccion.Model.TblModels
{
    public class TbMunicipalities
    {
        public Guid MunicipalitiesID { get; set; }
        public Guid StateID { get; set; }
        public string NameMunicipalities { get; set; }

        public virtual TbStates States { get; set; }
    }
}
