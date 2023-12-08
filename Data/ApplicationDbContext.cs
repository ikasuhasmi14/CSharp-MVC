
namespace MVCproject.Data;
using MVCproject.Models;
using Microsoft.EntityFrameworkCore;


public class ApplicationDbContext :DbContext {

public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
{

}

public DbSet<BooksEntity> Books {get;set;}
}