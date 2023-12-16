using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "ürün eklendi ";
        public static string CarNameInvalid = "ürün ismi geçersiz ";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "ürünler Listelendi ";


        public static string UserAdded = "ürün eklendi ";
        public static string UserNameInvalid = "ürün ismi geçersiz ";
      
        public static string UsersListed = "ürünler Listelendi ";
        public static string CarImagesListed= "fotoğraflar Listelendi";
        public static string CarUpdated="ürün güncellendi";
        public static string CarDeleted="ürün silindi";
        public static string? AuthorizationDenied="yetkilendirme reddedildi";
        public static string UserRegistered="yeniden düzenlendi";
        public static string UserNotFound= "kullanıcı bulunamadı";
        public static string PasswordError ="şifre hatası";
        public static string SuccessfulLogin="başarılı giriş ";
        public static string UserAlreadyExists="kullanıcı çoktan oluşturuldu";
        public static string AccessTokenCreated= "erişim belirteci yratıldı";
    }
}
