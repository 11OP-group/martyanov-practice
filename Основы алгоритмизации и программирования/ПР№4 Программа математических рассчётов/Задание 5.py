mins = int(input("Минут: "))

hours = mins // 60
mins_left = mins % 60

print(f"{mins} минут - это {hours} час и {mins_left} минут")