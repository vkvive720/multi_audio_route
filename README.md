
# Multi-Device System Audio Router 🎵

A **C# application** using **NAudio** and **WASAPI Loopback Capture** to **capture system audio** and **route it to multiple output devices simultaneously**. Supports **device selection, volume control, delay adjustments**, and more.

## ✨ Features
- 🎧 **Capture system audio** and route it to multiple audio devices.
- 🔊 **Independent volume control** for each output device.
- ⏳ **Custom delay configuration** per device.
- 🎛️ **GUI-based control panel** (upcoming feature).

## 🛠️ Technologies Used
- **C# (.NET)**
- **NAudio** (for audio processing)
- **WASAPI Loopback Capture** (for system audio routing)
- **WinForms/WPF** (for UI - future enhancement)

### 📂 Project Structure  

```
MultiDeviceAudioUi/
│── src/
│   ├── MainWindow.xaml        # UI Layout
│   ├── MainWindow.xaml.cs     # UI Logic
│   ├── AudioManager.cs        # Core audio processing
│   ├── DeviceController.cs    # Handles output device selection
│   ├── VolumeController.cs    # Adjusts volume per device
│   ├── DelayController.cs     # Implements delay for each output
│   └── Utils.cs               # Helper functions
│── assets/                    # UI icons and images
│── README.md                  # Project documentation
│── MultiDeviceAudioUi.sln      # Solution file
│── LICENSE                    # License details
│── .gitignore                  # Git ignored files
```

---

## 🚀 Installation & Setup  
### 1️⃣ Prerequisites  
- Install *Visual Studio* (latest version)  
- Install *.NET 6.0 or higher*  
- Install *NAudio NuGet Package*  
  ```sh
  Install-Package NAudio
  ```

### 2️⃣ Clone Repository  
```sh
git clone https://github.com/yourusername/MultiDeviceAudioUi.git
cd MultiDeviceAudioUi
```

### 3️⃣ Build & Run  
1. Open *MultiDeviceAudioUi.sln* in *Visual Studio*  
2. Restore dependencies  
3. Click *Start* (or press F5) to run the application  

---

## 🎨 UI Preview  
### Main Interface:
![Multi-Device Audio Enhancer](https://github.com/vkvive720/multi_audio_route/blob/0a25000b4ed304d5ac1df121ebac8893660fb1c3/Screenshot%202025-03-14%20001802.png)

### Sound Output Selection:
![Sound Output Selection](https://drive.google.com/file/d/1rnq_hVacOpLBbfWndchUSuR9k_MScGfG/view?usp=sharing)

*Screenshots showcasing the multi-device routing functionality.*

---

## 🤝 Contributing  
🔹 Fork this repository  
🔹 Create a feature branch (`git checkout -b feature-name`)  
🔹 Commit changes (`git commit -m "Add new feature"`)  
🔹 Push to branch (`git push origin feature-name`)  
🔹 Open a pull request  

---

## ⚖ License  
📜 This project is licensed under the *MIT License* – feel free to modify and use it.  

---

## 🚀 How to Run
1. **Clone the repository:**
   ```sh
   git clone https://github.com/your-username/MultiDeviceAudioRouter.git
   cd MultiDeviceAudioRouter
   ```
```

### Steps to Add Screenshots to Your GitHub Repository:
1. Move the image files (`image1.png`, `image2.png`) to the `assets/` folder inside your project.
2. Update the file paths in `README.md` (if stored in a different directory).
3. Run the following commands to commit and push the changes:
   ```sh
   git add assets/image1.png assets/image2.png README.md
   git commit -m "Added screenshots and updated README"
   git push origin main
   ```

This will ensure the images appear correctly when viewed on GitHub. 🚀
