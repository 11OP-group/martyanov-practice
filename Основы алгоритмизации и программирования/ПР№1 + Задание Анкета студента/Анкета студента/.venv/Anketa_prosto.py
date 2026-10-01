#Запрос данных от пользователя
name = input("Ваше имя: ")
age = int(input("Ваш возраст: "))
subject_list = input("Ваши любимые предметы (через запятую): ").split(", ")

#Преобразовали типы при вводе

#Создание словаря
student = {"st_name":name,
           "st_age":age,
           "st_subject":subject_list
}

#Вывод анкеты
print("=" * 25)

print("АНКЕТА СТУДЕНТА")

print("=" * 25)

print(f"Имя: {student['st_name']}")
print(f"Возраст: {student['st_age']}")
print(f"Предметы: {student['st_subject']}")

print("=" * 25)