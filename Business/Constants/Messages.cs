using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid="Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Maksimum kategori listelendi";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez";
        public static string CategoryLimitExceded = "Kategoride limit aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır";
    }
}
