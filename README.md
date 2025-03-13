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


---
---

## 🚀 Installation & Setup  
### 1️⃣ Prerequisites  
- Install *Visual Studio* (latest version)  
- Install *.NET 6.0 or higher*  
- Install *NAudio NuGet Package* (Install-Package NAudio)  

### 2️⃣ Clone Repository  
bash
git clone https://github.com/yourusername/MultiDeviceAudioUi.git
cd MultiDeviceAudioUi


### 3️⃣ Build & Run  
1. Open *MultiDeviceAudioUi.sln* in *Visual Studio*  
2. Restore dependencies  
3. Click *Start* (or press F5) to run the application  

---

## 🎨 UI Preview  
🚧 Coming Soon – Screenshots of the UI  

---

## 🤝 Contributing  
🔹 Fork this repository  
🔹 Create a feature branch (git checkout -b feature-name)  
🔹 Commit changes (git commit -m "Add new feature")  
🔹 Push to branch (git push origin feature-name)  
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
