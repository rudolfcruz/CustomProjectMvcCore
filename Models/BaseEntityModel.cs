using System;

namespace Seccion.Model
{
    public abstract class BaseEntityModel
    {
        public DateTime? DateInsert { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string UserInsert { get; set; }
        public string UserUpdate { get; set; }
    }
}
