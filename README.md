# MAServer - Local HTTP File Sharing Server

A C#-based desktop application designed to turn your computer into a simple HTTP server for sharing files over a local network. This project allows users to easily add, manage, and serve files via a web interface, with support for drag-and-drop file addition, user tracking, and basic HTTP request handling.

---

## 🚀 Demo


### 🖥️ GUI Demo
![GUI Demo](./images/MAServer.png)

Example usage:
```bash
# Launch the application (no CLI flags; run via executable or Visual Studio)
bin/MAServer.exe
```

* No command-line flags are supported; all interactions are through the GUI.
* Add files via drag-and-drop or the "Add" button.
* Start the server by clicking "Start".
* Access files via a browser at http://[your-ip]:80.

---

## 🧩 Features

* 📂 Easy file management with drag-and-drop and "Add" button support
* 🛡️ Start/stop server functionality with real-time status updates
* 🤖 Automatic generation of an HTML index page listing available files for download or viewing
* 🎯 Parses HTTP requests and serves files or HTML responses accordingly
* ✉️ Tracks connected users via User-Agent headers and displays them in the UI
* 🖥️ Windows Forms-based interface for file list management, server control, and user monitoring
* ⚡ Lightweight TCP listener on port 80 for local network file sharing

---

## 🛠️ Tech Stack

| Category       | Technologies              |
| -------------- | ------------------------- |
| Programming    | C#                        |
| UI Framework   | Windows Forms             |
| Networking     | System.Net.Sockets, System.Net |
| Framework      | .NET Framework 4.6.1      |
| Others         | LINQ, Threading           |

---

## 🧠 How It Works

1. **Adding Files**
   Users can drag-and-drop files into the application window or use the "Add" button to select files via a file dialog. Files are added to a list and displayed in the UI with index numbers and remove buttons.

2. **Starting the Server**
   Clicking the "Start" button initializes a TCP listener on the local IP address at port 80. The server runs in a separate thread to handle incoming connections without blocking the UI.

3. **Handling Client Requests**
   The server accepts TCP connections, reads HTTP requests, parses them (e.g., GET method, URL), and generates responses. If the root URL is requested, it serves an HTML page with links to download or open files. For specific file URLs (e.g., /0 for the first file), it serves the file binary data.

4. **User Tracking**
   User-Agent headers from requests are logged and can be refreshed in the "Users" tab to display connected clients.

5. **Stopping the Server**
   Clicking "Stop" aborts the server thread and closes the listener, resetting the UI.

---

## 🧾 Example

**File List in UI:**
0 : example.txt
1 : image.jpg

**Browser Access:**
Navigate to http://192.168.1.100:80/ or displayed IP to see an HTML table with file indices, names, and links for "Download" or "Open".

Clicking "Download:0" downloads example.txt.

Even if file paths differ, the server resolves and streams the file content correctly.

---

## 👨‍💻 About the Author

**Mohammad Alaei**
AI Researcher & Computer Engineer
🔗 [https://alaeimo.ir](https://alaeimo.ir)

This project demonstrates expertise in network programming, desktop application development, and HTTP protocol implementation, providing a practical tool for local file sharing and server management.

---