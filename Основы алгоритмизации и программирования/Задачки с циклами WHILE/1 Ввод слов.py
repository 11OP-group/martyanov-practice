print("Ввод слов")
print("Остановить программу можно словами:")
print("стоп, хватит, достаточно")

word = input("Введите слово: ")
running = True
i = 0
while running:
    i += 1
    if word.lower() == "стоп" or word.lower() == "хватит" or word.lower() == "достаточно":
        i -= 1
        running = False
    else:
        word = input("Введите слово: ")

print(f"Вы ввели {i} слов")