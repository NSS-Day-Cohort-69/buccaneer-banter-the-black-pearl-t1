var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Add Follower
// app.MapPost("/api/Follow",(Follower followObj)=>
// {
//     if(followObj==null)
//     {
//         return Results.BadRequest();
//     }
    
//    // followObj.Id=follwer
// });


app.Run();
