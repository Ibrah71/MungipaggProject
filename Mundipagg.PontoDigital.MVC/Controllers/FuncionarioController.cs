using Mundipagg.PontoDigital.Aplication.Interfaces;
using Mundipagg.PontoDigital.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mundipagg.PontoDigital.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioController( IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionario = _funcionarioService.GetAll();
            return View(funcionario);
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(double id)
        {
            return View(_funcionarioService.GetByCardId(id));
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        public ActionResult Create(FuncionarioViewModel funcionario)
        {
            if (ModelState.IsValid)
            {
                if (_funcionarioService.Add(funcionario))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(funcionario);
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(double id)
        {
           
            return View(_funcionarioService.GetByCardId(id));
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult Edit( FuncionarioViewModel funcionario)
        {

          
                if (_funcionarioService.Update(funcionario))
                {
                    return RedirectToAction("Index");
                }
                  
                        

                return View(funcionario);
            
        }

              

        // get Livro/Delete/5
        public ActionResult Delete(double id)
        {
            var funcionario = _funcionarioService.GetByCardId(id);

            return View( funcionario);
        }

        // POST: Funcionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(double id)
        {
            
                _funcionarioService.Remove(id);

                return RedirectToAction("Index");           
                
            
        }
    }
}
