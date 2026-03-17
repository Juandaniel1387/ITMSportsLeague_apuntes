using SportsLeague.Domain.Entities;


namespace SportsLeague.Domain.Interfaces.Repositories;


public interface IPlayerRepository : IGenericRepository<Player>

{

    Task<IEnumerable<Player>> GetByTeamAsync(int teamId);// Obtiene todos los jugadores de un equipo específico

    Task<Player?> GetByTeamAndNumberAsync(int teamId, int number);// Obtiene un jugador específico por su número en un equipo

    Task<IEnumerable<Player>> GetAllWithTeamAsync();// Obtiene todos los jugadores de todos los equipos, es un select all

    Task<Player?> GetByIdWithTeamAsync(int id);// Obtiene un jugador específico por su ID junto con su información de equipo

}