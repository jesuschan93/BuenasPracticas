using AliExpress.Datos.Interfaces.Pedido;
using AliExpress.Datos.Pedido;
using Microsoft.Extensions.DependencyInjection;
namespace ContenedorDependencias
{
    public class ObjetoFactory
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IObtenedorDatosEnvio, ObtenedorDatosEnvioAereo>();
            var aa = new ServiceCollection();
        }
    }
}