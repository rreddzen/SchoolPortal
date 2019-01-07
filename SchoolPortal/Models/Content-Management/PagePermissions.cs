using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models.Content_Management
{
    public class PagePermissions
    {
        public Guid UserId { get; set; }

        public int PageId { get; set; }

        public bool IsAllowed { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Pages Pages { get; set; }
    }
}