pockets = int(input("Номер кармана: "))

if pockets in range(0, 37):
    if pockets % 2 == 0 and pockets != 0:    #Проверка на чётность
        if 1 <= pockets <= 10 or 11 <= pockets <= 18 or 19 <= pockets <= 28:
            print(f"Карман №{pockets} - чёрный")
        else:
            print(f"Карман №{pockets} - красный")
    elif pockets % 2 != 0:
        if 1 <= pockets <= 10 or 11 <= pockets <= 18 or 19 <= pockets <= 28:
            print(f"Карман №{pockets} - красный")
        else:
            print(f"Карман №{pockets} - чёрный")
    else:
        print(f"Карман №{pockets} - зелёный")
else:
    print("Число вне допустимого диапазона!")