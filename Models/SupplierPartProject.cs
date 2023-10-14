using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_ADONET.Models
{
	public class SupplierPartProject
	{
		public int Id { get; set; }

		public int SupplierId { get; set; }
		public int PartId { get; set; }
		public int ProjectId { get; set; }
		public int QTY { get; set; }

		public Project Project { get; set; }
		public Part Part { get; set; }
		public Supplier Supplier { get; set; }
	}
}
