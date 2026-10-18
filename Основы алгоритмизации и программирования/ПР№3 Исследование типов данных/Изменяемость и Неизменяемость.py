my_list = [1, 2, 3]
my_tuple = (1, 2, 3)
my_string = "cat"

#Задание со списком
print("="*25)
print("Список:")
print(*my_list)
my_list[0] = 100
print(*my_list)

#Задание с кортежем
print("="*25)
print("Кортеж:")
print(*my_tuple)
try:
    my_tuple[0] = 110
except:
    print("Неизменяемый тип данных!")

#Задание со строкой
print("="*25)
print("Строка: " + my_string)
try:
    my_string[0] = "b"
except:
    print("Неизменяемый тип данных!")
print("="*25)