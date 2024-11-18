namespace hello_web_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            //service(container)
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer(); //service controlleri ke�fetmesini istedik 
            builder.Services.AddSwaggerGen(); 
            //service kay�tlar�m� tamamlad�m 
            //model controller view olmal� model de sql ile ba�lant�l� olmal�
            //��s expresste �al��mad� bu konfig�rasyon launchsettingste launc url le ayarlam��t�k 
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