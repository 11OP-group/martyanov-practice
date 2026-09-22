shopping_list = ["Морковь", "Молоко", "Хлеб"]
shopping_list.append("Макароны")
print("Список:")
print(*shopping_list)

print(" ")

unique_list = ("Морковь", "Молоко", "Хлеб")
print("Множество:")
print(*unique_list)
print(" ")
unique_list += ("Макароны",)
print("Произошла конкатинация множеств")
print(*unique_list)