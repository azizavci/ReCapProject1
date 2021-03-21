using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.NorthwindConstants
{
    public class Messages
    {
        //CAR MESSAGES
        public static string CarAdded = "araba eklendi!";
        public static string CarDeleted = "araba silindi!";
        public static string CarUpdated = "araba güncellendi!";
        public static string CarNameInvalid = "araba ismi geçersiz!";
        public static string CarsListed="arabalar listelendi";

        //BRAND MESSAGES
        public static string BrandAdded = "marka eklendi!";
        public static string BrandDeleted = "marka silindi!";
        public static string BrandUpdated = "marka güncellendi!";
        public static string BrandNameInvalid = "marka ismi geçersiz!";
        public static string BrandsListed = "markalar listelendi";

        //COLOR MESSAGES
        public static string ColorAdded = "renk eklendi!";
        public static string ColorDeleted = "renk silindi!";
        public static string ColorUpdated = "renk güncellendi!";
        public static string ColorNameInvalid = "renk ismi geçersiz!";
        public static string ColorsListed = "renkler listelendi";

        //SYSTEM MESSAGES
        internal static string MaintenanceTime = "bakım zamanı";
        
    }
}
