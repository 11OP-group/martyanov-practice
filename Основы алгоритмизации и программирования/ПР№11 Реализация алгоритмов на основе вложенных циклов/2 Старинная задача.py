N = 10
K = 5
M = 0.5

for i in range(1, 11):
    for j in range(0, 21):
        for k in range(0, 201):
            if (10*i + 5*j + 0.5*k == 100 and i + j + k >= 1):
                print(i, j, k)