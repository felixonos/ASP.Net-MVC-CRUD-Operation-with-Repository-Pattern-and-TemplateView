using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmtWallet.Web.Data;
using SmtWallet.Web.Data.Entities;
using SmtWallet.Web.Data.Repositories.Interfaces;

namespace SmtWallet.Web.Controllers
{
    public class ClientController: Controller
    {
        //private readonly ApplicationDbContext _dbContext;
        private readonly IRepository<Client, Guid> _clientRepository;

        public ClientController(IRepository<Client, Guid> clientRepository)
        //public ClientController(ApplicationDbContext dbContext)
        {
            //_dbContext = dbContext;
            _clientRepository = clientRepository;
        }
        public async Task<IActionResult> Index() 
        {
            //var clients = await _dbContext.Clients.ToListAsync();
            var clients = await _clientRepository.Get("");
            return View(clients); 
        }

        public IActionResult Create()
        {
            var model = new Client { BirthDate = DateTime.Now, Active = true}; 
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Client model)
        {
            if (ModelState.IsValid)
            {
               // _dbContext.Clients.Add(model);
               //await _dbContext.SaveChangesAsync(); 
               await _clientRepository.Add(model);  
                
                return RedirectToAction("Index", "Client");   
            }
           
            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            //var model = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);
            var model = await _clientRepository.Get(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Client model)
        {
            if (ModelState.IsValid)
            {
                //_dbContext.Clients.Update(model);
                //await _dbContext.SaveChangesAsync();
                await _clientRepository.Update(model);  

                return RedirectToAction("Index", "Client");
            }

            return View(model);
        }

        //[HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            //var model = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);
            //if (model != null)
            //{
            //    _dbContext.Clients.Remove(model);
            //    await _dbContext.SaveChangesAsync();
            //}
            await _clientRepository.Delete(id); 

            return RedirectToAction("Index", "Client");
        }
    }
}
