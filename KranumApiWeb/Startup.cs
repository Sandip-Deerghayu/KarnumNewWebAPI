using MediatR;
using KranumApiWeb.Middleware;
using KranumCore.BlobHandler;
using KranumCore.Security;
using KranumDataAccess.Model;
using KranumDataAccess.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using KranumCore.Mediator.Event;
using AutoMapper;
using KranumCore.AutoMapperProfile;
//using MediatR;
using System;
using KranumDataAccess.Models;

namespace KranumApiWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EventProfile));
            services.AddControllers(options =>
            {
                var policy = new AuthorizationPolicyBuilder(new[] { JwtBearerDefaults.AuthenticationScheme })
                             .RequireAuthenticatedUser().Build();
                //options.Filters.Add(new AuthorizeFilter(policy));
            });
            //.SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //services.AddControllers().AddJsonOptions(options =>
            //{
            //    options.UseCamelCasing(true);
            //});

            var connectionString = Configuration.GetConnectionString("KranumConnection");
            services.AddDbContext<RelyfyDotNetStagingContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseSqlServer(connectionString);
            });
            services.AddTransient<RelyfyDotNetStagingContext>();
           

            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Kranum API",
                    Description = "Kranum API",
                    Version = "v1"
                });

                //options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                //{
                //    Name = "Authorization",
                //    Type = SecuritySchemeType.ApiKey,
                //    Scheme = "Bearer",
                //    BearerFormat = "JWT",
                //    In = ParameterLocation.Header,
                //    Description = "JWT Authorization header using the Bearer scheme",
                //});

                //options.AddSecurityRequirement(new OpenApiSecurityRequirement
                //{
                //    {
                //        new OpenApiSecurityScheme
                //        {
                //            Reference = new OpenApiReference
                //            {
                //                Type = ReferenceType.SecurityScheme,
                //                Id = "Bearer"
                //            }
                //        },
                //        new string[] {}
                //    }
                //});
            });

            services.AddSignalR();
            
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed((_) => true)
                    .AllowCredentials()
                    );
            });


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SuPEr SeCrET KeY"));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateAudience = false,
                    ValidateIssuer = false
                }) ;

            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            services.AddMediatR(typeof(GetEvents));
            // services.AddMediatR(typeof(CreateUser));

            //services.AddScoped<ClientRepository>();
            //services.AddScoped<UserRepository>();
            //services.AddScoped<SponsorChatRepository>();
            //services.AddScoped<EventRepository>();
            //services.AddScoped<SessionRepository>();
            //services.AddScoped<ResourceRepository>();
            //services.AddScoped<EventResourceRepository>();
            //ervices.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
            //services.AddSingleton(provider => new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile(new SourceMappingProfile(provider.CreateScope().ServiceProvider.GetService<IUnitOfWork>()));
            //}).CreateMapper());
            services.AddMemoryCache();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBlobManager, BlobManager>();
            
            //  services.AddScoped<ICreateUserActivityPoint, CreateUserActivityPoint>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            var scope = app.ApplicationServices.CreateScope();
            var service = scope.ServiceProvider.GetService<IUnitOfWork>();
            app.UseMiddleware<ErrorHandlingMiddleware>(service);
            app.UseCors("CorsPolicy");
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Kranum API");
            });


            app.UseEndpoints(endpoints =>
            {
               // endpoints.MapHub<MessageHub>("/messagehub");
                endpoints.MapControllers();
            });
        }
    }
}
