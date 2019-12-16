using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T.Domain
{
    public class ClassHistory
    {
        public int Id { get; set; }

        public string ClassName { get; set; }

        public bool IsDelete { get; set; }

        #region Reference

        public int StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        #endregion
    }
}
