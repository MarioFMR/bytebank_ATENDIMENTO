Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//Array de inteiro
void TestaArrayInt()
{
    // Criar array
    int[] idades = new int[5];

    //Atribui valor no array
    idades[0] = 31;
    idades[1] = 26;
    idades[2] = 52;
    idades[3] = 57;
    idades[4] = 30;

    //Tamanho do Array
    Console.WriteLine($"\nTamanho do Array {idades.Length}\n");

    //Percorrendo o Array
    for ( var i = 0; i < idades.Length; i++ )
    {
        Console.WriteLine($"idades[{i}]: {idades[i]}");
    }

    //Trabalhando com os valores do Array
    int somaIdade = 0;

    for ( var i = 0;i < idades.Length; i++ )
    {
        somaIdade += idades[i];
    }

    int media = somaIdade / idades.Length;

    Console.WriteLine($"\nMédia de idade: {media}");

}

//Array de string
void TesteBuscaPalavra()
{
    string[] arrayDePalavras = new string[5];

    for ( var i = 0; i < arrayDePalavras.Length; i++ )
    {
        Console.Write($"Digite {i+1}° palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("\nDigite palavra que deseja procurar:");
    var busca = Console.ReadLine();

    foreach ( string i in arrayDePalavras )
    {
        if( i.Equals(busca) ) 
        {
            Console.WriteLine($"\nPalavra {i} encontrada.");
            break;
        }
    }
}

//Array de double
Array amostra = Array.CreateInstance(typeof(double), 5);

amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

void TestaMediana(Array array)
{
    if (( array == null) || (array.Length == 0 )) {
        Console.WriteLine("Array vazio ou nulo.");
    }

    //Clona o array que recebeu como parametro para numerosOrdenados
    double[] numerosOrdenados = (double[]) array.Clone();
    
    //Ordena o array na ordem crescente 
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;

    // Condição ternária verifica se a sobra da divisão é diferente de 0
    // Caso for, ele apresenta a mediana, casos a sobra for igual a 0
    // Pega a o valor atual e o anterior, soma e divide por 2, o resultado sera a mediana
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"A mediana é igual a {mediana}");

}

void TestaArrayInt2()
{
    //
    int[] valores = { 10, 58, 36, 47 };

    foreach (int i in valores)
    {
        Console.WriteLine(i);
    }
}

try
{
    //TestaArrayInt();
    //TesteBuscaPalavra();
    //TestaMediana(amostra);
    TestaArrayInt2();
}
catch ( Exception ex )
{
    Console.WriteLine(ex.Message);
}
