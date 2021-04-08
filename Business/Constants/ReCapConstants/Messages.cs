using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.ReCapConstants
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

        //USER MESSAGES
        public static string UserAdded = "kullanıcı eklendi!";
        public static string UserDeleted = "kullanıcı silindi!";
        public static string UserUpdated = "kullanıcı güncellendi!";
        public static string UserNameInvalid = "kullanıcı ismi geçersiz!";
        public static string UsersListed = "kullanıcılar listelendi";

        //CUSTOMER MESSAGES
        public static string CustomerAdded = "müşteri eklendi!";
        public static string CustomerDeleted = "müşteri silindi!";
        public static string CustomerUpdated = "müşteri güncellendi!";
        public static string CustomerNameInvalid = "müşteri ismi geçersiz!";
        public static string CustomersListed = "müşteriler listelendi";

        //RENTAL MESSAGES
        public static string RentalAdded = "kira eklendi!";
        public static string RentalDeleted = "kira silindi!";
        public static string RentalUpdated = "kira güncellendi!";
        public static string RentalsListed = "kira geçmişi listelendi!";
        public static string RentalNotReturned = "araç teslim edilmedi!";



        //CAR IMAGES MESSAGES
        public static string CarImageAdded = "araba resmi eklendi!";
        public static string CarImageDeleted = "araba resmi silindi!";
        public static string CarImageNotDeleted = "araba resmi silinemedi!";
        public static string CarImageUpdated = "araba resmi güncellendi!";
        public static string CarImageNotFound = "araba resmi bulunamadı!";
        public static string CarNotFound = "araba bulunamadı";
        public static string CarImageCountLimitExceeded = "araba resmi limiti aşıldı!";



        //SYSTEM MESSAGES
        internal static string MaintenanceTime = "bakım zamanı!";
        internal static string IdError = "hatalı id girişi yaptnız!";
        
    }
}
