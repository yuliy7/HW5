#Задача №35. Решение в группах
#Напишите функцию, которая принимает одно число и
#проверяет, является ли оно простым
#Напоминание: Простое число - это число, которое
#имеет 2 делителя: 1 и n(само число)
#Input: 5
#Output: yes

def Chek(number):
     for i in range(2,number):
         if number%i==0:
             return(f"Число {number} не простое")
    
         return(f"Число простое")    
number=int(input("Ввeдите число: "))
res=Chek(number)
print(res)  