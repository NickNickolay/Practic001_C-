//Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел.
 //Создать на его основе масив B, отбрасывая те, которые нарушают порядок возрастания 
//больше среднего арифметического элементов A чётные
// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

int[] A = new int[20];
int i=0;
while(i<A.Length)

{
    A[i] = new Random().Next(10, 100);
    Console.Write(A[i] + " ");
    i++;
}

Console.WriteLine();

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания

i = 1;
int arg = A[0];
Console.Write(arg + " ");

while(i<A.Length)
{
    if(A[i]>arg)
    {
        Console.Write(A[i] + " ");
        arg = A[i];
        
    }
    i++;
}

Console.WriteLine();
 

// 2  больше среднего арифметического элементов A

int srArif(int summ, int coll)
{
     return(summ / coll);
}

int summ = A[0];
int coll = 1;
i = 1;
while(i<A.Length)
{
    summ = summ + A[i];
    coll++;
    i++;
}
Console.WriteLine(srArif(summ, coll));


for(i = 0; i < A.Length; i++)
{
    if(A[i] < srArif(summ, coll))
    Console.Write(A[i] + " ");
}
Console.WriteLine();
// 3  чётные
 
 for(i = 0; i<A.Length; i++)
 {
     if(A[i] %2 !=0)
    
     Console.Write(A[i] + " ");
 }

// Задать массив




/*int[] array = new int[10];
 //Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания
int currentElement = array[0];
Console.WriteLine(currentElement);
while (index <= 9)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    index++;
}*/
