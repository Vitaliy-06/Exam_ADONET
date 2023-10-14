using Exam_ADONET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_ADONET.Configuration
{
	public class SpjConfiguration : IEntityTypeConfiguration<SupplierPartProject>
	{
		public void Configure(EntityTypeBuilder<SupplierPartProject> builder)
		{
			builder.HasKey(x => new { x.SupplierId, x.ProjectId, x.PartId, x.Id });
		}
	}
}

