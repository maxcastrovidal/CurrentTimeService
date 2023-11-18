namespace CurrentTimeService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseHttpsRedirection();

            //Obtener uct..
            app.MapGet("/time/uct", () => Results.Ok(DateTime.UtcNow));

            app.Run();
        }
    }
}