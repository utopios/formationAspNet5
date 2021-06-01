using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanqueWeb.Controllers
{
    public class OperationController : Controller
    {
        private IRepository<Operation> _operationRepository;

        public OperationController(IRepository<Operation> repository)
        {
            _operationRepository = repository;
        }
        public IActionResult Index()
        {
            return View(_operationRepository.FindAll());
        }
    }
}