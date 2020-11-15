using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using tour.DataAccess.Internal;
using tour.DataAccess.SqlAccess;
using tour.Models;
using tour.Models.Entities;
using tour.Repository;
using tour.Repository.DiaDiem;
using tour.Repository.Gia;
using tour.Repository.Loai;
using tour.Repository.NhanVien;
using tour.Repository.Tour;
using tour.Repository.Doan;
using tour.Repository.ChiTiet;
using tour.Repository.Khachhang;
using tour.Repository.Nguoidi;
using tour.Repository.LoaiChiPhi;
using tour.Repository.ChiPhi;

namespace tour
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
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<Tour_DBContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddSingleton(Configuration);
            services.AddScoped<IDiaDiemRepo,DiaDiemRepository>();
            services.AddScoped<IGiaRepo,GiaRepository>();
            services.AddScoped<INhanVienRepo, NhanVienRepository>();
            services.AddScoped<ILoaiRepo, LoaiRepository>();
            services.AddScoped<IChiTietRepo, ChiTietRepository>();
            services.AddSingleton<IDataAccess, DataAccess.Internal.DataAccess>();
            services.AddScoped<IDoanAccess, DoanAccess>();
            services.AddScoped<ITourRepo, TourRepositoty>();
            services.AddScoped<ILoaiChiPhiRepo, LoaiChiPhiRepository>();
            services.AddScoped<Repository.Repository, Repository.Repository>();
            services.AddScoped<IChiPhiRepo, ChiPhiRepository>();
            // services.AddScoped<IDoanService, DoanService>();
            services.AddScoped<IDoanRepo, DoanRepository>();
            services.AddScoped<INguoidiRepo, NguoidiRepository>();
            services.AddScoped<IKhachhangRepo, KhachangRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
