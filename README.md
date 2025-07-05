# 📱 WhatsApp Business Integration API

## Overview
This project is a **.NET 9 Web API** designed to integrate with the **WhatsApp Business Cloud API** test environment. 
It allows sending various types of WhatsApp messages such as text, images, and documents using simple HTTP requests.

## 🚀 Features

- ✅ Send a basic **hello-world** message to verify setup
- 💬 Send **text notifications** with a title and body
- ⏰ Send **reminder messages** for payments or follow-ups
- 🖼️ Send **image-based messages** using a URL
- 📄 Send **documents** such as invoices via WhatsApp

---

## 📡 API Endpoints

| Method | Endpoint                        | Description                          |
|--------|----------------------------------|--------------------------------------|
| POST   | `/api/WhatsApp/hello-world`      | Sends a basic test message           |
| POST   | `/api/WhatsApp/notify`           | Sends a standard notification        |
| POST   | `/api/WhatsApp/reminder-notify`  | Sends a payment reminder             |
| POST   | `/api/WhatsApp/image-notify`     | Sends a message with an image        |
| POST   | `/api/WhatsApp/doc-notify`       | Sends a document (PDF, etc.)         |

---

## 📥 Sample Requests

### 🔹 Send Notifications

POST /api/WhatsApp/notify

```json
{
  "PhoneNumber": "",
  "Title": "",
  "Body": ""
}
```
POST /api/WhatsApp/reminder-notify
```json
{
  "PhoneNumber": "",
  "PaymentFor": "",
  "CardNumber": "",
  "ReminderDate": ""
}
```
POST /api/WhatsApp/image-notify
```json
{
  "PhoneNumber": "",
  "ImagePath": "",
  "Body": ""
}
```
POST /api/WhatsApp/doc-notify
```json
{
  "PhoneNumber": "",
  "ReceiverName": "",
  "FileName": "",
  "FilePath": "",
  "Body": ""
}
```



