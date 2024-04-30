using Handicap.Entities;
using Microsoft.EntityFrameworkCore;

namespace Handicap.Services;


public interface IRoundService
{
    public void addRound(Round round);
    public Task<List<Round>> getAllRounds();

    public Task<List<Round>> getLastXRounds(int count);

}

public class RoundService : IRoundService
{

    private AppDbContext _dbContext;

    
    public RoundService(AppDbContext dbContext)
    {
        this._dbContext = dbContext;
    }
    
    
    public void addRound(Round round)
    {
        this._dbContext.Rounds.Add(round);
        this._dbContext.SaveChangesAsync();
    }

    public Task<List<Round>> getAllRounds()
    {
        return this._dbContext.Rounds
            .OrderByDescending(r => r.date)
            .ToListAsync();
    }

    public Task<List<Round>> getLastXRounds(int count)
    {
        return this._dbContext.Rounds
            .OrderByDescending(r => r.date)
            .Take(count)
            .ToListAsync();
    }
}