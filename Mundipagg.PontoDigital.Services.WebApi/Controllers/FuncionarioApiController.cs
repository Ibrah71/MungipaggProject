using Mundipagg.PontoDigital.Aplication.Interfaces;
using Mundipagg.PontoDigital.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Mundipagg.PontoDigital.Services.WebApi.Controllers
{
    public class FuncionarioApiController : ApiController
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioApiController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        // GET: api/FuncionarioApi
        public List<FuncionarioViewModel> Get()
        {
            return _funcionarioService.GetAll();
        }

        // GET: api/FuncionarioApi/5
        [ResponseType(typeof(FuncionarioViewModel))]
        public IHttpActionResult Get(double id)
        {

            try
            {

                var funcionario = _funcionarioService.GetByCardId(id);
                return Ok(funcionario);
            }
            catch ( Exception)
            {
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Funcionario não localizado."));
            }     
            

          
        }

        // POST: api/FuncionarioApi
        [ResponseType(typeof(FuncionarioViewModel))]
        public IHttpActionResult PostFuncionario(FuncionarioViewModel funcionario)
        {
            if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

            else
                {
                    _funcionarioService.Add(funcionario);
                return CreatedAtRoute("DefaultApi", new { id = funcionario.CardId }, funcionario);
            }

            
        }

        // PUT: api/FuncionarioApi/5
        public IHttpActionResult Put(double id, [FromBody]FuncionarioViewModel funcionario)
        {
            FuncionarioViewModel funcionarioBase = _funcionarioService.GetByCardId(id);

            if (funcionarioBase != null)

                {
                    funcionarioBase.Nome = funcionario.Nome;
               

                _funcionarioService.Update(funcionarioBase);

                    return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
                }

            else
                {
                    return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Funcionario não localizado para alteração."));
                }
        }

        // DELETE: api/FuncionarioApi/5

        [ResponseType(typeof(FuncionarioViewModel))]

       public IHttpActionResult DeleteFuncionario(double id)
        {
            FuncionarioViewModel funcionario = _funcionarioService.GetByCardId(id);


            try
            {
                _funcionarioService.Remove(id);
                return Ok(id);
            }
            catch (Exception)
            {

                return NotFound();
            }         

                     
        }
    }
}
