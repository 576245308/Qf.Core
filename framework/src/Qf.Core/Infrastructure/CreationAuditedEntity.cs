﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Qf.Core.Infrastructure
{
    /// <summary>
    /// This class can be used to simplify implementing <see cref="T:Volo.Abp.Auditing.ICreationAuditedObject" /> for an entity.
    /// </summary>
    public abstract class CreationAuditedEntity : Entity
    {
        /// <inheritdoc />
        public virtual DateTime CreationTime { get; set; }

        /// <inheritdoc />
        public virtual Guid? CreatorId { get; set; }
    }

    /// <summary>
    /// This class can be used to simplify implementing <see cref="ICreationAuditedObject"/> for an entity.
    /// </summary>
    /// <typeparam name="TKey">Type of the primary key of the entity</typeparam>
    public abstract class CreationAuditedEntity<TKey> : Entity<TKey>
    {
        /// <inheritdoc />
        public virtual DateTime CreationTime { get; set; }

        /// <inheritdoc />
        public virtual Guid? CreatorId { get; set; }

        protected CreationAuditedEntity()
        {

        }

        protected CreationAuditedEntity(TKey id)
            : base(id)
        {

        }
    }
}
