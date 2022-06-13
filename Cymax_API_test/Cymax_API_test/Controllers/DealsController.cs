using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cymax_API_test.ApiConsumers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cymax_API_test.Controllers
{
    public class DealsController : Controller
    {
        private readonly Service1Consumer _service1Consumer;

        private readonly Service2Consumer _service2Consumer;

        private readonly Service3Consumer _service3Consumer;


        public DealsController(Service1Consumer svc1 , Service2Consumer svc2, Service3Consumer svc3)
        {
            _service1Consumer = svc1;
            _service2Consumer = svc2;
            _service3Consumer = svc3;
        }

        public async Task<int> getDeals(string src, string des, Double[] size)
        {
            List<int> response = new List<int>();
            response.Add(await _service1Consumer.getDeal(new Models.svc1DTO(src, des, size)));
            response.Add(await _service2Consumer.getDeal(new Models.svc2DTO(src, des, size)));
            response.Add(await _service3Consumer.getDeal(new Models.svc3DTO(src, des, size)));

            return response.Min();
        }
    }
}

