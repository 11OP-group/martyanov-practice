#Запрашиваем данные студента
name = input("Ваше имя: ")
age = input("Ваш возраст: ")
#Разделяем введённую строку и формируем список
subjects = input("Любимые предметы (укажите через запятую): ").split(", ")

print("="*25)
print("Анкета студента")
print("="*25)

print("Имя: " + name)   #Выводим имя студента
print("Возраст: " + age)    #Выводим возраст студента
res = ""    #Создаём пустую строку для вывода списка

i = 0
#Цикл перебора элементов списка Предметы
while(i < len(subjects)):
    if(i != len(subjects)-1):
        res += subjects[i].capitalize() + ", "  #Добавляем разделитель, если эл. не последний
    else:
        res += subjects[i].capitalize()     #Добавляем последний эл. без разделителя
    i += 1

print("Любит предметы: " + res)     #Выводим список предметов

print("="*25)
stud_profile = {"name" : name, "age" : age, "subjects" : subjects}
print(stud_profile)