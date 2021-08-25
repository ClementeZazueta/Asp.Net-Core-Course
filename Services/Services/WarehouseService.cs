using Services.Contracts;
using System.Collections.Generic;
using Unosquare.Course.REST.Models;

namespace Services.Services
{
    public class WarehouseService : IWarehouseService
    {
        public bool CreateWarehouse()
        {
            throw new System.NotImplementedException();
        }

        public IList<Warehouse> GetWarehouses()
        {
            return new List<Warehouse>()
            {
                new Warehouse() {Id = 1, Name = "Carlos Warehouse"},
                new Warehouse() {Id = 2, Name = "Clemente Warehouse"},
                new Warehouse() {Id = 3, Name = "Zazueta Warehouse"}
            };
        } 
    }
}
