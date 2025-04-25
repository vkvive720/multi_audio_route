
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
MultiDeviceAudioUI.sln
└── MultiDeviceAudioUI
    ├── App.xaml
    ├── App.xaml.cs
    ├── MainWindow.xaml
    ├── MainWindow.xaml.cs
    ├── Models
    │   └── OutputDeviceSetting.cs
    └── AudioProcessing
        ├── DeviceAudioPipeline.cs
        └── DelaySampleProvider.cs
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
![Sound Output Selection](https://github.com/vkvive720/multi_audio_route/blob/74a05719d677de6c352308f6bd0a8085648cc44b/Screenshot%202025-03-14%20001850.png)

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
   git clone https://github.com/vkvive720/multi_audio_route.git
   cd MultiDeviceAudioRouter
   ```
```


