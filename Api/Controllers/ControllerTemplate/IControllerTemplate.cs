using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Services.ServiceContracts;

namespace WebApi.Controllers.Template
{
    public interface IControllerTemplate<T>
    {
        IDataService<T> service { get; }
        IActionResult Get();
        IActionResult Get(int id);
        IActionResult Update(T value);
        IActionResult Delete(int value);
    }
}
