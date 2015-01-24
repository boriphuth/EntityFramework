﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Samples.Models
{
	public class MusicStoreDbContext : DbContext
	{
		public DbSet<Artist> Artists { get; set; }
		public DbSet<Album> Albums { get; set; }
	}
}