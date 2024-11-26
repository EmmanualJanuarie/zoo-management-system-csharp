==================================================
           Urban Safari Zoo Management System
==================================================

Welcome to the Urban Safari Zoo Management System! As the developer behind this project, I'm excited to share with you how to run the application, what to expect, and some future plans. Let's dive in!

## Table of Contents
1. [How to Run the Application](#1-how-to-run-the-application)
2. [Expected Errors](#2-expected-errors)
3. [Future Implementations](#3-future-implementations)
4. [Developer Credits](#4-developer-credits)

---

### 1. How to Run the Application

**Prerequisites**:
- Make sure you have Visual Studio 2022 (latest version as of May 2024) installed on your system.
- Open the solution file in Visual Studio.

**Running the Application**:
1. Locate the green play icon (usually labeled "Start Debugging") in Visual Studio.
2. Click the icon to build and run the application.
3. Alternatively, you can press F5 on your keyboard to start debugging.

**User  Interaction**:
- When the application launches, you'll be prompted to choose between being a guest or a member.
- If you select guest, you'll be directed to a form where you can choose animal types, species, food quantity, and other options. The system will provide an output based on your selections.
- If you choose to log in as a member, you'll have access to an admin member form (for managing members) or a regular member form (for animal welfare check-ups).
- New members can also register through the application.
- To exit the application, simply click the red "X" button.

---

### 2. Expected Errors

While we've done our best to create a robust system, a few errors might occur during usage. Here are some common ones:

1. **Incorrect Email Format**:
   - If you enter an invalid email format, the system will prompt you to correct it.

2. **Authentication Errors**:
   - If your email or password doesn't match what's in the database, you'll receive an authentication error.

3. **Empty Textboxes**:
   - Leaving required textboxes empty will trigger an error message.

4. **Combo Box Issues**:
   - Selecting incorrect options from combo boxes may lead to unexpected behavior.

5. **NaN Errors**:
   - Numeric input errors (such as dividing by zero) can cause NaN (Not-a-Number) issues.

6. **Exceptions**:
   - The application handles exceptions like FormatException, ArgumentException, and NullReferenceException.

---

### 3. Future Implementations

We're committed to enhancing the Urban Safari Zoo Management System. Here are some exciting future plans:

1. **Gift Shop Form**:
   - We'll implement a gift shop feature, allowing guests to purchase items like plushies, food, and more.

2. **Video Screening**:
   - Instead of text-based information, we'll introduce video screening of animal behavior.

3. **Variety of Animals**:
   - Utilizing a HashMap, we'll expand the system to include various animal types.

4. **Platform Expansion**:
   - We're exploring options to create a mobile app, desktop app, or web application using Blaze WebAssembly and C# with Razor syntax.

---

### 4. Developer Credits

- **Name**: Emmanual Januarie
- **Role**: Application Developer (Software Developer)
- **Institution**: CTU Training Solutions
