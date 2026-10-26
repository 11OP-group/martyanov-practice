m, n = map(int, input("Числа m и n: ").split())

if m > n:
    for i in range(n, m+1):
        print(i)
elif m < n:
    for i in range(m, n+1):
        print(i)
else:
    print("Числа равны!")