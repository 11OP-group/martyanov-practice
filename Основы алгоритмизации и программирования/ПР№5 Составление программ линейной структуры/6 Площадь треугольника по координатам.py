import math


def calculate_distance(x1, y1, x2, y2):
    """
    Расчитывает расстояние между двумя точками по заданным координатам

    :param x1:
    :param y1:
    :param x2:
    :param y2:
    :return: Расстояние между точками
    """

    distance = math.sqrt(math.pow(x2 - x1, 2) + math.pow(y2 - y1, 2))
    return distance

def calculate_triangle_area(a, b, c):
    """
    Расчитывает площадь треугольника по длинам сторон

    :param a: Сторона AB
    :param b: Сторона BC
    :param c: Сторона AC
    :return: Площадь треугольника
    """

    p = (a + b + c) / 2
    area = math.sqrt(p * (p - a) * (p - b) * (p - c))
    return area

a_x, a_y = map(int, input("Координаты первой точки: ").split())
b_x, b_y = map(int, input("Координаты второй точки: ").split())
c_x, c_y = map(int, input("Координаты третьей точки: ").split())

a_b = calculate_distance(a_x, a_y, b_x, b_y)
b_c = calculate_distance(b_x, b_y, c_x, c_y)
a_c = calculate_distance(a_x, a_y, c_x, c_y)

tr_area = calculate_triangle_area(a_b, b_c, a_c)

print(f"Площадь треугольника: {tr_area:.2f}")