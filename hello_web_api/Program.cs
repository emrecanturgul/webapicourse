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

            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.Run();
        }
    }
}