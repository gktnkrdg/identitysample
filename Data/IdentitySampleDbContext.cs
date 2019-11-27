﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.Data
{
    public class IdentiySampleDbContext : IdentityDbContext
    {
        public IdentiySampleDbContext(DbContextOptions<IdentiySampleDbContext> options)
            : base(options)
        {
        }
    }
}
