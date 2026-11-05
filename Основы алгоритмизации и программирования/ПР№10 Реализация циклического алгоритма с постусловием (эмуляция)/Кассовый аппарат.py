cost = int(input("Цена: "))
total_cost = 0

while cost != 0:
    if cost > 0:
        total_cost += cost
    else:
        print("Цена не может быть отрицательной!")

    cost = int(input("Цена: "))

if total_cost > 1000:
    print(f"Вам скидка 10%! Итоговая сумма: {total_cost - (total_cost * 0.1)}")
else:
    print(f"Итоговая сумма: {total_cost}")