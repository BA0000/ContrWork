// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3-м симовлам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно масивами

string[] words = new string[10] {"A","long","time","ago","in","a","galaxy","far","far","away"};
string[] newWords = new string[words.Length];

void ThreeLetter(string[] words, string[] newWords)
{   
    int counter = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length <= 3)
        {
          newWords[counter] = words[i];  
          counter++;
        }
    }
}   

void ShowArray(string[] words)
{
    for(int i = 0; i < words.Length; i++)
    { 
        Console.Write("  " + words[i]);
    }
    Console.WriteLine();
}

Console.Write("A new array of words with less than three letters: ");

ThreeLetter(words, newWords);
ShowArray(newWords);