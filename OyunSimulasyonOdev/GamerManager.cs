using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonOdev
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("{0} gamer added", gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız..!");
            }


        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} gamer deleted", gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} gamer updated", gamer.FirstName);
        }
    }
}
