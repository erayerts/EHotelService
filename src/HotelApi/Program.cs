using HotelApi.BusinessLogic.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AboutUsManager>();
builder.Services.AddScoped<IntroductionManager>();
builder.Services.AddScoped<NewsPostManager>();
builder.Services.AddScoped<RoomManager>();
builder.Services.AddScoped<ServiceManager>();
builder.Services.AddScoped<TestimonialReviewManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
