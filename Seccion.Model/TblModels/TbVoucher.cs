using System;

namespace Seccion.Model.TblModels
{
    public class TbVoucher : BaseEntityModel
    {
        public Guid VoucherID { get; set; }
        public Guid FuneralExpensesID { get; set; }
        public string NameVoucher { get; set; }
        //public DateTime? DateInsert { get; set; }
        //public DateTime? DateUpdate { get; set; }
        //public string UserInsert { get; set; }
        //public string UserUpdate { get; set; }
        public virtual TbFuneralExpenses FuneralExpenses { get; set; }
    }
}
