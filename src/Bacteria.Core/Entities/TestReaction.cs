using Bacteria.Core.Events;
using Bacteria.SharedKernel;
using Bacteria.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace Bacteria.Core.Entities
{
	public class TestReaction : BaseEntity, IAggregateRoot
	{
		public virtual Test Test { get; set; }
		public virtual Bact Bacteria { get; set; }
		public TestResults Result { get; set; }
		[Description("Замечание о результате теста")]
		public string Note { get; set; }
	}
}
