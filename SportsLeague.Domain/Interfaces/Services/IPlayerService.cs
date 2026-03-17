using SportsLeague.Domain.Entities;


namespace SportsLeague.Domain.Interfaces.Services;


public interface IPlayerService

{

    Task<IEnumerable<Player>> GetAllAsync();//obtiene todos los jugadores

    Task<Player?> GetByIdAsync(int id);//obtiene un jugador específico por su ID    

    Task<IEnumerable<Player>> GetByTeamAsync(int teamId);//obtiene los jugadores por un equipo específico

    Task<Player> CreateAsync(Player player); // Crea un nuevo jugador

    Task UpdateAsync(int id, Player player); //Se pasa el id del jugador a actualizar y el objeto con los nuevos datos

    Task DeleteAsync(int id); // se pasa id de jugador a eliminar

}