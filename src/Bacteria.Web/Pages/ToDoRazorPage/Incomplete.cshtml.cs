﻿using Bacteria.Core.Entities;
using Bacteria.Core.Specifications;
using Bacteria.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bacteria.Web.Pages.ToDoRazorPage
{
    public class IncompleteModel : PageModel
    {
        private readonly IRepository _repository;

        public List<ToDoItem> ToDoItems { get; set; }

        public IncompleteModel(IRepository repository)
        {
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            var spec = new IncompleteItemsSpecification();

            ToDoItems = await _repository.ListAsync(spec);
        }
    }
}
