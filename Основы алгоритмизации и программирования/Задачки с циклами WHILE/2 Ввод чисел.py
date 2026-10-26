nums = []

x = int(input("Введите число, кратное 7: "))

while x % 7 == 0:
    nums.append(x)
    x = int(input("Введите число, кратное 7: "))

print(*nums)