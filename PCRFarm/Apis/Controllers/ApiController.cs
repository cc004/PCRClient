using System.Text;
using BandoriBot;
using BandoriBot.Config;
using BandoriBot.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PCRFarm.Apis.Controllers;

[ApiController]
public class ApiController : Controller
{
    private static readonly Dictionary<string, Action<string>> callbacks = new();

    public static void RegisterCallback(string challenge, Action<string> validator)
    {
        lock (callbacks)
        {
            callbacks.Add(challenge, validator);
        }
    }

    [HttpGet("/geetest")]
    public async Task<ActionResult> Geetest() => File(await System.IO.File.ReadAllTextAsync("geetest.html"), "text/html");

    [HttpGet("/validate")]
    public ActionResult Validate(string challenge, string validate)
    {
        Action<string> callback;
        lock (callbacks)
            if (!callbacks.TryGetValue(challenge, out callback!))
                return BadRequest();
        callback(validate);
        return NoContent();
    }
}