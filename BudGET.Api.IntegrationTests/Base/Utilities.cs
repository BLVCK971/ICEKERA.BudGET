using BudGET.Domain.Entities;
using BudGET.Persistence;

namespace BudGET.Api.IntegrationTests.Base
{
    public class Utilities
    {
        public static void InitializeDbForTests(BudGETDbContext context)
        {
            var bitchesGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var eatingGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            var drugsGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");
            var fightClubGuid = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EE9}");

            context.Budgets.Add(new Budget
            {
                Id = bitchesGuid,
                Nom = "Bitches",
                Montant = 250,
                Exception = false
            });

            context.Budgets.Add(new Budget
            {
                Id = eatingGuid,
                Nom = "Eating",
                Montant = 90,
                Exception = false
            });

            context.Budgets.Add(new Budget
            {
                Id = drugsGuid,
                Nom = "Drugs",
                Montant = 500,
                Exception = false
            });

            context.Budgets.Add(new Budget
            {
                Id = fightClubGuid,
                Nom = "Fight Club",
                Montant = 35.99,
                Exception = false
            });

            context.SaveChanges();
        }
    }
}
