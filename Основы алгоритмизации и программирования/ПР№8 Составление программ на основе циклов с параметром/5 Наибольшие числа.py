n = int(input("Длина последовательности (больше 1): "))
if n < 2:
    print("Последовательность слишком мала!")
else:
    max_min = 0
    max_max = 0

    for i in range(0, n):
        x = int(input(f"x{i} = "))
        if x > max_max:
            max_min = max_max
            max_max = x
        elif max_min < x < max_max:
            max_min = x

    print(f"Максимальное: {max_max}")
    print(f"Второе максимальное: {max_min}")


