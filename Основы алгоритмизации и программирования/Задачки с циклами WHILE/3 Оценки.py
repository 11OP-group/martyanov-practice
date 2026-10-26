grade = int(input("Введите оценку: "))

i = 0
while 0 < grade <= 5:
    if grade == 5:
        i += 1
    grade = int(input("Введите оценку: "))

print(f"Количество пятёрок: {i}")