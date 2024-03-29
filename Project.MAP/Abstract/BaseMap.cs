﻿using Project.ENTITIES.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Abstract
{
    public abstract class BaseMap<T>: EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {

            Property(x => x.CreatedDate).HasColumnName("Olustuma Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Guncelleme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
