using Data.Entity;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GvResourceContext context;
        private IUnitOfWork unitOfWork;
        public UnitOfWork(GvResourceContext context)
        {
            this.context = context;
            #region Phân vùng IRepository theo Context
            Employee = new Repository<Employee>(context);
            MerchandiseGroup = new Repository<MerchandiseGroup>(context);
            Merchandise = new Repository<Merchandise>(context);
            ExportBillDetail = new Repository<ExportBillDetail>(context);
            ShipmentLocation = new Repository<ShipmentLocation>(context);
            Supplier = new Repository<Supplier>(context);
            ExportBill = new Repository<ExportBill>(context);
            ImportBill = new Repository<ImportBill>(context);
            StoreHouse = new Repository<StoreHouse>(context);
            Shipment = new Repository<Shipment>(context);
            #endregion
        }

        #region Phân vùng IRepository theo Model
        public IRepository<Employee> Employee { get; }
        public IRepository<MerchandiseGroup> MerchandiseGroup { get; }
        public IRepository<Merchandise> Merchandise { get; }
        public IRepository<ExportBillDetail> ExportBillDetail { get; }
        public IRepository<ImportBillDetail> ImportBillDetail { get; }
        public IRepository<ShipmentLocation> ShipmentLocation { get; }
        public IRepository<Supplier> Supplier { get; }
        public IRepository<ExportBill> ExportBill { get; }
        public IRepository<ImportBill> ImportBill { get; }
        public IRepository<StoreHouse> StoreHouse { get; }
        public IRepository<Shipment> Shipment { get; }
        #endregion

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
