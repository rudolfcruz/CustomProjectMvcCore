using System;
using System.Collections.Generic;

namespace Seccion.Model.TblModels
{
    public class TbFuneralExpenses : BaseEntityModel
    {
        public TbFuneralExpenses()
        {
            //this.GFComprobante = new HashSet<GFComprobante>();
        }

        public Guid FuneralExpensesID { get; set; }
        public Guid EmployeeID { get; set; }
        //public string FichaEmpleado { get; set; }
        public string OrderNumberGF { get; set; }
        //public string NombreFallecido { get; set; }
        //public string ApePaFallecido { get; set; }
        //public string ApeMaFallecido { get; set; }
        public string ServiceConcept { get; set; }
        public string TipoPago { get; set; }
        public string VoucherKey { get; set; }
        public string PersonaDescontar { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PeriodsPayment { get; set; }
        public decimal AbonoCatorcenalMensual { get; set; }
        public string Comments { get; set; }
        //public string UserInsert { get; set; }
        //public string UserUpdate { get; set; }
        //public DateTime? DateInsert { get; set; }
        //public DateTime? DateUpdate { get; set; }

        public virtual TbEmployee Employee { get; set; }
        public virtual ICollection<TbFuneralExpenses> FuneralExpenses { get; set; }
    }
}
