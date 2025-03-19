/*Проверить истинность высказывания: &quot;Цифры данного
трехзначного числа образуют возрастающую или убывающую
последовательность&quot;.*/

using System.Collections.Generic;
using Task2;

Sequence sequence = new Sequence(123);
Console.WriteLine(sequence.IsIncreasing() ? "Цифры образуют возрастающую последовательность":
                    sequence.IsDescending() ? "Цифры образуют убывающую последовательность" : "Цифры не образуют последовательность");
