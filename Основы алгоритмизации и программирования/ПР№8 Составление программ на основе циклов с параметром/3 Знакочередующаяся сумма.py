n = int(input("Введите число: "))
a = 0
b = 0

for i in range(0, n, 2):
    a += i
for i in range(1, n+1, 2):
    b -= i

print(a + b)