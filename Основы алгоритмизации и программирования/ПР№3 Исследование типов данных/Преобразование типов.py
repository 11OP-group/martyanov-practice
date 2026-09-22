try:
    num1, num2 = int(input("Первое число: ")), int(input("Второе число: "))
    summ = num1 + num2
    print("Сумма: " + str(summ))
except ValueError:
    print("Введены не числа!")
