using Bacteria.Core.Events;
using Bacteria.SharedKernel;
using Bacteria.SharedKernel.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace Bacteria.Core.Entities
{
	public class Experiment : BaseEntity, IAggregateRoot
	{
		public string Name { get; set; }
		public virtual ICollection<TestResult> Results { get; set; } 
	}
}
