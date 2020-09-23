using Bacteria.Core.Events;
using Bacteria.SharedKernel;
using Bacteria.SharedKernel.Interfaces;
using System.Dynamic;

namespace Bacteria.Core.Entities
{
	public class Bact : BaseEntity, IAggregateRoot
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }
	}
}
