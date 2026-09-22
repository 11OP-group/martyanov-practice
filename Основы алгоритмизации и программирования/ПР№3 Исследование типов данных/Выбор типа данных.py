studs = 25  #Количество студентов int
temperature = 23.5  #Градусы float
login = "ivanov_ivan"   #Логин str
nots_on = True  #Включены ли уведомления bool
movs = ["Интерстеллар", "Чужой", "Нечто"]   #Список фильмов list
coords = (54, 32)   #Координаты не подлежащие изменению tuple
id = {0, 1, 2, 3}    #id товаров set
caps = {
    "Россия" : "Москва",
    "Америка" : "Вашингтон"
}   #Словарь стран и их столиц dict

print(type(studs))
print(type(temperature))
print(type(login))
print(type(nots_on))
print(type(movs))
print(type(coords))
print(type(id))
print(type(caps))