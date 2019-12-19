using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seccion.Model.TblModels;
using System;

namespace Seccion.Data.Configuration
{
    public class TbEmployeeConfiguration : BaseEntityTypeConfiguration<TbEmployee>
    {
        public override void Configure(EntityTypeBuilder<TbEmployee> builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(TbEmployee));
            builder.HasKey(x => x.EmployeeID);
            base.Configure(builder);
        }
    }
}
