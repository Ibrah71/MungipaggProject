using Mundipagg.PontoDigital.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.PontoDigital.Application.Validations
{
   public  static class CardIdValidation
    {
        public static bool CardIdValidationStart(FuncionarioViewModel funcionario )
        {
           var convertion = Convert.ToString(funcionario.CardId);
          
            if (convertion.ToString().Length != 12)
                return false;

            else
                return true;
        }
    }
}
