NUMBERS_IN_ROOM = 4

number = int(input("Номер места: "))

search_num = (number - 1) // NUMBERS_IN_ROOM + 1

print(f"Место №{number} находится в {search_num} купе")