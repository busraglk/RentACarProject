﻿using System;
using System.Collections.Generic;
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


        public static string AddedRental = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";

    }
}
