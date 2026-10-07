using CoreLayer.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Data.Configurations
{
    public class BaseConfigurations<Tkey,TEntity>  //:IEntityTypeConfig<BaseEntity>
        where TEntity : BaseEntity<Tkey>
    {
        //public void Configure(EntityTypeBuilder<TEntity> builder)
        //{
        //    builder.Property(x => x.CreatedAt)
        //        .HasDefaultValueSql("GETDATE()");
        //}
    }
}
