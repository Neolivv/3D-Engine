# Simple 3D Engine (C# / Software Rendering)

A minimal 3D engine built from scratch in **C#** using **software rendering** (no GPU APIs like DirectX/OpenGL).
This project is focused on understanding the fundamentals of the 3D graphics pipeline.

---

## 🚀 Features

* Custom **software rasterizer**
* Basic **3D transformations**:

  * Model (world) transformations
  * Camera (view) transformations
  * Perspective projection
* **Backbuffer rendering** using `WriteableBitmap`
* Manual **pixel drawing**
* Support for:

  * Mesh vertices
  * Camera positioning
  * Object rotation
* Simple render loop
* FPS display (UI overlay)

---

## 🧠 Concepts Covered

This project demonstrates core graphics concepts:

* Coordinate spaces:

  * Local (Model space)
  * World space
  * View (Camera space)
  * Clip space
  * NDC (Normalized Device Coordinates)
  * Screen space

* Transformation pipeline:

```
Local → World → View → Projection → NDC → Screen
```

* Matrix operations:

  * Rotation
  * Translation
  * Perspective projection

* Perspective divide (`divide by w`)

---

## 🛠️ Tech Stack

* **C#**
* **UWP / WinUI (XAML)**
* **SharpDX (math only)**

---

## 📂 Project Structure

```
/cengine
│
├── Device.cs       # Core renderer (backbuffer, drawing, projection)
├── Mesh.cs         # Mesh data (vertices)
├── Camera.cs       # Camera position and target
├── MainPage.xaml   # UI (Image + FPS overlay)
├── MainPage.xaml.cs # App logic & render loop
```

---

## ▶️ How to Run

1. Open the project in Visual Studio
2. Make sure it is a **UWP project**
3. Build and run

---

## 🔮 Future Improvements

* Triangle rasterization (filled meshes)
* Z-buffer (depth handling)
* Lighting & shading
* Mouse controls (rotate camera / object)
* Vertex selection & editing (basic 3D editor)
* Model loading (e.g. `.obj`, `.babylon`)

---

## 📚 Learning Purpose

This project is meant for:

* Understanding **how 3D engines work internally**
* Learning the **math behind graphics**
* Building intuition for:

  * Matrices
  * Perspective
  * Rendering pipelines

---

## ⚠️ Disclaimer

This is **not a production engine**.
It is a learning project focused on clarity over performance.

---

## 💡 Author

Built as a hobby project to explore low-level 3D rendering concepts.

---


https://github.com/user-attachments/assets/e119e8e4-7a76-4669-ae0f-ccb11673bb33



