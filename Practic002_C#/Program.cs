/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue].
 Создать на его основе масив B, отбрасывая те, которые нарушают порядок возрастания
элементы, больше 8
знакочередования*/

int[] A = new int[10];
int i=0;
while(i<A.Length)

{
    A[i] = new Random().Next(-6, 31);
    Console.Write(A[i] + " ");
    i++;
}

Console.WriteLine();

int current = A[0];
Console.Write(current + " ");
for(i = 1; i <A.Length; i++)
{
    if(A[i]> current)
    { 
        Console.Write(A[i] + " ");
        current = A[i];
        i++;
    }
}
Console.WriteLine();
/* исключаем элементы больше 8
знакочередования*/

for(i=0;i<A.Length;i++)
{
    if(A[i]<8)
    Console.Write(A[i] + " ");
}
Console.WriteLine();

/*нарушают порядок возрастания
элементы, больше 8
знакочередования*/
int num = A[0];
i = 1;
Console.Write(num + " ");
while(i < A.Length)
{
    if((num < 0 && A[i] > 0 ) || (num > 0 && A[i] < 0))
    {
        Console.Write(A[i] + " ");
        num = A[i];
        
    }
    i++;
}

