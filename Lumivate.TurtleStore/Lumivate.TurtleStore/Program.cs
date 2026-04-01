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

            // TODO-checkpoint-3: Register the EF Core DbContext here
            // builder.Services.AddDbContext<TurtleStoreContext>(options =>
            //     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDbContext<Lumivate.TurtleStore.Data.TurtleStoreContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // TODO-checkpoint-4: Register your services for dependency injection here
            // builder.Services.AddScoped<ITurtleService, TurtleService>();
            // builder.Services.AddScoped<ICartService, CartService>();
            // builder.Services.AddScoped<IOrderService, OrderService>();

            builder.Services.AddScoped<Lumivate.TurtleStore.Services.ITurtleService, Lumivate.TurtleStore.Services.TurtleService>();
            builder.Services.AddScoped<Lumivate.TurtleStore.Services.ICartService, Lumivate.TurtleStore.Services.CartService>();
            builder.Services.AddScoped<Lumivate.TurtleStore.Services.IOrderService, Lumivate.TurtleStore.Services.OrderService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
