using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        /// <summary>
        /// Продукты
        /// </summary>
        public IEnumerable<Product> Products { get; set; }

        /// <summary>
        /// Инф-я о страницах для генерации ссылок
        /// </summary>
        public PagingInfo PagingInfo { get; set; }
    }
}