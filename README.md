# HTTP 5112 Assignment 1

List of functions in [/Controllers/Assignment1Controller.cs](HTTP5112_Assignment_1/Controllers/Assignment1Controller.cs)

## 1. GET `http://localhost/api/AddTen/{id}`:
- Returns 10 more than the integer input
- Parameter: {id} The input number
- Return: Returns 10 more than the integer input

## 2. GET `http://localhost/api/Square/{id}`:
- Returns the square of the integer input
- Parameter: {id} The input number
- Return: Returns the square of the integer input

## 3. POST `http://localhost/api/Greeting`:
- Returns the string "Hello World!"
- No parameter
- Return: Returns the string "Hello World!"

## 4. GET `http://localhost/api/Greeting/{id}`:
- Returns the string "Greetings to {id} people!" where id is an integer value.
- Parameter: {id} The input number
- Return: Returns the string "Greetings to {id} people!" where id is an integer value.

## 5. GET `http://localhost/api/NumberMachine/{id}`:
- Returns zero for any the integer input
- Parameter: {id} The input number
- Return: Returns zero for any the integer input

## 6. GET `http://localhost/api/HostingCost/{id}`:
- Calculates the hosting cost, tax and total hosting cost, where the hosting charges $5.50/FN and 13% HST.
- Parameter: {id} The input number
- Return: Returns 3 strings which describe the total hosting cost