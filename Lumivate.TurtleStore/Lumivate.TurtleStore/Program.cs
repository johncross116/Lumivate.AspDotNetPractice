using Lumivate.TurtleStore.Data;
using Lumivate.TurtleStore.Services;
using Microsoft.EntityFrameworkCore;

namespace Lumivate.TurtleStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Register EF Core with SQLite
            builder.Services.AddDbContext<TurtleStoreContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Register application services with Dependency Injection
            builder.Services.AddSingleton<ITurtleService, TurtleService>();
            builder.Services.AddSingleton<ICartService, CartService>();
            builder.Services.AddSingleton<IOrderService, OrderService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
