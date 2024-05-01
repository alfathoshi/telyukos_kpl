using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;


[Route("api/[controller]")]
[ApiController]
public class AccountController : Controller
{

    private static List<Account> akun = new List<Account>();

    public static void updateList(List<Account> akkun)
    {
        var convert = JsonConvert.SerializeObject(akkun);
         
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        FileStream fileStream = new FileStream(@"./Account.json", FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(convert);
        }
    }


    [HttpGet]
    public IEnumerable<Account> Get()
    {
        using (StreamReader reader = new StreamReader(@"./Account.json"))
        {
            akun = JsonConvert.DeserializeObject<List<Account>>(reader.ReadToEnd());
        }
        return akun;
    }

    [HttpPost]
    public void Post([FromBody] Account value)
    {

        akun.Add(value);
        updateList(akun);

    }

    [HttpGet("{id}")]
    public Account Get(int id)
    {
        return akun[id];
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        akun.RemoveAt(id);
        updateList(akun);
    }
}

