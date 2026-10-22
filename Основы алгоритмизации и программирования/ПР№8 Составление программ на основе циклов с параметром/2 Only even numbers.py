IS_EVEN = True

for i in range(0, 10):
    x = int(input(f"x{i} = "))
    if x % 2 != 0:
        IS_EVEN = False

if IS_EVEN:
    print("YES")
else:
    print("NO")