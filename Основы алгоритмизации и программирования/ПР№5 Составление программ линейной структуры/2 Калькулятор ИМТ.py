import math

weight, height = map(float, input("Введите вес(к) и рост(м) через пробел: ").split())

bmi = weight / (height * height)

print(f"Ваш индекс масы тела {bmi:.1f}")