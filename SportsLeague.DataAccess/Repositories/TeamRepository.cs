using Microsoft.EntityFrameworkCore;

using SportsLeague.DataAccess.Context;

using SportsLeague.Domain.Entities;

using SportsLeague.Domain.Interfaces.Repositories;


namespace SportsLeague.DataAccess.Repositories;


public class TeamRepository : GenericRepository<Team>, ITeamRepository

{

    public TeamRepository(LeagueDbContext context) : base(context)

    {

    }


    public async Task<Team?> GetByNameAsync(string name)//aqui devolvemos un objeto de tipo team

    {

        return await _dbSet

        .FirstOrDefaultAsync(t => t.Name.ToLower() == name.ToLower());

    }


    public async Task<IEnumerable<Team>> GetByCityAsync(string city)//con este método devolvemos una lista de tipo team, una colección de los teams por ciudad

    {

        return await _dbSet

        .Where(t => t.City.ToLower() == city.ToLower())

        .ToListAsync();

    }

}