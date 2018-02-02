# HoloLens IRAD

Integrates live sensor feeds into the HoloLens mixed reality display. A demo would be to use a large print out of the SLS rocket engine, attach some temperature and pressure sensors to it. Feed the streams into the HoloLens so the view is able to visualize live sensor readings while watching a rocket test. Simulated in our case.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See **Deployment** for notes on how to deploy the project on a live system.

### Prerequisites

Following [this Microsoft guide](https://developer.microsoft.com/en-us/windows/mixed-reality/install_the_tools) you'll need:
* [Visual Studio 2017](https://developer.microsoft.com/en-us/windows/downloads)
  * Select the **Universal Windows Platform development** workload
  * Select the **Game Development with Unity** workload
    * You may deselect the Unity Editor optional component since you'll be installing a newer version of Unity below
* [Unity 2017.2](https://store.unity.com/download)
  * Make sure to select the **Windows Store .NET Scripting Backend** (you may install the docs as well)
  * You will have to use the **Personal** version of Unity for it to be free
* [Vuforia](https://developer.vuforia.com/downloads/sdk)
  * Vuforia is now integrated with the Unity Editor (above), so just make sure that component is installed with your copy of Unity
* Windows 10 Fall Creators Update (version 1709)
  * Necessary for some Unity and Vuforia components to function properly, and for deployment
* **Optional:* [HoloLens Emulator and Holographic Templates](https://go.microsoft.com/fwlink/?linkid=852626)
  * **Your system must support Hyper-V** for the Emulator installation to succeed

## Deployment

### Export to the Visual Studio Solution

1. Open **File > Build Settings** window.
2. Click **Add Open Scenes** to add the scene.
3. Change **Platform** to **Universal Windows Platform** and click **Switch Platform**.
4. For **Target Device**, switch to **HoloLens**.
5. **UWP Build Type** should be **D3D**.
6. **UWP SDK** may be left as **Latest installed**.
7. Check **Unity C# Projects** under Debugging.
8. Click **Build**.
9. In the file explorer, click **New Folder** and name the folder **"App"** (proceed to next step if an App folder already exists).
10. With the **App** folder selected, click the **Select Folder** button.
11. When Unity is done building, a Windows File Explorer window will appear.
12. Open the **App** folder in file explorer.
13. Open the generated Visual Studio solution (HoloLensIRAD.sln for this project).

### Compile the Visual Studio solution

Now that we've exported the Visual Studio solution, we can deploy it to the device.
1. Using the top toolbar in Visual Studio, change the target from **Debug** to **Release** and from **ARM** to **x86**.

### Deploy to the HoloLens over Wi-Fi

1. Click on the arrow next to the **Local Machine** button, and change the deployment target to **Remote Machine**.
2. Enter the IP address of the HoloLens (this is found by running the [Holographic Remoting Player](https://developer.microsoft.com/en-us/windows/mixed-reality/holographic_remoting_player) app installed on the HoloLens) and change the **Authentication Mode** to Universal (Unencrypted Protocol) for HoloLens and **Windows** for other devices.
3. Click **Debug > Start without debugging**.
4. If the deployment succeeds, you can perform the **Bloom** gesture while wearing the HoloLens, and the solution will be installed as an app on the device menu.

If this is your first deployment, you'll need to pair [Using Visual Studio](https://developer.microsoft.com/en-us/windows/mixed-reality/using_visual_studio)

## Built With

* [Visual Studio 2017](https://developer.microsoft.com/en-us/windows/downloads) - C# scripting
* [Unity 2017.2](https://store.unity.com/download) - Graphics modeling engine
* [Vuforia](https://developer.vuforia.com/downloads/sdk) - Image target recognition and tracking

## Other Useful Resources

* [Microsoft Mixed Reality Academy](https://developer.microsoft.com/en-us/windows/mixed-reality/academy)
* [Microsoft Mixed Reality Tools Checklist](https://developer.microsoft.com/en-us/windows/mixed-reality/install_the_tools)
* [Vuforia Developer Portal](https://developer.vuforia.com/)

## Authors

* **Scott Knight** - [scott.knight@geocent.com](mailto:scott.knight@geocent.com)