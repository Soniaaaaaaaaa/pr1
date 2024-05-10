using Core;
using Microsoft.EntityFrameworkCore;
internal class Database{
    public static void  Migrate(WebApplication app){
        using (var container = app.Services.CreateScope()){
            var dbContext = container.ServiceProvider.GetService<CoreDbContext>();
            var pendingMigration =  dbContext!.Database.GetPendingMigrations();
            if(pendingMigration.Any()){
                dbContext.Database.Migrate();
            }
        }
    }
}