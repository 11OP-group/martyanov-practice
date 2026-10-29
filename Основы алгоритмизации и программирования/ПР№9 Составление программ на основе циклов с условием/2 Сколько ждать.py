name = input("Имя: ")

found = False

names_in_queue = 0
while name != "Левон":
    if found:
        names_in_queue += 1
    if name == "Александра":
        found = True
    name = input("Имя: ")

print(f"Игроков между Александрой и Левоном: {names_in_queue}")