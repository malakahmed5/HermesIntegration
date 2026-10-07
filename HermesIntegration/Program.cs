
using HMS.Core.Contracts;

namespace HermesIntegration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            #region DI Container
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services.AddDbContext<HotelDbContext>(options =>
            //{
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //});
            //builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            //builder.Services.AddAutoMapper(options => options.AddMaps(typeof(ServiceAssemblyReference).Assembly));

            ////integration:
            //builder.Services.Configure<PaymobSettings>(
            //    builder.Configuration.GetSection("PaymobSettings"));

            //builder.Services.AddHttpClient<IPaymentServiceGateway, PaymobPaymentGateway>();
            //builder.Services.AddSingleton<IPaymentServiceGateway, PaymobPaymentGateway>();
            //builder.Services.AddScoped<IPaymentService, PaymentService>(); 
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
