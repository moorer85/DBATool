using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBATool.Data;
using DBATool.Models.Server;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DBATool.Controllers
{
    public class ServerController : Controller
    {
        private readonly IServer __serverService;

        public ServerController(IServer serverService)
        {
            __serverService = serverService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var allServers = __serverService.GetAll();

            var serverModels = allServers
                .Select(p => new ServerDetailModel
                {
                    Id = p.Id,
                    Name = p.Name ?? "No First Name Provided",
                    CpuCore = p.CpuCore,
                    CpuSpeed = p.CpuSpeed,
                    ImageUrl = p.ImageUrl,
                    Memory = p.Memory
                }).ToList();

            var model = new ServerIndexModel
            {
                Servers = serverModels
            };

            return View(model);
        }
    }
}
