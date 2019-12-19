using System;
using System.Collections.Generic;

namespace Seccion.Model.TblModels
{
    public class TbEmployee : BaseEntityModel
    {
        public TbEmployee()
        {
            //this.GastosFunerarios = new HashSet<GastosFunerarios>();
            //this.Solicitud = new HashSet<Solicitud>();
        }

        public Guid EmployeeID { get; set; }
        //public Guid StateID { get; set; }
        public Guid MunicipalitiesID { get; set; }
        public string NumberFicha { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LastNameTwo { get; set; }
        public string RFC { get; set; }
        public string ContractualSituation{ get; set; }
        public string WorkLocation { get; set; }
        public string Rol { get; set; }
        public string Region { get; set; }
        public string DepartmentKey { get; set; }
        public int Level { get; set; }
        public string AsisteKey { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PhoneHouse { get; set; }
        public string CelularPhone { get; set; }
        public string Email { get; set; }
        public string Bank { get; set; }
        public string BranchOffice { get; set; }
        public string AccountNumber { get; set; }
        public string ClaveInterbancaria { get; set; }
        public string Comments { get; set; }
        public bool Delete { get; set; }
        //public DateTime? DateInsert { get; set; }
        //public DateTime? DateUpdate { get; set; }
        //public string UserInsert { get; set; }
        //public string UserUpdate { get; set; }

        //public virtual TbStates States { get; set; }
        public virtual TbMunicipalities Municipalities { get; set; }
        //public virtual ICollection<GastosFunerarios> GastosFunerarios { get; set; }

        public virtual ICollection<TbRequest> Request { get; set; }
    }
}
