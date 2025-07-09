# 2D Shooter Game - Unity Project

A 2D top-down shooter game built with Unity, featuring player movement, enemy spawning, projectile combat, and a complete UI system.

## 🎮 Game Features

- **Player Movement**: Smooth 2D character movement with keyboard controls
- **Combat System**: Player can shoot projectiles at enemies
- **Enemy AI**: Dynamic enemy spawning with movement patterns
- **Health System**: Player and enemy health management with visual health bars
- **Scoring System**: Track and display player score
- **Menu System**: Main menu and pause menu functionality
- **Background Effects**: Animated cloud backgrounds for immersive atmosphere
- **Audio**: Background music and sound effects
- **Object Pooling**: Efficient bullet management system

## 📸 Screenshots & Assets

### Game Assets Preview

#### Character Sprites
![Enemy Character](Enemies/Alan%20(16%20x%2016).png)
*16x16 pixel art enemy character*

#### Background Assets
![Cloud Background](free-sky-with-clouds-background-pixel-art-set/Clouds/Clouds%201/1.png)
*Animated cloud background asset for immersive atmosphere*

#### Enemy Assets
![Enemy Character](Enemies/Alan%20(16%20x%2016).png)
*16x16 pixel art enemy character*

#### Game Prefabs
- **Enemy.prefab**: Enemy character with AI behavior
- **PlayerBullet.prefab**: Player projectile system
- **Canvas.prefab**: Main UI canvas with health bars and score
- **UICanvas.prefab**: User interface elements

### Project Structure Visual
```
🎮 Assets-project/
├── 🎬 Animation/           # Character and enemy animations
├── 🎵 Audio/              # Music and sound effects
├── 👾 Enemies/            # Enemy sprites and assets
├── ☁️ free-sky-with-clouds-background-pixel-art-set/  # Background assets
├── 🧩 Prefabs/            # Reusable game objects
├── 🎭 Scenes/             # Game scenes (MainMenu, SampleScene)
└── 💻 scripts/            # C# game scripts
    ├── 👾 Enemy/          # Enemy-related scripts
    ├── ❤️ Health/         # Health system scripts
    └── 🎯 [Various game logic scripts]
```

## 🎯 Core Gameplay Systems

### Player System
- **PlayerController.cs**: Handles player movement and input
- **PlayerAttack.cs**: Manages player shooting mechanics
- **Projectile1.cs**: Controls bullet behavior and physics

### Enemy System
- **EnemyController.cs**: Enemy AI and movement
- **EnhancedSpawner.cs**: Advanced enemy spawning logic
- **Spawner.cs**: Basic enemy spawning
- **BulletController.cs**: Enemy projectile behavior
- **DamageDealer.cs**: Handles damage calculations

### Health & UI System
- **Health1.cs**: Core health management
- **Healthbar.cs**: Visual health bar display
- **ScoreManager.cs**: Score tracking and display
- **GameManager.cs**: Overall game state management

### Background & Effects
- **BackgroundController.cs**: Animated background management
- **BulletPooler.cs**: Efficient bullet object pooling

### Menu System
- **mainMenu.cs**: Main menu functionality
- **Pause Manu.cs**: Pause menu controls

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3 LTS or later
- Basic knowledge of Unity Editor

### Installation
1. Clone or download this repository
2. Open Unity Hub
3. Click "Add" and select the project folder
4. Open the project in Unity
5. Navigate to `Scenes/MainMenu.unity` to start

### Controls
- **WASD** or **Arrow Keys**: Move player
- **Spacebar** or **Mouse Click**: Shoot projectiles
- **Escape**: Pause/Resume game
- **Enter**: Confirm menu selections

## 🎨 Assets Used

- **Character Sprites**: Custom 16x16 pixel art characters
- **Background**: Free sky with clouds pixel art set
- **Audio**: Custom game music and effects
- **UI Elements**: Unity UI system with custom styling

## 🔧 Development

### Scripts Overview
- All scripts are written in C# and follow Unity best practices
- Modular design allows for easy extension and modification
- Object pooling implemented for performance optimization

### Key Components
- **Rigidbody2D**: Used for physics-based movement
- **Collider2D**: Handles collision detection
- **Animator**: Controls character animations
- **AudioSource**: Manages game audio

## 📝 License

This project is for educational and personal use. Please respect the licenses of any third-party assets used.

## 🤝 Contributing

Feel free to fork this project and submit pull requests for improvements or bug fixes.

## 📞 Support

For questions or issues, please open an issue in the repository or contact the development team.

---

**Happy Gaming! 🎮**