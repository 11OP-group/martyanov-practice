import math

x = float(input("Введите число: "))

y = math.floor(x) + math.ceil(x)

print("Сумма ⌊x⌋+⌈x⌉: " + str(y))