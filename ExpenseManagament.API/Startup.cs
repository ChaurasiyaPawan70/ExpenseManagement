using ExpenseManagament.BLL.Interface;
using ExpenseManagament.BLL.Services;
using ExpenseManagament.DAL.Data;
using ExpenseManagament.DAL.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManagament.API;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container
    public void ConfigureServices(IServiceCollection services)
    {

        services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("ConStr")));
        services.AddAutoMapper(typeof(MasterMapper));
        services.AddSwaggerGen();
        services.AddControllers();
        services.AddScoped<IMasterService, MasterService>();

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
    {
        loggerFactory.AddFile("Logs/mylog-{Date}.txt");
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseStaticFiles();
        app.UseSwagger();
        app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "ExpenseManagement API"));
        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();
        app.UseEndpoints(x => x.MapControllers());
    }
}