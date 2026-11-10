# Koi Quest

A 3D third-person navigation and evasion game made in **Unity** for my undergraduate thesis in Game Design and Development at UITM Rzeszów (2026).

You guide a koi that swims forward on its own. Steer it through the water, dodge whirlpools and enemies, dash out of danger and fire bubble shots to clear the way to the goal.

## Controls

| Action | Keys |
| --- | --- |
| Steer | W / A / S / D or arrow keys |
| Dash | Hold a direction key |
| Bubble Shot | Space |
| Pause | P |

## Project

- **Engine:** Unity 2022.3.62f1 (LTS)
- **Language:** C#
- **Scenes:** `main menu`, `SampleScene` (the game level)

### Scripts (`Assets/Scripts`)

| Script | What it does |
| --- | --- |
| `FishController.cs` | Constant forward swimming and steering |
| `FishShooter.cs` | Bubble Shot |
| `CameraFollow.cs` | Third-person camera that keeps the whole koi in view |
| `Enemy.cs` | Enemy behaviour |
| `WhirlpoolObstacle.cs` | Whirlpool hazard |
| `Goal.cs` | Level goal |
| `GameManager.cs` | Game state and flow |
| `MainMenu.cs`, `PauseMenu.cs` | Menus |
| `SkyboxRotator.cs` | Slowly rotating underwater skybox |

## Not included in this repository

This repository contains my own code, scenes, animations and project settings. Assets made by other people are **not** included, because their licences don't allow sharing the files publicly. Scenes will show missing references (pink materials or empty objects) until these are added back.

**Free packs from the Unity Asset Store** (search for them by name and import them):

- LowPoly Animals by Backrock Studios
- Free Quick Effects Vol. 1 by Gabriel Aguiar Productions
- Jiggly Bubble Free
- Surreal Skyboxes (underwater skybox)
- Ambience – Underwater Worlds by Phat Phrog Studios
- Unity UI Samples by Unity

**Also needed:**

- **TextMesh Pro essentials:** in Unity choose *Window → TextMesh Pro → Import TMP Essential Resources*.
- **Jellyfish and sea shell 3D models** and the **main-menu background image** (not included).

## Author

**Michael Kagwima**

© 2026 Michael Kagwima. Third-party assets belong to their respective creators.
