using System;

class Program{

    static void Main(string[] args){

        int[] numeros = {38, 27, 43, 3, 9 , 82, 10};
        MostrarArreglo(numeros);
        MergeSort(numeros, 0, numeros.Length -1);
        MostrarArreglo(numeros);

    }


    static void QuickSort(int[] arreglo, int izquierda, int derecha){

        //Si tiene un elemento o ninguno ya esta ordenado

        if (izquierda < derecha){

            //Obtener la posicion del pivote
            int indicePivote = Particionar(arreglo, izquierda, derecha); 

            //Ordenar los elementos menores al pivote
            QuickSort(arreglo, izquierda, indicePivote - 1);

            //Ordenar los elementos mayores al pivote
            QuickSort(arreglo, indicePivote + 1, derecha);

        }

    }

    //Reorganizar el arreglo colocando el pivote en la posicion correcta
    static int Particionar(int[] arreglo, int izquierda, int derecha){

        int pivote = arreglo[derecha];
        int i = izquierda -1;

        //recorrer el arreglo

        for(int j = izquierda; j<derecha; j++){

            if (arreglo[j] <= pivote){
                i++;
                Intercambiar(arreglo, i, j);

            }

        } 

        //Colocar el pibote en la posicion definitiva
        Intercambiar(arreglo, i + 1, derecha);

        //Devolver el pivote
        return i+1;
    }


    //Intercambiar elementos del arreglo
    static void Intercambiar(int[] arreglo, int i , int j){
        
        int temporal = arreglo[i];
        arreglo[i] = arreglo[j];
        arreglo[j] = temporal;

    }

    //Miestra el contenido

    static void MostrarArreglo(int[] arreglo){

        foreach(int numero in arreglo){
            Console.Write(numero + " ");
        }
        Console.WriteLine()
    }
    }