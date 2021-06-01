using System;
using System.Threading.Tasks;
using BanqueRepositoryClass.Interface;
using BanqueRepositoryClass.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanqueWeb.ViewComponents
{
    [ViewComponent(Name = "customer")]
    public class CustomerViewComponent : ViewComponent
    {
        private readonly IRepository<Customer> _customerRepository;
        public CustomerViewComponent(IRepository<Customer> repository)
        {
            _customerRepository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_customerRepository.FindAll());
        }
    }
}
