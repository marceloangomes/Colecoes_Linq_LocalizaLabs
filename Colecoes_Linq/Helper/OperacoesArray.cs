namespace Colecoes_Linq.Helper
{
    public class OperacoesArray
    {
        public void ImprimirArray(int[] array)
        {
            // for (int i = 0; i < array.Length; i++)
            // {
            //     System.Console.WriteLine(array[i]);
            // }
            var linha = string.Join(", ",array);
            System.Console.WriteLine(linha);
        }

        public void OrdernarBubbleSort(ref int[] array){
            var temp = 0 ;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j]>array[j+1]){
                        temp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] =  temp;
                    }
                }
            }
        }

        public void Ordenar(ref int[] array){
            Array.Sort(array);
        }

        public void Copiar (int[] array, ref int[] arrayDestino){
            Array.Copy(array,arrayDestino,array.Length);
        }

        public bool Existe(int[] array, int valor){
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaior(int[] array, int valor){
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
    }
}