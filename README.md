# ❌ Tic-Tac-Toe Game (X-O) ⭕

A sleek, fully functional, and interactive **Tic-Tac-Toe** desktop application built using **C#** and **Windows Forms (WinForms)**. The game provides a smooth user experience with dynamic turn-switching, custom player names, and real-time win/draw detection with visual board highlighting.

---

## ✨ Features

- **Dynamic Player Input:** Allows custom names for both Player 1 and Player 2 before starting the game.
- **Smart Turn Management:** Automatically switches turns between players and displays the current turn in real-time.
- **Win Detection & Highlighting:** Instantly checks for 8 possible winning combinations and changes the background color of the winning cells to `MediumTurquoise` for clear visual feedback.
- **Draw/Game Over Logic:** Detects full board states and announces a draw if no winning combinations are met.
- **Clean State Management:** Features "Start Game" and "Restart Game" routines that enable/disable UI controls safely to prevent illegal moves.

---

## 🚀 Technologies Used

- **Language:** C# (`.NET 8.0` / Windows Forms)
- **IDE:** Visual Studio 2022
- **Paradigm:** Object-Oriented Programming (OOP) & Event-Driven Architecture

---

## 🛠️ Project Structure & Architecture Insight

The core game logic relies on clean separation of concerns and optimized event handling:
- **Centralized Event Handling:** Utilizes the `sender` object to handle board grid clicks via a unified method, reducing redundant control events.
- **Move Validation:** A dedicated validation layer prevents players from overwriting already selected cells ("Wrong Choice" error handling).
- **State Control:** Disables player info textboxes and input parameters once the game starts to preserve data integrity mid-match.

---

## 🎮 How to Run the Application

1. Clone the repository:
   ```bash
   git clone [https://github.com/Aissamfreee/Tic-Tac-Toe-Game.git]
Open the .sln file in Visual Studio.

Press F5 or click Start to build and run the project.

(Optional) You can find the standalone compiled executable (.exe) inside the bin/Debug/net8.0-windows/ directory.
