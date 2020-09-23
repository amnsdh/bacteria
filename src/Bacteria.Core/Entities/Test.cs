using Bacteria.Core.Events;
using Bacteria.SharedKernel;
using Bacteria.SharedKernel.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace Bacteria.Core.Entities
{
	public class Test : BaseEntity, IAggregateRoot
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public virtual ICollection<Test> SubTests { get; set; }
	}
}
