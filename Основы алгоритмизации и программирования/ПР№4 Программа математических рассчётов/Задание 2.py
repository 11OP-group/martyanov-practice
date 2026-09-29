import math

def point_distance(x1, y1, x2, y2):
    p = math.sqrt(math.pow(x[0] - x[1], 2) + math.pow(y[0] - y[1], 2))
    return p

x1, y1 = map(float, input("Координаты первой точки (x1 y1): ").split())
x2, y2 = map(float, input("Координаты второй точки (x2 y2): ").split())

x = (x1, y1)
y = (x2, y2)

dist = point_distance(x1, y1, x2, y2)

print(f"Расстояние между точками {x} и {y}: {dist:.2f}")