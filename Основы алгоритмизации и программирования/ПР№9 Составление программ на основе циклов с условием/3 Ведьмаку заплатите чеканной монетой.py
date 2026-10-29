NOMINALS = [1, 5, 10, 25]

cost = int(input("Цена услуги: "))

coins = 0
while cost > 0:
    coins += cost // NOMINALS[3]
    cost -= cost // NOMINALS[3] * NOMINALS[3]

    coins += cost // NOMINALS[2]
    cost -= cost // NOMINALS[2] * NOMINALS[2]

    coins += cost // NOMINALS[1]
    cost -= cost // NOMINALS[1] * NOMINALS[1]

    coins += cost // NOMINALS[0]
    cost -= cost // NOMINALS[0] * NOMINALS[0]
print(f"Нужно {coins} монет")