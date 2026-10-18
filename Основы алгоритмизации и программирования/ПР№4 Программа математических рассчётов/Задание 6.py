import math

radians = math.radians(int(input("Число в градусах: ")))

func = math.sin(radians) + math.cos(radians) + math.pow(math.tan(radians), 2)

print(f"Значение функции: {func}")