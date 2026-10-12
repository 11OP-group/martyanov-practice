status = input("Введите статус заказа: ").lower()

description = ""
est_time = ""
recommendation = ""
is_problem = False

print("◤" + "—" * 37 + "◥" + "\n" +
      "‖" + "🧺 СТАТУС ЗАКАЗА 🧺".center(35) + "‖" + "\n" +
       "◣" + "—" * 37 + "◢")

match status:
    case "pending":
        status = "В ожидании ⌚"
        description = "Заказ находится на ожидании обработки"
        est_time = "24 часа"
        recommendation = "Отслеживайте изменения статуса"
    case "processing":
        status = "В обработке ⚙️"
        description = "Заказ находится на обработке"
        est_time = "12 часов"
        recommendation = "Отслеживайте изменения статуса"
    case "shipped":
        status = "Отправлен ✈️"
        description = "Заказ находится в пути"
        est_time = "2-5 дней"
        recommendation = "Следите за уведомлениями о доставке"
    case "delivered":
        status = "Доставлен ✔️"
        description = "Заказ доставлен"
        est_time = "Не требуется"
        recommendation = "Не требуется"
    case "canceled":
        status = "Отменён ✖️"
        description = "Заказ отменён"
        est_time = "Не требуется"
        recommendation = "Не требуется"
    case _:
        is_problem = True
        print("❌ Ошибка: Неизвестный статус 'invalid_status'\n"
              "Доступные статусы: pending, processing, shipped, delivered, canceled")

if not is_problem:
    print(f"Статус: {status}\n"
          f"Описание: {description}\n"
          f"Примерное время: {est_time}\n"
          f"Рекомендация: {recommendation}")