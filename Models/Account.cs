using System;
using System.Collections.Generic;

namespace Accounting.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Sum { get; set; }
        public string Category { get; set; } = null!;
        public string? Comment { get; set; }
        public bool Transaction { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
