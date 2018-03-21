using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryData;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class BranchController : Controller
    {
        private ILibraryBranch _branch;

        public BranchController(ILibraryBranch branch)
        {
            _branch = branch;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}