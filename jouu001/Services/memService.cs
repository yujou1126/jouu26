using jouu001.Models;

namespace jouu001.Services;

public class MemeService
{
    public async Task<List<MemeModel>> List();
    {
        List<MemeModel> result = new List<MemeModel>();
        try
        {
             //
             HttpClient client = new HttpClient();
            
             
             HttpResponseMessage response = await client.GetAsync("")
             if (response.IsSuccessStatusCode)
             {
                 response.Content.ReadFromJsonAsync < List<MemeModel>();
                
             }
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }

        return result;
    }
}