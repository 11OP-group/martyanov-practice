from math import fabs

first_cell_x, first_cell_y = map(int, input("Первая клетка (x y): ").split())
second_cell_x, second_cell_y = map(int, input("Вторая клетка (x y): ").split())

if fabs(second_cell_x - first_cell_x) == fabs(second_cell_y - first_cell_y) or (first_cell_x == second_cell_x or first_cell_y == second_cell_y):
    print("YES")
else:
    print("NO")
