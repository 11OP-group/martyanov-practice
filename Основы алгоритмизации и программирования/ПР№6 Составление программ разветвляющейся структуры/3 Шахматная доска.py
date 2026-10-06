first_cell_x, first_cell_y = map(int, input("Первая клетка (x y): ").split())
second_cell_x, second_cell_y = map(int, input("Вторая клетка (x y): ").split())

#False - клетки чёрные, True - клетки белые
first_cell_color = False
second_cell_color = False

if first_cell_x % 2 == 0 and first_cell_y % 2 == 0 or first_cell_x % 2 != 0 and first_cell_y % 2 != 0 or first_cell_x == first_cell_y:
    first_cell_color = True

if second_cell_x % 2 == 0 and second_cell_y % 2 == 0 or second_cell_x % 2 != 0 and second_cell_y % 2 != 0 or second_cell_x == second_cell_y:
    second_cell_color = True

if first_cell_color == second_cell_color:
    print("YES")
else:
    print("NO")