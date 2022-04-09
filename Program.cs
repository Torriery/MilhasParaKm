Double milhas,kms;
Console.Write("escreva qualquer numeros (em milhas)...");
milhas=Convert.ToDouble(Console.ReadLine());
kms=milhas * 1.609;
Console.WriteLine($"{kms:N3} Km");
