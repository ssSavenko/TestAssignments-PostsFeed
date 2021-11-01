namespace TestAssigment.Models.DAL
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DbBase
    {
        private Guid id;
        [Key]
        public virtual Guid Id
        {
            get
            {
                id = id == Guid.Empty ? Guid.NewGuid() : id;
                return id;
            }
            set
            {
                id = value;
            }
        }
         
        private DateTime? createdOn;
        public virtual DateTime? CreatedOn
        {
            get
            {
                createdOn ??= DateTime.UtcNow;
                return createdOn.Value;
            }
            set => createdOn = value;
        }
    }
}