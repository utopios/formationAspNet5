using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanqueWeb.Controllers
{
    public class AccountController : Controller
    {

        private IRepository<Account> _accountRepository;

        public AccountController(IRepository<Account> repository)
        {
            _accountRepository = repository;
        }
        public IActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View(_accountRepository.FindAll());
        }

        public IActionResult FormAccount()
        {
            return View("Formulaire");
        }

        [HttpPost]
        public IActionResult SubmitAccount([Bind("FirstName, LastName, Phone")] Customer customer, [Bind("Amount")] Account account)
        {
            account.Customers.Add(customer);
            string message = "";
            if(account.Amount > 0 && _accountRepository.Create(account))
            {
                message = "Compte ajouté, numéro : " + account.UniqNumber;
                return RedirectToAction("Index", new { message = message });
            }
            else
            {
                message = "Erreur d'ajout compte";
                ViewBag.Message = message;
            }
            return View("Formulaire");
        }


        public IActionResult FormOperation(int id, string type)
        {
            Account account = _accountRepository.Find(id);
            if(account != null)
            {
                ViewBag.type = type;
                return View(account);
            }
            else
            {
                string message = "Aucun compte avec cet id";
                return RedirectToAction("Index", new { message = message });
            }
        }

        public IActionResult SubmitOperation(int id, string type, Operation operation)
        {
            Account account = _accountRepository.Find(id);
            if(type == "retrait")
            {
                operation.Amount *= -1;
            }
            string message = "";
            if(account != null)
            {
                account.Operations.Add(operation);
                account.Amount += operation.Amount;
                _accountRepository.Update();
                message = "opération executé";
            }
            else
            {
                message = "Erreur compte";
            }
            return RedirectToAction("Index", new { message = message });

        }
    }
}