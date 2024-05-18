using Auctions.API.Entities;
using Auctions.API.Repositories;

namespace Auctions.API.Services;

public class LoggedUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public LoggedUser(IHttpContextAccessor httpContext)
    {
        _httpContextAccessor = httpContext;
    }

    public User User()
    {
        var repository = new AuctionsDbContext();

        var token = TokenOnRequest();
        var email = FromBase64String(token);

        return repository.Users.First();
    }

    private string TokenOnRequest()
    {
        var Authentication = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

        return Authentication["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return System.Text.Encoding.UTF8.GetString(data);
    }
}
