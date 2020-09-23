using Bacteria.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bacteria.Core.Interfaces
{
	public class ExperimentResult
	{
		public ICollection<BacteriaScore> Scores { get; set; } = new List<BacteriaScore>();
		public ICollection<Test> NextTests { get; set; } = new List<Test>();
	}
}
