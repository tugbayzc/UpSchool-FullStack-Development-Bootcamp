using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Address> Addresses { get; set; } 
        DbSet<Category> Categories { get; set; }
        DbSet<Note> Notes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);//asenkron işlemi yarıda kesmeye yarar!
        int SaveChanges();//kaç kaydın etkilendiğini dönüyor int olarak!

    }
}