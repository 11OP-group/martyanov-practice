import random

MY_NUMBER = random.randint(1, 10)

is_winner = False

for i in range(1, 4):
    x = int(input(f"Попытка №{i}: "))
    if x == MY_NUMBER:
        print("Угадали! 👍")
        is_winner = True
        break
    elif x != MY_NUMBER:
        print("Неверно!")
        if x > MY_NUMBER:
            print("Попробуйте число меньше")
        else:
            print("Попробуйте число больше")

if not is_winner:
    print(f"Верное число: {MY_NUMBER}")