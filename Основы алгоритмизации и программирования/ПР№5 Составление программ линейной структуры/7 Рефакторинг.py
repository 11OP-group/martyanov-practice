#Тариф
RATE = 49.5

distance = float(input("Введите расстояние поездки (км): "))
fuel = float(input("Потребление бензина автомобилем (100 км/л): "))

fuel_needed = distance * (fuel / 100)
cost = RATE * fuel_needed

print(f"Уйдёт безнзина: {fuel_needed:.1f}л.")
print(f"Стоимость составит {cost:,.2f} руб.".replace(",", " "))