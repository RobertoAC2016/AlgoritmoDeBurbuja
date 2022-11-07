List<int> numeros = new List<int> { 456, 12, 5, 756, 123, 258, 654, 951, 854, 325, 652, 45, 68, 91, 27 };

//Utilizamos un rango de numeros al azar y desordenado

Console.WriteLine($"Numeros a ordenar por metodo de burbuja: ");

foreach (var num in numeros)
    Console.WriteLine(num);

algoritmo_de_ordenamiento_por_metodo_de_burbuja(numeros);

Console.WriteLine($"Numeros ordenados por metodo de burbuja: ");

//  Aqui ya se presenta el resultado del ordenamiento
Console.WriteLine();
foreach (var num in numeros)
    Console.WriteLine(num);




void algoritmo_de_ordenamiento_por_metodo_de_burbuja(List<int> nums)
{
    //primero recorremos todas las pocisiones del arreglo
    for (int i = 1; i < nums.Count; i++)                    //Aqui empezamos el recorrido desde la posicion 1 y no 0
    {
        for (int j = 0; j < nums.Count - 1; j++)            //Aqui recorremos las posiciones del arreglo desde la por 0 pero hasta n-1
        {                                                   //Donde n, es la longitud del arreglo menos 1
            if (nums[j] > nums[j + 1])                      //preguntamos si la posicion es 0 -> numero es mayor a la posicion 1->numero
            {                                               //si la condicion es verdadera se invierten las posiciones
                var aux = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = aux;
            }
        }
    }
}
