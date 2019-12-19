using System;

namespace Seccion.Model.TblModels
{
    public class TbRequest : BaseEntityModel
    {
        public Guid RquestID { get; set; }
        public Guid EmployeeID { get; set; }
        //public string FichaEmpSolicitud { get; set; }        
        public DateTime DateCreateRequest { get; set; }
        public string RequestNumber { get; set; }
        public decimal Amount { get; set; }
        public string PaymentsPeriod { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal AdministrationExpenses { get; set; }
        public decimal AdministrationExpensesResult { get; set; }
        public string AdditionalMonths { get; set; }
        public decimal TotalPay { get; set; }
        public string AbonoCatorcenalMensual { get; set; }
        public string CatorcenaLiquidate { get; set; }
        public string BelongingSection { get; set; }
        public DateTime? NextRise { get; set; }
        public string AvalName { get; set; }
        public int? AvalKey { get; set; }
        public string DebtAval { get; set; }
        public string Comments { get; set; }
        //public byte? Status { get; set; }
        //public DateTime? DateInsert { get; set; }
        //public DateTime? DateUpdate { get; set; }
        //public string UserInsert { get; set; }
        //public string UserUpdate { get; set; }

        public virtual TbEmployee Employee { get; set; }
    }
}
