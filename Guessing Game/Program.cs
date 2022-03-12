string[] A = { "country", "sadness", "equilibrium", "allergy", "scarcity", "passport", "horse", "language", "hooker", "disappointment", "vegetarian", "kidney", "awe", "shilajit", "neuron" };

Random B = new Random();
int C = B.Next(A.Length);

string D = A[C - 1];
for (int i = 0; i < D.Length; i++)
{
    D = D.Remove(i, 1);
    D = D.Insert(i, "*");
}

Console.WriteLine("Guess the word: {0}", D);

string F = A[C - 1];

bool Bool = false;

do
{
    Console.WriteLine("Enter a letter");
    string G = Console.ReadLine();
    var E = char.Parse(G); 

    for (int j = 0; j < F.Length; j++)
    {
        if (E == F[j])
        {
            Bool = true;
            D = D.Remove(j, 1);
            D = D.Insert(j, G);
        }
    }
    if (Bool == true)
    {
        Console.WriteLine(D);
    }
    else
    {
        Console.WriteLine("The letter {0} is not in the word", G);
    }
} while (D.Contains("*"));

Console.WriteLine("Congrats! The word is {0}", D);



