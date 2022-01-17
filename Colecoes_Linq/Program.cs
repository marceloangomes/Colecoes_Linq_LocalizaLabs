// See https://aka.ms/new-console-template for more information
using Colecoes_Linq.Helper;

System.Console.WriteLine("Array");
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;
System.Console.WriteLine("Percorrendo o array pelo for");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    System.Console.WriteLine($"Indice {i} valor: {arrayInteiros[i]}");
}

System.Console.WriteLine("Percorrendo o array pelo forech");
foreach (var item in arrayInteiros)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Matriz");
int[,] matriz = new int[4,2]
{
    {0,0},
    {10,20},
    {50,100},
    {90,200}
};

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        System.Console.WriteLine(matriz[i,j]);
    }
}

System.Console.WriteLine("Bobble Sort");
OperacoesArray op = new OperacoesArray();
int[] array = new int[5] {6,3,8,1,9};
System.Console.WriteLine("Sem Ordenação");
op.ImprimirArray(array);
op.OrdernarBubbleSort(ref array);
System.Console.WriteLine("Com Ordenação Bubble Sort");
op.ImprimirArray(array);
op.Ordenar(ref array);
System.Console.WriteLine("Com Ordenação Classe Array");
op.ImprimirArray(array);

int[] arrayCopia = new int[10];
System.Console.WriteLine("Array antes da Copia");
op.ImprimirArray(arrayCopia);
System.Console.WriteLine("Array após Copia");
op.Copiar(array,ref arrayCopia);
op.ImprimirArray(arrayCopia);

System.Console.WriteLine("Verifica se existe um elemento");
var valorProcurado =1;
bool existe = op.Existe(array,1);
if(existe){
    System.Console.WriteLine("Encontrei o valor: {0}",valorProcurado);
}
else{
    System.Console.WriteLine("Não encontrei o valor: {0}",valorProcurado);
}

System.Console.WriteLine("Verifica se todos os elementos são maior que o valor passado");
var valorComparado = 100;
bool maior = op.TodosMaior(array,valorComparado);
if(maior){
    System.Console.WriteLine("Todos maiores que o valor: {0}",valorComparado);
}
else{
    System.Console.WriteLine("Encontrei valores menores que: {0}",valorComparado);
}

int[] arrayNumeros = new int[5] {1,4,8,15,29};

var numerosParesQuery = 
                from num in arrayNumeros
                where num % 2 == 0
                orderby num
                select num;

var numerosParesMetodo = arrayNumeros.Where(x=> x % 2 == 0).OrderBy(x => x).ToList();

System.Console.WriteLine("Numeros Pares Query: " + string.Join(", ",numerosParesQuery));
System.Console.WriteLine("Números Pares Metodo: " + string.Join(", ", numerosParesMetodo));

