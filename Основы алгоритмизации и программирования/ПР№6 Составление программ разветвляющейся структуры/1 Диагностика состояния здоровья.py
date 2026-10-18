temperature = float(input("Температура: "))
pressure, pulse = map(int, input("Давление и пульс: ").split())

if not (( temperature < 35 or temperature > 38) or (pressure < 105 or pressure > 140) or (pulse < 55 or pulse > 110)):
    if 36 < temperature < 37 and 110 < pressure < 130 and 60 < pulse < 100:
        print("Всё в порядке!")
    else:
        print("Наблюдается лёгкое недомогание!")
else:
    print("Обратитесь к врачу!")