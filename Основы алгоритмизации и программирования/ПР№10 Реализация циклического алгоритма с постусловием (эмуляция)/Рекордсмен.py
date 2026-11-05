x = int(input("Число: "))
maxim = -1

while x != 0:
    if x > maxim:
        maxim = x
    x = int(input("Число: "))

if maxim >= 0:
    print(f"Самое большое число: {maxim}")
else:
    print("Самого большого числа нет!")