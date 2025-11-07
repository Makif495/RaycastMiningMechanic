# ⛏️ Raycast Mining Mechanic

A **Unity prototype** demonstrating a simple yet interactive **mining mechanic** using **Raycast** and physics-based object behaviors.

---

## 🧩 Overview

In this prototype, the player can **equip a pickaxe** by pressing the **E key**, then **mine nearby tiles** by **clicking the mouse**.  
When mined, tiles are destroyed using **Raycast detection** aligned with the player's direction.

Floating **diamond objects** in the scene are also reactive:  
if they are **not in contact with any tile**, their **Rigidbody** becomes active and they **fall to the ground**.  
When the player **touches a diamond**, it is **collected** and disappears — representing a basic resource pickup mechanic.

This project focuses on implementing:
- Raycast-based object interaction  
- Simple item collection logic  
- Dynamic Rigidbody activation based on environment conditions  

---

## 🎥 Gameplay Preview

[![Watch the video](https://img.youtube.com/vi/3E-nX4FMJDY/0.jpg)](https://www.youtube.com/watch?v=3E-nX4FMJDY)

---

## ⚙️ How It Works

| Action | Description |
|:--|:--|
| **E Key** | Equip |
| **Mouse Click** | Send a Raycast forward to mine the tile |
| **Tile Hit** | Tile is destroyed upon detection |
| **Floating Diamonds** | Fall when not touching tiles |
| **Player Touch** | Diamond is collected |

---

## 🧠 Built With

- **Unity Engine**
- **C#**
- **Raycast Physics**
- **Rigidbody Interactions**

---
