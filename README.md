# InvoiceManagementAPI – Dependency Injection in Action

## 🎯 Goal

To demonstrate the **correct and incorrect** use of **Dependency Injection (DI)** in a real-world .NET Core Web API context.

---

## 📌 Use Case: Invoice Management

This API accepts invoice creation requests and sends a notification to the customer.

---

## 🔥 Without Dependency Injection

`POST /api/bad/invoice`

- Services are instantiated manually inside the controller.
- Tightly coupled code: harder to test, change, or extend.
- Breaks **Open/Closed Principle** and **Single Responsibility Principle**.

---

## ✅ With Dependency Injection

`POST /api/good/invoice`

- Follows **Constructor Injection** via Interfaces.
- Improves flexibility: `INotificationService` can be replaced with `SmsNotificationService`, `MockNotificationService`, etc.
- Increases testability and reduces coupling.
- Makes the system scalable and future-proof.

---

## 💡 Why This Matters

> "If you want to test it, inject it."

Dependency Injection is not just about cleaner code. It gives you power to adapt, test, and grow your architecture safely.

---

## 📚 Concepts Applied

- Constructor Injection
- Interface Segregation
- Open/Closed Principle
- Single Responsibility
- Clean Separation of Concerns

