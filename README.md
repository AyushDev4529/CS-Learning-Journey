<p align="center">
  <img src="https://img.shields.io/github/last-commit/AyushDev4529/CS-Learning-Journey">
  <img src="https://img.shields.io/github/repo-size/AyushDev4529/CS-Learning-Journey">
</p>


# CSharp-Learning-Journey
Documenting my journey from C# fundamentals to shipping my first Unity game by 2026. Includes algorithms, design patterns, and mini-projects.

## 👨‍💻 About Me
I am Ayush, an aspiring Game Developer. My goal is to publish my first polished game by the end of 2026. This repository documents my daily progress in mastering C# logic and algorithms.

## 🚀 Current Roadmap
- [ ] **Phase 1:** C# Fundamentals & Logic (Current Focus)
- [ ] **Phase 2:** Unity Prototypes (Feb 2026)
- [ ] **Phase 3:** First Commercial Game (Late 2026)

## 📚 What's Inside
* **Coddy.tech Solutions:** Algorithms for Pattern Finding, Loops, and Logic flow.
* **Mini-Projects:** Console applications to test core concepts.

## 📅 Progress Snapshot (Updated Weekly)
| Week | Focus | Progress |
|---|---|---|
| Week 1 | Arrays & Loops | Built Dungeon Map Renderer (2D arrays + movement) |
| Week 2 | Modular Logic | Built Tic-Tac-Toe + Arcade Menu System |
| Week 3 | OOP Foundation | Implemented Entity, Player, Events, Polymorphism |
| Week 4 | RPG Systems | Building Turn-Based Combat Prototype |



> 📌 This section updates every Sunday to track growth like a real engineering log.

## 🧠 Skills Gained So Far

* Object-Oriented Programming (Classes, Inheritance, Encapsulation, Polymorphism)

* Events & Delegates (OnDeath system implemented)

* Clean console architecture (UI separated from core logic)

* Version control workflow (consistent commits, refactoring habits)

* Algorithmic thinking: 2D grids, pattern loops, input handling

* Understanding of access modifiers (public, protected, private)

## ⭐ Highlighted Mini-Projects
| Project |	Concepts Demonstrated |
|---|---|
| Dungeon Map Renderer | 2D arrays, player movement, collision checks |
| Tic-Tac-Toe |	Win detection using loops; no hardcoded conditions |
| Arcade Menu System | Program routing, modular structure |
| Entity OOP System | Inheritance, events, overridden methods |
| RPG Combat Prototype | Attack system, event triggers, turn loop |


## 🎮 How To Run These Projects
1. Clone the repo 
```git clone https://github.com/AyushDev4529/CS-Learning-Journey
```
2. Open in Visual Studio / VS Code  
3. Run Program.cs  inside the project you want to test
4. Follow on-screen instructions in the console

---

## 🧱 Object-Oriented Programming Progress (December 2025)

This month is focused on transitioning from procedural C# into **true OOP and clean architecture**, preparing for Unity development in January.

### ✔️ Concepts Implemented
- **Classes & Objects**  
  Created reusable blueprints for game entities (Player, Enemy).

- **Inheritance**  
  `Player` and future NPC/enemy types inherit from a shared `Entity` base class.

- **Encapsulation**  
  Used `protected` fields for Health/Damage and public getters for safe access.

- **Polymorphism**  
  Overridable methods such as `TakeDamage()` allow specialized behavior in subclasses.

- **Events & Delegates**  
  Implemented an `OnDeath` event so other systems can react when an entity dies.
-
- **Polymorphic Attack System**  
  Refactored Player and Enemy to share a unified Entity base class with overridable combat behavior (virtual + override).

---

## ⚔️ Current Mini-Project: Console RPG Combat Prototype

A small combat simulation used to practice real game-like architecture before moving to Unity.

### 🔧 Features Implemented
- Player can attack an enemy via `Player.Attack()`.
- Entity death triggers a **C# event callback**.
- Movement logic using row/column grid positions.
- Overridden `ToString()` method to print entity stats cleanly.
- Turn-based loop inside `Program.cs`.

### 🧪 Example Architecture

Entity (Base Class)
├── Player : Entity
└── Enemy : Entity


The goal is to think like a **Unity gameplay engineer**, not just write procedural scripts.

---

## 📌 Next Steps (Short-Term)

- Add **Enemy AI behavior** (random movement / counterattack logic).
- Implement a **Battle Log** for debugging + clarity.
- Expand `Attack()` to include:
  - Critical hits  
  - Damage variance  
  - Status messages  
- Prepare for **Christmas OOP Final Project: Console RPG Arena**.

---

## 📈 Commit Style Guide (For This Repo)

When pushing updates, use descriptive commit messages such as:

- `feat: added Player subclass with Attack() logic`
- `refactor: extracted movement logic into Entity base class`
- `fix: resolved event not triggering on enemy death`
- `docs: updated README with OOP progress`

This helps track your journey toward professional development standards.

---

## 🔮 Future Additions

* Inventory System (OOP + Lists + Data Containers)

* Enemy AI (random movement, counterattacks)

* Event-driven UI Simulator (console-based HUD)

* Basic A* Pathfinding mini-demo

* Unity Prototypes (starting January 2026)

* Quest + Dialogue System (early 2026)

* Save/Load System using JSON

---

## 🎯 Mission Statement

“Learning game engineering with discipline — one small project a day.”

---

## 🎮 Long-Term Vision

Every console mini-project in this repository helps build the foundation for:

- Unity character controllers  
- Combat systems  
- Event-driven gameplay  
- Clean and scalable architecture  

This prepares the transition to **Unity Development (Jan 2026)** and eventually your **first published game by Dec 2026**.

---


