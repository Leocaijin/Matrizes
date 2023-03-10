// See https://aka.ms/new-console-template for more information
/*1. Leia uma matriz 4 x 4, conte e escreva quantos valores maiores que 10 ela possui.*/

int[,]matriz =  new int [4,4];
Random rd = new Random();
int [,]matriz2 = new int [4,4];
int contador = 0;
//preenche a matriz com numeros randomicos
for(int i = 0;i< 4;i++){
    for(int j = 0;j< 4; j++){
        matriz[i,j] = (int)(rd.NextDouble()*21);
    }
}
//imprime a matriz 
Console.WriteLine("MATRIZ");
for(int i = 0;i< 4;i++){
    for(int j = 0;j< 4; j++){

        Console.Write(matriz[i,j]+"\t");
        
    }
    Console.WriteLine();
}
//mostra a matriz com numeros > 10
Console.WriteLine("MATRIZ numeros maiores que 10");
for(int i = 0;i< 4;i++){
    for(int j = 0;j< 4; j++){

       if(matriz[i,j] > 10){
        matriz2[i,j] = matriz[i,j];
               }
               Console.Write(matriz2[i,j]+"\t");  
         }  
         Console.WriteLine();
    }
    // imprime a quantidade de numeros > 10
    Console.WriteLine("A quantidade destes numeros são: ");
    for(int i = 0;i< 4;i++){
        for(int j = 0;j< 4;j++){

            if(matriz[i,j] > 10){

                contador++;
            }
        }  
    }
    Console.Write(contador);


/*
2. Declare uma matriz 5 x 5. Preencha com 1 a diagonal principal e com 0 os demais
elementos. Escreva ao final a matriz obtida.
3. Fac¸a um programa que preenche uma matriz com o produto do valor da linha e da coluna
de cada elemento. Em seguida, imprima na tela a matriz.
4. Leia uma matriz 4 x 4, imprima a matriz e retorne a localizac¸ao (linha e a coluna) do ˜
maior valor.
5. Leia uma matriz 5 x 5. Leia tambem um valor ´ X. O programa devera fazer uma busca ´
desse valor na matriz e, ao final, escrever a localizac¸ao (linha e coluna) ou uma mensa- ˜
gem de “nao encontrado”. ˜
6. Leia duas matrizes 4 x 4 e escreva uma terceira com os maiores valores de cada posic¸ao˜
das matrizes lidas.*/

