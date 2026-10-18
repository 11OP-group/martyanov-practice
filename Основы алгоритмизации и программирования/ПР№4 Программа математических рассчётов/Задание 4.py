n = int(input("Количество школьников: "))
k = int(input("Количество мандарин: "))

in_shkolnik = k // n
in_busket = k % n

print(f"Школьникам достанется по {in_shkolnik} штуке(-и)")
print(f"А вот {in_busket} мандарин останется в корзине")