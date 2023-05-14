using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Error
{
    public class ErrorResponse
    {
        public List<string> DataValidationErrors { get; set; }

        public ErrorResponse()
        {
            DataValidationErrors = new List<string>();
        }
    }
}
