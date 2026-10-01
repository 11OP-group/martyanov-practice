import math


def calculate_rectangle_area(width, height):
    """
    Расчёт площади прямоугольника

    :param width: Ширина
    :param height: Высота
    :return: Площадь прямоугольника
    """

    area = width * height
    return area

def calculate_circle_area(radius):
    """
    Расчёт площади круга

    :param radius: Радиус
    :return: Площадь круга
    """

    area = math.pi * math.pow(radius, 2)
    return area

rect_width, rect_height = map(float, input("Введите ширину и высоту прямоугольника: ").split())
rect_area = calculate_rectangle_area(rect_width, rect_height)

circle_radius = float(input("Введите радиус окружности: "))
circle_area = calculate_circle_area(circle_radius)

print(f"Площадь прямоугольника {rect_area:.2f}")
print(f"Площадь окружности {circle_area:.2f}")