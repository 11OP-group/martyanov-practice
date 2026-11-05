balance = 1000

print("=" * 45)
print("1) Узнать баланс\n2) Снять 100 руб.\n3) Положить 100 руб.\n4) Выход")
print("=" * 45)

act = input("Действие: ")

while act != "4":
    match act:
        case "1":
            print(f"Ваш баланс: {balance}")
        case "2":
            if balance > 0:
                balance -= 100
                print(f"Баланс: {balance}")
            else:
                print("Ваш баланс слишком мал!")
        case "3":
            balance += 100
            print(f"Баланс: {balance}")

    print("=" * 45)
    print("1) Узнать баланс\n2) Снять 100 руб.\n3) Положить 100 руб.\n4) Выход")
    print("=" * 45)
    act = input("Действие: ")