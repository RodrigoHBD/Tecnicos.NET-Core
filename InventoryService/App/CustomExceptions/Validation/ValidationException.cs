using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.CustomExceptions
{
    public class ValidationException : CustomException
    {
        public override string Message
        {
            get
            {
                if (ReasonToBeInvalid.Length > 0)
                {
                    return $"Erro de validacao, o campo '{InvalidFieldName}' esta invalido. Motivo: '{ReasonToBeInvalid}'";
                }
                else
                {
                    return $"Erro de validacao, o campo '{InvalidFieldName}' esta invalido.";
                }
                
            }
        }

        private string InvalidFieldName { get; set; }

        private string ReasonToBeInvalid { get; set; }

        public ValidationException(string invalidField, string reason = "")
        {
            Type = "InvalidInputData";
            InvalidFieldName = invalidField;
            ReasonToBeInvalid = reason;
        }

    }
}
