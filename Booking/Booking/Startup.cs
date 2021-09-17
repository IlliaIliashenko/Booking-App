using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.BLL.Permission;
using Booking.BLL.Policy;
using Booking.BLL.Services.Authentication;
using Booking.BLL.Services.Authentication.Interfaces;
using Booking.Configuration;
using Booking.DAL.Data;
using Booking.DAL.Models.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Booking
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookingContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultBookingConnection")));

            services.AddIdentity<UserEntity, RoleEntity>(options =>
                {
                    options.Password.RequiredLength = 6;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireDigit = false;
                })
                .AddEntityFrameworkStores<BookingContext>();

            services.AddCors(options => options.AddDefaultPolicy(builder =>
                builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin()));
                    //.AllowCredentials()));
            //.WithOrigins("http://localhost:3000")

            services.AddScoped<ITokenBuilder, TokenBuilder>();
            services.AddScoped<ITokenDecoder, TokenDecoder>();
            services.AddScoped<ISignInManager, IdentitySignInManager>();
            services.AddScoped<IUserManager, IdentityUserManager>();
            services.AddScoped<IAuthOption, AuthOption>();


            services.AddAutoMapper(AutoMapperConfiguration.GetAutoMapperProfilesFromAllAssemblies().ToArray());
            services.AddControllers();

            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    AuthOption authOptions = new AuthOption(Configuration);

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = authOptions.Issuer,
                        ValidateAudience = true,
                        ValidAudience = authOptions.Audience,
                        ValidateLifetime = true,
                        IssuerSigningKey = authOptions.SymmetricKey,
                        ValidateIssuerSigningKey = true
                    };
                });

            services.AddAuthorization(options => 
                options.AddPolicy(PolicyTypes.Users.View,
                    policy => { policy.RequireClaim(CustomClaimTypes.Permission, UserPermissions.View);})
            );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Booking", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Booking v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
