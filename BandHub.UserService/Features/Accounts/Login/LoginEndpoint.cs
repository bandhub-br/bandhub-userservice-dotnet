namespace BandHub.UserService.Features.Accounts.Login;

public static class LoginEndpoint
{
    public static IEndpointRouteBuilder MapLoginEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/accounts/login", async (
            LoginRequest request,
            LoginHandler handler,
            CancellationToken cancellationToken) =>
        {
            try
            {
                var response = await handler.HandleAsync(request, cancellationToken);
                return Results.Ok(response);
            }
            catch (InvalidOperationException ex)
            {
                return Results.Json(new { message = ex.Message }, statusCode: 401);
            }
        })
        .WithName("Login")
        .WithTags("Accounts");

        return app;
    }
}
