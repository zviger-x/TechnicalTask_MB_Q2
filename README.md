# EasyShapes

**EasyShapes** — это простая библиотека на C#, которая предоставляет базовую функциональность для работы с геометрическими фигурами, такими как круги и треугольники.

## Структура проекта

Проект состоит из следующих компонентов:

- **IShape**  
  Интерфейс, определяющий метод для вычисления площади фигуры. Любая фигура, реализующая этот интерфейс, обязательно реализует метод `GetArea()`.

- **Circle**  
  Структура, созданная для теста, представляющая круг. Круг определяется радиусом и имеет метод вычисления площади.

- **Triangle**  
  Структура, созданная для теста, представляющая треугольник. Треугольник определяется длинами трех сторон и предоставляет методы для вычисления площади и проверки, является ли треугольник прямоугольным.

- **UnitTests.ShapeTests**  
  Класс тестов, который включает в себя юнит-тесты для проверки корректности работы методов вычисления площади круга, площади треугольника, а также проверки треугольника на прямоугольность.