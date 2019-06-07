namespace SimulacroExamen
{
    public class Ejercicio2
    {
        public void InformarMayorElemento(){
            var rows = int.Parse(System.Console.ReadLine("Ingrese cantidad de filas de la matriz:"));
            var columns = int.Parse(System.Console.ReadLine("Ingrese cantidad de columnas de la matriz:"));

            int[,] matrix = new int[rows,columns];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    matrix[r,c] = int.Parse(System.Console.ReadLine($"[{r},{c}]"));
                }
            }

            int mayorElemento = -1;
            int filaMayorElemento = -1;
            int columnaMayorElemento = -1;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if(mayorElemento < matrix[r,c]){
                        mayorElemento = matrix[r,c];
                        filaMayorElemento = r;
                        columnaMayorElemento = c;
                    }
                }
            }

            System.Console.WriteLine($"Mayor elemento: {mayorElemento}");
            System.Console.WriteLine($"Fila Mayor elemento: {filaMayorElemento}");
            System.Console.WriteLine($"Columna Mayor elemento: {columnaMayorElemento}");
        }
    }
}