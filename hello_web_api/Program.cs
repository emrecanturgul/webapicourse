namespace hello_web_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            //service(container)
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer(); //service controlleri keþfetmesini istedik 
            builder.Services.AddSwaggerGen(); 
            //service kayýtlarýmý tamamladým 
            //model controller view olmalý model de sql ile baðlantýlý olmalý
            //ýýs expresste çalýþmadý bu konfigürasyon launchsettingste launc url le ayarlamýþtýk 
            var app = builder.Build();
            if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers(); 
            
            app.Run();
        }
    }
}