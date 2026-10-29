using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Web.Data.Repositories
{
    public class KoffieRepo : GenericRepo<Koffie>, IKoffieRepo
    {
        public KoffieRepo(CoffeeShopDbContext context) : base(context)
        {
            
        }
        public async Task<List<Koffie>> GetByName(string zoekWaarde)
        {
            List<Koffie> koffies = await _context.Koffies
                                                .Where(x => x.Naam == zoekWaarde)
                                                .ToListAsync();
            return koffies;
        }

        public async Task<Koffie> GetKoffieDetailAsync(int id)
        {
            Koffie koffie = await _context.Koffies
                                        .Include(x => x.IngredientenInKoffie)
                                            .ThenInclude(x => x.Ingredient)
                                                .ThenInclude(x => x.Categorie)
                                        .Where(x => x.Id == id)
                                        .FirstOrDefaultAsync();
            return koffie;
        }
    }
}
