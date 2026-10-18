import math

a = int(input("Число A: "))
b = int(input("Число B: "))

"""
Нам нужно выяснить, какими числами являются A и B.
В зависимости от результата складываем последовательности.
Выводим абсолютное значение разности сумм
"""
if a % 2 == 0 and b % 2 == 0:
    evens = sum(range(a, b + 1, 2))
    odds = sum(range(a + 1, b, 2))
elif a % 2 != 0 and b % 2 != 0:
    evens = sum(range(a + 1, b, 2))
    odds = sum(range(a, b + 1, 2))
elif a % 2 == 0 and b % 2 != 0:
    evens = sum(range(a, b, 2))
    odds = sum(range(a + 1, b + 1, 2))
elif a % 2 != 0 and b % 2 == 0:
    evens = sum(range(a + 1, b + 1, 2))
    odds = sum(range(a, b, 2))


print(math.fabs(evens - odds))