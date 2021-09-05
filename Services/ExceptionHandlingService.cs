using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerryFinder.Services
{
    public class ExceptionHandlingService
    {
        public async Task HandleExceptionAsync(Exception ex)
        {
            if (ex == null)
                return;

            Console.WriteLine(ex.Message);
            await Task.CompletedTask;
        }
    }
}
