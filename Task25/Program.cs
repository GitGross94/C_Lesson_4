﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите первое число : ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число : ");
  int B = Convert.ToInt32(Console.ReadLine());
int Step(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++){
    result = result * A;
  }

    return result;
}

  int itog = Step(A, B);
  Console.WriteLine("Ответ: " + itog);