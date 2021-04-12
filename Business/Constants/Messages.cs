using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Concrete;
using Entities.Dtos;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserAdded = "Kullanıcı oluşturuldu";
        public static string CustomerAdded = "Müşteri oluşturuldu";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CarOnRent = "Araç kiradan dönmedi";
        public static string CarImagesReachedMaxNumberOfPhoto = "Maksimum resim sayısına ulaşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt edildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatası";
        public static string UserAlreadyExists = "Böyle bir kullanıcı mevcut";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı";
        public static string NoResultForThisFilter = "Bu filtre için sonuç dönmedi";
    }
}
