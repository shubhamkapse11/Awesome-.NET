namespace ProductApi
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            // injections
            var app = builder.Build();
            //pipeline
          app.MapGet("/", () => "Hello World!");

          app.Run();

        }
    }
}