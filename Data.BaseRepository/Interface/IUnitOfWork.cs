using Data.Entity;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Employee> Employee { get; }
        IRepository<MerchandiseGroup> MerchandiseGroup { get; }
        IRepository<Merchandise> Merchandise { get; }
        IRepository<ExportBillDetail> ExportBillDetail { get; }
        IRepository<ImportBillDetail> ImportBillDetail { get; }
        IRepository<ShipmentLocation> ShipmentLocation { get; }
        IRepository<Supplier> Supplier { get; }
        IRepository<ExportBill> ExportBill { get; }
        IRepository<ImportBill> ImportBill { get; }
        IRepository<StoreHouse> StoreHouse { get; }
        IRepository<Shipment> Shipment { get; }
    }
}
