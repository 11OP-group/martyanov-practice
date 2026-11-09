print(f"ТАБЛИЦА УМНОЖЕНИЯ".center(40))
print("="*40)

for i in range(2, 10, 4):
    for j in range(1, 10):
        print(f"{j}*{i}={j*i:<2}\t"
              f"{j}*{i+1}={j*(i+1):<2}\t"
              f"{j}*{i+2}={j*(i+2):<2}\t"
              f"{j}*{i+3}={j*(i+3):<2}".center(35))
    print("\n")