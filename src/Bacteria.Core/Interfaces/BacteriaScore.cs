using Bacteria.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bacteria.Core.Interfaces
{
	public class BacteriaScore
	{
		public Bact Bacteria { get; set; }
		public ICollection<TestResult> StandartResults { get; set; }
		public double Score { get; set; }
	}
}
