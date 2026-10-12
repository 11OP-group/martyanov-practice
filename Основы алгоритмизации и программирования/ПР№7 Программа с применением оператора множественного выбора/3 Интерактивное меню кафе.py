PRODUCT_COSTS = [120, 80, 100, 50, 90]
DISCOUNTS = {
    "STUDENT" : 0.2
}

product = input("Номер напитка в меню(1-5) или название: ").lower()
portions = int(input("Количество порций: "))
discount_input = input("Код скидки (если есть): ").upper().strip()
discount = discount_input if discount_input else "NONE"

output = ""
portions_spell = ""
summa = 0

match portions:
    case 1:
        portions_spell = "порция"
    case 2 | 3 | 4:
        portions_spell = "порции"
    case _:
        portions_spell = "порций"

match product:
    case "1" | "кофе":
        summa = PRODUCT_COSTS[0] * portions
        output += (f"Товар: Кофе\n"
                   f"Цена за порцию: {PRODUCT_COSTS[0]}руб.\n"
                   f"Количество: {portions} {portions_spell}\n"
                   f"Сумма: {summa}руб.")
    case "2" | "чай":
        summa = PRODUCT_COSTS[1] * portions
        output += (f"Товар: Кофе\n"
                   f"Цена за порцию: {PRODUCT_COSTS[1]}руб.\n"
                   f"Количество: {portions} {portions_spell}\n"
                   f"Сумма: {summa}руб.")
    case "3" | "сок":
        summa = PRODUCT_COSTS[2] * portions
        output += (f"Товар: Кофе\n"
                   f"Цена за порцию: {PRODUCT_COSTS[2]}руб.\n"
                   f"Количество: {portions} {portions_spell}\n"
                   f"Сумма: {summa}руб.")
    case "4" | "вода":
        summa = PRODUCT_COSTS[3] * portions
        output += (f"Товар: Кофе\n"
                   f"Цена за порцию: {PRODUCT_COSTS[3]}руб.\n"
                   f"Количество: {portions} {portions_spell}\n"
                   f"Сумма: {summa}руб.")
    case "5" | "лимонад":
        summa = PRODUCT_COSTS[4] * portions
        output += (f"Товар: Кофе\n"
                   f"Цена за порцию: {PRODUCT_COSTS[4]}руб.\n"
                   f"Количество: {portions} {portions_spell}\n"
                   f"Сумма: {summa}руб.")
    case _:
        output = "Такой позиции нет в меню!"

print("=" * 34 + "\n" +
      "‖" + " "*9 + "КВИТАНЦИЯ КАФЕ" + " "*9 + "‖" + "\n" +
       "=" * 34)

#При наличии скидочного кода применяет скидку
if discount != "NONE" and discount in DISCOUNTS:
    disc_summ = summa * DISCOUNTS[discount]
    output += (f"\n" +
               f"Скидка по коду {discount} {DISCOUNTS[discount] * 100}%   -{disc_summ}руб.")
else:
    disc_summ = 0

print(output)
print("=" * 34 + "\n"
      f"К ОПЛАТЕ: {summa - disc_summ}руб." + "\n" +
      "=" * 34)