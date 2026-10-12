status = input("Введите статус заказа: ").lower()

description = ""
est_time = ""
recommendation = ""
is_problem = False

print("=" * 35 + "\n" +
      "‖" + " "*10 + "СТАТУС ЗАКАЗА" + " "*10 + "‖" + "\n" +
       "=" * 35)

match status:
    case "pending":
        status = "в ожидании"
        description = "Заказ находится на ожидании обработки"
        est_time = "24 часа"
        recommendation = "Отслеживайте изменения статуса"
    case "processing":
        status = "в обработке"
        description = "Заказ находится на обратке"
        est_time = "12 часов"
        recommendation = "Отслеживайте изменения статуса"
    case "shipped":
        status = "отправлен"
        description = "Заказ находится в пути"
        est_time = "2-5 дней"
        recommendation = "Следите за уведомлениями о доставке"
    case "delivered":
        status = "доставлен"
        description = "Заказ доставлен"
        est_time = "Не требуется"
        recommendation = "Не требуется"
    case "canceled":
        status = "отменён"
        description = "Заказ отменён"
        est_time = "Не требуется"
        recommendation = "Не требуется"
    case _:
        is_problem = True
        print("Ошибка: Неизвестный статус 'invalid_status'\n"
              "Доступные статусы: pending, processing, shipped, delivered, canceled")

if is_problem == False:
    print(f"Статус: {status}\n"
          f"Описание: {description}\n"
          f"Примерное время: {est_time}\n"
          f"Рекомендация: {recommendation}")