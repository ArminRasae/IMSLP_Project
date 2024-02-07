using System;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.Models.BaseEntities
{
    public class BaseEntity
    {
        #region properties

        [Key]
        public long Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        #endregion
    }
}
