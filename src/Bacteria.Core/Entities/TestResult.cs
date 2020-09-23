using Bacteria.Core.Events;
using Bacteria.SharedKernel;
using Bacteria.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Dynamic;

namespace Bacteria.Core.Entities
{
	public enum TestResults
	{
		POSITIVE_RESULT = 1,
		NEGATIVE_RESULT = -1,
		VARIABLE_RESULT = 0
	}
	public class TestResult : BaseEntity, IAggregateRoot
	{
		public virtual Test Test { get; set; }
		public TestResults Result { get; set; }
	}
}
