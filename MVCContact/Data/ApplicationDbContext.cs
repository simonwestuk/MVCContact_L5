using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCContact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCContact.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ContactModel> Contact { get; set; }

        public DbSet<MeetingModel> Meeting { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
