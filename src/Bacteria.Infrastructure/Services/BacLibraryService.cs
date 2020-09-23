using Bacteria.Core.Entities;
using Bacteria.Core.Interfaces;
using Bacteria.Infrastructure.Data;
using Bacteria.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacteria.Infrastructure.Services
{
	public class BacLibraryService : IBacLibraryService
	{
		private readonly AppDbContext _dbContext;
		public BacLibraryService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<ExperimentResult> GetExperimentResult(int experimentId)
		{
			ExperimentResult result = new ExperimentResult();
			var experiment = await _dbContext.Experiments.Include(x => x.Results).SingleOrDefaultAsync(x => x.Id == experimentId);
			if (experiment == null)
				return result;

			Dictionary<int, BacteriaScore> scores = new Dictionary<int, BacteriaScore>();
			foreach (var testResult in experiment.Results)
			{
				var bacterias =_dbContext.TestReactions
					.Where(x => x.Test.Id == testResult.Id && x.Result == testResult.Result)
					.Select(x => x.Bacteria);
				foreach(var bac in bacterias)
				{
					if (scores.ContainsKey(bac.Id))
					{
						bacterias[bac.Id] = 
					}
					else
					{

					}
				}
			}
			
			return result;
		}
	}
}
