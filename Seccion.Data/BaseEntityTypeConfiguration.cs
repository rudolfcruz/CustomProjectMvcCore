using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seccion.Model;
using System;

namespace Seccion.Data
{
    public abstract class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntityModel
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            //throw new NotImplementedException();
        }
    }
}
