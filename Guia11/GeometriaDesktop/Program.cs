using GeometriaDesktop;
using GeometriaModels.DALs;
using GeometriaModels.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

    //host es el contenedor principal de la aplicación.
    var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        #region Registro de DALs
        services.AddSingleton<IFigurasDAL, FiguraListDAL>();
        #endregion

        #region Registro de services.
        services.AddSingleton <FigurasService>();
        #endregion


        #region Registro de las vistas
        services.AddTransient<Form1>();
        #endregion
    })
    .Build();

    ApplicationConfiguration.Initialize();
    var form = host.Services.GetRequiredService<Form1>();
    Application.Run(form);