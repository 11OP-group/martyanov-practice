number = int(input("Введите число: "))

threes = 0
last_num = number % 10
lasts = 0
evens = 0
summ_more_than_five = 0
mult_more_than_seven = 1
zero_or_five = 0

while number > 0:
    x = number % 10
    if x == 3:
        threes += 1
    if x == last_num:
        lasts += 1
    if x % 2 == 0:
        evens += 1
    if x > 5:
        summ_more_than_five += x
    if x > 7:
        mult_more_than_seven *= x
    if x == 0 or x == 5:
        zero_or_five += 1
    number //= 10

print(f"Троек: {threes}")
print(f"Последняя цифра: {lasts}")
print(f"Чётные: {evens}")
print(f"Сумма цифр больше 5: {summ_more_than_five}")
print(f"Произведение цифр больше 7: {mult_more_than_seven}")
print(f"0 или 5: {zero_or_five}")