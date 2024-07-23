# CepFinder

## Description
CepFinder is a simple C# program that allows you to query address information based on postal codes (CEP) using the public API provided by ViaCEP.

## Technologies Used
- C# (programming language)
- .NET (development framework)
- HttpClient (for making HTTP requests)

## How to Use
To use CepFind, follow the instructions below:

1. **Prerequisites:**
   - Ensure you have the .NET SDK installed. You can download it from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

2. **Clone the repository:**
   ```
   git clone https://github.com/WesleyBSa/cep-finder.git
   cd CepFinder
   ```

3. **Run the program:**
   - Open a command prompt or terminal and navigate to the directory where the project was cloned.

   - Compile and run the program using the `dotnet run` command:
     ```
     dotnet run
     ```

4. **Enter the desired CEP (postal code):**
   - The program will prompt you to enter the postal code (CEP) you wish to query.

5. **Results:**
   - The program will make a request to the ViaCEP API and display the address information associated with the postal code in the console.

6. **Error handling:**
   - The program validates that the entered CEP is valid (consists of exactly 8 digits) before making the API request.

7. **Customizations (optional):**
   - You can modify the code to implement additional features, such as more robust exception handling or different output formatting.

## Example Usage
```
Enter the CEP you wish to query:
01001000

{
  "cep": "01001-000",
  "logradouro": "Praça da Sé",
  "complemento": "lado ímpar",
  "bairro": "Sé",
  "localidade": "São Paulo",
  "uf": "SP",
  "ibge": "3550308",
  "gia": "1004",
  "ddd": "11",
  "siafi": "7107"
}
```

## Contributing
Contributions are welcome! Feel free to open a Pull Request or Issue with suggestions, corrections, or improvements.

---
