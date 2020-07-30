using RestorantManagement.Models;
using RestorantManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestorantManagement.Helper
{
    public static class ModelConverter
    {
        public static TableViewModel ToTableOverview(this Table table)
        {
            return new TableViewModel
            {
                TableName = table.TableName,
                Id = table.Id,
                IsTaken = table.IsTaken
            };
        }

        public static TableDetailsViewModel ToTableDetails(this Table table)
        {
            var model = new TableDetailsViewModel();

            model.Id = table.Id;
            model.TableName = table.TableName;

            var openReceipt = table.Receipts.FirstOrDefault(x => !x.DateClosed.HasValue);

            if (openReceipt != null)
            {
                model.Products = openReceipt.ProductReceipts.Select(x => x.ToProductReceiptViewModel()).ToList();
            }
            else
            {
                model.Products = new List<ProductReceiptViewModel>();
            }

            return model;
        }

        public static ProductReceiptViewModel ToProductReceiptViewModel(this ProductReceipt receipt)
        {
            return new ProductReceiptViewModel
            {
                Id = receipt.Id,
                Name = receipt.Product.Name,
                Price = receipt.Price,
                Quantity = receipt.Quantity
            };
        }

        public static ProductViewModel ToProductViewModel(this Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }

    }
}
