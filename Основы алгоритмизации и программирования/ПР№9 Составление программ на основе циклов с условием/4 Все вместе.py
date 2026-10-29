number = int(input("Введите число: "))

threes = 0
last_num = number % 10
last_num_count = 0
even_nums = 0
sum_more_than_five = 0
mult_more_than_seven = 1
zero_or_five = 0
print(number//10)
while number > 0:
    x = number % 10
    if x == 3:
        threes += 1
    if x == last_num:
        last_num_count += 1
    if x % 2 == 0:
        even_nums += 1
    if x > 5:
        sum_more_than_five += x
    if x > 7:
        mult_more_than_seven *= x
    if x == 0 or x == 5:
        zero_or_five += 1
    number //= 10

print(f"Кол-во цифр 3: {threes}")
print(f"Сколько раз встречается последняя цифра: {last_num_count}")
print(f"Кол-во чётных цифр: {even_nums}")
print(f"Сумма цифр, больше 5: {sum_more_than_five}")
print(f"Произведение цифр, больше 7: {mult_more_than_seven}")
print(f"Сколько раз встречаются 0 или 5: {zero_or_five}")
