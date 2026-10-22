m = int(input("Стартовое кол-во: "))
p = float(input("Увеление в процентах\сут.: "))
n = int(input("Кол-во дней: "))

for i in range(1, n+1):
    m += m * (p / 100)
    print(f"{i} {m:.0f}")