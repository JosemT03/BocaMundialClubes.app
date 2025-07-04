﻿using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Repositories;
using BocaMundialClubesAPI.Services;
using BocaMundialClubesAPI.Data;
using Microsoft.EntityFrameworkCore;


namespace BocaMundialClubesAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddScoped<IPartidoRepository, PartidoRepository>();
            builder.Services.AddScoped<IPartidoService, PartidoService>();
            builder.Services.AddScoped<IEntradaRepository, EntradaRepository>();
            builder.Services.AddScoped<IEntradaService, EntradaService>();
            builder.Services.AddScoped<IVentaRepository, VentaRepository>();
            builder.Services.AddScoped<IVentaService, VentaService>();
            builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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







