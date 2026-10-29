n = int(input("Введите число: "))

i = 1
while i <= n:
    if i not in range(5, 10) and i not in range(17, 38) and i not in range(78, 88):
        print(i)
    i += 1