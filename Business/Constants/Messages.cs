using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product has been added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductsListed = "Urunler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 urun olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten baska bir urun var";
        public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni urun eklenemiyor";
        
    }
}
