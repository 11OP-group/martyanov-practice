USD_TO_RUB = 83.25

def convert_usd_to_rub(dollars):
    """
    Функция перевода долларов в рубли

    :param dollars: сумма в долларах
    :return: сумма в рублях
    """

    rubles = dollars * USD_TO_RUB
    return rubles

usd = float(input("Долларов: "))
rub = convert_usd_to_rub(usd)

print(f"${usd:,.2f} это {rub:,.2f} руб".replace(",", " "))