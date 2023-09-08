using MerchantPaymentServices.Models;

var builder = WebApplication.CreateBuilder(args);
string strConfigFile = "appsettings.json";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
AppConfigs.InitConfig(strConfigFile, app.Environment);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public static class AppConfigs
{
    private static string _AppsettingFile = "appsettings.json";
    public static IConfiguration? _configuration;
    public static IConfigurationSection? _ConfigInterapi;

    public static void InitConfig(string pConfigFileName, IWebHostEnvironment _Env)
    {
        if (!string.IsNullOrEmpty(pConfigFileName))
            _AppsettingFile = pConfigFileName;

        IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile(_AppsettingFile, true, true);
        _configuration = builder.Build();

//        Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(_configuration).CreateLogger();


        _ConfigInterapi = AppConfigs._configuration.GetSection("InterapiConfigs");
        // Database Connection strings 
    //    _ConfigDbConecctionStr = AppConfigs._configuration.GetSection("ConnectionStrings");
      //  DBConnectionConfigs.DefaultConnection = _ConfigDbConecctionStr.GetValue<string>("DefaultConnection");
       // DBConnectionConfigs.AuroraDBConnStr = _ConfigDbConecctionStr.GetValue<string>("AuroraDBConnStr");
        ///
        //
        
        InitInterapiConfigs();
    }
    public static void InitInterapiConfigs()
    {
        PaymentClientConfig.createMMPaymentURL = _ConfigInterapi.GetValue<string>("createMMPaymentURL");
        PaymentClientConfig.GetInvoiceURL = _ConfigInterapi.GetValue<string>("GetInvoiceURL");
        PaymentClientConfig.GetAccountProfileURL = _ConfigInterapi.GetValue<string>("GetAccountProfileURL");
        PaymentClientConfig.GetCustomerProfileURL = _ConfigInterapi.GetValue<string>("GetCustomerProfileURL");
    }
}