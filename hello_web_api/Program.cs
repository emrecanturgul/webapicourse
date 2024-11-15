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

            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.Run();
        }
    }
}