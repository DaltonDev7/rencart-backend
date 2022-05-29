using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using rencart.Context;
using rencart.Interfaces;
using rencart.Interfaces.Services;
using rencart.Repositories.Generico;
using rencart.Repositories.Repository;
using rencart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rencart
{
    public class Startup
    {
        private readonly string corsPolicy = "_defaultCorsPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // create cors policy

            services.AddControllers();

            services.AddMvc(setupAction =>
            {
                setupAction.EnableEndpointRouting = false;
            }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;


            }).ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;

            })
          .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "rencart", Version = "v1" });
            });

            services.AddCors(opts =>
            {
                opts.AddPolicy(name: corsPolicy, b =>
                {
                    b
                    //.AllowAnyOrigin()
                    .WithOrigins(new string[] { "http://localhost:4200", "http://localhost:5001", "http://localhost/angulartest" })
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                    // .AllowCredentials();
                });
            });

            services.AddDbContext<RencarDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("RencarDB")));




            services.AddTransient<IUnityOfWork, UnityOfWork>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IModeloRepository, ModeloRepository>();
            services.AddTransient<ITipoVehiculoRepository, TipoVehiculoRepository>();
            services.AddTransient<ITipoCombustibleRepository, TipoCombustibleRepository>();
            services.AddTransient<IVehiculoRepository, VehiculoRepository>();
            services.AddTransient<ITipoPersonaRepository, TipoPersonaRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();

            services.AddScoped<IComboxService, ComboxService>();
            services.AddScoped<IInspeccionService, InspeccionService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "rencart v1"));
            }

        
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(corsPolicy);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
