using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda!";

        public static string AddedBrand = "Marka başarıyla eklendi.";
        public static string DeletedBrand = "Marka başarıyla silindi.";
        public static string UpdatedBrand = "Marka başarıyla güncellendi.";
        public static string FailedBrandAddOrUpdate = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";
        public static string ListedCars = "Arabalar listelendi";

        public static string AddedCar = "Araba başarıyla eklendi.";
        public static string DeletedCar = "Araba başarıyla silindi.";
        public static string UpdatedCar = "Araba başarıyla güncellendi.";
        public static string FailedCarAddOrUpdate = "Araba güncellenemedi! Lütfen günlük araç kiralama fiyatının 0'dan büyük olduğuna ya da isim uzunluğunun iki karakterden fazla olmasına dikkat ediniz.";

        public static string AddedColor = "Renk başarıyla eklendi.";
        public static string DeletedColor = "Renk başarıyla silindi.";
        public static string UpdatedColor = "Renk başarıyla güncellendi.";

        public static string AddedCustomer = "Müşteri başarıyla eklendi.";
        public static string DeletedCustomer = "Müşteri başarıyla silindi.";
        public static string UpdatedCustomer = "Müşteri başarıyla güncellendi.";


        public static string AddedUser = "Kullanıcı başarıyla eklendi.";
        public static string DeletedUser = "Kullanıcı başarıyla silindi.";
        public static string UpdatedUser = "Kullanıcı başarıyla güncellendi.";
        public static string ListedUsers = "Kullanıcılar listelendi";


        public static string AddedRental = "Araba Kiralama işlemi başarıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi silindi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
     

        public static string AddedCarImage = "Araba resmi eklendi.";
        public static string DeletedCarImage = "Araba resmi silindi";
        public static string UpdatedCarImage = "Araba resmi güncellendi.";
        public static string ImageFileNotExists = "Böyle bir dosya bulunamadı.";
        public static string MissmatchingFileExtension ="Uzantı türü .jpeg, .png veya .jpg olmalıdır.";
        public static string CarImageLimitExceeded = "Bir arabanın en fazla 5 resmi olabilir";
        public static string CarImageDateExceded = "Zamanlar eşleşmiyor.";
        public static string CarImagesDeleteExceded = "Resminiz silinmedi";
        public static string CarImagesUpdateExceded = "Resminiz güncellenemedi";


        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
