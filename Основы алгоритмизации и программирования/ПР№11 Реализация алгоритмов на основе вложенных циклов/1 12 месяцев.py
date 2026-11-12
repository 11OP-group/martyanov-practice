N = 2
K = 8
M = 14

for i in range(1, N+1):
    for j in range(1, K+1):
        for k in range(1, M+1):
            if (28*i + 30*j + 31*k == 365):
                print(i, j, k)