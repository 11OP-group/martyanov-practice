ACTUAL_CODE = 4590

input_code = int(input("Код: "))
while input_code != ACTUAL_CODE:
    print("Код неверный! Попробуйте ещё раз")
    input_code = int(input("Код: "))
print("Код верный!")