#Константы валют
B5000 = 5000
B2000 = 2000
B1000 = 1000
B500 = 500
B200 = 200
B100 = 100

TEST_VAL = int(input("Введите сумму, кратную 100: "))

papers = [0, 0, 0, 0, 0, 0]
temp = 0

temp = TEST_VAL // B5000
papers[0] = temp
TEST_VAL -= temp * B5000

temp = TEST_VAL // B2000
papers[1] = temp
TEST_VAL -= temp * B2000

temp = TEST_VAL // B1000
papers[2] = temp
TEST_VAL -= temp * B1000

temp = TEST_VAL // B500
papers[3] = temp
TEST_VAL -= temp * B500

temp = TEST_VAL // B200
papers[4] = temp
TEST_VAL -= temp * B200

temp = TEST_VAL // B100
papers[5] = temp
TEST_VAL -= temp * B100

print("Банкомат выдаст:")
print(f"{papers[0]} купюр номиналом {B5000}")
print(f"{papers[1]} купюр номиналом {B2000}")
print(f"{papers[2]} купюр номиналом {B1000}")
print(f"{papers[3]} купюр номиналом {B500}")
print(f"{papers[4]} купюр номиналом {B200}")
print(f"{papers[5]} купюр номиналом {B100}")