using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamer = new GamerManager(new UserValidateManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                Name = "Coni",
                IdentityNo = 1234,
                BirthYear = 1980 
            };
            gamer.Add(gamer1);
        }
    }
}
