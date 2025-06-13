namespace Abdul_Portfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Production-safe pipeline
            if (!app.Environment.IsDevelopment())
            {
                // Use a generic error handler route
                app.UseExceptionHandler("/Portfolio/Error");
                // Skip HSTS for now to avoid HTTPS complications
                // app.UseHsts();
            }

            // 🚫 Commented out HTTPS redirection to prevent site can't be reached error
            // app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Portfolio}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
