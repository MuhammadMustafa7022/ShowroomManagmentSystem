using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.Models;
using ShowroomManagmentAPI.Models.Employee_Module;
using ShowroomManagmentAPI.Models.Marketing_Promotion_Module;
using ShowroomManagmentAPI.Models.Quality_Assurance_Module;
using ShowroomManagmentAPI.Models.Quality_xyz_Module;
using ShowroomManagmentAPI.Models.Sales_Managment_Module;
using ShowroomManagmentAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(x => 
x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<IDepartment, DepartmentModel>();
builder.Services.AddScoped<IRole, RoleModel>(); 
builder.Services.AddScoped<IEmployee, EmployeeModel>();
builder.Services.AddScoped<IAttendance, AttendanceModel>();
builder.Services.AddScoped<IVehicle, VehicleModel>();
builder.Services.AddScoped<IVehicleCategory, VehicleCategoryModel>();
builder.Services.AddScoped<ICustomer, CustomerModel>();
builder.Services.AddScoped<ICampaign, CampaignModel>();
builder.Services.AddScoped<IPromotion, PromotionModel>();
builder.Services.AddScoped<IChannel, ChannelModel>();
builder.Services.AddScoped<ICustomer_segment, CustomerSegmentModel>();
builder.Services.AddScoped<ICampaignChannelMapping, CampaignChannelMappingModel>();
builder.Services.AddScoped<ICampaignCustomerSegmentMapping, CampaignCustomerSegmentMappingModel>();
builder.Services.AddScoped<IInspector, InspectorModel>();
builder.Services.AddScoped<IInspection,InspectionModel>();
builder.Services.AddScoped<ISaleOrder,SalesOrderModel>();
builder.Services.AddScoped<IOrderItem,OrderItemModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
