using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCRUDVisualStudio2022.Models;

namespace MVCCRUDVisualStudio2022.Data
{
    public class MVCCRUDVisualStudio2022Context : DbContext
    {
        public MVCCRUDVisualStudio2022Context (DbContextOptions<MVCCRUDVisualStudio2022Context> options)
            : base(options)
        {
        }

        public DbSet<MVCCRUDVisualStudio2022.Models.Movie> Movie { get; set; }
    }
}
