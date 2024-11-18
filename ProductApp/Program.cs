namespace ProductApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //�nce service kayd� yap�l�r 
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddControllers();
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole(); 
            builder.Logging.AddDebug(); 
            


            var app = builder.Build();

            // Configure the HTTP request pipeline.
           //IIS express'e production dedim production da warning.
           //Project name de development modunda o da information
           //asppsettings dosyas�n� ortam de�i�kenlerine g�re ayr� ayr� d�zenleyebiliriz
           app.UseSwagger();
           app.UseSwaggerUI();
           
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}