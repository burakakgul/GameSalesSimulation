using System;

namespace OyunSimulasyonOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Gereksinimler

            *1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, 
            //kayıtlarını silebileceği bir ortamı simule ediniz.Müşteri bilgilerinin 
            //doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. 
            //(E - devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.
            //Bunu yapacak servisi simule etmeniz yeterlidir.)

            *2.Oyun satışı yapılabilecek satış ortamını simule ediniz.
            *(Yapılan satışlar oyuncu ile ilişkilendirilmelidir. 
            *Oyuncunun parametre olarak metotta olmasını kastediyorum.)

            *3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi 
            *imkanlarını simule ediniz.

            *4.Satışlarda kampanya entegrasyonunu simule ediniz.*/

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                IdentityNumber = 12345678910
            });


        }
    }
}
