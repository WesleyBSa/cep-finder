using System;
using System.Net.Http;
using System.Threading.Tasks;

class CepFinder
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite o CEP que deseja consultar:");
        string cep = Console.ReadLine().Trim();

        if (string.IsNullOrWhiteSpace(cep))
        {
            Console.WriteLine("CEP não pode estar em branco. Tente novamente.");
            return;
        }

        //Para remover os numericos caso haja.
        cep = new string(cep.ToCharArray().Where(c => char.IsDigit(c)).ToArray());

        if (cep.Length != 8)
        {
            Console.WriteLine("CEP inválido. Deve conter exatamente 8 números. Tente novamente.");
            return;
        }

        using (var httpClient = new HttpClient())
        {
            try
            {
                var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
