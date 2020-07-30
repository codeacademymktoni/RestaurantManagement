using RestorantManagement.Models;
using RestorantManagement.Repositories.Interfaces;
using RestorantManagement.Services.Interfaces;
using RestorantManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Services
{
    public class TableService: ITableService
    {
        private readonly ITableRepository tableRepository;
        private readonly IProductRepository productRepository;

        public TableService(ITableRepository tableRepository, IProductRepository productRepository)
        {
            this.tableRepository = tableRepository;
            this.productRepository = productRepository;
        }

        public void Close(int tableId)
        {
            var table = tableRepository.GetById(tableId);

            if (table != null)
            {
                table.IsTaken = false;

                var openReceipt = table.Receipts.FirstOrDefault(x => x.DateClosed == null);

                openReceipt.DateClosed = DateTime.Now;

                tableRepository.Update(table);
            }
        }

        public List<Table> GetAll()
        {
            return tableRepository.GetAll();
        }

        public Table GetById(int tableId)
        {
            return tableRepository.GetById(tableId);
        }

        public void TakeTable(int tableId)
        {
            var table = tableRepository.GetById(tableId);
            if (table != null)
            {
                table.IsTaken = true;

                var receipt = new Receipt();

                receipt.TableId = table.Id;
                receipt.DateCreated = DateTime.Now;

                table.Receipts.Add(receipt);

                tableRepository.Update(table);
            }
        }

        public void AddProductsToTable(int tableId, List<AddToTableProductViewModel> products)
        {
            var productsDB = productRepository.GetAll();
            var table = tableRepository.GetById(tableId);
            var openReceipt = table.Receipts.FirstOrDefault(x => x.DateClosed == null);
            var updatedProducts = new List<Product>();

            foreach (var product in products)
            {
                var currentProduct = productsDB.FirstOrDefault(x => x.Id == product.Id);
                currentProduct.Quantity -= product.Quantity;

                openReceipt.ProductReceipts.Add(new ProductReceipt()
                {
                    ProductId = product.Id,
                    ReceiptId = openReceipt.Id,
                    Quantity = product.Quantity,
                    Price = currentProduct.Price
                });

                updatedProducts.Add(currentProduct);
            }

            productRepository.Update(updatedProducts);
            tableRepository.Update(table);
        }
    }
}
