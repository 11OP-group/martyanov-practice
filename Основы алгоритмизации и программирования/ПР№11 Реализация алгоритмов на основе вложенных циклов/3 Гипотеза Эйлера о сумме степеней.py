for i in range(0, 150):
    for j in range(0, 150):
        for k in range(0, 150):
            for n in range(0, 150):
                for m in range(0, 150):
                    if (i^5 + j^5 + k^5 + n^5 == m^5):
                        print(f"{i}^5 + {j}^5 + {k}^5 + {n}^5 == {m}^5")