#Задача №37.

#Дано натуральное число N и
#последовательность из N элементов.
#Требуется вывести эту последовательность в
#обратном порядке.
#Примечание. В программе запрещается
#объявлять массивы и использовать циклы
#(даже для ввода и вывода).
#Input: 2 -> 3 4
#Output: 4 3

def pos(number):
     if number == 0:
         return " "
     x=int(input("Введите число: "))
     return pos(number-1)+str(x)
number = int(input("Введите количество элементов: "))
print(pos(number))
