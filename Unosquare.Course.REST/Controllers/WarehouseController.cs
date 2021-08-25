using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unosquare.Course.REST.Models;

namespace Unosquare.Course.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController : Controller
    {

        //localhost:8080/api/warehouse/warehouse
        [HttpGet("Warehouses")]
        public IActionResult GetWarehouse([FromServices] IWarehouseService _warehouseService)
        {

            //return Ok(_warehouseService.GetWarehouses());
            return Ok();
        }

        //localhost:8080/api/warehouse/warehouseFromQuery
        //By default query string its being used
        //[Querystring] = localhost:8080/api/warehouse/warehouseFromQuery?warehouseId=1&warehouseName=CarlosWarehouse
        [HttpGet("WarehouseFromQuery")]
        public IActionResult GetWarehouseFromQuery([FromQuery] int warehouseId, [FromQuery] string warehouseName)
        {
            return Ok($"Warehouse id {warehouseId} - {warehouseName}");
        }

        [HttpGet("WarehouseFromRoute/{warehouseId}/{warehouseName}")]
        public IActionResult GetWarehouseFromRoute([FromRoute] int warehouseId, [FromRoute] string warehouseName)
        {
            return Ok($"Warehouse id {warehouseId} - {warehouseName}");
        }

        [HttpPost("Warehouse")]
        public IActionResult CreateWarehouse([FromBody] Warehouse warehouse)
        {
            return Ok($"Warehouse id {warehouse.Id} - {warehouse.Name}");
        }

    }
}
