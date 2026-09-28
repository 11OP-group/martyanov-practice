import math

x1 = float(input("Координата x1: "))
x2 = float(input("Координата x2: "))
y1 = float(input("Координата y1: "))
y2 = float(input("Координата y2: "))

x = (x1, y1)
y = (x2, y2)

p = math.sqrt(math.pow(x[0] - x[1], 2) + math.pow(y[0] - y[1], 2))
p = round(p, 2)

print(f"Расстояние между точками {x} и {y}: {p}")