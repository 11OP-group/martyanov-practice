TAX = 0.13  #Налог 13%

income = float(input("Введите свой годовой доход: "))

taxed_income = income * TAX

total_income = income - taxed_income

print(f"Общий доход: {income:,} руб.".replace(",", " "))
print(f"Сумма налога с дохода: {taxed_income:,.2f} руб.".replace(",", " "))
print(f"Итоговый доход: {total_income:,.2f} руб.".replace(",", " "))