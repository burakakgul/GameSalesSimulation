using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonOdev
{
    class CampaingManager : ICampaingService
    {
        public void CampaingAdd()
        {
            Console.WriteLine("Campaing Added");
        }

        public void CampaingDelete()
        {
            Console.WriteLine("Campaing Deleted");
        }

        public void CampaingUpdate()
        {
            Console.WriteLine("Campaing Updated");
        }
    }
}
