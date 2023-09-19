var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/message", () =>
{
    var response = new MessagesResponseModel("This is an API! WOW", DateTime.Now);
    return Results.Ok(response);
});

app.Run();

public record MessagesResponseModel(String Message, DateTime When);